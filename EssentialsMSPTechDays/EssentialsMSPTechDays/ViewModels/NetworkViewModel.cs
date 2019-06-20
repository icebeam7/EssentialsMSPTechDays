using System.Linq;
using System.Collections.Generic;

using EssentialsMSPTechDays.Models;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.ViewModels
{
    public class NetworkViewModel : BaseViewModel
    {
        private NetworkModel network;
        private Command StatusChangeCommand;

        private List<ConnectionProfile> profile;

        public List<ConnectionProfile> Profile
        {
            get { return network.Profile; }
            set { network.Profile = value; OnPropertyChanged(); }
        }

        private NetworkAccess connection;

        public NetworkAccess Connection
        {
            get { return network.Connection; }
            set { network.Connection = value; OnPropertyChanged(); }
        }

        public NetworkViewModel()
        {
            network = new NetworkModel()
            {
                Profile = Connectivity.ConnectionProfiles.ToList(),
                Connection = Connectivity.NetworkAccess
            };

            Connectivity.ConnectivityChanged += (s, e) =>
            {
                StatusChangeCommand.Execute(e);
            };

            StatusChangeCommand = new Command<ConnectivityChangedEventArgs>((e) =>
            {
                Profile = e.ConnectionProfiles.ToList();
                Connection = e.NetworkAccess;
            });
        }
    }
}
