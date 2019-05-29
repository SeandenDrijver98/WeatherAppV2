using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppV2
{
    public class ForecastModel
    {
        public DateTime date { get; set; }
        public string city { get; set; }
        public string condition { get; set; }
        public int precipitation { get; set; }
        public int max_temp { get; set; }
        public int min_temp { get; set; }
        public int windspeed { get; set; }
        public int humidity { get; set; }
        public DateTime endDate { get; set; }
      
        
    }
}
