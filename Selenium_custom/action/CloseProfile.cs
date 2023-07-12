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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_custom.action
{
    public partial class CloseProfile : UserControl
    {
        public CloseProfile()
        {
            InitializeComponent();
        }

        private void CloseProfile_Load(object sender, EventArgs e)
        {

        }
        private void btnCloseCT_Click(object sender, EventArgs e)
        {
            string _uid = txtUidProfileCT.Text;
            if (_uid.Trim().Length > 0)
            {
                lbStatus.Text = "Running close profile ...";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.CloseProfile(_uid);
                Response_open_profile.Rootobject rootobject = JsonConvert.DeserializeObject<Response_open_profile.Rootobject>(data);

                string status = rootobject.status;

                lbStatus.Text = status;
                lbStatus.ForeColor = Color.BlueViolet;
            }
            else
            {
                MessageBox.Show("dien uid di");
            }
        }

        private void txtUidProfileCT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
