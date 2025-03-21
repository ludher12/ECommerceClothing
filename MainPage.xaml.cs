using ECommerceCloting.ViewModel;

namespace ECommerceCloting
{
    public partial class MainPage : ContentPage
    {

        public MainPage(ProductMainViewModel viewmodel)
        {
            BindingContext = viewmodel;
            InitializeComponent();
        }

    }

}
