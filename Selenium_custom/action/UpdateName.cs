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
    public partial class UpdateName : UserControl
    {
        public UpdateName()
        {
            InitializeComponent();
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            string uid = txtProfileUid.Text.Trim();
            string nameProfile = txtNameProfile.Text.Trim();
            Update_name update = new Update_name();
            update.profile_uuid = uid;
            update.data = nameProfile;
            if (!string.IsNullOrEmpty(uid))
            {
                lbStatus.Text = "running update note...";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.UpdateName(update);
                Response_update_name rootobject = JsonConvert.DeserializeObject<Response_update_name>(data);

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
