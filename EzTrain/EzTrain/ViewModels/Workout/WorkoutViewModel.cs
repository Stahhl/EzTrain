using EzTrain.Models;
using EzTrain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace EzTrain.ViewModels
{
    public class WorkoutViewModel : BaseViewModel
    {
        public WorkoutViewModel()
        {
            Intervals = DummyData.GetIntervals();
        }

        private Interval selected;
        private ObservableCollection<Interval> intervals;

        public Interval SelectedInterval
        {
            get { return selected; }
            set { SetProperty(ref selected, value); }
        }
        public ObservableCollection<Interval> Intervals
        {
            get { return intervals; }
            set { this.intervals = value; }
        }
    }
}
