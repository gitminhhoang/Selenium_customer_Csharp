using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class Update_note
    {
        public string profile_uuid { get; set; }
        public string note { get; set; }
    }

    public class Response_update_note
    {
        public string type { get; set; }
        public string title { get; set; }
        public object[] content { get; set; }
    }

}
