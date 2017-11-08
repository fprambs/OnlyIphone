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
    /// <summary>
    /// Login window application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Login : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        bool validate_username = false;
        bool validate_password = false;

        /// <summary>
        /// Handles the Click event of the enterButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void enterButton_Click(object sender, EventArgs e)
        {
            if(validate_username == true && validate_password == true)
            {
                string username = usernameTextBox.Text.Trim();
                string password = passwordTextBox.Text.Trim();

                User user = new User();

                user = Database.getUser(username);

                try
                {
                    if (Utils.Decrypt(user.Password) == password)
                    {
                        MessageBox.Show("Ingreso Exitoso, bienvenido "+user.Username, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main_Windows mr = new Main_Windows();
                        mr.send_username = user.Username;
                        mr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch
                {
                    MessageBox.Show("Usuario incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                MessageBox.Show("Error al ingresar, rellene todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        /// <summary>
        /// Handles the Leave event of the usernameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim().Length == 0)
            {
                validate_username = false;
            }
            else
            {
                validate_username = true;
            }
        }

        /// <summary>
        /// Handles the Leave event of the passwordTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Trim().Length == 0)
            {
                validate_password = false;
            }
            else
            {
                validate_password = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the cancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
