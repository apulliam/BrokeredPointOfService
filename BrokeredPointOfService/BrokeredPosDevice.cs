using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    internal class BrokeredPosDevice : PosDevice
    {
        internal Microsoft.PointOfService.PosDevice InternalPosDevice { get; set; }

        internal BrokeredPosDevice(Microsoft.PointOfService.PosDevice posDevice)
        {
            InternalPosDevice = posDevice;
        }

        public DeviceCompatibilities Compatibility
        {
            get
            {
                return new DeviceCompatibilities(InternalPosDevice.Compatibility);
            }
        }

    }
}
