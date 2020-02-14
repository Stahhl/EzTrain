using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EzTrain.Models;

namespace EzTrain.ViewModels
{
    public class IntervalViewModel : BaseViewModel
    {
        public IntervalViewModel()
        {
            Interval = new Interval()
            {
                //Intensity = IntervalIntensity.LIGHT,
                //Type = IntervalType.DURATION,
                //Amount = 30,
                //HighlightColor = Color.Cyan
            };
        }

        public Interval Interval { get; set; }

        private bool isSelected;

        public void ToggleSelection()
        {
            isSelected = !isSelected;

            if (isSelected == true)
            {
                Interval.HighlightColor = Color.Red;
            }
            else
            {
                Interval.HighlightColor = Color.Cyan;
            }
        }
    }
}
