using Plugin.Connectivity;
using SmartphoneStoreMobile.Helpers;
using SmartphoneStoreMobile.Models;
using SmartphoneStoreMobile.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartphoneStoreMobile.ViewModels
{
    class ProductViewModel : ObservableObject
    {
        private ObservableCollection<Product> products;
        private ProductService _productService { get; set; }
        public ICommand GetData { get; set; }
        public ProductViewModel()
        {
            _productService = new ProductService();
            products = new ObservableCollection<Product>();
            GetData = new Command(Get);
        }

        public async void Get()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                Products = await _productService.GetProducts().ConfigureAwait(false);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Нет подключения к интернету", "Ок");
            }
        }

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { SetProperty(ref products, value); }
        }
    }
}
