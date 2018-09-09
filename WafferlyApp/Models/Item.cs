using System;
using Newtonsoft.Json;

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
        public string Discount
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
        public string ItemImagePath
        {
            get;
            set;
        }
        public string[] Tags
        {
            get;
            set;
        }
        public string[] Receipes
        {
            get;
            set;
        }
        public string VendorId
        {
            get;
            set;
        }

        public Vendor Vendor
        {
            get;
            set;
        }
    }
}
