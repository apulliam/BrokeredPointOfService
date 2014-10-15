using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    public sealed class PowerState : Enumeration
    {
        internal Microsoft.PointOfService.PowerState InternalPowerState { get; set; }

        internal PowerState(Microsoft.PointOfService.PowerState powerState)
        {
            this.InternalPowerState = powerState;
        }

        // Summary:
        //     Cannot determine the device's power state.
        public static PowerState Unknown
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Unknown);
            }
        }

        //
        // Summary:
        //     The device is turned on and ready for use.
        public static PowerState Online
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Online);
            }
        }

        //
        // Summary:
        //     The device is turned off or detached from the terminal.
        public static PowerState Off
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Off);
            }
        }

        //
        // Summary:
        //     The device is turned on but is either not ready or unable to respond to requests.
        public static PowerState Offline
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Offline);
            }
        }

        //
        // Summary:
        //     The device is either turned off or offline.
        public static PowerState OffOffline
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.OffOffline);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) 
                return false;

            PowerState other = (PowerState)obj;
            return this.InternalPowerState.Equals(other.InternalPowerState);
        }

        public override int GetHashCode()
        {
            return InternalPowerState.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPowerState.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPowerState;
            }
        }
    }

}
