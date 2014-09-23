using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace Blazing_Tweet
{
    static class Program
    {
        private static string captcha;
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
            Application.Run(new Message());
        }

        private static void showDialog()
        {
            var applicationCredentials = CredentialsCreator.GenerateApplicationCredentials(Properties.Settings.Default.api_key, 
                                                                                           Properties.Settings.Default.api_key_secret);
            var url = CredentialsCreator.GetAuthorizationURL(applicationCredentials);
            System.Diagnostics.Process.Start(url);
            PinForm form = new PinForm();
            Application.Run(form);
            captcha = form.getCap();
            try
            {
                var newCredentials = CredentialsCreator.GetCredentialsFromVerifierCode(captcha, applicationCredentials);
                Properties.Settings.Default.access_token = newCredentials.AccessToken;
                Properties.Settings.Default.access_token = newCredentials.AccessTokenSecret;
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
