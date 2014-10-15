using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Defines the base class for POS for .NET classes containing event data.
    public interface PosEventArgs 
    {
        // Summary:
        //     Gets the event identifier.
        int EventId  { get; }
        
        //
        // Summary:
        //     Gets the DateTime of the event.
        DateTimeOffset TimeStamp  { get; }
    
    }
}
