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
    internal class BrokeredMsr : BrokeredPosCommon, Msr, IDisposable
    {
        // Summary:
        //     Indicates the card type is AAMVA.
        internal const string CardTypeAamva = "AAMVA";
        //
        // Summary:
        //     Indicates the card type is BANK.
        internal const string CardTypeBank = "BANK";
        //
        // Summary:
        //     Indicates an extended error where the device authentication process failed.
        internal const int ExtendedErrorDeviceAuthenticationFailed = 205;
        //
        // Summary:
        //     Indicates an extended error where the device deauthentication failed.
        internal const int ExtendedErrorDeviceDeauthenticationFailed = 206;
        //
        // Summary:
        //     Indicates an end sentinel error.
        internal const int ExtendedErrorEnd = 202;
        //
        // Summary:
        //     Indicates a general error.
        internal const int ExtendedErrorFailure = 111;
        //
        // Summary:
        //     Indicates an LRC error.
        internal const int ExtendedErrorLrc = 204;
        //
        // Summary:
        //     Indicates a parity error.
        internal const int ExtendedErrorParity = 203;
        //
        // Summary:
        //     Indicates a start sentinel error.
        internal const int ExtendedErrorStart = 201;
        //
        // Summary:
        //     Indicates no error.
        internal const int ExtendedErrorSuccess = 0;
        //
        // Summary:
        //     Contains the count of challenge requests.
        internal const string StatisticChallengeRequestCount = "ChallengeRequestCount";
        //
        // Summary:
        //     Contains the count of failed card authentication attempts.
        internal const string StatisticFailedCardAuthenticationDataCount = "FailedCardAuthenticationDataCount";
        //
        // Summary:
        //     Contains the count of failed device authentication attempts.
        internal const string StatisticFailedDeviceAuthenticationCount = "FailedDeviceAuthenticationCount";
        //
        // Summary:
        //     This is field contains the node name used in the POS.NET XML statistics file.
        //     The number of failed card reads is stored in this node.
        internal const string StatisticFailedReadCount = "FailedReadCount";
        //
        // Summary:
        //     This is field contains a node name used in the POS.NET XML statistics file.
        //     The number of failed card writes is stored in this node.
        internal const string StatisticFailedWriteCount = "FailedWriteCount";
        //
        // Summary:
        //     Contains the count of successful card authentication attempts.
        internal const string StatisticGoodCardAuthenticationDataCount = "GoodCardAuthenticationDataCount";
        //
        // Summary:
        //     Contains the count of successful device authentication attempts.
        internal const string StatisticGoodDeviceAuthenticationCount = "GoodDeviceAuthenticationCount";
        //
        // Summary:
        //     This is field contains the node name used in the POS.NET XML statistics file.
        //     The number of successful card reads is stored in this node.
        internal const string StatisticGoodReadCount = "GoodReadCount";
        //
        // Summary:
        //     This is field contains a node name used in the POS.NET XML statistics file.
        //     The number of successful card writes is stored in this node.
        internal const string StatisticGoodWriteCount = "GoodWriteCount";
        //
        // Summary:
        //     This is field contains a node name used in the POS.NET XML statistics file.
        //     The number of times the track 1 sentinel was found missing is stored in this
        //     node.
        internal const string StatisticMissingStartSentinelTrack1Count = "MissingStartSentinelTrack1Count";
        //
        // Summary:
        //     This is field contains a node name used in the POS.NET XML statistics file.
        //     The number of times the track 2 sentinel was found missing is stored in this
        //     node.
        internal const string StatisticMissingStartSentinelTrack2Count = "MissingStartSentinelTrack2Count";
        //
        // Summary:
        //     This is field contains a node name used in the POS.NET XML statistics file.
        //     The number of times the track 3 sentinel was found missing is stored in this
        //     node.
        internal const string StatisticMissingStartSentinelTrack3Count = "MissingStartSentinelTrack3Count";
        //
        // Summary:
        //     This is field contains a node name used in the POS.NET XML statistics file.
        //     The number of times the track 4 sentinel was found missing is stored in this
        //     node.
        internal const string StatisticMissingStartSentinelTrack4Count = "MissingStartSentinelTrack4Count";
        //
        // Summary:
        //     This is field contains the node name used in the POS.NET XML statistics file.
        //     The number of parity errors for track 1 is stored in this node.
        internal const string StatisticParityLrcErrorTrack1Count = "ParityLRCErrorTrack1Count";
        //
        // Summary:
        //     This is field contains the node name used in the POS.NET XML statistics file.
        //     The number of parity errors for track 2 is stored in this node.
        internal const string StatisticParityLrcErrorTrack2Count = "ParityLRCErrorTrack2Count";
        //
        // Summary:
        //     This is field contains the node name used in the POS.NET XML statistics file.
        //     The number of parity errors for track 3 is stored in this node.
        internal const string StatisticParityLrcErrorTrack3Count = "ParityLRCErrorTrack3Count";
        //
        // Summary:
        //     This is field contains the node name used in the POS.NET XML statistics file.
        //     The number of parity errors for track 4 is stored in this node.
        internal const string StatisticParityLrcErrorTrack4Count = "ParityLRCErrorTrack4Count";
        //
        // Summary:
        //     This is field contains the node name used in the POS.NET XML statistics file.
        //     The number of failed card reads is stored in this node.
        internal const string StatisticUnreadableCardCount = "UnreadableCardCount";
        //
        // Summary:
        //     Indicates if the device is authenticated.
        internal const int StatusDeviceAuthenticated = 11;
        //
        // Summary:
        //     Indicates if the device is deauthenticated.
        internal const int StatusDeviceDeauthenticated = 12;

        internal Microsoft.PointOfService.Msr InternalMsr 
        {
            get
            {
                return (Microsoft.PointOfService.Msr)InternalPosDevice;
            }
        }

        internal BrokeredMsr(Microsoft.PointOfService.Msr msr) : base(msr)
        {
            InternalMsr.DataEvent += InternalMsr_DataEvent;
            InternalMsr.ErrorEvent += InternalMsr_ErrorEvent;
        }

        void InternalMsr_ErrorEvent(object sender, Microsoft.PointOfService.DeviceErrorEventArgs e)
        {
            if (ErrorEvent != null)
                ErrorEvent(this, new DeviceErrorEventArgs(e));
        }

        void InternalMsr_DataEvent(object sender, Microsoft.PointOfService.DataEventArgs e)
        {
            if (DataEvent != null)
                DataEvent(this, new DataEventArgs(e));
        }

        public string AccountNumber
        {
            get 
            { 
                return InternalMsr.AccountNumber; 
            }
        }

        public byte[] AdditionalSecurityInformation
        {
            get 
            { 
                return InternalMsr.AdditionalSecurityInformation; 
            }
        }

        public bool AutoDisable
        {
            get
            {
                return InternalMsr.AutoDisable;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.AutoDisable = value;
                    });
            }
        }

        public string CapCardAuthentication
        {
            get 
            { 
                return InternalMsr.CapCardAuthentication; 
            }
        }

        public EncryptionAlgorithm CapDataEncryption
        {
            get 
            {
                return new EncryptionAlgorithm(InternalMsr.CapDataEncryption);
            }
        }

        public DeviceAuthenticationLevel CapDeviceAuthentication
        {
            get 
            {
                return new DeviceAuthenticationLevel(InternalMsr.CapDeviceAuthentication);
            }
        }

        public bool CapIso
        {
            get 
            {
                return InternalMsr.CapIso;
            }
        }

        public bool CapJisOne
        {
            get 
            {
                return InternalMsr.CapJisOne;
            }
        }

        public bool CapJisTwo
        {
            get
            {
                return InternalMsr.CapJisTwo;
            }
        }

        public bool CapTrackDataMasking
        {
            get 
            {
                return InternalMsr.CapTrackDataMasking; 
            }
        }

        public bool CapTransmitSentinels
        {
            get 
            {
                return InternalMsr.CapTransmitSentinels;
            }
        }

        public MsrTracks CapWritableTracks
        {
            get 
            {
                return new MsrTracks(InternalMsr.CapWritableTracks);
            }
        }

        public byte[] CardAuthenticationData
        {
            get 
            {
                return InternalMsr.CardAuthenticationData;
            }
        }

        public int CardAuthenticationDataLength
        {
            get 
            {
                return InternalMsr.CardAuthenticationDataLength;
            }
        }

        public string[] CardPropertyList
        {
            get
            {
                return InternalMsr.CardPropertyList.ToArray();
            }
        }

        public string CardType
        {
            get 
            {
                return InternalMsr.CardType;
            }
        }

        public string[] CardTypeList
        {
            get 
            {
                return InternalMsr.CardTypeList.ToArray(); 
            }
        }

        public int DataCount
        {
            get
            {
                return InternalMsr.DataCount;
            }
        }

        public EncryptionAlgorithm DataEncryptionAlgorithm
        {
            get
            {
                return new EncryptionAlgorithm(InternalMsr.DataEncryptionAlgorithm);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.DataEncryptionAlgorithm = value.InternalEncryptionAlgorithm;
                    });
            }
        }

        public bool DataEventEnabled
        {
            get
            {
                return InternalMsr.DataEventEnabled;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.DataEventEnabled = value;
                    });
            }
        }

        public bool DecodeData
        {
            get
            {
                return InternalMsr.DecodeData;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.DecodeData = value;
                    });
            }
        }

        public bool DeviceAuthenticated
        {
            get 
            {
                return InternalMsr.DeviceAuthenticated; 
            }
        }

        public DeviceAuthenticationProtocol DeviceAuthenticationProtocol
        {
            get 
            {
                return new DeviceAuthenticationProtocol(InternalMsr.DeviceAuthenticationProtocol);
            }
        }

        public int EncodingMaxLength
        {
            get 
            {
                return InternalMsr.EncodingMaxLength; 
            }
        }

        public MsrErrorReporting ErrorReportingType
        {
            get
            {
                return new MsrErrorReporting(InternalMsr.ErrorReportingType);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.ErrorReportingType = value.InternalMsrErrorReporting;
                    });
            }
        }

        public string ExpirationDate
        {
            get 
            { 
                return InternalMsr.ExpirationDate; 
            }
        }

        public string FirstName
        {
            get 
            {
                return InternalMsr.FirstName;
            }
        }

        public string MiddleInitial
        {
            get 
            {
                return InternalMsr.MiddleInitial; 
            }
        }

        public bool ParseDecodeData
        {
            get
            {
                return InternalMsr.ParseDecodeData;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.ParseDecodeData = value;
                    });
            }
        }

        public string ServiceCode
        {
            get 
            {
                return InternalMsr.ServiceCode; 
            }
        }

        public string Suffix
        {
            get 
            {
                return InternalMsr.Suffix; 
            }
        }

        public string Surname
        {
            get 
            {
                return InternalMsr.Surname; 
            }
        }

        public string Title
        {
            get 
            {
                return InternalMsr.Title;
            }
        }

        public byte[] Track1Data
        {
            get 
            { 
                return InternalMsr.Track1Data; 
            }
        }

        public byte[] Track1DiscretionaryData
        {
            get 
            {
                return InternalMsr.Track1DiscretionaryData;
            }
        }

        public byte[] Track1EncryptedData
        {
            get 
            {
                return InternalMsr.Track1EncryptedData;
            }
        }

        public int Track1EncryptedDataLength
        {
            get 
            {
                return InternalMsr.Track1EncryptedDataLength;     
            }
        }

        public byte[] Track2Data
        {
            get 
            {
                return InternalMsr.Track2Data;    
            }
        }

        public byte[] Track2DiscretionaryData
        {
            get 
            {
                return InternalMsr.Track2DiscretionaryData;    
            }
        }

        public byte[] Track2EncryptedData
        {
            get 
            {
                return InternalMsr.Track2EncryptedData;
            }
        }

        public int Track2EncryptedDataLength
        {
            get 
            {
                return InternalMsr.Track2EncryptedDataLength;    
            }
        }

        public byte[] Track3Data
        {
            get 
            {
                return InternalMsr.Track3Data;
            }
        }

        public byte[] Track3EncryptedData
        {
            get 
            {
                return InternalMsr.Track3EncryptedData;
            }
        }

        public int Track3EncryptedDataLength
        {
            get 
            {
                return InternalMsr.Track3EncryptedDataLength;
            }
        }

        public byte[] Track4Data
        {
            get 
            {
                return InternalMsr.Track4Data;
            }
        }

        public byte[] Track4EncryptedData
        {
            get 
            { 
                return InternalMsr.Track4EncryptedData;
            }
        }

        public int Track4EncryptedDataLength
        {
            get 
            {
                return InternalMsr.Track4EncryptedDataLength;
            }
        }

        public MsrTracks TracksToRead
        {
            get
            {
                return new MsrTracks(InternalMsr.TracksToRead);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.TracksToRead = value.InternalMsrTracks;
                    });
            }
        }

        public MsrTracks TracksToWrite
        {
            get
            {
                return new MsrTracks(InternalMsr.TracksToWrite);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.TracksToWrite = value.InternalMsrTracks;
                    });
            }
        }

        public bool TransmitSentinels
        {
            get
            {
                return InternalMsr.TransmitSentinels;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.TransmitSentinels = value;
                    });
            }
        }

        public string WriteCardType
        {
            get
            {
                return InternalMsr.WriteCardType;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalMsr.WriteCardType = value;
                    });
            }
        }

        public event Windows.Foundation.TypedEventHandler<Msr, DataEventArgs> DataEvent;

        public event Windows.Foundation.TypedEventHandler<Msr, DeviceErrorEventArgs> ErrorEvent;

        public void AuthenticateDevice([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] responseToken)
        {
            ExecuteAction(() =>
                {
                    InternalMsr.AuthenticateDevice(responseToken);
                });
        }

        public void ClearInput()
        {
            ExecuteAction(() =>
                {
                    InternalMsr.ClearInput();
                });
        }

        public void ClearInputProperties()
        {
            ExecuteAction(() =>
                {
                    InternalMsr.ClearInputProperties();
                });
        }

        public void DeauthenticateDevice([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] responseToken)
        {
            ExecuteAction(() =>
                {
                    InternalMsr.DeauthenticateDevice(responseToken);
                });
        }

        public string RetrieveCardProperty(string name)
        {
            return ExecuteFunction(() =>
                {
                    return InternalMsr.RetrieveCardProperty(name);
                });
        }

        public byte[] RetrieveDeviceAuthenticationData()
        {
            return ExecuteFunction(() =>
                {
                    return InternalMsr.RetrieveDeviceAuthenticationData();
                });
        }

        public void UpdateKey(string key, string keyName)
        {
            ExecuteAction(() =>
                {
                    InternalMsr.UpdateKey(key, keyName);
                });
        }

        public IAsyncOperation<int> WriteTracks([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track1Data,
                         [System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track2Data,
                         [System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track3Data,
                         [System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] byte[] track4Data,
            int timeout)
        {
            return Task.Run(() =>
            {
                return ExecuteFunction(() =>
                    {
                        InternalMsr.WriteTracks(track1Data, track2Data, track3Data, track4Data, timeout);
                        return 0;
                    });
            }).AsAsyncOperation<int>();
        }


        void IDisposable.Dispose()
        {
            InternalMsr.DataEvent -= InternalMsr_DataEvent;
            InternalMsr.ErrorEvent -= InternalMsr_ErrorEvent;
        }
    }
}
