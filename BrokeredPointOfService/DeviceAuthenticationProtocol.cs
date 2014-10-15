using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the device authentication protocol supported by the device.
    public sealed class DeviceAuthenticationProtocol : Enumeration
    {
        internal Microsoft.PointOfService.DeviceAuthenticationProtocol InternalDeviceAuthenticationProtocol { get; set; }

        internal DeviceAuthenticationProtocol(Microsoft.PointOfService.DeviceAuthenticationProtocol deviceAuthenticationProtocol)
        {
            this.InternalDeviceAuthenticationProtocol = deviceAuthenticationProtocol;
        }

        // Summary:
        //     The service does not support device authentication.
        public static DeviceAuthenticationProtocol None
        {
            get
            {
                return new DeviceAuthenticationProtocol(Microsoft.PointOfService.DeviceAuthenticationProtocol.None);
            }
        }

        //
        // Summary:
        //     The service supports the challenge response protocol.
        public static DeviceAuthenticationProtocol ChallengeResponse
        {
            get
            {
                return new DeviceAuthenticationProtocol(Microsoft.PointOfService.DeviceAuthenticationProtocol.ChallengeResponse);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) 
                return false;

            DeviceAuthenticationProtocol other = (DeviceAuthenticationProtocol)obj;
            return this.InternalDeviceAuthenticationProtocol.Equals(other.InternalDeviceAuthenticationProtocol);
        }

        public override int GetHashCode()
        {
            return InternalDeviceAuthenticationProtocol.GetHashCode();
        }

        public override string ToString()
        {
            return InternalDeviceAuthenticationProtocol.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalDeviceAuthenticationProtocol;
            }
        }
    }
}
