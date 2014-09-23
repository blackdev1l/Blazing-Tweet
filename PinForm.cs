using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blazing_Tweet
{
    public partial class PinForm : Form
    {
        private string captcha;
        public PinForm()
        {
            InitializeComponent();
        }

        private void onOk(object sender, EventArgs e)
        {
            captcha = pin_box.Text;
            this.Close();
        }

        public string getCap()
        {
            return this.captcha;
        }

    }
}
