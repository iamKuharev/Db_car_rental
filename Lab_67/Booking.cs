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
    public partial class Boocking : Form
    {
        public Boocking()
        {
            InitializeComponent();
        }
        public int id { get; set; }


        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=car_rental;password=134679";
       

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `booking` (`duration_from`, `duration_to`, `payment_method`, `pledge`, `id_cars`, `id_clients`) " +
                        "VALUES(@duration_from, @duration_to, @payment_method, @pledge, @id_cars, @id_clients) ", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@duration_from", DurationFrom.Text);
                        cmd.Parameters.AddWithValue("@duration_to", DurationTo.Text);
                        cmd.Parameters.AddWithValue("@payment_method", PaymentMethod.Text);
                        cmd.Parameters.AddWithValue("@pledge", Pledge.Text);
                        cmd.Parameters.AddWithValue("@id_cars", idCarsEdit.Text);
                        cmd.Parameters.AddWithValue("@id_clients", idClientEdit.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Бронь успешно добавлена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetBoockingRecords();
                        ResetObjects();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetObjects()
        {
            Pledge.Clear();
            idCarsEdit.Clear();
            PaymentMethod.Clear();
            idClientEdit.Clear();
            id = 0;
            idCarsEdit.Focus();
        }

        private void GetBoockingRecords()
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM booking", con))
                {
                    DataTable dt = new DataTable();

                    con.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);


                    BoockingGrid.DataSource = dt;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE `booking` SET `duration_from` = @duration_from, `duration_to` = @duration_to, " +
                            "`payment_method` = @payment_method, `pledge` = @pledge, `id_cars` = @id_cars, `id_clients` = @id_clients " +
                            "WHERE `id` = @id ", con))
                        {
                            cmd.CommandType = CommandType.Text;

                            cmd.Parameters.AddWithValue("@duration_from", DurationFrom.Text);
                            cmd.Parameters.AddWithValue("@duration_to", DurationTo.Text);
                            cmd.Parameters.AddWithValue("@payment_method", PaymentMethod.Text);
                            cmd.Parameters.AddWithValue("@pledge", Pledge.Text);
                            cmd.Parameters.AddWithValue("@id_cars", idCarsEdit.Text);
                            cmd.Parameters.AddWithValue("@id_clients", idClientEdit.Text);
                            cmd.Parameters.AddWithValue("@id", id);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Бронь успешно обновлена.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetBoockingRecords();
                            ResetObjects();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите бронь для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    DialogResult result = MessageBox.Show("Удаление брони повлечет за собой удаление связи с доп. услугами. Вы хотите продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;

                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE from booking where id = @id", con))
                        {

                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@id", id);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Бронь успешно удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                GetBoockingRecords();
                                ResetObjects();
                           
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите бронь для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoockingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(BoockingGrid.SelectedRows[0].Cells[0].Value);
            DurationFrom.Text = BoockingGrid.SelectedRows[0].Cells[1].Value.ToString();
            DurationTo.Text = BoockingGrid.SelectedRows[0].Cells[2].Value.ToString();
            PaymentMethod.Text = BoockingGrid.SelectedRows[0].Cells[3].Value.ToString();
            Pledge.Text = BoockingGrid.SelectedRows[0].Cells[4].Value.ToString();
            idCarsEdit.Text = BoockingGrid.SelectedRows[0].Cells[5].FormattedValue.ToString();
            idClientEdit.Text = BoockingGrid.SelectedRows[0].Cells[6].FormattedValue.ToString();

          
        }

        private void Boocking_Load(object sender, EventArgs e)
        {
            GetBoockingRecords();
        }

    }
}
