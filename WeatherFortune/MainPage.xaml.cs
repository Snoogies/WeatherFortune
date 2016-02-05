using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using WeatherFortune.Model;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace WeatherFortune
{
    /// <summary>
    /// App_load is called on startup that gets geolocation, instantiates current and forecast models, and Initializes controls.  
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void  App_Load(object sender, RoutedEventArgs e)
        {
            var position = await LocationManager.GetPosition();
            GetCurrentWeather(position);
            GetForcastWeather(position);  
        }
        
        private async void GetCurrentWeather(Geoposition position)
        {
            CurrentRootObject currentWeather = await CurrentClasses.GetWeather(position.Coordinate.Latitude, position.Coordinate.Longitude);
            string icon = string.Format("ms-appx:///Icon/{0}.png", currentWeather.weather[0].icon);
            iWeatherImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            tbTemp.Text = ((int)currentWeather.main.temp).ToString() + "°";
            tbLocation.Text = currentWeather.name;
            tbDescription.Text = currentWeather.weather[0].description;
            tbTime.Text = DateTime.Now.ToString("h:mm tt");
            
        }
 
        //TODO: Properly Bind forecast data to to the listview lvForecast
        private async void GetForcastWeather(Geoposition position)
        {
            ForecastRootObject futureWeather = await ForecastClasses.GetWeather(position.Coordinate.Latitude, position.Coordinate.Longitude);
            ObservableCollection<Day> DayList = new ObservableCollection<Day>(futureWeather.list);
            lvForecast.ItemsSource = DayList;
            tbMinTemp.Text = ((int)futureWeather.list[0].temp.min).ToString() + "°";            
            tbMaxTemp.Text = ((int)futureWeather.list[0].temp.max).ToString() + "°";
            tbMin.Text = "min";
            tbMax.Text = "max";
            
        }

        private void bHome_Click(object sender, RoutedEventArgs e)
        {
            svSplit.IsPaneOpen = !svSplit.IsPaneOpen;
        }

        private void lbMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App_Load(sender, e);
            svSplit.IsPaneOpen = !svSplit.IsPaneOpen;
        }
        
    }
}
