using EzTrain.ViewModels;
using EzTrain.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EzTrain.Services
{
    public class BookInfoRepository : BaseViewModel
    {
        public BookInfoRepository()
        {
            GenerateBookInfo();

            //MessagingCenter.Subscribe<NewBookPage, BookViewModel>(this, "AddBook", async (obj, book) =>
            //{
            //    var newItem = book as BookViewModel;
            //    BookInfo.Add(newItem);
            //    await BookDataStore.AddItemAsync(newItem);
            //});
        }

        private BookViewModel selectedBook;
        private ObservableCollection<BookViewModel> bookInfo;

        public BookViewModel SelectedBook
        {
            get { return selectedBook; }
            set { SetProperty(ref selectedBook, value); }
        }
        public ObservableCollection<BookViewModel> Books
        {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }

        public void AddNewBook()
        {

        }
        internal void GenerateBookInfo()
        {
            bookInfo = new ObservableCollection<BookViewModel>();
            bookInfo.Add(new BookViewModel() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is a programming paradigm based on the concept of objects" });
            bookInfo.Add(new BookViewModel() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions" });
            bookInfo.Add(new BookViewModel() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning" });
            bookInfo.Add(new BookViewModel() { BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development" });
            bookInfo.Add(new BookViewModel() { BookName = "Visual Studio Code", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming" });
            bookInfo.Add(new BookViewModel() { BookName = "Android Programming", BookDescription = "It is provides a useful overview of the Android application life cycle" });
            bookInfo.Add(new BookViewModel() { BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone" });
            bookInfo.Add(new BookViewModel() { BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment" });
            bookInfo.Add(new BookViewModel() { BookName = "Xamarin.Forms", BookDescription = "Its creates mappings from its C# classes and controls directly" });
            bookInfo.Add(new BookViewModel() { BookName = "Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development" });
        }

        public async Task<bool> AddItemAsync(BookViewModel item)
        {
            //throw new NotImplementedException();
            bookInfo.Add(item);

            return await Task.FromResult(true);
        }

        //public async Task<bool> UpdateItemAsync(BookViewModel item)
        //{
        //    throw new NotImplementedException();
        //    //return await Task.FromResult(false);

        //}

        //public async Task<bool> DeleteItemAsync(string id)
        //{
        //    throw new NotImplementedException();
        //    //return await Task.FromResult(false);

        //}

        //public async Task<BookViewModel> GetItemAsync(string id)
        //{
        //    throw new NotImplementedException();
        //    //return await Task.FromResult(bookInfo[0]);

        //}

        //public async Task<IEnumerable<BookViewModel>> GetItemsAsync(bool forceRefresh = false)
        //{
        //    throw new NotImplementedException();
        //    //return await Task.FromResult(bookInfo);

        //}
    }
}
