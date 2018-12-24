using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WafferlyApp.Models
{
    [JsonObjectAttribute]
	public class Address:List<VendorBranch>
    {
        public int Id
        {
            get;
            set;
        }
        public string AddressLine1
        {
            get;
            set;
        }
        public string AddressLine2
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string ZipCode
        {
            get;
            set;
        }
        public string Latitude
        {
            get;
            set;
        }
        public string Longitude
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

        public int AddressTranslationId {
            get;
            set;
		}
        public AddressTranslation AddressTranslation
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
        public int CountryId {
            get;
            set;
		}
        public Country Country
        {
            get;
            set;
        }

    }
}
