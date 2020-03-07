using EzTrain.Models;
using EzTrain.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EzTrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewIntervalPage : ContentPage
    {
        public NewIntervalPage(WorkoutViewModel _workout)
        {
            InitializeComponent();

            workout = _workout;

            interval = new Interval
            {
                //Type = IntervalType.NULL,
                //Intensity = IntervalIntensity.NULL,
                //Amount = 0,
            };

            BindingContext = this;
        }

        private Interval interval;
        private WorkoutViewModel workout;

        async void Save_Clicked(object sender, EventArgs e)
        {
            workout.Intervals.Add(interval);

            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
    
}