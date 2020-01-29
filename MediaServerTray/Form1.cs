using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediaServerTray {
    public partial class Form1 : Form {

        MS_Service msService = new MS_Service();
        StatusWorker statusWorker;
        bool shutdown = false;
        //StatusWorker worker;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Icon = Properties.Resources.Button_Blank_Green_icon;
            statusIcon.Icon = Properties.Resources.Button_Blank_Green_icon;            
            //statusIcon.BalloonTipIcon = ToolTipIcon.Info;
            //statusIcon.BalloonTipTitle = "Notify Title";
            //statusIcon.BalloonTipText = "Tip Text";            
            //statusIcon.ShowBalloonTip(2000);
            statusIcon.Text = "Status Icon Text";


            statusWorker = new StatusWorker(msService);
            this.Hide();
        }


        private void CutTextBox() {
            this.Invoke(new MethodInvoker(() => {
                if (textBox1.Lines.Count() > 30) {
                    textBox1.Text = string.Join(System.Environment.NewLine, textBox1.Lines.Skip(10));
                }
            }));
        }

        private void OnStatusEvent(RecStatus recordingStatus) {          
            Icon tmp = Properties.Resources.Button_Blank_Green_icon;
            string msg = string.Empty;
            string cmd = string.Empty;
            switch (recordingStatus.Status) {
                case RecStatus.eRecording.Error:
                    tmp = Properties.Resources.Button_Blank_Yellow;
                    msg = "Error " + recordingStatus.ErrorMsg;
                    cmd = Properties.Settings.Default.OnError;
                    //if (string.IsNullOrEmpty(Properties.Settings.Default.OnError) == false)
                    //    System.Diagnostics.Process.Start(Properties.Settings.Default.OnError+ " \""+ recordingStatus.ErrorMsg+"\"");
                    break;
                case RecStatus.eRecording.None:
                    tmp = Properties.Resources.Button_Blank_Green_icon;
                    msg = "Waiting";
                    break;
                case RecStatus.eRecording.Started:
                    tmp = Properties.Resources.Button_Blank_Red_icon;
                    msg = "Recording";
                    cmd = Properties.Settings.Default.OnRecordStart;
                    //if (string.IsNullOrEmpty(Properties.Settings.Default.OnRecordStart)==false)
                    //    System.Diagnostics.Process.Start(Properties.Settings.Default.OnRecordStart);
                    break;
                case RecStatus.eRecording.Stopped:
                    tmp = Properties.Resources.Button_Blank_Green_icon;
                    msg = "Recording";
                    cmd = Properties.Settings.Default.OnRecordEnd;
                    //if (string.IsNullOrEmpty(Properties.Settings.Default.OnRecordEnd) == false)
                    //    System.Diagnostics.Process.Start(Properties.Settings.Default.OnRecordEnd);
                    break;
                case RecStatus.eRecording.Recording:
                    tmp = Properties.Resources.Button_Blank_Red_icon; 
                    msg = "Recording";
                    break;
            }
            this.Invoke(new MethodInvoker(() => {
                this.Icon = tmp;
                statusIcon.Icon = tmp;
                if (string.IsNullOrEmpty(cmd) == false) {
                    // CreateObject("Wscript.Shell").Run "C:\Home\bin\Syncthing\Synthing_Start.bat", 0, False
                    //System.Diagnostics.Process.Start($"{cmd.Trim()} {DateTime.Now} msg");
                    System.Diagnostics.Process.Start(cmd);
                }
            }));
            string line = $"{string.Join(",",DateTime.Now,msService.Server,msg)}{System.Environment.NewLine}";
            this.Invoke(new MethodInvoker(() => {
                textBox1.AppendText(line);
            }));
            if (string.IsNullOrEmpty(Properties.Settings.Default.Logfile)==false)
                File.AppendAllText(Properties.Settings.Default.Logfile, line, Encoding.UTF8);
            CutTextBox();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            shutdown = true;
            this.Close();
        }

    

        private void Form1_Shown(object sender, EventArgs e) {
            this.Hide();          
            RestartServer();
        }

        private void RestartServer() {
            if (statusWorker.IsRunning)
                statusWorker.Stop = true;
            msService.Password = Properties.Settings.Default.Passwort;
            msService.User = Properties.Settings.Default.User; ;
            msService.Port = Properties.Settings.Default.Port;
            msService.Server = Properties.Settings.Default.Server;
            statusIcon.Text = "Watching "+msService.Server;     
            Task.Run( () =>
            {
                statusWorker.RunLoop(OnStatusEvent);
            });

        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem me = (ToolStripMenuItem)sender;
            me.Enabled = false;
            using (Options frm = new Options()) {
                string server = Properties.Settings.Default.Server;
                string port = Properties.Settings.Default.Port;
                string user = Properties.Settings.Default.User;
                string passwort = Properties.Settings.Default.Passwort;
                string onRecordStart = Properties.Settings.Default.OnRecordStart;
                string OnRecordEnd = Properties.Settings.Default.OnRecordEnd;
                string OnError = Properties.Settings.Default.OnError;
                if (frm.ShowDialog(this) == DialogResult.OK) {
                    if (server != Properties.Settings.Default.Server ||
                        port != Properties.Settings.Default.Port ||
                        user != Properties.Settings.Default.User ||
                        passwort != Properties.Settings.Default.Passwort)
                        RestartServer();
                }
                me.Enabled = true;
            }
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (shutdown == false) {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void statusIcon_Click(object sender, EventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
