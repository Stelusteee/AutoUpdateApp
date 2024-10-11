using System.Diagnostics;

namespace AutoUpdateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckForUpdates();
        }

        public async Task CheckForUpdates()
        {
            string currentVersion = "1.0.1";
            string versionUrl = "https://raw.githubusercontent.com/Stelusteee/AutoUpdateApp/refs/heads/master/version.txt";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string latestVersion = await client.GetStringAsync(versionUrl);

                    if (latestVersion.Trim() != currentVersion)
                    {
                        MessageBox.Show("New version available: " + latestVersion);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking version: " + ex.Message);
                }
            }
        }
    }
}
