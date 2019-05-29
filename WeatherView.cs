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
    public partial class WeatherView : UserControl
    {
        public WeatherView()
        {
            InitializeComponent();
            pnlFullReport.Hide();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            pnlWeeklyForecast.Controls.Clear();
            pnlFullReport.Hide();
            String city = cmbCity.Text;
            DateTime day = dateSearch.Value.Date;

            ForecastModel searchForecast = new ForecastModel
            {
                city = cmbCity.Text,
                date = dateSearch.Value.Date,
                endDate = dateSearch.Value.Date.AddDays(7)
            };

            List<ForecastModel> foundForecast = WeatherDbDataAccess.getWeather(searchForecast);

            if(foundForecast.Count > 0)
            {
                ForecastModel forecast = foundForecast.ElementAt(0);
                pnlFullReport.Show();
                lblTownName.Text = forecast.city;
                lblDate.Text = forecast.date.ToShortDateString();
                lblPrecipitation.Text = forecast.precipitation + "";
                lblMaxTemp.Text = forecast.max_temp+"";
                lblMinTemp.Text = forecast.min_temp+"";
                lblWindspeed.Text = forecast.windspeed +"";
                lblHumidity.Text = forecast.humidity+"";
            }
            else
            {
                MessageBox.Show("No Forecasts found on this day");
            }

          List<ForecastModel> weeklyForecast = WeatherDbDataAccess.getCityWeatherRange(searchForecast);
            foreach (var forecast in weeklyForecast)
            {
                pnlWeeklyForecast.Controls.Add(new WeeklyDayView(forecast));
            }
        }
    



    }
}
