using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class Change_status
    {
        public string id { get; set; }
        public string browser_uuid { get; set; }
    }

    public class Response_change_Status
    {
        public string type { get; set; }
        public string title { get; set; }
        public object[] content { get; set; }
    }

}
