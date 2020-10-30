using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace elemendidXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listview : ContentPage
    {
        public Listview()
        {
            InitializeComponent();
        }

        private async void phonesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((string)e.SelectedItem== "iPhone 4 Cтарая модель 2016 года")
            {
                await Navigation.PushAsync(new iphone_4());
            }
            if ((string)e.SelectedItem == "iPhone 5 Cтарая модель")
            {
                await Navigation.PushAsync(new iphone5());
            }
            if ((string)e.SelectedItem == "iPhone 12 Новая модель 2020 года")
            {
                await Navigation.PushAsync(new iphone12());
            }

        }
    }
}