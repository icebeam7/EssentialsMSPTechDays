using EssentialsMSPTechDays.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EssentialsMSPTechDays.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechView : ContentPage
    {
        public TextToSpeechView()
        {
            InitializeComponent();

            BindingContext = new TextToSpeechViewModel();
        }
    }
}