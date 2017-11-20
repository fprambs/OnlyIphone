namespace OnlyIphone
{
    partial class addProviders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProviders));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.namecheckPictureBox = new System.Windows.Forms.PictureBox();
            this.phonecheckPictureBox = new System.Windows.Forms.PictureBox();
            this.emailcheckPictureBox = new System.Windows.Forms.PictureBox();
            this.addresscheckPictureBox = new System.Windows.Forms.PictureBox();
            this.citycheckPictureBox = new System.Windows.Forms.PictureBox();
            this.namecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.phonecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.emailcrossPictureBox = new System.Windows.Forms.PictureBox();
            this.addresscrossPictureBox = new System.Windows.Forms.PictureBox();
            this.citycrossPictureBox = new System.Windows.Forms.PictureBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.namecheckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonecheckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailcheckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresscheckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citycheckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namecrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonecrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailcrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresscrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citycrossPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DimGray;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(284, 30);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nombre";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 90);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(64, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Telefono";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(12, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(43, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(12, 150);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Dirección";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(12, 180);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(51, 13);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "Ciudad";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(87, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(87, 87);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(160, 20);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            this.phoneTextBox.Leave += new System.EventHandler(this.phoneTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(87, 117);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 20);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(86, 147);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(160, 20);
            this.addressTextBox.TabIndex = 9;
            this.addressTextBox.Leave += new System.EventHandler(this.addressTextBox_Leave);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(86, 177);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(160, 20);
            this.cityTextBox.TabIndex = 10;
            this.cityTextBox.Leave += new System.EventHandler(this.cityTextBox_Leave);
            // 
            // namecheckPictureBox
            // 
            this.namecheckPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("namecheckPictureBox.Image")));
            this.namecheckPictureBox.Location = new System.Drawing.Point(252, 57);
            this.namecheckPictureBox.Name = "namecheckPictureBox";
            this.namecheckPictureBox.Size = new System.Drawing.Size(20, 20);
            this.namecheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namecheckPictureBox.TabIndex = 11;
            this.namecheckPictureBox.TabStop = false;
            this.namecheckPictureBox.Visible = false;
            // 
            // phonecheckPictureBox
            // 
            this.phonecheckPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("phonecheckPictureBox.Image")));
            this.phonecheckPictureBox.Location = new System.Drawing.Point(252, 87);
            this.phonecheckPictureBox.Name = "phonecheckPictureBox";
            this.phonecheckPictureBox.Size = new System.Drawing.Size(20, 20);
            this.phonecheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phonecheckPictureBox.TabIndex = 12;
            this.phonecheckPictureBox.TabStop = false;
            this.phonecheckPictureBox.Visible = false;
            // 
            // emailcheckPictureBox
            // 
            this.emailcheckPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emailcheckPictureBox.Image")));
            this.emailcheckPictureBox.Location = new System.Drawing.Point(252, 117);
            this.emailcheckPictureBox.Name = "emailcheckPictureBox";
            this.emailcheckPictureBox.Size = new System.Drawing.Size(20, 20);
            this.emailcheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailcheckPictureBox.TabIndex = 13;
            this.emailcheckPictureBox.TabStop = false;
            this.emailcheckPictureBox.Visible = false;
            // 
            // addresscheckPictureBox
            // 
            this.addresscheckPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addresscheckPictureBox.Image")));
            this.addresscheckPictureBox.Location = new System.Drawing.Point(252, 147);
            this.addresscheckPictureBox.Name = "addresscheckPictureBox";
            this.addresscheckPictureBox.Size = new System.Drawing.Size(20, 20);
            this.addresscheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addresscheckPictureBox.TabIndex = 14;
            this.addresscheckPictureBox.TabStop = false;
            this.addresscheckPictureBox.Visible = false;
            // 
            // citycheckPictureBox
            // 
            this.citycheckPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("citycheckPictureBox.Image")));
            this.citycheckPictureBox.Location = new System.Drawing.Point(252, 177);
            this.citycheckPictureBox.Name = "citycheckPictureBox";
            this.citycheckPictureBox.Size = new System.Drawing.Size(20, 20);
            this.citycheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.citycheckPictureBox.TabIndex = 15;
            this.citycheckPictureBox.TabStop = false;
            this.citycheckPictureBox.Visible = false;
            // 
            // namecrossPictureBox
            // 
            this.namecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("namecrossPictureBox.Image")));
            this.namecrossPictureBox.Location = new System.Drawing.Point(252, 57);
            this.namecrossPictureBox.Name = "namecrossPictureBox";
            this.namecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.namecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namecrossPictureBox.TabIndex = 16;
            this.namecrossPictureBox.TabStop = false;
            this.namecrossPictureBox.Visible = false;
            // 
            // phonecrossPictureBox
            // 
            this.phonecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("phonecrossPictureBox.Image")));
            this.phonecrossPictureBox.Location = new System.Drawing.Point(252, 87);
            this.phonecrossPictureBox.Name = "phonecrossPictureBox";
            this.phonecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.phonecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phonecrossPictureBox.TabIndex = 17;
            this.phonecrossPictureBox.TabStop = false;
            this.phonecrossPictureBox.Visible = false;
            // 
            // emailcrossPictureBox
            // 
            this.emailcrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emailcrossPictureBox.Image")));
            this.emailcrossPictureBox.Location = new System.Drawing.Point(252, 117);
            this.emailcrossPictureBox.Name = "emailcrossPictureBox";
            this.emailcrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.emailcrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailcrossPictureBox.TabIndex = 18;
            this.emailcrossPictureBox.TabStop = false;
            this.emailcrossPictureBox.Visible = false;
            // 
            // addresscrossPictureBox
            // 
            this.addresscrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addresscrossPictureBox.Image")));
            this.addresscrossPictureBox.Location = new System.Drawing.Point(252, 147);
            this.addresscrossPictureBox.Name = "addresscrossPictureBox";
            this.addresscrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.addresscrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addresscrossPictureBox.TabIndex = 19;
            this.addresscrossPictureBox.TabStop = false;
            this.addresscrossPictureBox.Visible = false;
            // 
            // citycrossPictureBox
            // 
            this.citycrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("citycrossPictureBox.Image")));
            this.citycrossPictureBox.Location = new System.Drawing.Point(252, 177);
            this.citycrossPictureBox.Name = "citycrossPictureBox";
            this.citycrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.citycrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.citycrossPictureBox.TabIndex = 20;
            this.citycrossPictureBox.TabStop = false;
            this.citycrossPictureBox.Visible = false;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(171, 217);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 21;
            this.acceptButton.Text = "Agregar";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(86, 217);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.citycrossPictureBox);
            this.Controls.Add(this.addresscrossPictureBox);
            this.Controls.Add(this.emailcrossPictureBox);
            this.Controls.Add(this.phonecrossPictureBox);
            this.Controls.Add(this.namecrossPictureBox);
            this.Controls.Add(this.citycheckPictureBox);
            this.Controls.Add(this.addresscheckPictureBox);
            this.Controls.Add(this.emailcheckPictureBox);
            this.Controls.Add(this.phonecheckPictureBox);
            this.Controls.Add(this.namecheckPictureBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addProviders";
            this.Text = "addProviders";
            ((System.ComponentModel.ISupportInitialize)(this.namecheckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonecheckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailcheckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresscheckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citycheckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailcrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresscrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citycrossPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.PictureBox namecheckPictureBox;
        private System.Windows.Forms.PictureBox phonecheckPictureBox;
        private System.Windows.Forms.PictureBox emailcheckPictureBox;
        private System.Windows.Forms.PictureBox addresscheckPictureBox;
        private System.Windows.Forms.PictureBox citycheckPictureBox;
        private System.Windows.Forms.PictureBox namecrossPictureBox;
        private System.Windows.Forms.PictureBox phonecrossPictureBox;
        private System.Windows.Forms.PictureBox emailcrossPictureBox;
        private System.Windows.Forms.PictureBox addresscrossPictureBox;
        private System.Windows.Forms.PictureBox citycrossPictureBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}