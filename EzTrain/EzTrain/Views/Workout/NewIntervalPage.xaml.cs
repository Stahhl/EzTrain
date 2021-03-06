﻿using EzTrain.Models;
using EzTrain.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//https://help.syncfusion.com/xamarin/timepicker/gettingstarted
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
            timePicker.TimeSelected += Time_Changed;
            typePicker.SelectedIndexChanged += typeChanged;
            BindingContext = interval;
        }

        private void typeChanged(object sender, EventArgs e)
        {
            if(typePicker.SelectedItem == IntervalType.NULL)
            {
                timePicker.IsVisible = false;
            }
            if (typePicker.SelectedItem == IntervalType.DISTANCE)
            {
                timePicker.IsVisible = false;

            }
            if (typePicker.SelectedItem == IntervalType.DURATION)
            {
                timePicker.IsVisible = true;

            }
        }

        private Interval interval;
        private WorkoutViewModel workout;


        async void AddItem_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new NavigationPage(new NewIntervalPage(viewModel)));
        }
        async void Start_Clicked(object sender, EventArgs e)
        {

        }
        async void Save_Clicked(object sender, EventArgs e)
        {
            if (hasErrors())
                return;

            workout.Intervals.Add(interval);

            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private void Time_Changed(object sender, EventArgs e)
        {
            if (timePicker.Time > TimeSpan.Zero)
                interval.Amount = (int)timePicker.Time.TotalSeconds;
        }
        private bool hasErrors()
        {
            if (
                interval.Intensity == 0 ||
                interval.Type == 0 ||
                interval.Amount == 0
                )
                return true;

            return false;
        }
    }

}