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
            //Title = "BookInfo";
            //Items = new ObservableCollection<Item>();
            //var task = Task.Run(async () => await ExecuteLoadItemsCommand());
            ////LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //BookSelectedCommand = new Command(async () =>
            //{
            //    var bookDetails = new BookDetailsViewModel { BookName = bookName, BookDescription = bookDesc };

            //    await Application.Current.MainPage.Navigation.PushAsync(new BookDetailsPage(bookDetails));
            //});

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        //public Command BookSelectedCommand;
        //public Command LoadItemsCommand;

        ////public BookInfoRepository BookInfoRepository = new BookInfoRepository();
        //public ObservableCollection<Item> Items;

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

        //async Task ExecuteLoadItemsCommand()
        //{
        //    if (IsBusy)
        //        return;

        //    IsBusy = true;

        //    try
        //    {
        //        Items.Clear();
        //        var items = await DataStore.GetItemsAsync(true);
        //        foreach (var item in items)
        //        {
        //            Items.Add(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}
    }
}
