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
    public partial class ChangeStatus : UserControl
    {
        public ChangeStatus()
        {
            InitializeComponent();
        }

        private void btnSyncTags_Click(object sender, EventArgs e)
        {
            string uid = txtProfileUid.Text.Trim();
            string id = txtId.Text.Trim();

            Change_status change = new Change_status();
            change.browser_uuid = uid;
            change.id = id;

            if (!string.IsNullOrEmpty(uid))
            {
                lbStatus.Text = "running sync tag...";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.Change_Status(change);
                Response_change_Status rootobject = JsonConvert.DeserializeObject<Response_change_Status>(data);

                string status = rootobject.type;

                lbStatus.Text = status;
                lbStatus.ForeColor = Color.BlueViolet;

            }
            else
            {

            }
        }

        private void txtProfileUid_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeStatus_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
