namespace OnlyIphone
{
    partial class Main_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Windows));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.providersButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportsButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.cashboxButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DimGray;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 42);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.menuPanel.Controls.Add(this.providersButton);
            this.menuPanel.Controls.Add(this.mainButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Controls.Add(this.reportsButton);
            this.menuPanel.Controls.Add(this.usersButton);
            this.menuPanel.Controls.Add(this.cashboxButton);
            this.menuPanel.Controls.Add(this.inventoryButton);
            this.menuPanel.Controls.Add(this.productsButton);
            this.menuPanel.Controls.Add(this.salesButton);
            this.menuPanel.Controls.Add(this.clientsButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 42);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(190, 492);
            this.menuPanel.TabIndex = 2;
            // 
            // providersButton
            // 
            this.providersButton.BackColor = System.Drawing.Color.OrangeRed;
            this.providersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.providersButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.providersButton.FlatAppearance.BorderSize = 0;
            this.providersButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.providersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.providersButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providersButton.ForeColor = System.Drawing.Color.White;
            this.providersButton.Image = ((System.Drawing.Image)(resources.GetObject("providersButton.Image")));
            this.providersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.providersButton.Location = new System.Drawing.Point(1, 415);
            this.providersButton.Name = "providersButton";
            this.providersButton.Size = new System.Drawing.Size(190, 37);
            this.providersButton.TabIndex = 8;
            this.providersButton.Text = "Proveedores";
            this.providersButton.UseVisualStyleBackColor = false;
            this.providersButton.Click += new System.EventHandler(this.providersButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.OrangeRed;
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.mainButton.FlatAppearance.BorderSize = 0;
            this.mainButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.ForeColor = System.Drawing.Color.White;
            this.mainButton.Image = ((System.Drawing.Image)(resources.GetObject("mainButton.Image")));
            this.mainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButton.Location = new System.Drawing.Point(0, 149);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(190, 37);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Principal";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.welcomeLabel);
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(190, 149);
            this.logoPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(24, 127);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(80, 14);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.OrangeRed;
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.Color.White;
            this.reportsButton.Image = ((System.Drawing.Image)(resources.GetObject("reportsButton.Image")));
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(0, 453);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(190, 37);
            this.reportsButton.TabIndex = 7;
            this.reportsButton.Text = "Reportes";
            this.reportsButton.UseVisualStyleBackColor = false;
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.OrangeRed;
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Image = ((System.Drawing.Image)(resources.GetObject("usersButton.Image")));
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Location = new System.Drawing.Point(0, 377);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(190, 37);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "Usuarios";
            this.usersButton.UseVisualStyleBackColor = false;
            // 
            // cashboxButton
            // 
            this.cashboxButton.BackColor = System.Drawing.Color.OrangeRed;
            this.cashboxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashboxButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.cashboxButton.FlatAppearance.BorderSize = 0;
            this.cashboxButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cashboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashboxButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashboxButton.ForeColor = System.Drawing.Color.White;
            this.cashboxButton.Image = ((System.Drawing.Image)(resources.GetObject("cashboxButton.Image")));
            this.cashboxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashboxButton.Location = new System.Drawing.Point(0, 187);
            this.cashboxButton.Name = "cashboxButton";
            this.cashboxButton.Size = new System.Drawing.Size(190, 37);
            this.cashboxButton.TabIndex = 1;
            this.cashboxButton.Text = "Caja";
            this.cashboxButton.UseVisualStyleBackColor = false;
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.OrangeRed;
            this.inventoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("inventoryButton.Image")));
            this.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.Location = new System.Drawing.Point(0, 339);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(190, 37);
            this.inventoryButton.TabIndex = 5;
            this.inventoryButton.Text = "Inventario";
            this.inventoryButton.UseVisualStyleBackColor = false;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.OrangeRed;
            this.productsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.Color.White;
            this.productsButton.Image = ((System.Drawing.Image)(resources.GetObject("productsButton.Image")));
            this.productsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.Location = new System.Drawing.Point(0, 301);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(190, 37);
            this.productsButton.TabIndex = 4;
            this.productsButton.Text = "Productos";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.OrangeRed;
            this.salesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.White;
            this.salesButton.Image = ((System.Drawing.Image)(resources.GetObject("salesButton.Image")));
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(0, 263);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(190, 37);
            this.salesButton.TabIndex = 3;
            this.salesButton.Text = "Ventas";
            this.salesButton.UseVisualStyleBackColor = false;
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.Color.OrangeRed;
            this.clientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.clientsButton.FlatAppearance.BorderSize = 0;
            this.clientsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.Color.White;
            this.clientsButton.Image = ((System.Drawing.Image)(resources.GetObject("clientsButton.Image")));
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.Location = new System.Drawing.Point(0, 225);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(190, 37);
            this.clientsButton.TabIndex = 2;
            this.clientsButton.Text = "Clientes";
            this.clientsButton.UseVisualStyleBackColor = false;
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(190, 42);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(710, 492);
            this.containerPanel.TabIndex = 3;
            // 
            // Main_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Windows";
            this.Text = "Main_Windows1";
            this.Load += new System.EventHandler(this.Main_Windows1_Load);
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button cashboxButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button providersButton;
        private System.Windows.Forms.Panel containerPanel;
    }
}