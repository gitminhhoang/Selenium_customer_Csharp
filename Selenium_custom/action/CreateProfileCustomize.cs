using Newtonsoft.Json;
using Selenium_custom.controller;
using Selenium_custom.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_custom.action
{
    public partial class CreateProfileCustomize : UserControl
    {
        public CreateProfileCustomize()
        {
            InitializeComponent();
            cbbCanvas.Text = "noise";
            cbbWebglImage.Text = "true";
            cbbAudioContext.Text = "true";
            cbbMetadata.Text = "true";
            cbbClientReact.Text = "true";
            cbbResolution.Text = "1024x768";
        }

        private void btnCreateByCustomizeCT_Click(object sender, EventArgs e)
        {
            string os = txtOs.Text.Trim();
            string version = txtVersion.Text.Trim();
            string useragent = txtUseragent.Text.Trim();
            string canvas = cbbCanvas.SelectedItem.ToString().Trim();
            string webGLImage = cbbWebglImage.SelectedItem.ToString().Trim();
            string audioContext = cbbAudioContext.SelectedItem.ToString().Trim();
            string webGLMetadata = cbbMetadata.SelectedItem.ToString().Trim();
            string clientRectsEnable = cbbClientReact.SelectedItem.ToString().Trim();

            string webGLVendor = txtVendor.Text.Trim();
            string webGLMetadataRenderer = txtRenderer.Text.Trim();
            string StartURL = txtStartUrl.Text.Trim();
            string languages = txtLanguages.Text.Trim();
            string resolution = cbbResolution.SelectedItem.ToString().Trim();

            Body_Customize body_ = new Body_Customize();

            body_.os = os;
            body_.version = version;
            body_.userAgent = useragent;
            body_.canvas = canvas;
            body_.webGLImage = webGLImage;
            body_.webGLMetadata = webGLMetadata;
            body_.audioContext = audioContext;
            body_.clientRectsEnable = clientRectsEnable;
            body_.webGLVendor = webGLVendor;
            body_.webGLMetadataRenderer = webGLMetadataRenderer;
            body_.StartURL = StartURL;
            body_.languages = languages;
            body_.resolution = resolution;

            lbStatus.Text = "Create profile running...";
            lbStatus.ForeColor = Color.Green;

            Api api = new Api();
            string data = api.CreateProfileCustomize(body_);
            Response_create_customize rootobject = JsonConvert.DeserializeObject<Response_create_customize>(data);

            string status = rootobject.type;

            lbStatus.Text = status;
            lbStatus.ForeColor = Color.BlueViolet;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
