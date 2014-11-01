// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace BrokeredPointOfService
{
    public interface Msr : PosCommon
    {
        // Summary:
        //     Holds the account number from the most recently swiped card.
        string AccountNumber { get; }
        byte[] AdditionalSecurityInformation { get; }
        //
        // Summary:
        //     Indicates whether POS for .NET automatically disables the device when data
        //     is received.
        bool AutoDisable { get; set; }
        string CapCardAuthentication { get; }
        EncryptionAlgorithm CapDataEncryption { get; }
        DeviceAuthenticationLevel CapDeviceAuthentication { get; }
        //
        // Summary:
        //     If true, the MSR device supports ISO cards; otherwise it is false.
        bool CapIso { get; }
        //
        // Summary:
        //     If true, the MSR device supports JIS Type-I cards; otherwise it is false.
        bool CapJisOne { get; }
        //
        // Summary:
        //     If true, the MSR device supports JIS Type-II cards; otherwise it is false.
        bool CapJisTwo { get; }
        bool CapTrackDataMasking { get; }
        //
        // Summary:
        //     If true, the MSR device can transmit start and end sentinels. If false, these
        //     characters cannot be returned to the application.
        bool CapTransmitSentinels { get; }
        MsrTracks CapWritableTracks { get; }
        byte[] CardAuthenticationData { get; }
        int CardAuthenticationDataLength { get; }
        string[] CardPropertyList { get; }
        string CardType { get; }
        string[] CardTypeList { get; }
        //
        // Summary:
        //     Holds the number of data events currently queued by the service object.
        int DataCount { get; }
        EncryptionAlgorithm DataEncryptionAlgorithm { get; set; }
        //
        // Summary:
        //     When set to true by the application, POS for .NET delivers the next event
        //     in the event queue.
        bool DataEventEnabled { get; set; }
        //
        // Summary:
        //     If false, the Microsoft.PointOfService.Msr.Track1Data, Microsoft.PointOfService.Msr.Track2Data,
        //     Microsoft.PointOfService.Msr.Track3Data, and Microsoft.PointOfService.Msr.Track4Data
        //     properties contain the original encoded bit sequence, known as “raw format.”
        bool DecodeData { get; set; }
        bool DeviceAuthenticated { get; }
        DeviceAuthenticationProtocol DeviceAuthenticationProtocol { get; }
        int EncodingMaxLength { get; }
        //
        // Summary:
        //     Holds the type of error reporting the application wants to receive. Possible
        //     values are defined by the Microsoft.PointOfService.MsrErrorReporting enumeration.
        MsrErrorReporting ErrorReportingType { get; set; }
        //
        // Summary:
        //     Holds the expiration date from the most recently swiped card, as four ASCII
        //     decimal characters in the form YYMM. For example, February 1998 is “9802”
        //     and August 2018 is “1808”.
        string ExpirationDate { get; }
        //
        // Summary:
        //     Holds the first name from the most recently swiped card.
        string FirstName { get; }
     
        //
        // Summary:
        //     Holds the middle initial from the most recently swiped card.
        string MiddleInitial { get; }
        //
        // Summary:
        //     If true, the decoded data contained within the Track1Data and Track2Data
        //     properties is further separated into fields for access via various other
        //     properties.
        bool ParseDecodeData { get; set; }
        //
        // Summary:
        //     Holds the service code from the most recently swiped card.
        string ServiceCode { get; }
        //
        // Summary:
        //     Holds the suffix from the most recently swiped card.
        string Suffix { get; }
        //
        // Summary:
        //     Holds the surname from the most recently swiped card.
        string Surname { get; }
        //
        // Summary:
        //     Holds the title from the most recently swiped card.
        string Title { get; }
        //
        // Summary:
        //     Holds either the Track 1 data from the most recently swiped card or an empty
        //     array.
        byte[] Track1Data { get; }
        //
        // Summary:
        //     Holds the Track 1 discretionary data from the most recently swiped card.
        byte[] Track1DiscretionaryData { get; }
        byte[] Track1EncryptedData { get; }
        int Track1EncryptedDataLength { get; }
        //
        // Summary:
        //     Holds either the Track 2 data from the most recently swiped card or an empty
        //     array.
        byte[] Track2Data { get; }
        //
        // Summary:
        //     The Track 2 discretionary data from the most recently swiped card.
        byte[] Track2DiscretionaryData { get; }
        byte[] Track2EncryptedData { get; }
        int Track2EncryptedDataLength { get; }
        //
        // Summary:
        //     Holds either the Track 3 data from the most recently swiped card or an empty
        //     array.
        byte[] Track3Data { get; }
        byte[] Track3EncryptedData { get; }
        int Track3EncryptedDataLength { get; }
        //
        // Summary:
        //     Holds the Track 4 data (JIS-II) from the most recently swiped card.
        byte[] Track4Data { get; }
        byte[] Track4EncryptedData { get; }
        int Track4EncryptedDataLength { get; }
        //
        // Summary:
        //     Indicates the track data that the application wishes to place into the Track1Data,
        //     Track2Data, Track3Data and Track4Data properties following a card swipe.
        MsrTracks TracksToRead { get; set; }
        //
        // Summary:
        //     Specifies which MSR tracks will be written when the Microsoft.PointOfService.Msr.WriteTracks(System.Byte[],System.Byte[],System.Byte[],System.Byte[],System.Int32)
        //     method is called and an MSR card swiped.
        MsrTracks TracksToWrite { get; set; }
        //
        // Summary:
        //     If true, the Track1Data, Track2Data, Track3Data, and Track4Data properties
        //     contain start sentinel and end sentinel values.
        bool TransmitSentinels { get; set; }
        string WriteCardType { get; set; }

        // Summary:
        //     Raised by the service object to indicate the delivery of input data from
        //     the device to the application.
        event TypedEventHandler<Msr, DataEventArgs> DataEvent;
        //
        // Summary:
        //     Raised by the service object when an error is detected while trying to read
        //     MSR data.
        event TypedEventHandler<Msr, DeviceErrorEventArgs> ErrorEvent;

        // Summary:
        //     Authenticates a device.
        //
        // Parameters:
        //   responseToken:
        //     A response token generated from the challenge token retrieved from a previous
        //     call to the Microsoft.PointOfService.Msr.RetrieveDeviceAuthenticationData()
        //     method.
        void AuthenticateDevice([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] responseToken);
        //
        // Summary:
        //     Clears all device input that has been buffered.
        void ClearInput();
        //
        // Summary:
        //     Resets the values of properties altered by Microsoft.PointOfService.Msr.DataEvent
        //     or Microsoft.PointOfService.Msr.ErrorEvent.
        void ClearInputProperties();
        //
        // Summary:
        //     Deauthenticates a device that is currently in the authenticated state
        //
        // Parameters:
        //   responseToken:
        //     A response token generated from the challenge token retrieved from a previous
        //     call to the Microsoft.PointOfService.Msr.RetrieveDeviceAuthenticationData()
        //     method.
        void DeauthenticateDevice([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] responseToken);
        //
        // Summary:
        //     Retrieves the value of specific parsed properties from the last card swiped.
        //
        // Parameters:
        //   name:
        //     Name of the property whose value is to be retrieved. The Microsoft.PointOfService.Msr.CardPropertyList
        //     property can be parsed to determine the set of valid properties for the most
        //     recently swiped card.
        string RetrieveCardProperty(string name);
        byte[] RetrieveDeviceAuthenticationData();
        //
        // Summary:
        //     Provides a new encryption key to the device.
        //
        // Parameters:
        //   keyName:
        //     A name used to identify the key.
        //
        //   key:
        //     A Hex-ASCII value for a new key.
        void UpdateKey(string key, string keyName);
        //
        // Summary:
        //     Initiates the encoding of data to the MSR track(s) selected in the Microsoft.PointOfService.Msr.TracksToWrite
        //     property.
        //
        // Parameters:
        //   track1Data:
        //     The first data track.
        //
        //   track3Data:
        //     The third data track.
        //
        //   timeout:
        //     The number of milliseconds before failing the method. If -1, the method waits
        //     as long as need before the card is swiped.
        //
        //   track2Data:
        //     The second data track.
        //
        //   track4Data:
        //     The fourth data track.
        IAsyncOperation<int> WriteTracks([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track1Data,
                         [System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track2Data,
                         [System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track3Data,
                         [System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track4Data,
                         int timeout);

    }
}
