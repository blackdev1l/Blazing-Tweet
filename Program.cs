using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace Blazing_Tweet
{
    static class Program
    {
        private static string captcha;
        private static Twitter twt;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.access_token == "")
                showDialog();
            twt = new Twitter();
            Application.Run(new Message());
        }

        /*
         * Function that handles the first program load
         */
        private static void showDialog()
        {
            var applicationCredentials = CredentialsCreator.GenerateApplicationCredentials(Properties.Settings.Default.api_key, 
                                                                                           Properties.Settings.Default.api_key_secret);
            var url = CredentialsCreator.GetAuthorizationURL(applicationCredentials);

            System.Diagnostics.Process.Start(url); //Url opener
            PinForm form = new PinForm();
            Application.Run(form);
            captcha = form.getCap();
            try
            {
                var newCredentials = CredentialsCreator.GetCredentialsFromVerifierCode(captcha, applicationCredentials);
                Properties.Settings.Default.access_token = newCredentials.AccessToken;
                Properties.Settings.Default.access_token_secret = newCredentials.AccessTokenSecret;
                Properties.Settings.Default.Save();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Application.Exit();
            }

        }
    }
}
