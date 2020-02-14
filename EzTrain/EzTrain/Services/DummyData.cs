using EzTrain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace EzTrain.Services
{
    public class DummyData
    {
        public static ObservableCollection<Interval> GetIntervals()
        {
            return new ObservableCollection<Interval>()
            {
                new Interval() { Intensity = IntervalIntensity.LIGHT, Type = IntervalType.DURATION, Amount = "30", HighlightColor = Color.CadetBlue },
                new Interval() { Intensity = IntervalIntensity.HIGH, Type = IntervalType.DURATION, Amount = "60", HighlightColor = Color.CadetBlue },
                new Interval() { Intensity = IntervalIntensity.LIGHT, Type = IntervalType.DURATION, Amount = "30", HighlightColor = Color.CadetBlue },
            };
        }
    }
}
