using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class UpdateProxy
    {

        public class Body_Update_Proxy
        {
            public string uuid { get; set; }
            public string title { get; set; }
            public string ip { get; set; }
            public string port { get; set; }
            public string user { get; set; }
            public string pass { get; set; }
            public string type { get; set; }
            public string note { get; set; }
            public Details details { get; set; }
        }

        public class Details
        {
            public string ip { get; set; }
            public string hostname { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public string loc { get; set; }
            public string org { get; set; }
            public string postal { get; set; }
            public string timezone { get; set; }
            public Asn asn { get; set; }
        }

        public class Asn
        {
            public string asn { get; set; }
            public string name { get; set; }
            public string domain { get; set; }
            public string route { get; set; }
            public string type { get; set; }
        }

    }
}
