using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void send_Click(object sender, EventArgs e)
        {
            sendMessage();
        }
    }
}