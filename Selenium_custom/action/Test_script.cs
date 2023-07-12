using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    public partial class Test_script : UserControl
    {
        public Test_script()
        {
            InitializeComponent();
        }
        public void sendLog(string mess)
        {
            Invoke(new MethodInvoker(() =>
            {
                rtbLog.AppendText(mess);
            }));
        }
        private void btnOpenScriptCT_Click(object sender, EventArgs e)
        {
            string _uid = txtUidProfileCT.Text;
            if (_uid.Trim().Length > 0)
            {
                startProfile(_uid.Trim());
            }
            else
            {
                MessageBox.Show("dien uid di");
            }
        }
        public void startProfile(string uid)
        {
            Thread thread = new Thread(() => {
                Api api = new Api();
                sendLog("Running profile : "+uid+"\n");
                string data = api.OpenProfile(uid);
                if(data.Contains("\"status\":\"error\"")){
                    sendLog("Profile open : false");
                    return;
                }
                Response_open_profile.Rootobject rootobject = JsonConvert.DeserializeObject<Response_open_profile.Rootobject>(data);

                int port = rootobject.data.remote_port;
                string status = rootobject.status;
                sendLog("Profile status: "+status + " \n");
                sendLog("Profile remote port: "+ port + " \n");
                Thread.Sleep(2000);

                Selenium_connect_port selenium = new Selenium_connect_port();
                if(selenium == null)
                {
                    sendLog("--- Connect port false ---" + " \n");
                    return;
                }
                var driver = ConnectPort(selenium,port);

                selenium.GotoUrl(driver, "https://checkip.vip/");
                sendLog("--- Go to url ---" + " \n");
                if (selenium.HasFindElementXpath(driver, "//*[@id=\"ip\"]"))
                {
                    IWebElement inputIp = selenium.findElementXpath(driver, "//*[@id=\"ip\"]");
                    selenium.SendText(inputIp, "38.170.114.231");
                    sendLog("--- send text --- : "+ "38.170.114.231" + " \n");
                }
                else
                {
                    sendLog(" --- khong tim thay xpath input IP --- " + " \n");
                }
                Thread.Sleep(2000);

                if (selenium.HasFindElementXpath(driver, "//*[@id=\"submit\"]"))
                {
                    IWebElement web = selenium.findElementXpath(driver, "//*[@id=\"submit\"]");
                    selenium.ClickElement(web);
                    sendLog("--- click element check ip --- : " + " \n");
                }
                else
                {
                    sendLog("--- khong tim thay xpath Submit --- " + " \n");
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public ChromeDriver ConnectPort(Selenium_connect_port selenium ,int port)
        {
            var driver = selenium.ConnectDriver(port);
            sendLog("Connect port: " + port + " \n");
            Thread.Sleep(2000);

            return driver;
        } 
        private void Test_script_Load(object sender, EventArgs e)
        {

        }
    }
}
