using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace Blazing_Tweet
{
    public partial class Message : Form
    {
        //baloon tip checker
        private bool BaloonShowed = false;

        public Message()
        {
            InitializeComponent();
            hide_checkbox.Checked = Properties.Settings.Default.autohide;
        }


        private void onSend(object sender, EventArgs e)
        {
            /*
             * Checks the message length and return a Dialog Error if it's over than 140 chars
             */
            if (message_box.TextLength > 140)
                MessageBox.Show("Tweet is too long",
                                "Max character is 140",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            var tweet = Tweet.CreateTweet(message_box.Text);
            if (tweet.Publish())
            {
                BaloonShowed = true; //if you send the Tweet it prevent to show "Tweet sent" on the first minimize
                notifyIcon1.BalloonTipText = "Tweet Sent";
                notifyIcon1.ShowBalloonTip(1000);
                if(hide_checkbox.Checked)
                    this.Hide();
                //Reset the message box
                message_box.Text = "";
            }
            else
            {
                MessageBox.Show("Error",
                                "Failed to Send",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);


            }


        }

        /**
         * Double click on traybar handler 
         */
        private void onNotifyDoubleClick(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        /*
         * Count handler, if the message length goes over 140
         * it change color to Red
         */
        private void updateCount(object sender, EventArgs e)
        {
            if (message_box.TextLength > 140)
                count_label.ForeColor = Color.Crimson;
            else
                count_label.ForeColor = Color.Black;
            count_label.Text = message_box.TextLength.ToString();
        }

        private void onQuit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * Reset the Access Token and Access token Secret
         */ 
        private void onLogOut(object sender, EventArgs e)
        {

            Properties.Settings.Default.access_token = "";
            Properties.Settings.Default.access_token_secret = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("Succesfully logged out, Good bye!");
            Application.Exit();
        }

        private void onCheckChange(object sender, EventArgs e)
        {
            Properties.Settings.Default.autohide = hide_checkbox.Checked;
            Properties.Settings.Default.Save();
            //hide_checkbox.Checked = !hide_checkbox.Checked;
        }

        /*
         * This function handles the "minimize on tray" behavior
         */
        private void onResize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                if (!BaloonShowed)
                {
                    notifyIcon1.ShowBalloonTip(500);
                    BaloonShowed = true;
                }
                this.Hide();
            }
        }  
    }
}
