using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace West_Shore_Chat
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        public void sendMessage()
        {
            string userName = Environment.UserName;

            mainText.AppendText(">>: " + userName + ": " + messageText.Text + "\n");

            messageText.Clear();

        }

        private void saveLog()
        {
            DateTime currentTime = DateTime.Now;

            FileStream fs = new FileStream(@"HelpDeskLog " + currentTime.ToString("MM-dd-yy(hh;mm;ss)") + ".txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(mainText);
            sw.Close();
        }

        private void send_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void messageText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                sendMessage();
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            saveLog();
        }
    }
}