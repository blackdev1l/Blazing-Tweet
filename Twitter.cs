using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace Blazing_Tweet
{
    public class Twitter
    {
        public Twitter()
        {
            TwitterCredentials.SetCredentials(Properties.Settings.Default.access_token,
                                              Properties.Settings.Default.access_token_secret,
                                              Properties.Resources.api_key,
                                              Properties.Resources.api_key_secret);
        }
    }
}
