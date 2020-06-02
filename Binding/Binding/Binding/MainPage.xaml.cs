using System.ComponentModel;
using Xamarin.Forms;


namespace Binding
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ViewToViewDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ViewToViewDemo());
            };
            BindingModeDemo.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new BindingModeDemo());
            };
            ListViewDemo.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new ListViewDemo());
            };
            PickerDemo.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new PickerDemo());
            };
        }
    }
}
