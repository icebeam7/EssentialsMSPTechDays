using System.Collections.Generic;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.Models
{
    public class NetworkModel
    {
        public NetworkAccess Connection { get; set; }
        public List<ConnectionProfile> Profile { get; set; }
    }
}
