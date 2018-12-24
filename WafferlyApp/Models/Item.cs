using System;

namespace WafferlyApp.Models
{

    public class Item
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
        public double Amount
        {
            get;
            set;
        }
        public string Unit
        {
            get;
            set;
        }
        public double UnitPrice
        {
            get;
            set;
        }
        public bool Discount
        {
            get;
            set;

        }
        public string DiscountImagePath
        {
            get;
            set;
        }
        public DateTime OfferStartDate
        {
            get;
            set;
        }
        public DateTime OfferEndDate
        {
            get;
            set;
        }
        public string ItemThumbPath
        {
            get;
            set;
        }
        public string ItemImagePath
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
#region Navigation Properties
        public  Translation Translation
        {
            get;
            set;
        }
        public  Category Category
        {
            get;
            set;
        }
        public  Brand Brand
        {
            get;
            set;
        }
        public  Country Country
        {
            get;
            set;
        }
        //public List<string> Tags
        //{
        //    get;
        //    set;
        //}
        //public List<string> Receipes
        //{
        //    get;
        //    set;
        //}
        public  Vendor Vendor
        {
            get;
            set;
        }
#endregion
        #region Foreign Keys
        public int? TranslationId
        {
            get;
            set;
        }
        public int? CategoryId
        {
            get;
            set;
        }
        public int? BrandId
        {
            get;
            set;
        }
        public int? CountryId
        {
            get;
            set;
        }
        public string VendorId
        {
            get;
            set;
        }
#endregion
    }
}
