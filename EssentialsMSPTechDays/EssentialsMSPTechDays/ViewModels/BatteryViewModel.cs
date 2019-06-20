using EssentialsMSPTechDays.Models;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.ViewModels
{
    public class BatteryViewModel : BaseViewModel
    {
        private BatteryModel battery;
        private Command StatusChangeCommand;

        private double level;

        public double Level
        {
            get { return battery.Level; }
            set { battery.Level = value; OnPropertyChanged(); }
        }

        private BatteryState state;

        public BatteryState State
        {
            get { return battery.State; }
            set { battery.State = value; OnPropertyChanged(); }
        }

        private BatteryPowerSource source;

        public BatteryPowerSource Source
        {
            get { return battery.Source; }
            set { battery.Source = value; OnPropertyChanged(); }
        }

        public BatteryViewModel()
        {
            battery = new BatteryModel()
            {
                Level = Battery.ChargeLevel,
                State = Battery.State,
                Source = Battery.PowerSource
            };

            Battery.BatteryInfoChanged += (s, e) =>
            {
                StatusChangeCommand.Execute(e);
            };

            StatusChangeCommand = new Command<BatteryInfoChangedEventArgs>((e) =>
            {
                Level = e.ChargeLevel;
                State = e.State;
                Source = e.PowerSource;
            });
        }
    }
}
