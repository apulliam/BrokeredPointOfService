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
using Windows.Foundation;

namespace BrokeredPointOfService
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public interface Scanner : PosCommon
    {
        // Summary:
        //     Get or sets a Boolean value whether POS for .NET automatically disables the
        //     Scanner after data is received.
        bool AutoDisable { get; set; }
        //
        // Summary:
        //     Gets the number of data events currently queued by the Service Object.
        int DataCount { get; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether POS for .NET can deliver
        //     the next queued event.
        bool DataEventEnabled { get; set; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether the data can be decoded.
        bool DecodeData { get; set; }

        //
        // Summary:
        //     Gets a byte array of the data that is read from the scanner.
        byte[] ScanData { get; }
        //
        // Summary:
        //     Gets the decoded bar code label.
        byte[] ScanDataLabel { get; }
        //
        // Summary:
        //     Gets the decoded bar code label type. Possible values are defined by the
        //     BarCodeSymbology enumeration.
        BarCodeSymbology ScanDataType { get; }

        // Summary:
        //     Raised by the Service Object to present scanned data from the device to the
        //     application.
        event TypedEventHandler<Scanner, DataEventArgs> DataEvent;
        //
        // Summary:
        //     Raised by the Service Object to notify the application that an error has
        //     been detected while attempting to read scanned data.
        event TypedEventHandler<Scanner, DeviceErrorEventArgs> ErrorEvent;

        // Summary:
        //     Clears all device input that has been buffered.
        void ClearInput();
        //
        // Summary:
        //     Resets the values of properties altered by Microsoft.PointOfService.Scanner.DataEvent
        //     or Microsoft.PointOfService.Scanner.ErrorEvent.
        void ClearInputProperties();
    }
}
