using EssentialsMSPTechDays.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsMSPTechDays.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentPage
    {
        public MapView()
        {
            InitializeComponent();

            BindingContext = new MapViewModel();
        }
    }
}