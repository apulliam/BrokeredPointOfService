using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible printer cartridge states.
    //     OK = 0     The cartridge in normal condition.
    //     Removed = 1    The cartridge has been removed.
    //     Empty = 2     The cartridge is empty.
    //     RemovedEmpty = 3
    //     NearEnd = 4     The cartridge is near its end.
    //     RemovedNearEnd = 5
    //     EmptyNearEnd = 6
    //     RemovedEmptyNearEnd = 7
    //     Cleaning = 8     The printer head is being cleaned.
    //     RemovedCleaning = 9
    //     EmptyCleaning = 10
    //     RemovedEmptyCleaning = 11
    //     NearEndCleaning = 12
    //     RemovedNearEndCleaning = 13
    //     EmptyNearEndCleaning = 14
    //     RemovedEmptyNearEndCleaning = 15
    //     Unknown = 268435456     Cannot determine the cartridge state.
    public sealed class PrinterCartridgeStates : Enumeration
    {
        internal Microsoft.PointOfService.PrinterCartridgeStates InternalPrinterCartridgeStates;

        internal PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates printerCartridgeStates)
        {
            InternalPrinterCartridgeStates = printerCartridgeStates;
        }

        // Summary:
        //     The cartridge in normal condition.
        public static PrinterCartridgeStates OK
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.OK);
            }
        }

        //
        // Summary:
        //     The cartridge has been removed.
        public static PrinterCartridgeStates Removed
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed);
            }
        }

        //
        // Summary:
        //     The cartridge is empty.
        public static PrinterCartridgeStates Empty
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Empty);
            }
        }

        // Summary:
        //     RemovedEmpty = 3
        public static PrinterCartridgeStates RemovedEmpty
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeStates.Empty);
            }
        }

        //
        // Summary:
        //     The cartridge is near its end.
        public static PrinterCartridgeStates NearEnd
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.NearEnd);
            }
        }

        // Summary:
        //     RemovedNearEnd = 5
        public static PrinterCartridgeStates RemovedNearEnd
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeStates.NearEnd);
            }
        }

        // Summary:
        //     EmptyNearEnd = 6
        public static PrinterCartridgeStates EmptyNearEnd
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeStates.NearEnd);
            }
        }

        // Summary:
        //     RemovedEmptyNearEnd = 7
        public static PrinterCartridgeStates RemovedEmptyNearEnd
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeStates.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeStates.NearEnd);
            }
        }

        //
        // Summary:
        //     The printer head is being cleaned.
        public static PrinterCartridgeStates Cleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }


        // Summary:
        //     RemovedCleaning = 9
        public static PrinterCartridgeStates RemoveCleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }

        // Summary:
        //     EmptyCleaning = 10
        public static PrinterCartridgeStates EmptyCleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }

        // Summary:
        //     RemovedEmptyCleaning = 11
        public static PrinterCartridgeStates RemovedEmptyCleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Empty |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }

        // Summary:
        //     NearEndCleaning = 12
        public static PrinterCartridgeStates NearEndCleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.NearEnd |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }

        // Summary:
        //     RemovedNearEndCleaning = 13
        public static PrinterCartridgeStates RemovedNearEndCleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.NearEnd |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }

        // Summary:
        //     EmptyNearEndCleaning = 14
        public static PrinterCartridgeStates EmptyNearEndCleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Empty |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.NearEnd |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }

        public static PrinterCartridgeStates RemovedEmptyNearEndCleaning
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Removed |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Empty |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.NearEnd |
                                                  Microsoft.PointOfService.PrinterCartridgeStates.Cleaning);
            }
        }
            
        //
        // Summary:
        //     Cannot determine the cartridge state.
        public static PrinterCartridgeStates Unknown
        {
            get
            {
                return new PrinterCartridgeStates(Microsoft.PointOfService.PrinterCartridgeStates.Unknown);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterCartridgeStates other = (PrinterCartridgeStates)obj;
            return this.InternalPrinterCartridgeStates.Equals(other.InternalPrinterCartridgeStates);
        }

        public override int GetHashCode()
        {
            return InternalPrinterCartridgeStates.GetHashCode();
        }
        
        public override string ToString()
        {
            return InternalPrinterCartridgeStates.ToString();
        }
        
        public int Value
        {
            get
            {
                return (int)InternalPrinterCartridgeStates;
            }
        }

    }
}
