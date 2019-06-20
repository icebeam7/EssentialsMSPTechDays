using EssentialsMSPTechDays.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsMSPTechDays.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetworkView : ContentPage
    {
        public NetworkView()
        {
            InitializeComponent();

            BindingContext = new NetworkViewModel();
        }
    }
}