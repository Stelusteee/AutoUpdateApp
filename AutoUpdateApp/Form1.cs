namespace AutoUpdateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckForUpdates();
        }

        private async Task<bool> CheckForUpdates()
        {
            var currentVersion = "1.0.0";
            using var client = new HttpClient();
            var latestVersion = await client.GetStringAsync("https://github.com/Stelusteee/AutoUpdateApp/blob/master/version.txt");

            if (latestVersion != currentVersion)
            {
                // download the app
                MessageBox.Show("HEY THERES A NEW UPDATE");
                return true;
            }

            return false;
        }
    }
}
