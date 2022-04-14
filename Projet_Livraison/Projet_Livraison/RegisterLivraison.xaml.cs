using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Livraison
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterLivraison : ContentPage
    {
        public RegisterLivraison()
        {
            InitializeComponent();
            //Pour lire et ecrire dans le telephone

            // Get the path to a file on internal storage
            var backingFile = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "count.txt");

            // Get the path to a file in the cache directory
            var cacheFile = Path.Combine(Xamarin.Essentials.FileSystem.CacheDirectory, "count.txt");
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Recuperation de la signature
                Stream bitmap = await signatureView.GetImageStreamAsync(SignatureImageFormat.Png);
                var strokes = signatureView.Strokes;
                //signatureView.Strokes = newStrokes;
                await DisplayAlert("Ok", "Signature Saved", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Bad", ex.Message, "OK");
            }
        }

        private async  void BtnBack_Clicked(object sender, EventArgs e)
        {
            try
            {
               
                await Navigation.PopModalAsync();
            }
            catch(Exception ex)
            {
                await DisplayAlert("Bad", ex.Message,"OK");
            }
        }
        //code pour la sauvegarde
        public async Task SaveCountAsync(int count)
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "count.txt");
            using (var writer = File.CreateText(backingFile))
            {
                await writer.WriteLineAsync(count.ToString());
            }
        }
        //Code pour lire
        public async Task<int> ReadCountAsync()
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "count.txt");

            if (backingFile == null || !File.Exists(backingFile))
            {
                return 0;
            }

            var count = 0;
            using (var reader = new StreamReader(backingFile, true))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (int.TryParse(line, out var newcount))
                    {
                        count = newcount;
                    }
                }
            }

            return count;
        }

       
    }
}