using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Defines the programmatic interface used to create an array, or list, of device
    //     statistics.
    public sealed class Statistic
    {
        internal Microsoft.PointOfService.Statistic InternalStatistic { get; set; }

        internal Statistic(Microsoft.PointOfService.Statistic statistic)
        {
            InternalStatistic = statistic;
        }


        public string Name 
        { 
            get
            {
                return InternalStatistic.Name;
            }
        }
        public object Value 
        { 
            get
            {
                return InternalStatistic.Value;
            }
            set
            {
                InternalStatistic.Value = value;
            }
        }

        internal Microsoft.PointOfService.Statistic ToInternal()
        {
            return (Microsoft.PointOfService.Statistic)Enum.ToObject(typeof(Microsoft.PointOfService.Statistic), InternalStatistic.Value);
        }
    }
}
