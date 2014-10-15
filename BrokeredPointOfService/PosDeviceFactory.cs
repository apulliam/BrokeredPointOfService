using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    internal class PosDeviceFactory
    {
        public static PosDevice CreatedBrokeredPosDevice(Microsoft.PointOfService.PosExplorer posExplorer, Microsoft.PointOfService.DeviceInfo deviceInfo)
        {
            var internalPosDevice =posExplorer.CreateInstance(deviceInfo);
            //var internalPosDeviceType = internalPosDevice.GetType();
            if (internalPosDevice == null)
                return null;

            PosDevice brokeredPosDevice = null;

            if (internalPosDevice is Microsoft.PointOfService.Scanner)
                brokeredPosDevice = new BrokeredScanner((Microsoft.PointOfService.Scanner)internalPosDevice);
            else if (internalPosDevice  is Microsoft.PointOfService.Msr)
                brokeredPosDevice = new BrokeredMsr((Microsoft.PointOfService.Msr)internalPosDevice);
            else if (internalPosDevice is Microsoft.PointOfService.PosPrinter)
                brokeredPosDevice = new BrokeredPosPrinter((Microsoft.PointOfService.PosPrinter)internalPosDevice);

            // Fallback to BrokeredPosCommon/BrokeredPosDevice for POS device types that don't have brokered component wrapper implemented
            else if (internalPosDevice is Microsoft.PointOfService.PosCommon)
                brokeredPosDevice = new BrokeredPosCommon((Microsoft.PointOfService.PosCommon)internalPosDevice);
            else
                brokeredPosDevice = new BrokeredPosDevice(internalPosDevice);
            return brokeredPosDevice;
        }
    }
}
