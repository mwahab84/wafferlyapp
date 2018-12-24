using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WafferlyApp.Models
{
    [JsonObjectAttribute]
	public class VendorBranch:List<VendorBranchTiming>
    {
        public int Id
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
        public string VendorBranchCoverPath
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
        public int TranslationId {
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
        public string VendorId {
            get;
            set;
		}
        public Vendor Vendor
        {
            get;
            set;
        }
        public int AddressId {
            get;
            set;
		}
        public Address Address
        {
            get;
            set;
        }

    }
}
