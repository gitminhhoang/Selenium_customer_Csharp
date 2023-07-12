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
    public partial class ListConfig : UserControl
    {
        public static ListConfig listConfig = new ListConfig();
        public ListConfig()
        {
            InitializeComponent();
        }
        public static void setListConfig(ListConfig configs)
        {
            listConfig = configs;
        }
        private void dgv_list_config_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(nbPage.Value.ToString());
            int limit = Int32.Parse(nbLimit.Value.ToString());

            Api api = new Api();
            string data = api.GetListProfile(page,limit);
            if(data == "[]")
            {
                MessageBox.Show("Khong co profile nao");
            }
            else
            {
                rtbList.Text = data;
            }
            
            
        }

        private void ListConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
