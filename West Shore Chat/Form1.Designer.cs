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
            this.connectionStatus = new System.Windows.Forms.Label();
            this.connectionStatus1 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
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
            this.mainText.TabIndex = 0;
            this.mainText.Text = "";
            // 
            // messageText
            // 
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.Location = new System.Drawing.Point(13, 377);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(707, 32);
            this.messageText.TabIndex = 1;
            this.messageText.Text = "";
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.Location = new System.Drawing.Point(731, 13);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(97, 13);
            this.connectionStatus.TabIndex = 2;
            this.connectionStatus.Text = "Connection Status:";
            // 
            // connectionStatus1
            // 
            this.connectionStatus1.AutoSize = true;
            this.connectionStatus1.ForeColor = System.Drawing.Color.Red;
            this.connectionStatus1.Location = new System.Drawing.Point(731, 26);
            this.connectionStatus1.Name = "connectionStatus1";
            this.connectionStatus1.Size = new System.Drawing.Size(79, 13);
            this.connectionStatus1.TabIndex = 3;
            this.connectionStatus1.Text = "Not Connected";
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
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 421);
            this.Controls.Add(this.send);
            this.Controls.Add(this.connectionStatus1);
            this.Controls.Add(this.connectionStatus);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.mainText);
            this.MinimumSize = new System.Drawing.Size(860, 460);
            this.Name = "mainForm";
            this.Text = "Help Desk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.RichTextBox messageText;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.Label connectionStatus1;
        private System.Windows.Forms.Button send;
    }
}

