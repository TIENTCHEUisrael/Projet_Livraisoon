using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Livraison
{
    public partial class App : Application
    {
        private static string serviceBaseAddress;

        public static string ServiceBaseAddress => serviceBaseAddress;
        public App()
        {
            InitializeComponent();
            //#if DEBUG
            if (DeviceInfo.DeviceType == DeviceType.Virtual)
                serviceBaseAddress = "http://10.0.2.2:8083/api/";
            else
                serviceBaseAddress = "http://192.168.43.183:8083/api/";
            //#else
            //serviceBaseAddress = "https://eshopam.com/api/";
            //#endif

            MainPage = new Accueil();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
