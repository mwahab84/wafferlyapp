using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WafferlyApp.Models
{
    [JsonObjectAttribute]
    public class Vendor:List<Item>
    {
        public string Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Desc
        {
            get;
            set;
        }
        public string VendorLogoPath
        {
            get;
            set;
        }
        public string[] Locations
        {
            get;
            set;
        }
    }
}
