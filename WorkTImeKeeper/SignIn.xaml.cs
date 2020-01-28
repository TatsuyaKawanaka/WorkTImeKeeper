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
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();
        }

        #region eventHandler
        private void EnterBtn_Clicked(object sender, EventArgs e)
        {
            //TODO validatecheck

            Application.Current.MainPage = new Stamp();
        }

        private void Id_Completed(object sender, EventArgs e)
        {
            Password.Focus();
        }

        private void Id_Focused(object sender, FocusEventArgs e)
        {
            Id.BackgroundColor = Color.WhiteSmoke;
        }

        private void Id_Unfocused(object sender, FocusEventArgs e)
        {
            if (CheckIdText(Id.Text))
            {

            }
        }

        private void Password_Completed(object sender, EventArgs e)
        {
            EnterBtn.Focus();
        }

        private void Password_Focused(object sender, FocusEventArgs e)
        {

        }

        private void Password_Unfocused(object sender, FocusEventArgs e)
        {
            if (CheckPasswordText(Password.Text))
            {

            }
        }
        #endregion

        #region method
        private bool CheckIdText(string txt)
        {
            return true;
        }
        
        private bool CheckPasswordText(string password)
        {
            return true;
        }
        #endregion
    }
}