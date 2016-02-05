using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFortune.Model
{
    class ForecastClasses
    {
        //Call to openweathermap api for 5 day forcast & deserialize JSON data
        public async static Task<ForecastRootObject> GetWeather(double lat, double lon)
        {            
            var http = new HttpClient();
            var url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?lat={0}&lon={1}&units=imperial&cnt=5&mode=json&appid=44db6a862fba0b067b1930da0d769e98", lat, lon);
            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(ForecastRootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (ForecastRootObject)serializer.ReadObject(ms);

            return data;
        }

        
    }

    [DataContract]
    public class Coord
    {
        [DataMember]
        public double lon { get; set; }
        [DataMember]
        public double lat { get; set; }
    }

    [DataContract]
    public class Weather
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string main { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string icon { get; set; }
    }
    
    [DataContract]
    public class Day
    {
        [DataMember]
        private DateTime _time;
        [DataMember]
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
        [DataMember]
        private int _dt;
        [DataMember]
        public int dt
        {
            get { return _dt; }
            set
            {
                _dt = value;
                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                Time = epoch.AddSeconds(value);
            }
        }        
        [DataMember]
        public Temp temp { get; set; }
        [DataMember]
        public double pressure { get; set; }
        [DataMember]
        public int humidity { get; set; }
        [DataMember]
        public List<Weather> weather { get; set; }
        [DataMember]
        public double speed { get; set; }
        [DataMember]
        public int deg { get; set; }
        [DataMember]
        public int clouds { get; set; }
        [DataMember]
        public double snow { get; set; }
        [DataMember]
        public double? rain { get; set; }
    }

    public class Temp
    {
        [DataMember]
        public double day { get; set; }
        [DataMember]
        public double min { get; set; }
        [DataMember]
        public double max { get; set; }
        [DataMember]
        public double night { get; set; }
        [DataMember]
        public double eve { get; set; }
        [DataMember]
        public double morn { get; set; }
    }

    [DataContract]
    public class ForecastRootObject
    {
        [DataMember]
        public City city { get; set; }
        [DataMember]
        public string cod { get; set; }
        [DataMember]
        public double message { get; set; }
        [DataMember]
        public int cnt { get; set; }
        [DataMember]
        public List<Day> list { get; set; }
    }
    
    [DataContract]
    public class City
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public Coord coord { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public int population { get; set; }
    }


}
