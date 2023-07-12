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
    public partial class UpdateNote : UserControl
    {
        public UpdateNote()
        {
            InitializeComponent();
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            string uid = txtProfileUid.Text.Trim();
            string notes = txtNotes.Text.Trim();
            Update_note note = new Update_note();
            note.profile_uuid = uid;
            note.note = notes;
            if(!string.IsNullOrEmpty(uid))
            {
                lbStatus.Text = "running update note...";
                lbStatus.ForeColor = Color.Green;

                Api api = new Api();
                string data = api.UpdateNote(note);
                Response_update_note rootobject = JsonConvert.DeserializeObject<Response_update_note>(data);

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
