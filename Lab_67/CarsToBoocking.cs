using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lab67
{
    public partial class CarsToBoocking : Form
    {
        public CarsToBoocking()
        {
            InitializeComponent();
        }

        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=car_rental;password=134679";

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT `brand`, `model`, `registration_number` " +
                    "FROM `booking` " +
                    "JOIN `cars` ON booking.id_cars = cars.id " +
                    "WHERE `duration_to` >= @StartDateText AND `duration_from` < @EndDateText", con))

                {
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@StartDateText",  StartDate.Text );
                    cmd.Parameters.AddWithValue("@EndDateText",  EndDate.Text);
                    DataTable dt = new DataTable();

                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);
                    CarsGrid.DataSource = dt;
                }
            }
        }

        
    }
}
