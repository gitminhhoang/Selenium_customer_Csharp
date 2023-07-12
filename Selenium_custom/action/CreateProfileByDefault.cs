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
    public partial class CreateProfileByDefault : UserControl
    {
        public CreateProfileByDefault()
        {
            InitializeComponent();
        }

        private void btnCreateByDefaultCT_Click(object sender, EventArgs e)
        {
            string _uid = txtConfigIdCT.Text;
            if (_uid.Trim().Length > 0)
            {
                lbStatus.Text = "Create profile running...";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.CreateProfileByDefault(_uid);
                Create_profile_by_default.Create_profile rootobject = JsonConvert.DeserializeObject<Create_profile_by_default.Create_profile>(data);

                string status = rootobject.type;

                lbStatus.Text = status;
                lbStatus.ForeColor = Color.BlueViolet;
            }
            else
            {
                MessageBox.Show("dien uid di");
            }
        }
    }
}
