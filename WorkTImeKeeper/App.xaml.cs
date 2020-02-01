using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkTImeKeeper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            MainPage = new SignIn();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
//#if __IOS__
//            // iOS用のコード
//#elif __ANDROID__
//            // Android用のコード
//#else
//            // UWP用のコード

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
