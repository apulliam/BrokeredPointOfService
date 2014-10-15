using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    internal class BrokeredNetfxExceptionFactory
    {
        public static NetfxException CreateBrokeredException(Exception internalException)
        {
            NetfxException brokeredException = null;

            if (internalException is Microsoft.PointOfService.PosControlException)
                brokeredException = new BrokeredPosControlException((Microsoft.PointOfService.PosControlException)internalException);
            else if (internalException is Microsoft.PointOfService.PosLibraryException)
                brokeredException = new BrokeredPosLibraryException((Microsoft.PointOfService.PosLibraryException)internalException);
            else if (internalException is Microsoft.PointOfService.PosManagementException)
                brokeredException = new BrokeredPosManagementException((Microsoft.PointOfService.PosManagementException)internalException);

            else
                brokeredException = new BrokeredNetfxException(internalException);
            return brokeredException;
        }
    }
}
