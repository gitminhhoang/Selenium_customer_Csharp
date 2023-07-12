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
    public partial class ListTag : UserControl
    {
        public ListTag()
        {
            InitializeComponent();
        }

        private void ListTag_Load(object sender, EventArgs e)
        {
            

        }
        public void getTag()
        {
            Api api = new Api();
            string data = api.GetListTag();
            if (data == "[]")
            {
                rtbListTag.Text = "khong co tag";
            }
            else
            {
                rtbListTag.Text = data;
            }

        }

        private void btnGetTag_Click(object sender, EventArgs e)
        {
            getTag();
        }
    }
}
