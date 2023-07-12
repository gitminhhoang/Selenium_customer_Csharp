using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class Update_profile_proxy
    {

        public class Body_update_profile_proxy
        {
            public Browser_Update[] browser_update { get; set; }
        }

        public class Browser_Update
        {
            public string uuid { get; set; }
            public string proxy { get; set; }
        }

    }
}
