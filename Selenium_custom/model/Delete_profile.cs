﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class Delete_profile
    {
        public string[] uuid_browser { get; set; }
    }

    public class Response_Delete_profile
    {
        public string type { get; set; }
        public string title { get; set; }
        public object[] content { get; set; }
    }

}
