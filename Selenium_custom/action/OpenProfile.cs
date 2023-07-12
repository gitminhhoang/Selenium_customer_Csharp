using Newtonsoft.Json;
using Selenium_custom.controller;
using Selenium_custom.model;
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
    public partial class OpenProfile : UserControl
    {
        public OpenProfile()
        {
            InitializeComponent();
        }

        private void OpenProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string _uid =  txtUidProfile.Text;
            if(_uid.Trim().Length > 0)
            {
                lbStatus.Text = "Running open profile";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.OpenProfile(_uid);
                Response_open_profile.Rootobject rootobject = JsonConvert.DeserializeObject<Response_open_profile.Rootobject>(data);

                int port = rootobject.data.remote_port;
                string status = rootobject.status;

                lbStatus.Text = status;
                lbStatus.ForeColor = Color.BlueViolet;
                Form1.setPort(port);
            }
            else
            {
                MessageBox.Show("dien uid di");
            }
            
        }
    }
}
