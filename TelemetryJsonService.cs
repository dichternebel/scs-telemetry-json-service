using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using Newtonsoft.Json;
using SCSSdkClient;
using SCSSdkClient.Object;
using static SCSSdkClient.Object.SCSTelemetry;

namespace TelemetryJsonService
{
    public partial class TelemetryJsonService : Form
    {
        private SCSSdkTelemetry Telemetry { get; set; }

        private static string baseDir { get; set; }

        public TelemetryJsonService()
        {
            baseDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            // moved here in order to start app minimized to system tray properly
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.FormClosing += new FormClosingEventHandler(this.FormClosing_TelemetryHtmlOverlay);

            DataService.StartWebServer();
            this.InitializeTelemetry();

            this.tbUrl.Text = $"http://localhost:{DataService.Port}/";

            UpdateSharedJs();
        }

        private void FormClosing_TelemetryHtmlOverlay(object sender, FormClosingEventArgs e)
        {
            //Telemetry.pause();
            //if (MessageBox.Show("Are you really sure?", "Shutdown Telemetry Json Service", MessageBoxButtons.YesNo) ==
            //    DialogResult.No)
            //{
            //    e.Cancel = true;
            //    Telemetry.resume();
            //    return;
            //}
            Telemetry.Dispose();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Keep port of shared javascript up to date
        /// </summary>
        private void UpdateSharedJs()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = assembly.GetManifestResourceNames().Single(str => str.EndsWith("shared-template.js"));
            string resourceContent;

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                resourceContent = reader.ReadToEnd();
            }

            resourceContent = resourceContent.Replace("{{port}}", DataService.Port.ToString());
            File.WriteAllText(Path.Combine(baseDir, "overlays/js", "shared.js"), resourceContent);
        }

        private void InitializeTelemetry()
        {
            Telemetry = new SCSSdkTelemetry();
            Telemetry.Data += Telemetry_Data;
            Telemetry.JobStarted += TelemetryOnJobStarted;
            Telemetry.JobCancelled += TelemetryJobCancelled;
            Telemetry.JobDelivered += TelemetryJobDelivered;
            Telemetry.Ferry += TelemetryFerry;
            Telemetry.Train += TelemetryTrain;
        }

        private void Telemetry_Data(SCSTelemetry data, bool updated)
        {
            try
            {
                // Pause the Telemetry while processing data
                Telemetry.pause();

                // convert data back and forth and save populate json
                var jsonString = JsonConvert.SerializeObject(data);
                var jsonObj = JsonConvert.DeserializeObject<CustomTelemetry>(jsonString);

                // Do some basic transformation
                switch (data.Game)
                {
                    case SCSGame.Ets2:
                        jsonObj.Game = "ETS2";
                        break;
                    case SCSGame.Ats:
                        jsonObj.Game = "ATS";
                        break;
                    default:
                        jsonObj.Game = "n.a.";
                        break;
                }
#if DEBUG
                // Simple mocking
                jsonObj.Game = "ETS2";
                jsonObj.SdkActive = true;
                jsonObj.Paused = false;
                jsonObj.SpecialEventsValues.OnJob = true;
#endif
                // Display some data on UI
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbGame.Text = jsonObj.Game;
                    lbGameVersion.Text = $"v{jsonObj.GameVersion.Major}.{jsonObj.GameVersion.Minor}";
                    lbTelemetryVersion.Text = $"v{jsonObj.TelemetryVersion.Major}.{jsonObj.TelemetryVersion.Minor}";
                    lbUpdateInterval.Text = Telemetry.UpdateInterval + "ms";
                    tbStatus.Text = jsonObj.SdkActive ? "SCS-SDK connected and running!" : "SCS-SDK currently not running... ¯\\_(ツ)_/¯ ";
                });

                // serialize back
                var jsonData = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);

                // write to file to be able find data objects easily
                File.WriteAllText(Path.Combine(baseDir, "overlays", "data.json"), jsonData);
                DataService.JsonData = jsonData;
                Telemetry.resume();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Telemetry was closed: " + ex);
            }
        }

        private void TelemetryFerry(object sender, EventArgs e) =>
            Console.WriteLine("Ferry");

        private void TelemetryJobCancelled(object sender, EventArgs e) =>
            Console.WriteLine("Job Cancelled");

        private void TelemetryJobDelivered(object sender, EventArgs e) =>
            Console.WriteLine("Job Delivered");

        private void TelemetryOnJobStarted(object sender, EventArgs e) =>
            Console.WriteLine("Just started job OR loaded game with active.");

        private void TelemetryTrain(object sender, EventArgs e) =>
            Console.WriteLine("Train");
    }
}

// Used icon is https://iconarchive.com/show/papirus-mimetypes-icons-by-papirus-team/app-json-icon.html under GNU General Public License v3.0
// So this app will inherit from that.