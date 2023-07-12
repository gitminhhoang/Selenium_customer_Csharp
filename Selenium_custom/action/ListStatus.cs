using Selenium_custom.controller;
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
    public partial class listStatus : UserControl
    {
        
        public listStatus()
        {
            InitializeComponent();
        }
        public  void setStatus()
        {
            Api api = new Api();
            string data = api.GetListStatus();
            if (data == "[]")
            {
                rtbListStatus.Text = "khong co status";
            }
            else
            {
                rtbListStatus.Text = data;
            }

        }
        private void ListStatus_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            setStatus();
        }
    }
}
