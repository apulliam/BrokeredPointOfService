using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Windows.Foundation;

namespace BrokeredPointOfService
{
    internal class BrokeredPosCommon : BrokeredPosDevice, PosCommon, IDisposable
    {
        public NetfxException LastException
        {
            get;
            protected set;
        }

        internal void ExecuteAction(Action action)
        {
            try
            {
                action();
            }

            catch (Exception exception) 
            {
                LastException = BrokeredNetfxExceptionFactory.CreateBrokeredException(exception);
                throw exception;  // doesn't hurt to rethrow here.  All stack gets lost anyway.
            }
        }

     
        internal TResult ExecuteFunction<TResult>(Func<TResult> function)
        {
            try
            {
                return function();
            }
            catch (Exception exception)
            {
                LastException = BrokeredNetfxExceptionFactory.CreateBrokeredException(exception);
                throw exception;  // doesn't hurt to rethrow here.  All stack gets lost anyway.
            }
        }

        internal Microsoft.PointOfService.PosCommon InternalPosCommon
        {
            get
            {
                return (Microsoft.PointOfService.PosCommon) InternalPosDevice;
            }
        }


        internal BrokeredPosCommon(Microsoft.PointOfService.PosCommon posCommon)
            : base(posCommon)
        {
            InternalPosCommon.DirectIOEvent += InternalPosCommon_DirectIOEvent;
            InternalPosCommon.StatusUpdateEvent += InternalPosCommon_StatusUpdateEvent;
        }

        void InternalPosCommon_StatusUpdateEvent(object sender, Microsoft.PointOfService.StatusUpdateEventArgs e)
        {
            if (StatusUpdateEvent != null)
                StatusUpdateEvent(this, new StatusUpdateEventArgs(e));
        }

        void InternalPosCommon_DirectIOEvent(object sender, Microsoft.PointOfService.DirectIOEventArgs e)
        {
            if (DirectIOEvent != null)
                DirectIOEvent(this, new DirectIOEventArgs(e));
        }

       
        public bool CapCompareFirmwareVersion
        {
            get 
            {
                return InternalPosCommon.CapCompareFirmwareVersion;
            }
        }

        public PowerReporting CapPowerReporting
        {
            get 
            {
                return new PowerReporting(InternalPosCommon.CapPowerReporting);
            }
        }

        public bool CapStatisticsReporting
        {
            get 
            {
                return InternalPosCommon.CapStatisticsReporting; 
            }
        }

        public bool CapUpdateFirmware
        {
            get 
            {
                return InternalPosCommon.CapUpdateFirmware;
            }
        }

        public bool CapUpdateStatistics
        {
            get 
            {
                return InternalPosCommon.CapUpdateStatistics; 
            }
        }

        public string CheckHealthText
        {
            get 
            {
                return InternalPosCommon.CheckHealthText; 
            }
        }

        public bool Claimed
        {
            get 
            {
                return InternalPosCommon.Claimed;
            }
        }

        public string DeviceDescription
        {
            get 
            {
                return InternalPosCommon.DeviceDescription;    
            }
        }

        public bool DeviceEnabled
        {
            get
            {
                return InternalPosCommon.DeviceEnabled;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosCommon.DeviceEnabled = value;
                    });
            }
        }

        public string DeviceName
        {
            get 
            {
                return InternalPosCommon.DeviceName;
            }
        }

        public bool FreezeEvents
        {
            get
            {
                return InternalPosCommon.FreezeEvents;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosCommon.FreezeEvents = value;
                    });
            }
        }

        public PowerNotification PowerNotify
        {
            get
            {
                return new PowerNotification(InternalPosCommon.PowerNotify);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosCommon.PowerNotify = value.InternalPowerNotification;
                    });
            }
        }

        public PowerState PowerState
        {
            get 
            {
                return new PowerState(InternalPosCommon.PowerState);
            }
        }

        public string ServiceObjectDescription
        {
            get 
            {
                return InternalPosCommon.ServiceObjectDescription; 
            }
        }

        public Version ServiceObjectVersion
        {
            get 
            {
                return new Version(InternalPosCommon.ServiceObjectVersion); 
            }
        }

        public ControlState State
        {
            get 
            {
                return new ControlState(InternalPosCommon.State);
            }
        }

        public event TypedEventHandler<PosCommon, DirectIOEventArgs> DirectIOEvent;

        public event TypedEventHandler<PosCommon, StatusUpdateEventArgs> StatusUpdateEvent;

        public string CheckHealth(HealthCheckLevel level)
        {
            return ExecuteFunction(() =>
                {
                    return InternalPosCommon.CheckHealth(level.InternalHealthCheckLevel);
                });
        }
    
        public IAsyncOperation<int> ClaimDevice(int timeout)
        {
            return Task.Run(() =>
            {
                return ExecuteFunction(() =>
                    {
                        InternalPosCommon.Claim(timeout);
                        return 0;
                    });
            }).AsAsyncOperation<int>();
        }

        public void CloseDevice()
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.Close();
                });
        }

        public CompareFirmwareResult CompareFirmwareVersion(string firmwareFileName)
        {
            return ExecuteFunction(() =>
                {
                    return new CompareFirmwareResult(InternalPosCommon.CompareFirmwareVersion(firmwareFileName));
                });
        }

        public DirectIOData DirectIO(int command, int data, object obj)
        {
            return ExecuteFunction(() =>
                {
                    return new DirectIOData(InternalPosCommon.DirectIO(command, data, obj));
                });
        }

        public void OpenDevice()
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.Open();
                });
        }

        public void ReleaseDevice()
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.Release();
                });
        }

        public void ResetStatistic(string statistic)
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.ResetStatistic(statistic);
                });
        }

        public void ResetStatistics()
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.ResetStatistics();
                });
        }

        public void ResetStatisticsByCategories(StatisticCategories statistics)
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.ResetStatistics(statistics.InternalStatisticCategories);
                });
        }

        public void ResetStatisticsByNames([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] string[] statistics)
        {
            ExecuteAction(()=>
                {
                    InternalPosCommon.ResetStatistics(statistics);
                });
        }

        public string RetrieveStatisticByName(string statistic)
        {
            return ExecuteFunction(() =>
                {
                    return InternalPosCommon.RetrieveStatistic(statistic);
                });
        }

        public string RetrieveStatistics()
        {
            return ExecuteFunction(() =>
                {
                    return InternalPosCommon.RetrieveStatistics();
                });
        }

        public string RetrieveStatisticsByCategories(StatisticCategories statistics)
        {
            return ExecuteFunction(() =>
                {
                    return InternalPosCommon.RetrieveStatistics(statistics.InternalStatisticCategories);
                });
        }

        public string RetrieveStatisticsByNames([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] string[] statistics)
        {
            return ExecuteFunction(() =>
                {
                    return InternalPosCommon.RetrieveStatistics(statistics);
                });
        }

        public void UpdateFirmware(string firmwareFileName)
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.UpdateFirmware(firmwareFileName);
                });
        }

        public void UpdateStatistic(string name, object value)
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.UpdateStatistic(name, value);
                });
        }

        public void UpdateStatistics([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] Statistic[] statistics)
        {
            ExecuteAction(() =>
                {
                    var internalStatistics = new List<Microsoft.PointOfService.Statistic>();
                    foreach (var statistic in statistics)
                        internalStatistics.Add(statistic.InternalStatistic);
                    InternalPosCommon.UpdateStatistics(internalStatistics.ToArray());
                });
        }

        public void UpdateStatisticsByCategory(StatisticCategories statistics, object value)
        {
            ExecuteAction(() =>
                {
                    InternalPosCommon.UpdateStatistics(statistics.InternalStatisticCategories, value);
                });
        }


        public void Dispose()
        {
            InternalPosCommon.DirectIOEvent -= InternalPosCommon_DirectIOEvent;
            InternalPosCommon.StatusUpdateEvent -= InternalPosCommon_StatusUpdateEvent;
        }
    }
}
