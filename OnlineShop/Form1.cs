using Microsoft.Win32;
using OnlineShop.Forms;

namespace OnlineShop
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            SuperAdmin superAdmin = new SuperAdmin();
            superAdmin.Show();

        }

        private void Registr_Click(object sender, EventArgs e)
        {
            Registratsiya registratsiya = new Registratsiya();
            registratsiya.Show();
        }
    }
}
