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
    public partial class popupwindows : ContentPage
    {
        Label actionLabel;
        public popupwindows()
        {

            Button alertButton = new Button { Text = "Alert" };
            alertButton.Clicked += AlertButton_Clicked;
            actionLabel = new Label();
            Content = new StackLayout { Children = { alertButton, actionLabel } };

        }

        private async void AlertButton_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Поделиться", "Отмена", "Удалить", "Вконтакте", "Твиттер", "Фейсбук");
            actionLabel.Text = action;
        }
    }
}