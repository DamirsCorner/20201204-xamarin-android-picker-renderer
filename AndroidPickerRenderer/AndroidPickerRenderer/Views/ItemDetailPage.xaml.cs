using System.ComponentModel;
using Xamarin.Forms;
using AndroidPickerRenderer.ViewModels;

namespace AndroidPickerRenderer.Views
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