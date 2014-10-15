using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ModernPosExplorer.Common;
using ModernPosExplorer.ViewModels;
using BrokeredPointOfService;

namespace ModernPosExplorer.Views
{
    public sealed partial class DevicePage : Page
    {
        private NavigationHelper navigationHelper;
        private DeviceViewModel deviceViewModel = new DeviceViewModel();
        private ViewModelBase deviceSpecificViewModel;

        public DeviceViewModel DeviceViewModel
        {
            get { return this.deviceViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public DevicePage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            PageProgressRing.IsActive = true;

            if (e.NavigationParameter != null)
            {
                // Use e.NavigationParameter here, because App.CurrentCustomerId is set to 0
                // when you create a new instance of CustomerViewModel above.
                deviceViewModel.LoadData((DeviceInfo)e.NavigationParameter);

                if (deviceViewModel.PosCommon is Scanner)
                {
                    var scanner = new ScannerControl();
                    deviceSpecificViewModel = scanner.ScannerViewModel;
                    scanner.ScannerViewModel.LoadData(deviceViewModel);
                    this.DeviceSpecificFields.Children.Add(scanner);
                }
                else if (deviceViewModel.PosCommon is Msr)
                {
                    var msr = new MsrControl();
                    deviceSpecificViewModel = msr.MsrViewModel;
                    msr.MsrViewModel.LoadData(deviceViewModel);
                    this.DeviceSpecificFields.Children.Add(msr);
                }
                else if (deviceViewModel.PosCommon is PosPrinter)
                {
                }


            }

            PageProgressRing.IsActive = false;
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="e.PageState">An empty dictionary to be populated with serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            if (deviceSpecificViewModel != null)
                deviceSpecificViewModel.Dispose();
            deviceViewModel.Dispose();
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

    
    }
}
