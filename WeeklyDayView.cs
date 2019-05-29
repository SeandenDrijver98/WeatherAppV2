using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppV2
{
    public partial class WeeklyDayView : UserControl
    {
        public WeeklyDayView(ForecastModel forecast)
        {
            InitializeComponent();
            setCondition(forecast.condition);
            lblDate.Text = forecast.date.ToShortDateString();
            lblMaxTemp.Text = forecast.maxTemp + "";
            lblMinTemp.Text = forecast.minTemp + "";
        }

        public void setCondition(String condition)
        {
            switch (condition)
            {
                case "Sunny":
                    pbConditions.Image = Image.FromFile("../Resources/icons8-sun-64.png");
                    break;
                case "Partly Cloudy":
                    pbConditions.Image = Image.FromFile("../Resources/icons8-partly-cloudy-day-64.png");
                    break;
                case "Showers":
                    pbConditions.Image = Image.FromFile("../Resources/icons8-rain-64(1).png");
                    break;
                case "Overcast":
                    pbConditions.Image = Image.FromFile("../Resources/icons8-clouds-64.png");
                    break;
                default:
                    break;
            }
        }

 
    }
}
