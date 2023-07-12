using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class Response_open_profile
    {
        public class Rootobject
        {
            public string status { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public int remote_port { get; set; }
        }
    }
}
