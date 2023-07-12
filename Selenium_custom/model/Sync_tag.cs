using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class Sync_tag
    {
        public string[] tags { get; set; }
        public string profile_uuid { get; set; }
    }

    public class Respone_Sync_tags
    {
        public string type { get; set; }
        public string title { get; set; }
        public object[] content { get; set; }
    }

}
