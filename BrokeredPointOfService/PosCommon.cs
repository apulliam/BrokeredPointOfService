// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace BrokeredPointOfService
{
    public interface PosCommon : PosDevice
    {
        NetfxException LastException { get; }
        // Summary:
        //     Gets a Boolean value that indicates whether the Service Object/device supports
        //     comparing the firmware version in the physical device against that of a firmware
        //     file.
        bool CapCompareFirmwareVersion { get; }
        //
        // Summary:
        //     Gets the power reporting capabilities of the device.
        PowerReporting CapPowerReporting { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the device can accumulate and
        //     can provide various statistics regarding usage.
        bool CapStatisticsReporting { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the device's firmware can be
        //     updated through the UpdateFirmware method.
        bool CapUpdateFirmware { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether some or all the device statistics
        //     can be reset to 0 (zero) by using the ResetStatistic and ResetStatistics
        //     methods, or updated by using the UpdateStatistic and UpdateStatistics methods.
        bool CapUpdateStatistics { get; }
        //
        // Summary:
        //     Gets a string that indicates the health of the device.
        string CheckHealthText { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the device is claimed for exclusive
        //     access.
        bool Claimed { get; }
        //
        // Summary:
        //     Gets a string identifying the device and the company that manufactured it.
        string DeviceDescription { get; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether the device has been placed
        //     in an operational state.
        bool DeviceEnabled { get; set; }
        //
        // Summary:
        //     Gets a short string identifying the device and any pertinent information
        //     about it.
        string DeviceName { get; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether the application has requested
        //     that the Service Object not deliver events.
        bool FreezeEvents { get; set; }
        //
        // Summary:
        //     Gets or sets the type of power notification selection made by the application.
        PowerNotification PowerNotify { get; set; }
        //
        // Summary:
        //     Gets the current power condition.
        PowerState PowerState { get; }
        //
        // Summary:
        //     Gets a string identifying the Service Object that supports the device and
        //     the company that produced it.
        string ServiceObjectDescription { get; }
        //
        // Summary:
        //     Gets the Service Object version number.
        Version ServiceObjectVersion { get; }
        //
        // Summary:
        //     Gets the current state of the device.
        ControlState State { get; }
        //
        // Summary:
        //     Gets or sets the object that is used to marshal the event handler calls issued
        //     because of a POS event.
        //System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get; set; }

        //
        // Summary:
        //     Raised by the Service Object to communicate information directly to the application.
        event TypedEventHandler<PosCommon, DirectIOEventArgs> DirectIOEvent;
        //
        // Summary:
        //     Raised by the Service Object to alert the application of a device status
        //     change.
        event TypedEventHandler<PosCommon, StatusUpdateEventArgs> StatusUpdateEvent;

        // Summary:
        //     Tests the state of a device.
        //
        // Parameters:
        //   level:
        //     Indicates the type of health check to be performed on the device. Possible
        //     values are defined by the HealthCheckLevel enumeration.
        string CheckHealth(HealthCheckLevel level);
        //
        // Summary:
        //     Requests exclusive access to the device.
        //
        // Parameters:
        //   timeout:
        //     Contains the maximum number of milliseconds to wait for exclusive access
        //     to be satisfied.
        IAsyncOperation<int> ClaimDevice(int timeout);
        //
        // Summary:
        //     Releases the device and its resources.
        void CloseDevice();
        //
        // Summary:
        //     Determines whether the version of the specified firmware is newer than, older
        //     than, or the same as the version of firmware in the physical device.
        //
        // Parameters:
        //   firmwareFileName:
        //     The name of the file that contains the firmware, or the name of a file that
        //     contains a list of firmware files.
        CompareFirmwareResult CompareFirmwareVersion(string firmwareFileName);
        //
        // Summary:
        //     Used to communicate directly with the Service Object.
        //
        // Parameters:
        //   Obj:
        //     Additional data supplied by the Service Object. Specific values vary by command
        //     and by what the Service Object chooses to transmit.
        //
        //   Data:
        //     Additional numeric data. Specific values vary by command and the Service
        //     Object.
        //
        //   command:
        //     Command number. Specific values assigned by the Service Object.
        DirectIOData DirectIO(int command, int data, object obj);
        void OpenDevice();
        //
        // Summary:
        //     Releases exclusive access to the device.
        void ReleaseDevice();
        //
        // Summary:
        //     Resets the specified statistic to 0 (zero).
        //
        // Parameters:
        //   statistic:
        //     Specifies the statistic that is to be reset.
        void ResetStatistic(string statistic);
        //
        // Summary:
        //     Resets all statistics associated with a device to 0 (zero).
        void ResetStatistics();
        //
        // Summary:
        //     Resets all statistics for a specified category to 0 (zero).
        //
        // Parameters:
        //   statistics:
        //     Contains the category of statistics the application wishes to reset for the
        //     device. Possible categories are defined by the StatisticsCategories enumeration.
        void ResetStatisticsByCategories(StatisticCategories statistics);
        //
        // Summary:
        //     Resets the specified statistics to 0 (zero).
        //
        // Parameters:
        //   statistics:
        //     Contains an array of statistic names to be reset.
        void ResetStatisticsByNames([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] string[] statistics);
        //
        // Summary:
        //     Retrieves the specified device statistic.
        //
        // Parameters:
        //   Statistic:
        //     Specifies the statistic to be retrieved.
        string RetrieveStatisticByName(string statistic);
        //
        // Summary:
        //     Retrieves all device statistics.
        string RetrieveStatistics();
        //
        // Summary:
        //     Retrieves the statistics for the specified category.
        //
        // Parameters:
        //   Statistics:
        //     Contains the category of statistics the application wishes to retrieve. Possible
        //     values are defined by the StatisticsCategories enumeration.
        string RetrieveStatisticsByCategories(StatisticCategories statistics);
        //
        // Summary:
        //     Retrieves the specified statistics.
        //
        // Parameters:
        //   Statistics:
        //     Contains an array of statistic names to retrieve.
        string RetrieveStatisticsByNames([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] string[] statistics);
        //
        // Summary:
        //     Updates the firmware of a device with the version of the firmware contained
        //     or defined in the file specified by the firmwareFileName parameter regardless
        //     of whether that firmware’s version is newer than, older than, or the same
        //     as the version of the firmware already in the device.
        //
        // Parameters:
        //   firmwareFileName:
        //     Specifies either the name of the file that contains the firmware or a file
        //     that contains a set of firmware files that are to be downloaded into the
        //     device.
        void UpdateFirmware(string firmwareFileName);
        //
        // Summary:
        //     Updates the value of a specified device statistic.
        //
        // Parameters:
        //   Value:
        //     Value to which the statistic should be set.
        //
        //   Name:
        //     Name of the statistic to be updated.
        void UpdateStatistic(string name, object value);
        //
        // Summary:
        //     Updates a list of statistics with the corresponding specified values.
        //
        // Parameters:
        //   statistics:
        //     Contains an array of Statistic class instances (name-value pairs) that contain
        //     the names and values of the statistics to be updated.
        void UpdateStatistics([System.Runtime.InteropServices.WindowsRuntime.ReadOnlyArray] Statistic[] statistics);
        //
        // Summary:
        //     Updates the specified category of statistics with the specified value.
        //
        // Parameters:
        //   Value:
        //     Contains the value to be used to update the statistics in the specified category.
        //
        //   statistics:
        //     Contains the category of statistics the application wishes to update. Possible
        //     categories are defined by the StatisticsCategories enumeration.
        void UpdateStatisticsByCategory(StatisticCategories statistics, object value);
    }

}
