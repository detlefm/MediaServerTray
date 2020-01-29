namespace MediaServerTray {
    partial class Options {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOnRecStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOnRecEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOnError = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbLogfile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.tbEnd = new System.Windows.Forms.Button();
            this.tbError = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.Button();
            this.btTestStart = new System.Windows.Forms.Button();
            this.btTestEnd = new System.Windows.Forms.Button();
            this.btTestError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(90, 32);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(250, 20);
            this.tbServer.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(90, 69);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(250, 20);
            this.tbPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(90, 106);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(250, 20);
            this.tbUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // tbPasswort
            // 
            this.tbPasswort.Location = new System.Drawing.Point(90, 143);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(250, 20);
            this.tbPasswort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passwort";
            // 
            // tbOnRecStart
            // 
            this.tbOnRecStart.Location = new System.Drawing.Point(90, 180);
            this.tbOnRecStart.Name = "tbOnRecStart";
            this.tbOnRecStart.Size = new System.Drawing.Size(221, 20);
            this.tbOnRecStart.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "On Rec Start";
            // 
            // tbOnRecEnd
            // 
            this.tbOnRecEnd.Location = new System.Drawing.Point(90, 217);
            this.tbOnRecEnd.Name = "tbOnRecEnd";
            this.tbOnRecEnd.Size = new System.Drawing.Size(221, 20);
            this.tbOnRecEnd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "On Rec End";
            // 
            // tbOnError
            // 
            this.tbOnError.Location = new System.Drawing.Point(90, 254);
            this.tbOnError.Name = "tbOnError";
            this.tbOnError.Size = new System.Drawing.Size(221, 20);
            this.tbOnError.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "On Error";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(339, 331);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(244, 331);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 15;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbLogfile
            // 
            this.tbLogfile.Location = new System.Drawing.Point(90, 291);
            this.tbLogfile.Name = "tbLogfile";
            this.tbLogfile.Size = new System.Drawing.Size(221, 20);
            this.tbLogfile.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Logfile";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(317, 180);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(34, 21);
            this.btStart.TabIndex = 18;
            this.btStart.Text = ",,,";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(317, 217);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(34, 21);
            this.tbEnd.TabIndex = 19;
            this.tbEnd.Text = ",,,";
            this.tbEnd.UseVisualStyleBackColor = true;
            this.tbEnd.Click += new System.EventHandler(this.tbEnd_Click);
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(317, 254);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(34, 21);
            this.tbError.TabIndex = 20;
            this.tbError.Text = ",,,";
            this.tbError.UseVisualStyleBackColor = true;
            this.tbError.Click += new System.EventHandler(this.tbError_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(317, 291);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(34, 21);
            this.tbLog.TabIndex = 21;
            this.tbLog.Text = ",,,";
            this.tbLog.UseVisualStyleBackColor = true;
            this.tbLog.Click += new System.EventHandler(this.tbLog_Click);
            // 
            // btTestStart
            // 
            this.btTestStart.Location = new System.Drawing.Point(366, 180);
            this.btTestStart.Name = "btTestStart";
            this.btTestStart.Size = new System.Drawing.Size(48, 23);
            this.btTestStart.TabIndex = 22;
            this.btTestStart.Text = "Test";
            this.btTestStart.UseVisualStyleBackColor = true;
            this.btTestStart.Click += new System.EventHandler(this.btTestStart_Click);
            // 
            // btTestEnd
            // 
            this.btTestEnd.Location = new System.Drawing.Point(366, 217);
            this.btTestEnd.Name = "btTestEnd";
            this.btTestEnd.Size = new System.Drawing.Size(48, 23);
            this.btTestEnd.TabIndex = 23;
            this.btTestEnd.Text = "Test";
            this.btTestEnd.UseVisualStyleBackColor = true;
            this.btTestEnd.Click += new System.EventHandler(this.btTestEnd_Click);
            // 
            // btTestError
            // 
            this.btTestError.Location = new System.Drawing.Point(366, 254);
            this.btTestError.Name = "btTestError";
            this.btTestError.Size = new System.Drawing.Size(48, 23);
            this.btTestError.TabIndex = 24;
            this.btTestError.Text = "Test";
            this.btTestError.UseVisualStyleBackColor = true;
            this.btTestError.Click += new System.EventHandler(this.btTestError_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 376);
            this.Controls.Add(this.btTestError);
            this.Controls.Add(this.btTestEnd);
            this.Controls.Add(this.btTestStart);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbLogfile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbOnError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOnRecEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbOnRecStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOnRecStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOnRecEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOnError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbLogfile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button tbEnd;
        private System.Windows.Forms.Button tbError;
        private System.Windows.Forms.Button tbLog;
        private System.Windows.Forms.Button btTestStart;
        private System.Windows.Forms.Button btTestEnd;
        private System.Windows.Forms.Button btTestError;
    }
}