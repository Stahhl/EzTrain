using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace EzTrain.Models
{
    public class Interval
    {
        public IntervalIntensity Intensity { get; set; }
        public IntervalType Type { get; set; }
        public int Amount { get; set; } //100m or 1s
        public Color HighlightColor { get; set; } = Color.CadetBlue;

        public List<string> IntensityNames
        {
            get
            {
                return Enum.GetNames(typeof(IntervalIntensity)).Select(b => b).ToList();
            }
        }
        public List<string> TypeNames
        {
            get
            {
                return Enum.GetNames(typeof(IntervalType)).Select(b => b).ToList();
            }
        }
    }
    public enum IntervalIntensity
    {
        INACTIVE,
        LIGHT,
        MEDIUM,
        HIGH,
    }
    public enum IntervalType
    {
        DURATION,
        DISTANCE
    }
}
