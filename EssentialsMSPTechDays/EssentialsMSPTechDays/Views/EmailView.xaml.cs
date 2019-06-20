using EssentialsMSPTechDays.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsMSPTechDays.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailView : ContentPage
    {
        public EmailView()
        {
            InitializeComponent();

            BindingContext = new MessageViewModel("Email");
        }
    }
}