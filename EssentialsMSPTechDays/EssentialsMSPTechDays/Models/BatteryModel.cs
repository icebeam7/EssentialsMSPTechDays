using Xamarin.Essentials;

namespace EssentialsMSPTechDays.Models
{
    public class BatteryModel
    {
        public double Level { get; set; }
        public BatteryState State { get; set; }
        public BatteryPowerSource Source { get; set; }
    }
}
