using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string login = "admin";
        string password = "admin";
        public Form1()
        {

            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*login = textBox1.Text;*/
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*password = textBox2.Text;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == login && textBox2.Text == password)
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

