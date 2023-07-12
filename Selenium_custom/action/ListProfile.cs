using Selenium_custom.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_custom.action
{
    public partial class ListProfile : UserControl
    {
        public ListProfile()
        {
            InitializeComponent();
        }

        private void btnGetListProfile_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(nbPage.Value.ToString());
            int limit = Int32.Parse(nbLimit.Value.ToString());

            Thread thread = new Thread(() =>
            {
                Api api = new Api();
                string data = api.GetListProfile(page,limit);
                Invoke(new MethodInvoker(() =>
                {
                    rtbList.Text = data;
                }));
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void ListProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
