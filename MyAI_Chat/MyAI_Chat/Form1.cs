using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatGpt.Net;

namespace MyAI_Chat
{
    public partial class ConversationWithChatBot : Form
    {
        public ConversationWithChatBot()
        {
            InitializeComponent();
        }

        private void rUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.apiKeyArea.Enabled = true;
            this.loadApiKeyBtn.Enabled = true;
        }

        private void loadApiKeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var bot = new ChatGpt(apiKeyArea.Text)
            }
            if (apiKeyArea.Text.Length > 0)
            {
                this.chatArea.Enabled = true;

                chatArea.Text += "Hello. This is a simple ChatBot_conversation_app." + "\r\n" + "Please type the message and push 'ENTER_BUTTON'." + "\r\n" + "Have a good time:-)";
            }
        }
    }
}
