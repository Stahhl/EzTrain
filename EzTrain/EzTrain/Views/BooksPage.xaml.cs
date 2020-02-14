using EzTrain.Models;
using EzTrain.Services;
using EzTrain.ViewModels;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

                BindingContext = viewModel = new BookInfoRepository();

                listView.SelectionChanged += ListView_OnSelectionChanged;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private BookInfoRepository viewModel;
        private bool isLooping;

        private async void ListView_OnSelectionChanged(object sender, ItemSelectionChangedEventArgs args)
        {
            await Navigation.PushAsync(new BookDetailsPage(new BookDetailsViewModel((BookViewModel)listView.SelectedItem)));

            listView.SelectedItem = null;
        }
        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewBookPage(viewModel)));
        }
        private async void Start_Clicked(object sender, EventArgs e)
        {
            if (isLooping == true)
                return;

            isLooping = true;

            await LoopItems();

            isLooping = false;
        }
        private async Task LoopItems()
        {
            BookViewModel current = null;
            BookViewModel last = null;

            for (int i = 0; i < viewModel.Books.Count; i++)
            {
                current = viewModel.Books[i];

                current.ToggleSelection();
                if (last != null)
                    last.ToggleSelection();

                last = current;

                await Task.Delay(1000);
            }

            last.ToggleSelection();
        }

    }

}