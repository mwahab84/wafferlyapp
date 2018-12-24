using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WafferlyApp.Models
{
    [JsonObjectAttribute]
	public class Country: List<Item>//, List<Address>, List<Brand>, List<VendorBranch>
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
        public string CountryFlagPath
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
        #region foreign keys
        public int? TranslationId
        {
            get;
            set;
        }
        #endregion

        #region navigation properties
        public Translation Translation
        {
            get;
            set;
        }
     
#endregion
    }
}
