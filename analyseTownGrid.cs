using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherAppV2//WeatherForecaster_SeanDenDrijver.Pages
{
    public partial class analyseTownGrid : UserControl
    {
        int currentRow = 0;
        public analyseTownGrid(String Town)
        {
            InitializeComponent();
            lblTown.Text = Town;

            gridWeather.Rows.Add();


        }

        // Add a record to the data grid
        public void addRecord(String[] forecast)
        {
            gridWeather.Rows.Add();
            gridWeather.Rows[currentRow].Cells[0].Value = forecast[1];
            gridWeather.Rows[currentRow].Cells[1].Value = forecast[2];
            gridWeather.Rows[currentRow].Cells[2].Value = forecast[3];
            gridWeather.Rows[currentRow].Cells[3].Value = forecast[4];
            gridWeather.Rows[currentRow].Cells[4].Value = forecast[5];
            gridWeather.Rows[currentRow].Cells[5].Value = forecast[6];
            gridWeather.Rows[currentRow].Cells[6].Value = forecast[7];
            currentRow++;
        }

        // Apply filters to records
        public void applyFilter(int condition, String[] forecast, int value)
        {
            //bool flagFound;
            List<String> rowContent = new List<String>();
            try
            {
                for (int row = 0; row < gridWeather.RowCount - 1; row++)
                {
                    //Check that the condition selected matches & date selected & & value selected
                    if (gridWeather.Rows[row].Cells[condition - 1].Value.ToString() == forecast[condition] && value + "" == gridWeather.Rows[row].Cells[condition - 1].Value.ToString() && gridWeather.Rows[row].Cells[0].Value.ToString() == forecast[1])
                    {
                        gridWeather.Rows[row].Cells[condition - 1].Style.BackColor = Color.Gold;

                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong..");

            }

        }

        //Clear all filters
        public void clearFilters()
        {
            for (int row = 0; row < gridWeather.RowCount; row++)
            {
                // foreach cell in each column set default colour
                for (int col = 0; col < gridWeather.Rows[row].Cells.Count; col++)
                {
                    gridWeather.Rows[row].Cells[col].Style.BackColor = Color.WhiteSmoke;
                }

            }
        }

        // Clear all records
        public void clearRecords()
        {
            townForecastBinding.Clear();
        }

        private void gridWeather_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
