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
    public partial class AdminForecastView : UserControl
    {
        public AdminForecastView()
        {
            InitializeComponent();
            List<ForecastModel> forecasts = WeatherDbDataAccess.getAllForecasts();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminForecastView_Load(object sender, EventArgs e)
        {

        }
    }
}
