namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            String text1 = textBox1.Text;
            String text2 = textBox2.Text;
            if (text1 != "")
            {
                if (text2 != "")
                {
                    MessageBox.Show("You Success : " + text1 + text2);
                    Form1_1 form1_1 = new Form1_1(); // เปลี่ยน Form เป็นชื่อของฟอร์มที่ต้องการเปิด
                    form1_1.Show(); 
                }
                else
                {
                    MessageBox.Show("text2 is null");
                }
            }
            else
            {
                MessageBox.Show("text1 is null");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}