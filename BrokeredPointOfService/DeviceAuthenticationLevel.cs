using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the level of device authentication supported by the service.
    public sealed class DeviceAuthenticationLevel : Enumeration
    {
        internal Microsoft.PointOfService.DeviceAuthenticationLevel InternalDeviceAuthenticationLevel { get; set; }

        internal DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel deviceAuthenticationLevel)
        {
            this.InternalDeviceAuthenticationLevel = deviceAuthenticationLevel;
        }

        // Summary:
        //     The service does not support device authentication.
        public static DeviceAuthenticationLevel NotSupported
        {
            get
            {
                return new DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel.NotSupported);
            }
        }
        
        //
        // Summary:
        //     The service supports device authentication, but does not require it.
        public static DeviceAuthenticationLevel Optional
        {
            get
            {
                return new DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel.Optional);
            }
        }

        //
        // Summary:
        //     The service requires device authentication.
        public static DeviceAuthenticationLevel Required
        {
            get
            {
                return new DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel.Required);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) 
                return false;

            DeviceAuthenticationLevel other = (DeviceAuthenticationLevel)obj;
            return this.InternalDeviceAuthenticationLevel.Equals(other.InternalDeviceAuthenticationLevel);
        }

        public override int GetHashCode()
        {
            return InternalDeviceAuthenticationLevel.GetHashCode();
        }

        public override string ToString()
        {
            return InternalDeviceAuthenticationLevel.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalDeviceAuthenticationLevel;
            }
        }
    }
}
