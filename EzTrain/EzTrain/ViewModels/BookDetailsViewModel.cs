using System;
using System.Collections.Generic;
using System.Text;

namespace EzTrain.ViewModels
{
    public class BookDetailsViewModel : BaseViewModel
    {

        public BookDetailsViewModel(BookViewModel selected)
        {
            Title = "Book Details";
            BookName = selected.BookName;
            BookDescription = selected.BookDescription;
        }

        private string bookName;
        private string bookDesc;

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
