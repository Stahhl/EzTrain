using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EzTrain.Models
{
    public class Interval
    {
        public IntervalIntensity Intensity { get; set; }
        public IntervalType Type { get; set; }
        public string Amount { get; set; } //m or s
        public Color HighlightColor { get; set; } = Color.CadetBlue;
    }
    public enum IntervalIntensity
    {
        NULL,
        INACTIVE,
        LIGHT,
        MEDIUM,
        HIGH,
    }
    public enum IntervalType
    {
        NULL,
        DURATION,
        DISTANCE
    }
}
