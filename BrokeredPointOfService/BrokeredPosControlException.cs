using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    internal class BrokeredPosControlException : BrokeredNetfxException, PosControlException
    {
        internal Microsoft.PointOfService.PosControlException InternalPosControlException
        {
            get
            {
                return InternalException as Microsoft.PointOfService.PosControlException;
            }
        }

        internal BrokeredPosControlException(Microsoft.PointOfService.PosControlException posControlException) : base(posControlException)
        {
        }

        public ErrorCode ErrorCode
        {
            get 
            {
                return new ErrorCode(InternalPosControlException.ErrorCode);
            }
        }

        public int ErrorCodeExtended
        {
            get 
            {
                return InternalPosControlException.ErrorCodeExtended;
            }
        }

        public override string ToString()
        {
            return InternalPosControlException.ToString();
        }
    }
}
