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
    public partial class SyncTag : UserControl
    {
        public SyncTag()
        {
            InitializeComponent();
        }

        private void btnSyncTags_Click(object sender, EventArgs e)
        {
            string uid = txtProfileUid.Text.Trim();
            string tags = rtbTags.Text.Trim();
            string[] arr_tags = tags.Split(',');

            Sync_tag tag = new Sync_tag();
            tag.profile_uuid = uid;
            tag.tags = arr_tags;

            if (!string.IsNullOrEmpty(uid))
            {
                lbStatus.Text = "running sync tag...";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.Sync_Tag(tag);
                Respone_Sync_tags rootobject = JsonConvert.DeserializeObject<Respone_Sync_tags>(data);

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
