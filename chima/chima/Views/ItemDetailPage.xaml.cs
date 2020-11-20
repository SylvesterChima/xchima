using chima.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace chima.Views
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