using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    internal class BrokeredPosLibraryException : BrokeredNetfxException, PosLibraryException
    {
        internal BrokeredPosLibraryException(Microsoft.PointOfService.PosLibraryException posLibraryException) : base(posLibraryException)
        {
        }

        internal Microsoft.PointOfService.PosLibraryException InternalPosLibraryException
        {
            get
            {
                return InternalException as Microsoft.PointOfService.PosLibraryException;
            }
        }

        public override string ToString()
        {
            return InternalPosLibraryException.ToString();
        }
    }
}
