using System;
using System.Collections.Generic;
using System.Text;

namespace EzTrain.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        HelloWord,
        Stopwatch,
        BookInfo,
        Workout,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
