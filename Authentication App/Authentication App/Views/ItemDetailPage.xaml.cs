using Authentication_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Authentication_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}