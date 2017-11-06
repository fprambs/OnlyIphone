using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyIphone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            User user = new User();

            user = Controller.getUser(username);

            if (user.Password == password)
            {
                MessageBox.Show("Ingreso Exitoso", "Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("username y/o contraseña incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
