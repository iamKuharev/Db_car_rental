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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public int id { get; set; }

        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=car_rental;password=134679";

        private void ClientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(ClientGrid.SelectedRows[0].Cells[0].Value);
            FullNameEdit.Text = ClientGrid.SelectedRows[0].Cells[1].FormattedValue.ToString();
            DateOfBirth.Text = ClientGrid.SelectedRows[0].Cells[2].FormattedValue.ToString();
            PassportEdit.Text = ClientGrid.SelectedRows[0].Cells[3].FormattedValue.ToString();
            PlaceOfResidenceEdit.Text = ClientGrid.SelectedRows[0].Cells[4].FormattedValue.ToString();
            DriverIcense.Text = ClientGrid.SelectedRows[0].Cells[5].FormattedValue.ToString();
            PhoneNumberEdit.Text = ClientGrid.SelectedRows[0].Cells[6].FormattedValue.ToString();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
           try
            {
               using (MySqlConnection con = new MySqlConnection(connection))
               {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `clients` (`full_name`, `date_of_birth`, `passport`, `place_of_residence`, `driver's_icense`, `phone_number`)" +
                        "VALUES (@full_name, @date_of_birth, @passport, @place_of_residence, @driver, @phone_number)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@full_name", FullNameEdit.Text);
                        cmd.Parameters.AddWithValue("@date_of_birth", DateOfBirth.Text);
                        cmd.Parameters.AddWithValue("@passport", PassportEdit.Text);
                        cmd.Parameters.AddWithValue("@place_of_residence", PlaceOfResidenceEdit.Text);
                        cmd.Parameters.AddWithValue("@driver", DriverIcense.Text);
                        cmd.Parameters.AddWithValue("@phone_number", PhoneNumberEdit.Text);
                        DataTable dt = new DataTable();

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Клиент успешно добавлен", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetClientRecords();
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
            //idClient = 0;
            PlaceOfResidenceEdit.Clear();
            PassportEdit.Clear();
            FullNameEdit.Clear();
            DriverIcense.Clear();
            FullNameEdit.Focus();
            PhoneNumberEdit.Clear();
           

        }

        private void GetClientRecords()
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Clients", con))
                {
                    DataTable dt = new DataTable();

                    con.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);


                    ClientGrid.DataSource = dt;
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
                            using (MySqlCommand cmd = new MySqlCommand("UPDATE `car_rental`.`clients` SET `full_name` = @full_name, `date_of_birth` = @date_of_birth, `passport` = @passport, `place_of_residence` = @place_of_residence, `driver's_icense` = @driver, `phone_number` = @phone_number WHERE (`id` = @id)", con))
                            {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@full_name", FullNameEdit.Text);
                            cmd.Parameters.AddWithValue("@date_of_birth", DateOfBirth.Text);
                            cmd.Parameters.AddWithValue("@passport", PassportEdit.Text);
                            cmd.Parameters.AddWithValue("@place_of_residence", PlaceOfResidenceEdit.Text);
                            cmd.Parameters.AddWithValue("@driver", DriverIcense.Text);
                            cmd.Parameters.AddWithValue("@phone_number", PhoneNumberEdit.Text);
                            cmd.Parameters.AddWithValue("@id", id);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Клиент успешно обновлен.", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                GetClientRecords();
                                ResetObjects();
                            }
                        }
                }
                else
                {
                    MessageBox.Show("Выберите клиента для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM `clients` WHERE (`id` = @id)", con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Клиент успешно удален.", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetClientRecords();
                            ResetObjects();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите клиента для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Client_Load(object sender, EventArgs e)
        {
            GetClientRecords();
        }


    }
}

