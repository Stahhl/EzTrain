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
    public partial class WorkoutSetupPage : ContentPage
    {
        public WorkoutSetupPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new WorkoutViewModel();
        }

        private WorkoutViewModel viewModel;

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewIntervalPage(viewModel)));
        }
        private async void Start_Clicked(object sender, EventArgs e)
        {

        }
    }
}