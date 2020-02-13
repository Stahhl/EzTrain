using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzTrain.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EzTrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StopwatchPage : ContentPage
    {
        public StopwatchPage()
        {
            InitializeComponent();
            BindingContext = new StopwatchViewModel();

            //Text
            lblStopwatch.SetBinding(Label.TextProperty, nameof(StopwatchViewModel.Time));
            btnStartStop.SetBinding(Button.TextProperty, nameof(StopwatchViewModel.ToggleButtonTxt));

            //Command
            btnStartStop.SetBinding(Button.CommandProperty, nameof(StopwatchViewModel.StartStopCommand));
            btnReset.SetBinding(Button.CommandProperty, nameof(StopwatchViewModel.ResetCommand));
        }
    }
}