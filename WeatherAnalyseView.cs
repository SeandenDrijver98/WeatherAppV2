using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WeatherAppV2
{
    public partial class AnalyseWeatherView : UserControl
    {
        //Declare Global variables
        SelectionRange searchRange;
        //Instantiate Grid Objects
        analyseTownGrid CapeTown = new analyseTownGrid("Cape Town");
        analyseTownGrid Johannesburg = new analyseTownGrid("Johannesburg");
        analyseTownGrid Pretoria = new analyseTownGrid("Pretoria");
        analyseTownGrid Durban = new analyseTownGrid("Durban");
        analyseTownGrid PortElizabeth = new analyseTownGrid("Port Elizabeth");

        public AnalyseWeatherView()
        {
            InitializeComponent();
        }



        private void btnCity_Click(object sender, EventArgs e)
        {
            searchRange = dateSearch.SelectionRange;
            ForecastModel searchForecast = new ForecastModel
            {
                date = searchRange.Start,
                endDate = searchRange.End
            };


            List<String> Cities = populateSelectedCities();

            //Clear old data
            pnlData.Controls.Clear();
            CapeTown.clearRecords();
            Johannesburg.clearRecords();
            Pretoria.clearRecords();
            Durban.clearRecords();
            PortElizabeth.clearRecords();

            CapeTown.clearFilters();
            Johannesburg.clearFilters();
            PortElizabeth.clearFilters();
            Pretoria.clearFilters();
            Durban.clearFilters();




            foreach (var forecast in WeatherDbDataAccess.getWeatherRange(searchForecast))
            {
                // Check if city is selected 
                if (Cities.Contains(forecast.city))
                {
                    // Add Records to specicific 
                    switch (forecast.city)
                    {
                        case "Cape Town":
                            CapeTown.addRecord(forecast);
                            break;
                        case "Johannesburg":
                            Johannesburg.addRecord(forecast);
                            break;
                        case "Durban":
                            Durban.addRecord(forecast);
                            break;
                        case "Pretoria":
                            Pretoria.addRecord(forecast);
                            break;
                        case "Port Elizabeth":
                            PortElizabeth.addRecord(forecast);
                            break;
                        default:
                            break;
                    }
                }

            }
            // Add Active components
            foreach (var city in Cities)
            {
                switch (city)
                {
                    case "Cape Town":
                        pnlData.Controls.Add(CapeTown);
                        break;
                    case "Johannesburg":
                        pnlData.Controls.Add(Johannesburg);
                        break;
                    case "Durban":
                        pnlData.Controls.Add(Durban);
                        break;
                    case "Pretoria":
                        pnlData.Controls.Add(Pretoria);
                        break;
                    case "Port Elizabeth":
                        pnlData.Controls.Add(PortElizabeth);
                        break;
                    default:
                        break;
                }
            }

        }

        //Store all Active cities into a list
        public List<String> populateSelectedCities()
        {
            List<string> Cities = new List<string>();

            if (chbCapeTown.Checked)
            {
                Cities.Add("Cape Town");
            }
            if (chbJhb.Checked)
            {
                Cities.Add("Johannesburg");
            }
            if (chbDurban.Checked)
            {
                Cities.Add("Durban");
            }
            if (chbPE.Checked)
            {
                Cities.Add("Port Elizabeth");
            }
            if (chbPretoria.Checked)
            {
                Cities.Add("Pretoria");
            }
            return Cities;

        }

        //Store all Active Filters into a list
        public List<String> populateSelectedFilters()
        {
            List<string> Filters = new List<string>();

            if (chbMaxTemp.Checked)
            {
                Filters.Add("MaxTemp");
            }
            if (chbMinTemp.Checked)
            {
                Filters.Add("MinTemp");
            }
            if (chbHumidity.Checked)
            {
                Filters.Add("Humidity");
            }
            if (chbWindspeed.Checked)
            {
                Filters.Add("Windspeed");
            }
            if (chbPrecipitation.Checked)
            {
                Filters.Add("Precipitation");
            }
            return Filters;

        }

        public String[] mapModelToArray(ForecastModel obj)
        {
            String[] Attributes =
            {
                obj.city,
                obj.date+"",
                obj.condition,
                obj.precipitation+"",
                obj.maxTemp+"",
                obj.minTemp+"",
                obj.windspeed+"",
                obj.humidity+""
            };
            return Attributes;
        }
        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            CapeTown.clearFilters();
            Johannesburg.clearFilters();
            PortElizabeth.clearFilters();
            Pretoria.clearFilters();
            Durban.clearFilters();

            List<ForecastModel> dailyForecasts = new List<ForecastModel>();
            List<String[]> Attributes = new List<string[]>();
            DateTime selectedDate = searchRange.Start.Date;
            ForecastModel searchForecast = new ForecastModel
            {
                date = searchRange.Start,
                endDate = searchRange.End
            };
            
            try
            {
                // for each day in the reange
                for (int i = 0; i <= (searchRange.End.Subtract(searchRange.Start)).Days; i++)
                {
                    //Loop through date range days
                    foreach (var forecast in WeatherDbDataAccess.getWeatherRange(searchForecast))
                    {
                        Attributes.Add(mapModelToArray(forecast));
                        //for each day loop through array of forecasts
                        if (forecast.endDate == searchRange.Start.AddDays(i))    
                        {
                            dailyForecasts.Add(forecast);
                        }
                    }
                        //compare all filters for this day
                        //--------------------------------
                        List<String> ActiveFilters = populateSelectedFilters();
                    
                        foreach (var filter in ActiveFilters)
                        {
                        switch (filter)
                            {
                                case "MaxTemp":
                                    int maxValue = 100;
                                    foreach (var forecast in dailyForecasts)
                                    {
                                        if (forecast.maxTemp <= maxValue)
                                        {
                                            maxValue = forecast.maxTemp;
                                        }
                                    }
                                    MapForecastToTable(dailyForecasts, 4, maxValue);
                                break;
                                case "MinTemp":
                                    int minValue = 0;
                                    foreach (var forecast in dailyForecasts)
                                    {
                                        if (forecast.minTemp >= minValue)
                                        {
                                            minValue = forecast.minTemp;
                                        }
                                    }
                                    MapForecastToTable(dailyForecasts, 5, minValue);
                                break;
                                case "Precipitation":
                                    int precipitationValue = 100;
                                    foreach (var forecast in dailyForecasts)
                                    {
                                        if (forecast.precipitation <= precipitationValue)
                                        {
                                            precipitationValue = forecast.precipitation;
                                        }
                                    }
                                    MapForecastToTable(dailyForecasts, 3, precipitationValue);
                                break;
                                case "Windspeed":
                                int WindspeedValue = 100;
                                foreach (var forecast in dailyForecasts)
                                {
                                    if (forecast.precipitation <= WindspeedValue)
                                    {
                                        precipitationValue = forecast.windspeed;
                                    }
                                }
                                MapForecastToTable(dailyForecasts, 6, WindspeedValue);
                                break;
                                case "Humidity":
                                int HumidityValue = 100;
                                foreach (var forecast in dailyForecasts)
                                {
                                    if (forecast.precipitation <= HumidityValue)
                                    {
                                        HumidityValue = forecast.humidity;
                                    }
                                }
                                MapForecastToTable(dailyForecasts, 7, HumidityValue);
                                break;
                                default:
                                    break;
                            }
                        }

                        dailyForecasts.Clear();
                    
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Analysis Encountered an error");
            }

        }
             

        public void MapForecastToTable(List<ForecastModel> dayForecasts, int condition, int value)
        {
            int i = 0;
            //Foreach identical value
            foreach (var forecast in dayForecasts)
            {
                String[] arrForecast = WeatherDbDataAccess.toArray(forecast);
                if (int.Parse(arrForecast[condition]) == value)
                {
                    //Find the city
                    switch (arrForecast[0])
                    {
                        case "Cape Town":
                            CapeTown.applyFilter(condition, arrForecast, value);
                            break;
                        case "Johannesburg":
                            Johannesburg.applyFilter(condition, arrForecast, value);
                            break;
                        case "Durban":
                            Durban.applyFilter(condition, arrForecast, value);
                            break;
                        case "Pretoria":
                            Pretoria.applyFilter(condition, arrForecast, value);
                            break;
                        case "Port Elizabeth":
                            PortElizabeth.applyFilter(condition, arrForecast, value);
                            break;
                        default:
                            break;
                    }
                }
               
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDoc.PrintPage += PrintDoc_PrintPage;
            printPreview.Document = printDoc;

            if (printPreview.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        private void PrintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmOutput = new Bitmap(pnlData.Width, pnlData.Height);
            pnlData.DrawToBitmap(bmOutput, new Rectangle(0, 0, pnlData.Width, pnlData.Height));
            e.Graphics.DrawImage(bmOutput, 0, 0);

        }
    }
}
