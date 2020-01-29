using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaServerTray {
    public partial class Options : Form {
        public Options() {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e) {
            tbServer.Text = Properties.Settings.Default.Server;
            tbPort.Text = Properties.Settings.Default.Port;
            tbUser.Text = Properties.Settings.Default.User;
            tbPasswort.Text = Properties.Settings.Default.Passwort;
            tbOnRecStart.Text = Properties.Settings.Default.OnRecordStart;
            tbOnRecEnd.Text = Properties.Settings.Default.OnRecordEnd;
            tbOnError.Text = Properties.Settings.Default.OnError;
            tbLogfile.Text = Properties.Settings.Default.Logfile;
        }

        private void Options_Save() {
            Properties.Settings.Default.Server = tbServer.Text;
            Properties.Settings.Default.Port = tbPort.Text;
            Properties.Settings.Default.User = tbUser.Text;
            Properties.Settings.Default.Passwort = tbPasswort.Text;
            Properties.Settings.Default.OnRecordStart = tbOnRecStart.Text;
            Properties.Settings.Default.OnRecordEnd = tbOnRecEnd.Text;
            Properties.Settings.Default.OnError = tbOnError.Text;
            Properties.Settings.Default.Logfile = tbLogfile.Text;
            Properties.Settings.Default.Save();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e) {
            Options_Save();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btStart_Click(object sender, EventArgs e) {
            if (TryGetFileName("Choose On Record Start App",out string fname)) {
                tbOnRecStart.Text = fname;
            }
        }

        private bool TryGetFileName(string title, out string filename) {
            filename = string.Empty;
            using (OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.Title = title;
                if (dlg.ShowDialog() == DialogResult.OK) {
                    filename = dlg.FileName;
                    return true;
                }
            }
            return false;
        }

        private void tbEnd_Click(object sender, EventArgs e) {
            if (TryGetFileName("Choose On Record End App", out string fname)) {
                tbOnRecEnd.Text = fname;
            }
        }

        private void tbError_Click(object sender, EventArgs e) {
            if (TryGetFileName("Choose On Error App", out string fname)) {
                tbOnError.Text = fname;
            }
        }

        private void tbLog_Click(object sender, EventArgs e) {
            if (TryGetFileName("Choose Log file", out string fname)) {
                tbLogfile.Text = fname;
            }
        }

        private void btTestStart_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(tbOnRecStart.Text);
        }

        private void btTestEnd_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(tbOnRecEnd.Text);
        }

        private void btTestError_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(tbOnError.Text);
        }
    }
}
