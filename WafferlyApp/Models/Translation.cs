using System;


namespace WafferlyApp.Models
{
    public class Translation
    {
        public int Id{
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
        public string Entity
        {
            get;
            set;
        }
        public string ArabicTitle
        {
            get;
            set;
        }
        public string ArabicDesc
        {
            get;
            set;
        }
        public string ArabicUnit
        {
            get;
            set;
        }
        public string FrenchTitle
        {
            get;
            set;
        }
        public string FrenchDesc
        {
            get;
            set;
        }
        public string FrenchUnit
        {
            get;
            set;
        }
        public string TurkishTitle
        {
            get;
            set;
        }
        public string TurkishDesc
        {
            get;
            set;
        }
        public string TurkishUnit
        {
            get;
            set;
        }
        public string PersianTitle
        {
            get;
            set;
        }
        public string PersianDesc
        {
            get;
            set;
        }
        public string PersianUnit
        {
            get;
            set;
        }
        public string UrduTitle
        {
            get;
            set;
        }
        public string UrduDesc
        {
            get;
            set;
        }
        public string UrduUnit
        {
            get;
            set;
        }
        public string IndianTitle
        {
            get;
            set;
        }
        public string IndianDesc
        {
            get;
            set;
        }
        public string IndianUnit
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

        
        public  Vendor Vendor
        {
            get;
            set;
        }

        public VendorBranch VendorBranch
        {
            get;
            set;
        }

        public Country Country
        {
            get;
            set;
        }

        public virtual Category Category
        {
            get;
            set;
        }

        public Brand Brand
        {
            get;
            set;
        }

        public Item Item
        {
            get;
            set;
        }
    }
}
