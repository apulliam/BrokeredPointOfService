using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ModernPosExplorer.Common;
using ModernPosExplorer.Views;
using BrokeredPointOfService;

namespace ModernPosExplorer.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private PosExplorer PosExplorer { get; set; }
        public Helpers.RelayCommand<DeviceInfo> ClickDevice { get; private set; }

        private ObservableCollection<DeviceInfo> devices;
        public ObservableCollection<DeviceInfo> Devices
        {
            get
            {
                return devices;
            }

            set
            {
                devices = value;
                RaisePropertyChanged("Devices");
            }
        }
        public MainViewModel()
        {
            devices = new ObservableCollection<DeviceInfo>();
            ClickDevice = new Helpers.RelayCommand<DeviceInfo>(Click);
        }

        public void LoadData()
        {
            PosExplorer = new PosExplorer();
            var deviceArray =  PosExplorer.GetDevicesByCompatibilities(DeviceCompatibilities.CompatibilityLevel1);
            foreach (var device in deviceArray)
            {
                devices.Add(device);
            }
        }

        private void Click(DeviceInfo device)
        {
            App.AppFrame.Navigate(typeof(DevicePage), device);
        }

        public override void Dispose()
        {
            if (PosExplorer != null)
                PosExplorer.Dispose();
        }
    }
}
