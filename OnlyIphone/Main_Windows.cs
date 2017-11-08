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
    public partial class Main_Windows : Form
    {
        public string send_username;
        public Main_Windows()
        {
            InitializeComponent();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Windows_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Bienvenido " + send_username;
        }

        private void mainButton_MouseMove(object sender, MouseEventArgs e)
        {
            mainRectangle.BackColor = Color.DarkOrange;
            mainRectangle.BorderColor = Color.DarkOrange;
        }

        private void mainButton_MouseLeave(object sender, EventArgs e)
        {
            mainRectangle.BackColor = Color.DimGray;
            mainRectangle.BorderColor = Color.DimGray;
        }

        private void cashboxButton_MouseMove(object sender, MouseEventArgs e)
        {
            cashboxRectangle.BackColor = Color.DarkOrange;
            cashboxRectangle.BorderColor = Color.DarkOrange;
        }

        private void cashboxButton_MouseLeave(object sender, EventArgs e)
        {
            cashboxRectangle.BackColor = Color.DimGray;
            cashboxRectangle.BorderColor = Color.DimGray;
        }

        private void clientButton_MouseMove(object sender, MouseEventArgs e)
        {
            clientRectangle.BackColor = Color.DarkOrange;
            clientRectangle.BorderColor = Color.DarkOrange;
        }

        private void clientButton_MouseLeave(object sender, EventArgs e)
        {
            clientRectangle.BackColor = Color.DimGray;
            clientRectangle.BorderColor = Color.DimGray;
        }

        private void saleButton_MouseMove(object sender, MouseEventArgs e)
        {
            saleRectangle.BackColor = Color.DarkOrange;
            saleRectangle.BorderColor = Color.DarkOrange;
        }

        private void saleButton_MouseLeave(object sender, EventArgs e)
        {
            saleRectangle.BackColor = Color.DimGray;
            saleRectangle.BorderColor = Color.DimGray;
        }

        private void productButton_MouseMove(object sender, MouseEventArgs e)
        {
            productRectangle.BackColor = Color.DarkOrange;
            productRectangle.BorderColor = Color.DarkOrange;
        }

        private void productButton_MouseLeave(object sender, EventArgs e)
        {
            productRectangle.BackColor = Color.DimGray;
            productRectangle.BorderColor = Color.DimGray;
        }

        private void inventoryButton_MouseMove(object sender, MouseEventArgs e)
        {
            inventoryRectangle.BackColor = Color.DarkOrange;
            inventoryRectangle.BorderColor = Color.DarkOrange;
        }

        private void inventoryButton_MouseLeave(object sender, EventArgs e)
        {
            inventoryRectangle.BackColor = Color.DimGray;
            inventoryRectangle.BorderColor = Color.DimGray;
        }

        private void userButton_MouseMove(object sender, MouseEventArgs e)
        {
            usersRectangle.BackColor = Color.DarkOrange;
            usersRectangle.BorderColor = Color.DarkOrange;
        }

        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            usersRectangle.BackColor = Color.DimGray;
            usersRectangle.BorderColor = Color.DimGray;
        }

        private void reportsButton_MouseMove(object sender, MouseEventArgs e)
        {
            reportsRectangle.BackColor = Color.DarkOrange;
            reportsRectangle.BorderColor = Color.DarkOrange;
        }

        private void reportsButton_MouseLeave(object sender, EventArgs e)
        {
            reportsRectangle.BackColor = Color.DimGray;
            reportsRectangle.BorderColor = Color.DimGray;
        }
    }
}
