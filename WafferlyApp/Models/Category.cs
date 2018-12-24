using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WafferlyApp.Models
{
    [JsonObjectAttribute]
	public class Category:List<Item>//, List<Category>
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
        public string CatImagePath
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
        public int? ParentId
        {
            get; set;
        }
        public int? TranslationId
        {
            get;
            set;
        }

#endregion
        #region navigation properties
        public Category Parent
        {
            get;
            set;
        }
        
        public Translation Translation
        {
            get;
            set;
        }
#endregion
    }
}
