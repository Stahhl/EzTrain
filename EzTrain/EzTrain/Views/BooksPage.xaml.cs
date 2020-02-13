using EzTrain.Services;
using EzTrain.ViewModels;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EzTrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksPage : ContentPage
    {
        public BooksPage()
        {
            try
            {
                InitializeComponent();

                BindingContext = new BookInfoRepository();

                listView.SelectionChanged += ListView_OnSelectionChanged;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void ListView_OnSelectionChanged(object sender, ItemSelectionChangedEventArgs args)
        {
            await Navigation.PushAsync(new BookDetailsPage(new BookDetailsViewModel((BookViewModel)listView.SelectedItem)));

            listView.SelectedItem = null;
        }
    }
}