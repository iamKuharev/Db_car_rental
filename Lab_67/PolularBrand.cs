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
    public partial class PolularBrand : Form
    {
        public PolularBrand()
        {
            InitializeComponent();
        }

        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=car_rental;password=134679";

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT *, COUNT(*) AS `quantity` FROM( SELECT `id_cars`, `brand` " +
                    "FROM `lease_agreement` JOIN `cars` ON lease_agreement.id_cars = cars.id " +
                    "UNION ALL " +
                    "SELECT `id_cars`, `brand` " +
                    "FROM `booking` " +
                    "JOIN `cars` ON booking.id_cars = cars.id)t " +
                    "GROUP BY `brand` " +
                    "ORDER BY COUNT(*) DESC; ", con))
                {
                    
                    DataTable dt = new DataTable();

                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);
                    PolularBrandGrid.DataSource = dt;
                }
            }
        }

        private void PolularBrandGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
