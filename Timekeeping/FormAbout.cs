/// <author>Thomas Krahl</author>

using System.Diagnostics;

namespace Timekeeping
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void OnAboutPanelLinkLabelClick(object sender, EventArgs e)
        {
            string url = "https://" +linkLabel1.Text;
            ProcessStartInfo openUrl = new ProcessStartInfo();
            openUrl.FileName = url;
            openUrl.UseShellExecute = true;
            Process.Start(openUrl);
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
