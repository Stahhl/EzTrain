using EzTrain.Models;
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
        private bool isLooping;

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewIntervalPage(viewModel)));
        }
        private async void Start_Clicked(object sender, EventArgs e)
        {
            if (isLooping == true)
                return;

            isLooping = true;

            await LoopItems();

            isLooping = false;
        }
        private async Task LoopItems()
        {
            Interval current = null;
            Interval last = null;

            for (int i = 0; i < viewModel.Intervals.Count; i++)
            {
                current = viewModel.Intervals[i];

                current.ToggleSelection();
                if (last != null)
                    last.ToggleSelection();

                last = current;

                await Task.Delay(1000);
            }

            last.ToggleSelection();
        }
    }
}