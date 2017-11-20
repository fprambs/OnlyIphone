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

        private bool mouseDown;
        private Point lastLocation;
        
    
        private void Main_Windows1_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
            welcomeLabel.Text = "Bienvenido " + send_username;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {

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

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void providersButton_Click(object sender, EventArgs e)
        {
            if (!containerPanel.Controls.Contains(providers.Instance))
            {
                containerPanel.Controls.Add(providers.Instance);
                providers.Instance.Dock = DockStyle.Fill;
                providers.Instance.BringToFront();
            }
            else
            {
                providers.Instance.BringToFront();
            }
        }
    }
}
