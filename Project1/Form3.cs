using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีแถวที่ถูกเลือกใน DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // ดึงข้อมูลจากแถวที่ถูกเลือก
                string brand = dataGridView1.SelectedRows[0].Cells["brand"].Value.ToString();
                string stock = dataGridView1.SelectedRows[0].Cells["stock"].Value.ToString();
                string price = dataGridView1.SelectedRows[0].Cells["price"].Value.ToString();

                // ทำสิ่งที่คุณต้องการเมื่อคลิกปุ่ม "เลือกและซื้อ" ตรงนี้
                // คุณสามารถเรียกฟอรมหรือเปิดหน้าต่างใหม่เพื่อทำรายการเพิ่มเติม

                // เช่น แสดงข้อความแจ้งเตือน 
                MessageBox.Show("คุณซื้อ " + brand + " ราคา : " + price + " บาท : " + " จำนวน : " + stock + "เครื่อง");
            }
            else
            {
                // ถ้าไม่มีแถวที่ถูกเลือก ให้แจ้งเตือนให้ผู้ใช้เลือกแถวก่อน
                MessageBox.Show("โปรดเลือกรายการที่คุณต้องการเลือกและซื้อ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string brand = dataGridView1.SelectedRows[0].Cells["brand"].Value.ToString();
                string stock = dataGridView1.SelectedRows[0].Cells["stock"].Value.ToString();
                string price = dataGridView1.SelectedRows[0].Cells["price"].Value.ToString();

                DataTable selectedItems = new DataTable();
                selectedItems.Columns.Add("brand");
                selectedItems.Columns.Add("stock");
                selectedItems.Columns.Add("price");

                selectedItems.Rows.Add(brand, stock, price);

                dataGridView2.DataSource = selectedItems;
            }
            else
            {
                MessageBox.Show("โปรดเลือกรายการที่คุณต้องการเลือกและซื้อ");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1_1 form1_1 = new Form1_1(); // เปลี่ยน Form เป็นชื่อของฟอร์มที่ต้องการเปิด
            form1_1.Show();
        }
    }
}
