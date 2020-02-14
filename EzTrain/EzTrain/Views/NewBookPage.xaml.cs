using EzTrain.Services;
using EzTrain.ViewModels;
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
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage(BookInfoRepository bookInfoRepository)
        {
            InitializeComponent();

            this.bookInfoRepository = bookInfoRepository;

            Book = new BookViewModel
            {
                BookName = "Item name",
                BookDescription = "This is an item description."
            };

            BindingContext = this;
        }

        public BookViewModel Book { get; set; }
        private BookInfoRepository bookInfoRepository;

        async void Save_Clicked(object sender, EventArgs e)
        {
            try
            {
                await bookInfoRepository.AddItemAsync(Book);

                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}