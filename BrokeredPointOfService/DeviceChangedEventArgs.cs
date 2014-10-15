using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Defines the programmatic interface for the transmission of Device Added Events
    //     and Device Removed Events.
    public sealed class DeviceChangedEventArgs 
    {
        internal Microsoft.PointOfService.DeviceChangedEventArgs InternalDeviceChangedEventArgs { get; set; }

        internal DeviceChangedEventArgs(Microsoft.PointOfService.DeviceChangedEventArgs deviceChangedEventArgs)
        {
            InternalDeviceChangedEventArgs = deviceChangedEventArgs;
        }

        // Summary:
        //     Gets the DeviceInfo for an event.
        public DeviceInfo Device 
        {
            get
            {
                return new DeviceInfo(InternalDeviceChangedEventArgs.Device);
            }
        }
    }
}
