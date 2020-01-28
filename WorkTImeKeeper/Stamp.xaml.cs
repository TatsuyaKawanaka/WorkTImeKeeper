using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkTImeKeeper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stamp : ContentPage
    {
        public Stamp()
        {
            InitializeComponent();
        }

        private void SignOutBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignIn();
        }

        private void DataViewBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new DataViewer();
        }

        private void StartTimeBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void EndTimeBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}