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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTables.SelectedItem == "User")
            {
                //TODO: add view to panel
            
            }
        }


    }
}
