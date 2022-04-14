using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Livraison
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {

        }

        private async void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushModalAsync(new RegisterLivraison());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Bad", ex.Message, "OK");
            }
        }
    }
}