using System;
namespace WafferlyApp.Models
{
    public class VendorBranchTiming
    {
        public int Id
        {
            get;
            set;
        }
        public TimeSpan SatOpenHour
        {
            get;
            set;
        }
        public TimeSpan SatCloseHour
        {
            get;
            set;
        }
        public TimeSpan SatBreakStart
        {
            get;
            set;
        }
        public TimeSpan SatBreakEnd
        {
            get;
            set;
        }
        public TimeSpan SunOpenHour
        {
            get;
            set;
        }
        public TimeSpan SunCloseHour
        {
            get;
            set;
        }
        public TimeSpan SunBreakStart
        {
            get;
            set;
        }
        public TimeSpan SunBreakEnd
        {
            get;
            set;
        }
        public TimeSpan MonOpenHour
        {
            get;
            set;
        }
        public TimeSpan MonCloseHour
        {
            get;
            set;
        }
        public TimeSpan MonBreakStart
        {
            get;
            set;
        }
        public TimeSpan MonBreakEnd
        {
            get;
            set;
        }
        public TimeSpan TueOpenHour
        {
            get;
            set;
        }
        public TimeSpan TueCloseHour
        {
            get;
            set;
        }
        public TimeSpan TueBreakStart
        {
            get;
            set;
        }
        public TimeSpan TueBreakEnd
        {
            get;
            set;
        }
        public TimeSpan WedOpenHour
        {
            get;
            set;
        }
        public TimeSpan WedCloseHour
        {
            get;
            set;
        }
        public TimeSpan WedBreakStart
        {
            get;
            set;
        }
        public TimeSpan WedBreakEnd
        {
            get;
            set;
        }
        public TimeSpan ThuOpenHour
        {
            get;
            set;
        }
        public TimeSpan ThuCloseHour
        {
            get;
            set;
        }
        public TimeSpan ThuBreakStart
        {
            get;
            set;
        }
        public TimeSpan ThuBreakEnd
        {
            get;
            set;
        }
        public TimeSpan FriOpenHour
        {
            get;
            set;
        }
        public TimeSpan FriCloseHour
        {
            get;
            set;
        }
        public TimeSpan FriBreakStart
        {
            get;
            set;
        }
        public TimeSpan FriBreakEnd
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
        public int VendorBranchId {
            get;
            set;
		}
        public VendorBranch VendorBranch
        {
            get;
            set;
        }
    }
}
