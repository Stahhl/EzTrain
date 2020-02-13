using EzTrain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EzTrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookDetailsPage : ContentPage
    {
        public BookDetailsPage(BookDetailsViewModel bookDetailsViewModel)
        {
            InitializeComponent();

            BindingContext = bookDetailsViewModel;

            btnBack.Clicked += BtnBack_Clicked;

            //ExitCommand = new Command(async () => await Navigation.PopAsync());
            //ExitCommand = new Command(async () => await Application.Current.MainPage.Navigation.PopAsync());
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        public Command ExitCommand { get; }
    }
}