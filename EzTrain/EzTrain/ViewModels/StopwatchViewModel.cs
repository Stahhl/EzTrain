using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace EzTrain.ViewModels
{
    class StopwatchViewModel : BaseViewModel
    {
        public StopwatchViewModel()
        {
            Title = "Stopwatch";

            watch = new Stopwatch();

            StartStopCommand = new Command(() => StartStop());
            ResetCommand = new Command(() => Reset());
        }

        private const string timePlaceholderTxt = "00:00:00.000";

        private Stopwatch watch;
        private string time = timePlaceholderTxt;
        private string toggleButtonTxt = "Start";

        public string Time
        {
            get { return time; }
            set { SetProperty(ref time, value); }
        }
        public string ToggleButtonTxt
        {
            get { return toggleButtonTxt; }
            set { SetProperty(ref toggleButtonTxt, value); }
        }


        public void StartStop()
        {
            if (watch.IsRunning == false)
            {
                watch.Start();

                ToggleButtonTxt = "Stop";

                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    Time = watch.Elapsed.ToString(@"hh\:mm\:ss\.fff");

                    if (watch.IsRunning == false)
                        return false;
                    else
                        return true;
                });
            }
            else
            {
                watch.Stop();

                ToggleButtonTxt = "Start";
            }
        }
        public void Reset()
        {
            watch.Reset();

            Time = timePlaceholderTxt;
            ToggleButtonTxt = "Start";
        }

        public Command StartStopCommand { get; }
        public Command ResetCommand { get; }
    }
}
