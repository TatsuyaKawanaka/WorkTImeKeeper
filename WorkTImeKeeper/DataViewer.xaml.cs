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
    public partial class DataViewer : ContentPage
    {
        public DataViewer()
        {
            InitializeComponent();
            YearSelector.ItemsSource = GetYears();

            YearSelector.SelectedIndexChanged += YearSelector_SelectedIndexChanged;
            MonthSelector.SelectedIndexChanged += MonthSelector_SelectedIndexChanged;


            if (YearSelector.Items.Count > 0)
            {
                YearSelector.SelectedIndex = 0;
            }

            InitGridBase();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YearSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthSelector.ItemsSource = GetMonths(int.Parse(YearSelector.SelectedItem.ToString()));

            //TODO 表示月の初期値を当月に設定
            MonthSelector.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonthSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO データグリッドの更新

            UpdateGrid(int.Parse(YearSelector.SelectedItem.ToString()), int.Parse(MonthSelector.SelectedItem.ToString()));
        }

        /// <summary>
        /// 登録データからデータの存在する念を取得する
        /// </summary>
        private List<string> GetYears()
        {
            List<string> list = new List<string>();

            list.Add("2020");

            return list;
        }

        /// <summary>
        /// 年からデータの存在する月を取得する
        /// </summary>
        private List<string> GetMonths(int year)
        {
            List<string> list = new List<string>();

            for (var i = 0; i < 12; i++)
            {

                list.Add((i + 1).ToString());
            }

            return list;
        }

        /// <summary>
        /// グリッドの初期化
        /// </summary>
        private void InitGridBase()
        {
            DataGrid.RowDefinitions.Add(new RowDefinition());
            DataGrid.ColumnDefinitions.Clear();
            for (var i = 0; i < Columns.Count; i++)
            {
                DataGrid.Children.Add(Columns[i]);

                Columns[i].BackgroundColor = Color.AliceBlue;
                Columns[i].TextColor = Color.Black;
                Columns[i].FontSize = 14;

                DataGrid.ColumnDefinitions.Add(new ColumnDefinition());
                Columns[i].SetValue(Grid.ColumnProperty, i);
                Columns[i].SetValue(Grid.RowProperty, 0);
            }


        }

        private List<Label> Columns = new List<Label>()
        {
            { new Label() { Text = "日付" } },
            { new Label() { Text = "曜日" } },
            { new Label() { Text = "開始時間" } },
            { new Label() { Text = "終了時間" } },
            { new Label() { Text = "拘束時間" } },
            { new Label() { Text = "休憩時間" } },
            { new Label() { Text = "実働時間" } },
            { new Label() { Text = "特記" } },
            { new Label() { Text = "備考" } },
        };


        private void UpdateGrid(int year, int month)
        {
            for (var col = 0; col < Columns.Count; col++)
            {
                Label label;
                for (var row = 0; row < DateTime.DaysInMonth(year, month); row++)
                {
                    DataGrid.RowDefinitions.Add(new RowDefinition());
                    label = new Label() { Text = (row + 1).ToString(), BackgroundColor = Color.WhiteSmoke, TextColor = Color.Black };
                    label.SetValue(Grid.ColumnProperty, col);
                    label.SetValue(Grid.RowProperty, row + 1);
                    DataGrid.Children.Add(label);
                }
            }

        }

        private void StampBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Stamp();
        }
    }
}