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
    public partial class frmMain : Form
    {
        WeatherView DailyWeather = new WeatherView();
        AnalyseWeatherView Analyse = new AnalyseWeatherView();
        CaptureView Capture = new CaptureView();
        public frmMain(String access)
        {
            InitializeComponent();
            clearScreen();
            if(access == "General")
            {
                pnlTitle.Show();
                lblTitle.Show();
            }
            if(access == "Admin")
            {
                btnAnalyse.Show();
                btnCapture.Show();
                pnlTitle.Hide();
            }
        }
        public void clearScreen()
        {
            pnlView.Controls.Clear();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnViewWeather_Click(object sender, EventArgs e)
        {
            clearScreen();
            pnlView.Controls.Add(DailyWeather);
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            clearScreen();
            pnlView.Controls.Add(Analyse);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            clearScreen();
            pnlView.Controls.Add(Capture);
        }


    }
}
