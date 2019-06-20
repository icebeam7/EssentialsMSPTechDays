using System;
using System.Threading.Tasks;

using EssentialsMSPTechDays.Models;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        private MapModel map;
        public Command ShowMapCommand { get; set; }

        private double latitude;

        public double Latitude
        {
            get { return map.Latitude; }
            set { map.Latitude = value; OnPropertyChanged(); }
        }

        private double longitude;

        public double Longitude
        {
            get { return map.Longitude; }
            set { map.Longitude = value; OnPropertyChanged(); }
        }

        public MapViewModel()
        {
            map = new MapModel();

            ShowMapCommand = new Command(async () =>
            {
                await Map.OpenAsync(new Location(Latitude, Longitude));
            });

            MapInit();
        }

        async Task MapInit()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    Latitude = location.Latitude;
                    Longitude = location.Longitude;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
