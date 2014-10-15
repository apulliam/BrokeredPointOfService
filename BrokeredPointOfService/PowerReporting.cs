using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible power reporting capabilities of a device.
    public sealed class PowerReporting : Enumeration
    {
        internal Microsoft.PointOfService.PowerReporting InternalPowerReporting { get; set; }

        internal PowerReporting(Microsoft.PointOfService.PowerReporting powerReporting)
        {
        }

        // Summary:
        //     The service object cannot determine the state of the device. Therefore, no
        //     power reporting is possible.
        public static PowerReporting None
        {
            get
            {
                return new PowerReporting(Microsoft.PointOfService.PowerReporting.None);
            }
        }

        //
        // Summary:
        //     The service object can determine and report two of the power states, OffOffline
        //     (that is, Off or Offline) and Online.
        public static PowerReporting Standard
        {
            get
            {
                return new PowerReporting(Microsoft.PointOfService.PowerReporting.Standard);
            }
        }

        //
        // Summary:
        //     The service object can determine and report all three power states, Off,
        //     Offline, and Online.
        public static PowerReporting Advanced
        {
            get
            {
                return new PowerReporting(Microsoft.PointOfService.PowerReporting.Advanced);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PowerReporting other = (PowerReporting)obj;
            return this.InternalPowerReporting.Equals(other.InternalPowerReporting);
        }

        public override int GetHashCode()
        {
            return InternalPowerReporting.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPowerReporting.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPowerReporting;
            }
        }
    }
}
