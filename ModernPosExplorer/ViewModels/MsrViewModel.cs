using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using ModernPosExplorer.Common;
using ModernPosExplorer.Views;
using BrokeredPointOfService;

namespace ModernPosExplorer.ViewModels
{
    public class MsrViewModel : ViewModelBase
    {
        private DeviceViewModel DeviceViewModel { get; set; }

        private  bool encryptionIsSupported  = false;
        private Msr Msr 
        {
            get
            {
                return DeviceViewModel.PosCommon as Msr;
            }
        }

        public bool AutoDisable 
        { 
            get
            {
                return Msr.AutoDisable;
            }
            set
            {
                try
                {
                    Msr.AutoDisable = value;
                    RaisePropertyChanged("AutoDisable");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Msr.LastException.ToString();
                }
            }
        }

        public bool DataEnabled
        {
            get
            {
                return Msr.DataEventEnabled;
            }
            set
            {
                try
                {
                    Msr.DataEventEnabled = value;
                    RaisePropertyChanged("DataEnabled");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Msr.LastException.ToString();
                }
            }
        }

        public bool DecodeData
        {
            get
            {
                return Msr.DecodeData;
            }
            set
            {
                try
                {
                    Msr.DecodeData = value;
                    RaisePropertyChanged("DecodeData");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Msr.LastException.ToString();
                }
            }
        }

        public bool ParseDecodeData
        {
            get
            {
                return Msr.ParseDecodeData;
            }
            set
            {
                try
                {
                    Msr.ParseDecodeData = value;
                    RaisePropertyChanged("ParseDecodeData");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Msr.LastException.ToString();
                }
            }
        }

        public bool TransmitSentinels
        {
            get
            {
                return Msr.TransmitSentinels;
            }
            set
            {
                try
                {
                    Msr.TransmitSentinels = value;
                    RaisePropertyChanged("TransmitSentinels");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Msr.LastException.ToString();
                }
            }
        }

        public MsrTracks TracksToRead
        {
            get
            {
                return Msr.TracksToRead;
            }
            set
            {
                try
                {
                    Msr.TracksToRead = value;
                    RaisePropertyChanged("TracksToRead");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Msr.LastException.ToString();
                }
            }
        }

        public string ErrorReportingType
        {
            get
            {
                return Msr.ErrorReportingType.ToString();
            }
            //set
            //{
            //    try
            //    {
            //        Msr.ErrorReportingType = value;
            //        RaisePropertyChanged("ErrorReportingType"); 
            //    }
            //    catch (Exception ex)
            //    {
            //        DeviceViewModel.ErrorOutput = Msr.LastException.ToString();
            //    }
            //}
        }

        public string CardType
        {
            get
            {
                return Msr.CardType;
 
            }
        }

        public string Track1Data
        {
            get
            {
                return GetString(Msr.Track1Data, false);
            }
        }

        public string Track2Data
        {
            get
            {
                return GetString(Msr.Track2Data, false);
            }
        }

        public string Track3Data
        {
            get
            {
                return GetString(Msr.Track3Data, false);
            }
        }

        public string Track4Data
        {
            get
            {
                return GetString(Msr.Track4Data, false);
            }
        }

        public string EncryptionCapabilities
        {
            get
            {
                return Msr.CapDataEncryption.ToString();
            }
        }

        public string AdditionalSecurityInformation
        {
            get
            {
                return GetString(Msr.AdditionalSecurityInformation, true);
            }
        }

        public string AuthenticationCapabilities
        {
            get
            {
                return Msr.CapCardAuthentication.ToString();
            }
        }

        public string AuthenticationData
        {
            get
            {
                return GetString(Msr.CardAuthenticationData, true);
            }
        }

        public string Track1EncryptedData
        {
            get
            {
                if (!encryptionIsSupported)
                    return null;    
                return GetString(Msr.Track1EncryptedData, false);
            }
        }

        public string Track2EncryptedData
        {
            get
            {
                if (!encryptionIsSupported)
                    return null;
                return GetString(Msr.Track2EncryptedData, false);
            }
        }

        public string Track3EncryptedData
        {
            get
            {
                if (!encryptionIsSupported)
                    return null;
                return GetString(Msr.Track3EncryptedData, false);
            }
        }

        public string Track4EncryptedData
        {
            get
            {
                if (!encryptionIsSupported)
                    return null;
                return GetString(Msr.Track4EncryptedData, false);
            }
        }

        public string Track1DiscretionaryData
        {
            get
            {
                return GetString(Msr.Track1DiscretionaryData, false);
            }
        }

        public string Track2DiscretionaryData
        {
            get
            {
                return GetString(Msr.Track2DiscretionaryData, false);
            }
        }

      

        public string AccountNumber
        {
            get
            {
                return Msr.AccountNumber;
            }
        }

        public string ExpirationDate
        {
            get
            {
                return Msr.ExpirationDate;
            }
        }

        public string Title
        {
            get
            {
                return Msr.Title;
            }
        }

        public string FirstName
        {
            get
            {
                return Msr.FirstName;
            }
        }

        public string MiddleInitial
        {
            get
            {
                return Msr.MiddleInitial;
            }
        }

        public string Surname
        {
            get
            {
                return Msr.Surname;
            }
        }
 
        public string ServiceCode
        {
            get
            {
                return Msr.ServiceCode;
            }
        }

        public string Suffix
        {
            get
            {
                return Msr.Suffix;
            }
        }

        public string[] CardPropertiesNames
        {
            get
            {
                return Msr.CardPropertyList;
            }
        }

        public string[] CardPropertiesValues
        {
            get
            {
                var cardPropertyValues = new List<string>();

                foreach (string property in Msr.CardPropertyList)
                {
                    string value = "";
                    try
                    {
                        value = Msr.RetrieveCardProperty(property);
                    }
                    catch (Exception ex)
                    {
                        value = "error";
                    }
                    cardPropertyValues.Add(value);
                }
                return cardPropertyValues.ToArray();
            }
        }
    
        public void LoadData(DeviceViewModel deviceViewModel)
        {
            this.DeviceViewModel = deviceViewModel;
            Msr.DataEvent += Msr_DataEvent;
            Msr.ErrorEvent += Msr_ErrorEvent;
        }

        async void Msr_ErrorEvent(object sender, DeviceErrorEventArgs e)
        {
            var coreWindowDispatcher = CoreApplication.MainView.CoreWindow.Dispatcher;
            await coreWindowDispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                DeviceViewModel.ErrorOutput = e.ToString();
            }).AsTask();
        }

        async void Msr_DataEvent(object sender, DataEventArgs e)
        {
            var coreWindowDispatcher = CoreApplication.MainView.CoreWindow.Dispatcher;
            await coreWindowDispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                UpdateSettings();
                DeviceViewModel.UpdateSettings();
            }).AsTask();
        }

        public void UpdateSettings()
        {
            var encryptionIsSupported = false;
            RaisePropertyChanged("DataEnabled");
            RaisePropertyChanged("EncryptionCapabilities");
            RaisePropertyChanged("AuthenticationCapabilities");

            // fire property changed event(s) to requery state from PosCommon
            if (Msr.ServiceObjectVersion.Major >= 1 && Msr.ServiceObjectVersion.Minor >= 12)
            {
                encryptionIsSupported = (Msr.CapDataEncryption != EncryptionAlgorithm.None);

                RaisePropertyChanged("CardType");
            }
            
            RaisePropertyChanged("Track1Data");
            RaisePropertyChanged("Track1DiscretionaryData");
            RaisePropertyChanged("Track2Data");
            RaisePropertyChanged("Track2DiscretionaryData");
            RaisePropertyChanged("Track3Data");
            RaisePropertyChanged("Track4Data");

            if (encryptionIsSupported)
            {
                RaisePropertyChanged("Track1EncrypedData");
                RaisePropertyChanged("Track2EncrypedData");
                RaisePropertyChanged("Track3EncrypedData");
                RaisePropertyChanged("Track4EncrypedData");
            }


            if (Msr.ServiceObjectVersion.Major >= 1 && Msr.ServiceObjectVersion.Minor >= 12 && Msr.CardPropertyList != null && Msr.CardPropertyList.Length > 0)
            {
                RaisePropertyChanged("CardPropertiesNames");
                RaisePropertyChanged("CardPropertiesValues");
            }

            if (Msr.CapDataEncryption != EncryptionAlgorithm.None)
                RaisePropertyChanged("AdditionalSecurityInformation");

            RaisePropertyChanged("AccountNumber");
            RaisePropertyChanged("ExpirationDate");
            RaisePropertyChanged("Title");
            RaisePropertyChanged("FirstName");
            RaisePropertyChanged("MiddleInitial");
            RaisePropertyChanged("Surname");
            RaisePropertyChanged("ServiceCode");
            RaisePropertyChanged("Suffix");

            if (Msr.CapCardAuthentication != null)
            {
                if (Msr.CapCardAuthentication.Length > 0)
                    RaisePropertyChanged("AuthenticationData");
            }

          
        }


        static private string GetString(byte[] b, bool hex)
        {
            if (b == null)
                return "";

            StringBuilder sb = new StringBuilder(b.Length);

            for (int i = 0; i < b.Length; i++)
                if (hex)
                    sb.Append(b[i].ToString("X2", System.Globalization.CultureInfo.CurrentCulture));
                else
                    sb.Append((char)b[i]);

            return sb.ToString();
        }

        public override void Dispose()
        {
            if (Msr != null)
            {
                Msr.ErrorEvent -= Msr_ErrorEvent;
                Msr.DataEvent -= Msr_DataEvent;
            }
        }
    }
}
