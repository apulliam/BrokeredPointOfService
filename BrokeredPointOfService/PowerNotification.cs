using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{    
    // Summary:
    //     Enumerates the possible states of power notification for the current device.
    public sealed class PowerNotification : Enumeration
    {
        internal Microsoft.PointOfService.PowerNotification InternalPowerNotification { get; set; }

        internal PowerNotification(Microsoft.PointOfService.PowerNotification powerNotification)
        {
            this.InternalPowerNotification = powerNotification;
        }

        // Summary:
        //     The service object will not provide power notifications to the application.
        //     No power notification StatusUpdateEvent events will be raised, and the PowerState
        //     property may not be set.
        public static PowerNotification Disabled
        {
            get
            {
                return new PowerNotification(Microsoft.PointOfService.PowerNotification.Disabled);
            }
        }

        //
        // Summary:
        //     The service object will raise power notification StatusUpdateEvent events
        //     and update the PowerState property, beginning when the DeviceEnabled property
        //     is set to true. The level of functionality available depends on the value
        //     of the CapPowerReporting property.
        public static PowerNotification Enabled
        {
            get
            {
                return new PowerNotification(Microsoft.PointOfService.PowerNotification.Enabled);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PowerNotification other = (PowerNotification)obj;
            return this.InternalPowerNotification.Equals(other.InternalPowerNotification);
        }

        public override int GetHashCode()
        {
            return InternalPowerNotification.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPowerNotification.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPowerNotification;
            }
        }
    }
}
