using System;
using System.Configuration;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace TelemetryJsonService
{
    // Source: http://www.gabescode.com/dotnet/2018/11/01/basic-HttpListener-web-service.html
    internal static class DataService
    {
        private static volatile bool _keepGoing = true;

        private static HttpListener Listener;
        private static Task _mainLoop;

        public static string Address { get; private set; }
        public static int Port { get; private set; }
        public static string JsonData { get; set; }

        public static void StartWebServer()
        {
            if (_mainLoop != null && !_mainLoop.IsCompleted) return;

            Address = ConfigurationManager.AppSettings["address"];
            Port = int.Parse(ConfigurationManager.AppSettings["port"]);
            Listener = new HttpListener { Prefixes = { $"http://{Address}:{Port}/" } };
            _mainLoop = MainLoop();
        }

        /// <summary>
        /// Call this to stop the web server. It will not kill any requests currently being processed.
        /// </summary>
        public static void StopWebServer()
        {
            _keepGoing = false;
            lock (Listener)
            {
                //Use a lock so we don't kill a request that's currently being processed
                Listener.Stop();
            }
            try
            {
                _mainLoop.Wait();
            }
            catch { /* ¯\_(ツ)_/¯ */ }
        }

        /// <summary>
        /// The main loop to handle requests into the HttpListener
        /// </summary>
        /// <returns></returns>
        private static async Task MainLoop()
        {
            Listener.Start();
            while (_keepGoing)
            {
                try
                {
                    //GetContextAsync() returns when a new request come in
                    var context = await Listener.GetContextAsync();
                    lock (Listener)
                    {
                        if (_keepGoing) ProcessRequest(context);
                    }
                }
                catch (Exception e)
                {
                    if (e is HttpListenerException) return; //this gets thrown when the listener is stopped
                    //TODO: Log the exception
                }
            }
        }

        /// <summary>
        /// Handle an incoming request
        /// </summary>
        /// <param name="context">The context of the incoming request</param>
        private static void ProcessRequest(HttpListenerContext context)
        {
            using (var response = context.Response)
            {
                try
                {
                    var handled = false;
                    
                    // CORS
                    response.AppendHeader("Access-Control-Allow-Origin", "*");

                    switch (context.Request.Url.AbsolutePath)
                    {
                        // Define routes
                        case "/":
                            switch (context.Request.HttpMethod)
                            {
                                case "OPTIONS":
                                    response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, X-Requested-With");
                                    response.AddHeader("Access-Control-Allow-Methods", "OPTIONS, GET");
                                    response.AddHeader("Access-Control-Max-Age", "1728000");
                                    response.StatusCode = 200;
                                    handled = true;
                                    break;

                                case "GET":
                                    response.ContentType = "application/json";
                                    var buffer = Encoding.UTF8.GetBytes(JsonData);
                                    response.ContentLength64 = buffer.Length;
                                    response.OutputStream.Write(buffer, 0, buffer.Length);
                                    handled = true;
                                    break;

                            }
                            break;
                    }
                    if (!handled)
                    {
                        response.StatusCode = 404;
                    }
                }
                catch (Exception e)
                {
                    //Return the exception details to the client
                    response.StatusCode = 500;
                    response.ContentType = "application/json";
                    var buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(e));
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);

                    //TODO: Log the exception
                }
            }
        }
    }
}
