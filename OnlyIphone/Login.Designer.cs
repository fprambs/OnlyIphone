namespace OnlyIphone
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel_username = new System.Windows.Forms.Panel();
            this.panel_password = new System.Windows.Forms.Panel();
            this.logoOnlyiPhone = new System.Windows.Forms.PictureBox();
            this.panel_username.SuspendLayout();
            this.panel_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoOnlyiPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(13, 12);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(175, 24);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(13, 12);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(175, 24);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.DarkOrange;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.enterButton.Location = new System.Drawing.Point(40, 220);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(200, 53);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Ingresar";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.Location = new System.Drawing.Point(40, 279);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 34);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel_username
            // 
            this.panel_username.BackColor = System.Drawing.SystemColors.Control;
            this.panel_username.Controls.Add(this.usernameTextBox);
            this.panel_username.Location = new System.Drawing.Point(40, 97);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(200, 45);
            this.panel_username.TabIndex = 6;
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.SystemColors.Control;
            this.panel_password.Controls.Add(this.passwordTextBox);
            this.panel_password.Location = new System.Drawing.Point(40, 148);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(200, 45);
            this.panel_password.TabIndex = 7;
            // 
            // logoOnlyiPhone
            // 
            this.logoOnlyiPhone.Image = global::OnlyIphone.Properties.Resources._18740092_1851243531863286_2642745955361773779_n;
            this.logoOnlyiPhone.Location = new System.Drawing.Point(90, 12);
            this.logoOnlyiPhone.Name = "logoOnlyiPhone";
            this.logoOnlyiPhone.Size = new System.Drawing.Size(109, 79);
            this.logoOnlyiPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoOnlyiPhone.TabIndex = 8;
            this.logoOnlyiPhone.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(280, 350);
            this.Controls.Add(this.logoOnlyiPhone);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_username);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form1";
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoOnlyiPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.PictureBox logoOnlyiPhone;
    }
}

