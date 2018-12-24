using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WafferlyApp.Models
{
    [JsonObjectAttribute]
	public class Vendor:List<Item>//, List<VendorBranch>
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
        public string VendorCoverPath
        {
            get;
            set;
        }
        public bool Status
        {
            get;
            set;
        }
        public bool IsApproved
        {
            get;
            set;
        }
        public bool IsPublished
        {
            get;
            set;
        }
        public Translation Translation
        {
            get;
            set;
        }
        public DateTime DateCreated
        {
            get;
            set;
        }
        public DateTime DateLastModified
        {
            get;
            set;
        }
        //public string[] Locations
        //{
        //    get;
        //    set;
        //}

        //[JsonIgnore]
        //public ICollection<Item> Items { get; set; }

        //[JsonIgnore]
        //public ICollection<VendorBranch> VendorBranches
        //{
        //    get;
        //    set;
        //}
    }
}
