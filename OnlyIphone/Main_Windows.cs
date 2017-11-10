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
        public Main_Windows()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Windows1_Load(object sender, EventArgs e)
        {

        }

        private void Main_Windows1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_Windows1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void Main_Windows1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            toggle(sender);

            if (!containerPanel.Controls.Contains(main.Instance))
            {
                containerPanel.Controls.Add(main.Instance);
                main.Instance.Dock = DockStyle.Fill;
                main.Instance.BringToFront();
            }
            else
            {
                main.Instance.BringToFront();
            }
        }



        void toggle(object sender)
        {
            mainButton.selected = false;
            cashboxButton.selected = false;
            clientButton.selected = false;
            salesButton.selected = false;
            productsButton.selected = false;
            inventoryButton.selected = false;
            usersButton.selected = false;
            reportsButton.selected = false;

            mainButton.Normalcolor = Color.OrangeRed;
            cashboxButton.Normalcolor = Color.OrangeRed;
            clientButton.Normalcolor = Color.OrangeRed;
            salesButton.Normalcolor = Color.OrangeRed;
            productsButton.Normalcolor = Color.OrangeRed;
            inventoryButton.Normalcolor = Color.OrangeRed;
            usersButton.Normalcolor = Color.OrangeRed;
            reportsButton.Normalcolor = Color.OrangeRed;


            ((Bunifu.Framework.UI.BunifuFlatButton)sender).selected = true;
            ((Bunifu.Framework.UI.BunifuFlatButton)sender).Normalcolor = Color.DimGray;
        }

        private void cashboxButton_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

    }
}
