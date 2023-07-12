using Chilkat;
using Newtonsoft.Json;
using OpenQA.Selenium;
using Selenium_custom.action;
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

namespace Selenium_custom
{
    public partial class Form1 : Form
    {
        bool isShowOpen = false;
        bool isShowClose = false;
        bool isShowCheck = false;
        bool isShowTestScript = false;

        bool isShowListConFig = false;
        bool isShowListTag = false;
        bool isShowListProfile = false;
        bool isShowCreateProfileDefault = false;
        bool isShowCreateProfileCustomize = false;
        bool isShowUpdateNote = false;
        bool isShowUpdateName = false;
        bool isShowSyncTag = false;
        bool isShowChangeStatus = false;
        bool isShowDeleteProfile = false;
        bool isShowListStatus = false;
        bool isShowGetProfileUid = false;

        static int port = -1;

        public Form1()
        {
            InitializeComponent();
        }
        public static void setPort(int _port)
        {
            port = _port;
        }
        public void resetVisible()
        {
            openProfileCT.Visible = false;
            closeProfileCT.Visible = false;
            checkingProfileCT.Visible = false;
            listConfigCT.Visible = false;
            createProfileByDefaultCT.Visible = false;
            createProfileCustomizeCT.Visible = false;
            updateNoteCT.Visible = false;
            updateNameCT.Visible = false;
            syncTagCT.Visible = false;
            changeStatusCT.Visible = false;
            deleteProfileCT.Visible = false;
            listStatus_CT.Visible = false;
            listTagCT.Visible = false;
            getProfileByUid_CT.Visible = false;
            listProfile_CT.Visible = false;

            test_script1.Visible = false;

            isShowOpen = false;
            isShowClose = false;
            isShowCheck = false;
            isShowListConFig = false;
            isShowCreateProfileDefault = false;
            isShowCreateProfileCustomize = false;
            isShowUpdateNote = false;
            isShowUpdateName = false;
            isShowSyncTag = false;
            isShowChangeStatus = false;
            isShowDeleteProfile = false;
            isShowListStatus = false;
            isShowListTag = false;
            isShowGetProfileUid = false;
            isShowListProfile = false;

            isShowTestScript = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Global glob = new Global();
            glob.UnlockBundle("ADSVN8.CBX1124_zUkOHNdJpY9b");
        }

        private void btnOpenProfile_Click(object sender, EventArgs e)
        {
            #region test_remote
            //Api api = new Api();
            //string data = api.OpenProfile("992fdf34-4f1a-4fc7-960f-68f4e6a32511");
            //Response_open_profile.Rootobject rootobject = JsonConvert.DeserializeObject<Response_open_profile.Rootobject>(data);

            //int  port = rootobject.data.remote_port;
            //string status = rootobject.status;

            //Thread.Sleep(2000);

            //Selenium_connect_port selenium = new Selenium_connect_port();
            //var driver = selenium.ConnectDriver(port);

            //Thread.Sleep(2000);

            //selenium.GotoUrl(driver, "https://checkip.com.vn/");
            //if(selenium.HasFindElementXpath(driver, "//*[@id=\"frm-checkip\"]/input"))
            //{
            //    IWebElement inputIp = selenium.findElementXpath(driver, "//*[@id=\"frm-checkip\"]/input");
            //    selenium.SendText(inputIp, "38.170.114.231");

            //    Thread.Sleep(2000);

            //    if (selenium.HasFindElementXpath(driver, "//*[@id=\"frm-checkip\"]/button"))
            //    {
            //        IWebElement web = selenium.findElementXpath(driver, "//*[@id=\"frm-checkip\"]/button");
            //        selenium.ClickElement(web);
            //    }
            //}
            //OpenProfile openProfile = new OpenProfile();
            //openProfile.Show();
            #endregion

            resetVisible();
            
            openProfileCT.Visible = !isShowOpen;
            isShowOpen = !isShowOpen;
        }

        private void btnCloseProfile_Click(object sender, EventArgs e)
        {
            resetVisible();

            closeProfileCT.Visible = !isShowClose;
            isShowClose = !isShowClose;
        }

        private void closeProfileCT_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckingProfile_Click(object sender, EventArgs e)
        {
            resetVisible();

            checkingProfileCT.Visible = !isShowCheck;
            isShowCheck = !isShowCheck;
        }

        private void btnListConfig_Click(object sender, EventArgs e)
        {
            resetVisible();
            listConfigCT.Visible = !isShowListConFig;
            isShowListConFig = !isShowListConFig;

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            resetVisible();
            test_script1.Visible = !isShowTestScript;
            isShowTestScript = !isShowTestScript;

        }

        private void btnCreateProfileDefault_Click(object sender, EventArgs e)
        {
            resetVisible();
            createProfileByDefaultCT.Visible = !isShowCreateProfileDefault;
            isShowCreateProfileDefault = !isShowCreateProfileDefault;
        }

        private void btnCreateProfileCustomize_Click(object sender, EventArgs e)
        {
            resetVisible();

            createProfileCustomizeCT.Visible = !isShowCreateProfileCustomize;
            isShowCreateProfileCustomize = !isShowCreateProfileCustomize;
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            resetVisible();
            updateNoteCT.Visible = !isShowUpdateNote;
            isShowUpdateNote = !isShowUpdateNote;
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            resetVisible();
            updateNameCT.Visible = !isShowUpdateName;
            isShowUpdateName = !isShowUpdateName;
        }


        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            resetVisible();
            changeStatusCT.Visible = !isShowChangeStatus;
            isShowChangeStatus = !isShowChangeStatus;
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            resetVisible();
            deleteProfileCT.Visible = !isShowDeleteProfile;
            isShowDeleteProfile = !isShowDeleteProfile;
        }

        private void btnSyncTag_Click(object sender, EventArgs e)
        {
            resetVisible();
            syncTagCT.Visible = !isShowSyncTag;
            isShowSyncTag = !isShowSyncTag;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            resetVisible();
            listStatus_CT.Visible = !isShowListStatus;
            isShowListStatus = !isShowListStatus;
        }
        private void btnListTag_Click(object sender, EventArgs e)
        {
            resetVisible();
            listTagCT.Visible = !isShowListTag;
            isShowListTag = !isShowListTag;
        }

        private void btnGetProfileByUuid_Click(object sender, EventArgs e)
        {
            resetVisible();
            getProfileByUid_CT.Visible = !isShowGetProfileUid;
            isShowGetProfileUid = !isShowGetProfileUid;
        }

        private void btnUpdateProxy_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfileProxy_Click(object sender, EventArgs e)
        {

        }

        private void btnListProfile_Click(object sender, EventArgs e)
        {
            resetVisible();
            listProfile_CT.Visible = !isShowListProfile;
            isShowListProfile = !isShowListProfile;
        }
    }
}
