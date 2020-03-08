using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace EzTrain.Models
{
    public class Interval
    {
        [Required]
        public IntervalIntensity Intensity { get; set; }
        [Required]
        public IntervalType Type { get; set; }
        [Required]
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
