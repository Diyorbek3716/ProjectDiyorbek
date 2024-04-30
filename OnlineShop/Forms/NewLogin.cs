using Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Forms
{
    public partial class Registratsiya : Form
    {
        public Registratsiya()
        {
            InitializeComponent();
        }

        private void NewLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string UserFilePath = "C:\\Users\\Hp\\source\\repos\\OnlineShop\\OnlineShop\\UserList.txt";
            string[] id = File.ReadAllLines(UserFilePath);
            File.AppendAllText(UserFilePath,id.Length+","+ FullName.Text + "," + UserName.Text + "," + NewLogin.Text + "," + NewPassword.Text + "," + PhoneNumber.Text+"\n");
        }
    }
}
