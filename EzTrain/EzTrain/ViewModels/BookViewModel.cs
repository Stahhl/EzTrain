using EzTrain.Models;
using EzTrain.Services;
using EzTrain.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EzTrain.ViewModels
{
    public class BookViewModel : BaseViewModel
    {
        public BookViewModel()
        {
            MyColor = Color.White;
        }

        private string bookName;
        private string bookDesc;
        private Color myColor;

        private bool isSelected = false;

        public void ToggleSelection()
        {
            isSelected = !isSelected;

            if(isSelected == true)
            {
                MyColor = Color.Red;
            }
            else
            {
                MyColor = Color.White;
            }
        }

        public Color MyColor
        {
            get { return myColor; }
            set { SetProperty(ref myColor, value); }
        }
        public string BookName
        {
            get { return bookName; }
            set { SetProperty(ref bookName, value); }
        }
        public string BookDescription
        {
            get { return bookDesc; }
            set { SetProperty(ref bookDesc, value); }
        }
    }
}
