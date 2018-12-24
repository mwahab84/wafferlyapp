using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WafferlyApp.Models
{
    [JsonObjectAttribute]
	public class Brand:List<Item>
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
        public string BrandLogoPath
        {
            get;
            set;
        }
        public bool IsQatariNational
        {
            get;
            set;
        }
        public string NationalLogoPath
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
