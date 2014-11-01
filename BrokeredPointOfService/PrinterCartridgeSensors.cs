// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{

    // Summary:
    //     Enumerates the possible printer-cartridge-monitoring sensors.
    //     
    // None = 0                 The device does not support cartridge-monitoring sensors.
    // Removed = 1              A sensor that indicates the cartridge has been removed.
    // Empty = 2                A sensor that indicates the cartridge is empty.
    // RemovedEmpty = 3
    // NearEnd = 4              A sensor that determines whether the color cartridge is near its end.
    // RemovedNearEnd = 5
    // EmptyNearEnd = 6
    // RemovedEmptyNearEnd = 7
    // Cleaning = 8             A sensor that indicates the head is being cleaned.
    // RemovedCleaning = 9
    // EmptyCleaning = 10
    // RemovedEmptyCleaning = 11
    // NearEndCleaning = 12
    // RemovedNearEndCleaning = 13
    // EmptyNearEndCleaning = 14
    // RemovedEmptyNearEndCleaning = 15

    public sealed class PrinterCartridgeSensors : Enumeration
    {
        internal Microsoft.PointOfService.PrinterCartridgeSensors InternalPrinterCartridgeSensors;

        internal PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors printerCartridgeSensors)
        {
            InternalPrinterCartridgeSensors = printerCartridgeSensors;
        }

        // Summary:
        //     The device does not support cartridge-monitoring sensors.
        public static PrinterCartridgeSensors None
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.None);
            }
        }

        //
        // Summary:
        //     A sensor that indicates the cartridge has been removed.
        //     Removed = 1           
        public static PrinterCartridgeSensors Removed
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed);
            }
        }


        //
        // Summary:
        //     A sensor that indicates the cartridge is empty.
        //     Empty = 2
        public static PrinterCartridgeSensors Empty
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Empty);
            }
        }

        // Summary:
        //     RemovedEmpty = 3
        public static PrinterCartridgeSensors RemovedEmpty
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Empty);
            }
        }

        //
        // Summary:
        //     A sensor that determines whether the color cartridge is near its end.
        //     NearEnd = 4 
        public static PrinterCartridgeSensors NearEnd
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd);
            }
        }

        // Summary:
        //     RemovedNearEnd = 5
        public static PrinterCartridgeSensors RemovedNearEnd
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed | 
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd);
            }
        }

        // Summary:
        //     EmptyNearEnd = 6
        public static PrinterCartridgeSensors EmptyNearEnd
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd);
            }
        }

        // Summary:
        //     RemovedEmptyNearEnd = 7
        public static PrinterCartridgeSensors RemovedEmptyNearEnd
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd);
            }
        }

        //
        // Summary:
        //     A sensor that indicates the head is being cleaned.
        //     Cleaning = 8
        public static PrinterCartridgeSensors Cleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }

        // Summary:
        //     RemovedCleaning = 9
        public static PrinterCartridgeSensors RemoveCleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }

        // Summary:
        //     EmptyCleaning = 10
        public static PrinterCartridgeSensors EmptyCleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }

        // Summary:
        //     RemovedEmptyCleaning = 11
        public static PrinterCartridgeSensors RemovedEmptyCleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }

        // Summary:
        //     NearEndCleaning = 12
        public static PrinterCartridgeSensors NearEndCleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }

        // Summary:
        //     RemovedNearEndCleaning = 13
        public static PrinterCartridgeSensors RemovedNearEndCleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }

        // Summary:
        //     EmptyNearEndCleaning = 14
        public static PrinterCartridgeSensors EmptyNearEndCleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Empty |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }

        // Summary:
        //     RemovedEmptyNearEndCleaning = 15
        public static PrinterCartridgeSensors RemovedEmptyNearEndCleaning
        {
            get
            {
                return new PrinterCartridgeSensors(Microsoft.PointOfService.PrinterCartridgeSensors.Removed |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Empty | 
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.NearEnd |
                                                   Microsoft.PointOfService.PrinterCartridgeSensors.Cleaning);
            }
        }


       

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterCartridgeSensors other = (PrinterCartridgeSensors)obj;
            return this.InternalPrinterCartridgeSensors.Equals(other.InternalPrinterCartridgeSensors);
        }

        public override int GetHashCode()
        {
            return InternalPrinterCartridgeSensors.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrinterCartridgeSensors.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterCartridgeSensors;
            }
        }

    }
}
