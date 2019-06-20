using EssentialsMSPTechDays.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsMSPTechDays.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SMSView : ContentPage
    {
        public SMSView()
        {
            InitializeComponent();

            BindingContext = new MessageViewModel("Sms");
        }
    }
}