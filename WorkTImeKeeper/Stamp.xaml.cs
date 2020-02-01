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
            UserCom.Text = UserStatus.Company;
            UserName.Text = UserStatus.UserName;
        }

        private void SignOutBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignIn();
        }

        private void DataViewBtn_Clicked(object sender, EventArgs e)
        {
            // 一覧画面への遷移
            Application.Current.MainPage = new DataViewer();
        }

        private void StartTimeBtn_Clicked(object sender, EventArgs e)
        {
            //TODO 開始時間の登録

        }

        private void EndTimeBtn_Clicked(object sender, EventArgs e)
        {
            //TODO 終了時間の登録
        }
    }
}