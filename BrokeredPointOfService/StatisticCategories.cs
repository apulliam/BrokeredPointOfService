using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Lists the possible categories of device statistics that can be retrieved,
    //     reset, or updated.
    public sealed class StatisticCategories : Enumeration
    {
        internal Microsoft.PointOfService.StatisticCategories InternalStatisticCategories { get; set; }

        private StatisticCategories(Microsoft.PointOfService.StatisticCategories statisticCategories)
        {
            this.InternalStatisticCategories = statisticCategories;
        }
        // Summary:
        //     Unified POS-defined statistics.
        public static StatisticCategories Upos
        {
            get
            {
                return new StatisticCategories(Microsoft.PointOfService.StatisticCategories.Upos);
            }
        }
        //
        // Summary:
        //     Manufacturer-defined statistics.
        public static StatisticCategories Manufacturer
        {
            get
            {
                return new StatisticCategories(Microsoft.PointOfService.StatisticCategories.Manufacturer);
            }
        }
        //
        // Summary:
        //     All available statistics for the device.
        public static StatisticCategories All
        {
            get
            {
                return new StatisticCategories(Microsoft.PointOfService.StatisticCategories.All);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            StatisticCategories other = (StatisticCategories)obj;
            return this.InternalStatisticCategories.Equals(other.InternalStatisticCategories);
        }

        public override int GetHashCode()
        {
            return InternalStatisticCategories.GetHashCode();
        }

        public override string ToString()
        {
            return InternalStatisticCategories.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalStatisticCategories;
            }
        }
    }
}
