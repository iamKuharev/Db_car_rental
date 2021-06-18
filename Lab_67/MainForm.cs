using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab67
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toClientBtn_Click(object sender, EventArgs e)
        {
            Form toClient = new Client();
            toClient.Owner = this;
            toClient.Show();
        }

        private void toBoockingBtn_Click(object sender, EventArgs e)
        {
            Form toBoocking = new Boocking();
            toBoocking.Owner = this;
            toBoocking.Show();
        }

        private void CarsToBoockingBtn_Click(object sender, EventArgs e)
        {
            Form CarsToBoocking = new CarsToBoocking();
            CarsToBoocking.Owner = this;
            CarsToBoocking.Show();
        }

        private void PolularBrandBtn_Click(object sender, EventArgs e)
        {
            Form PolularBrand = new PolularBrand();
            PolularBrand.Owner = this;
            PolularBrand.Show();
        }


    }
}
