using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    internal class BrokeredPosManagementException : BrokeredNetfxException, PosManagementException
    {
        internal BrokeredPosManagementException(Microsoft.PointOfService.PosManagementException posManagementException)
            : base(posManagementException)
        {
        }

        internal Microsoft.PointOfService.PosManagementException InternalPosManagementException
        {
            get
            {
                return InternalException as Microsoft.PointOfService.PosManagementException;
            }
        }

        public override string ToString()
        {
            return InternalPosManagementException.ToString();
        }
    }
}
