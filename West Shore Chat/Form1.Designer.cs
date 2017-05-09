namespace West_Shore_Chat
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.messageText = new System.Windows.Forms.RichTextBox();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainText.Location = new System.Drawing.Point(13, 13);
            this.mainText.Name = "mainText";
            this.mainText.ReadOnly = true;
            this.mainText.Size = new System.Drawing.Size(707, 358);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "";
            // 
            // messageText
            // 
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.Location = new System.Drawing.Point(13, 377);
            this.messageText.Multiline = false;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(707, 32);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "";
            this.messageText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageText_KeyDown);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(731, 13);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.connectionStatusLabel.TabIndex = 2;
            this.connectionStatusLabel.Text = "Connection Status:";
            // 
            // connectionStatus
            // 
            this.connectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.ForeColor = System.Drawing.Color.Red;
            this.connectionStatus.Location = new System.Drawing.Point(731, 26);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(79, 13);
            this.connectionStatus.TabIndex = 3;
            this.connectionStatus.Text = "Not Connected";
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Location = new System.Drawing.Point(748, 377);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 31);
            this.send.TabIndex = 4;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(731, 53);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(78, 13);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Connected To:";
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(731, 66);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(29, 13);
            this.user.TabIndex = 6;
            this.user.Text = "User";
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(731, 100);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(99, 13);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Computer Location:";
            // 
            // location
            // 
            this.location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(731, 113);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(34, 13);
            this.location.TabIndex = 8;
            this.location.Text = "Blank";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(748, 347);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 9;
            this.log.Text = "Save Log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 421);
            this.Controls.Add(this.log);
            this.Controls.Add(this.location);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.user);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.send);
            this.Controls.Add(this.connectionStatus);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.mainText);
            this.MinimumSize = new System.Drawing.Size(860, 460);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Help Desk Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.RichTextBox messageText;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Button log;
    }
}

