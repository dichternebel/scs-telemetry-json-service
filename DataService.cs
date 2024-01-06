using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TelemetryJsonService
{
    internal static class DataService
    {
        public static int Port { get; private set; }
        public static string JsonData { get; set; }

        public static void StartWebServer()
        {
            Port = int.Parse(ConfigurationManager.AppSettings["port"]);
            Task.Run(() => StartTcpListener(Port));
        }

        static async Task StartTcpListener(int port)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            Console.WriteLine($"Listening on port {port}");

            try
            {
                while (true)
                {
                    TcpClient client = await tcpListener.AcceptTcpClientAsync();
                    _ = HandleClientAsync(client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                tcpListener.Stop();
                Console.WriteLine("Listener stopped.");
            }
        }

        /// <summary>
        /// Handle an incoming request
        /// </summary>
        static async Task HandleClientAsync(TcpClient tcpClient)
        {
            using (NetworkStream stream = tcpClient.GetStream())
            {
                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Received request: {request}");

                // Parse the HTTP method
                string httpMethod = "GET";
                string[] requestLines = request.Split('\n');
                string firstLine = requestLines.FirstOrDefault();
                string[] tokens = firstLine?.Split(' ');

                if (tokens != null && tokens.Length >= 2)
                {
                    httpMethod = tokens[0];
                    Console.WriteLine($"HTTP Method: {httpMethod}");
                }

                string responseText = "HTTP/1.1 200 OK\r\n" +
                      "Content-Type: application/json\r\n" +
                      "Access-Control-Allow-Origin: *\r\n" +  // Allow requests from any origin
                      "Access-Control-Allow-Methods: GET, OPTIONS\r\n" +  // Specify allowed methods
                      "Access-Control-Allow-Headers: Content-Type, Accept, X-Requested-With\r\n\r\n";  // Specify allowed headers

                if ( httpMethod == "GET" )
                {
                    responseText += JsonData;
                }

                byte[] responseBytes = Encoding.UTF8.GetBytes(responseText);
                await stream.WriteAsync(responseBytes, 0, responseBytes.Length);
            }

            tcpClient.Close();
        }
    }
}
