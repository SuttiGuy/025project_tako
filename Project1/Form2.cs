using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private void label10_Click(object sender, EventArgs e)
        {
            Form1_1 form1_1 = new Form1_1(); // เปลี่ยน Form เป็นชื่อของฟอร์มที่ต้องการเปิด
            form1_1.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=phone;User Id=root;Password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string id = textBox1.Text;
                string brand = textBox2.Text;
                string modele = textBox3.Text;
                string price = textBox4.Text;
                string stock = textBox5.Text;
                string camara = textBox6.Text;


                string insertQuery = "INSERT INTO phone (id, brand, modele, price, stock, camara) VALUES (@id, @brand, @modele,@price,@stock,@camara)";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@brand", brand);
                insertCommand.Parameters.AddWithValue("@modele", modele);
                insertCommand.Parameters.AddWithValue("@price", price);
                insertCommand.Parameters.AddWithValue("@stock", stock);
                insertCommand.Parameters.AddWithValue("@camara", camara);
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("บันทึกข้อมูลสำเร็จ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=phone;User Id=root;Password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string id = textBox1.Text;
                string brand = textBox2.Text;
                string modele = textBox3.Text;
                string price = textBox4.Text;
                string stock = textBox5.Text;
                string camara = textBox6.Text;


                string updateQuery = "UPDATE phone SET id = @id, brand = @brand, modele = @modele, price = @price, stock = @stock, camara = @camara  WHERE id = @id";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@id", id);
                updateCommand.Parameters.AddWithValue("@brand", brand);
                updateCommand.Parameters.AddWithValue("@modele", modele);
                updateCommand.Parameters.AddWithValue("@price", price);
                updateCommand.Parameters.AddWithValue("@stock", stock);
                updateCommand.Parameters.AddWithValue("@camara", camara);
                updateCommand.ExecuteNonQuery();

                MessageBox.Show("อัปเดตข้อมูลสำเร็จ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการอัปเดต: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=phone;User Id=root;Password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM phone";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=phone;User=root;Password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string id = textBox1.Text;

                string deleteQuery = "DELETE FROM phone WHERE id = @id";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ!");
                }
                else
                {
                    MessageBox.Show("ไม่พบผู้ใช้ที่ต้องการลบ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการลบ: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=phone;User Id=root;Password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM phone";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}