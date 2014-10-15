using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    public interface PosControlException : PosException
    {

        // Summary:
        //     Gets the Microsoft.PointOfService.ErrorCode value for this exception.
        ErrorCode ErrorCode { get; }
        //
        // Summary:
        //     Gets the extended error code for this exception
        int ErrorCodeExtended { get; }

    }
}
