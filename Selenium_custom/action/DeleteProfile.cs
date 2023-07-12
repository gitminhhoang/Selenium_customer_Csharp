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
    public partial class DeleteProfile : UserControl
    {
        public DeleteProfile()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = rtbProfiles.Text.Trim();
            string[] _uids = uid.Split(',');

            Delete_profile delete = new Delete_profile();
            delete.uuid_browser = _uids;

            if (!string.IsNullOrEmpty(uid))
            {
                lbStatus.Text = "running delete profile...";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.Delete_Profile(delete);
                Response_Delete_profile rootobject = JsonConvert.DeserializeObject<Response_Delete_profile>(data);

                string status = rootobject.type;

                lbStatus.Text = status;
                lbStatus.ForeColor = Color.BlueViolet;

            }
            else
            {

            }
        }
    }
}
