using Selenium_custom.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_custom.action
{
    public partial class GetProfileByUid : UserControl
    {
        public GetProfileByUid()
        {
            InitializeComponent();
        }

        private void btnGetProfile_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.Trim();
            if(!string.IsNullOrEmpty(uid))
            {
                Thread thread = new Thread(() =>
                {
                    Api api = new Api();
                    string data = api.GetProfileByUid(uid);
                    Invoke(new MethodInvoker(() =>
                    {
                        rtbInfor.Text = data;
                    }));
                });
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void GetProfileByUid_Load(object sender, EventArgs e)
        {

        }
    }
}
