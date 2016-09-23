using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinForms.SQLite;
using XamarinForms.SQLite.SQLite;

namespace LAPIZZA
{
    public partial class OrderHistoryPage : ContentPage
    {
        private readonly SQLiteConnection _sqLiteConnection;

        public OrderHistoryPage()
        {

            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

            _sqLiteConnection.CreateTable<TodoItem>();


        }


        //public Task Navigation { get; private set; }

        /// <summary>
        /// Gets a ContentPage that contains the items saved in the SQLite database.
        /// </summary>
        /// <returns></returns>
        /// 

        public ContentPage GetHistoryContentPage()
        {

            var ClearButton = new Button
            {
                Text = "Clear Order"
            };

            ClearButton.Clicked += (s, e) =>
            {


				_sqLiteConnection.Delete<TodoItem>(2);
            };



            var listView = new ListView
            {
                ItemsSource = _sqLiteConnection.Table<TodoItem>()
            };

            //.....................................................
            var HistoryContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "LAPIZZA",
                            FontSize = 50
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {

                            listView,

                            }
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {

                               

                            }
                        },
                       
                       
                        ClearButton


                    }
                }
            };
            return HistoryContentPage;
        }
    }
}