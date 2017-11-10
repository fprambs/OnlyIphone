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
            this.reportsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.usersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inventoryButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.productsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.salesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clientButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cashboxButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mainButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
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
            this.menuPanel.Controls.Add(this.reportsButton);
            this.menuPanel.Controls.Add(this.usersButton);
            this.menuPanel.Controls.Add(this.inventoryButton);
            this.menuPanel.Controls.Add(this.productsButton);
            this.menuPanel.Controls.Add(this.salesButton);
            this.menuPanel.Controls.Add(this.clientButton);
            this.menuPanel.Controls.Add(this.cashboxButton);
            this.menuPanel.Controls.Add(this.mainButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 42);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(190, 492);
            this.menuPanel.TabIndex = 2;
            // 
            // reportsButton
            // 
            this.reportsButton.Activecolor = System.Drawing.Color.DimGray;
            this.reportsButton.BackColor = System.Drawing.Color.OrangeRed;
            this.reportsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportsButton.BorderRadius = 0;
            this.reportsButton.ButtonText = "Reportes";
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.DisabledColor = System.Drawing.Color.Gray;
            this.reportsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.reportsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("reportsButton.Iconimage")));
            this.reportsButton.Iconimage_right = null;
            this.reportsButton.Iconimage_right_Selected = null;
            this.reportsButton.Iconimage_Selected = null;
            this.reportsButton.IconMarginLeft = 15;
            this.reportsButton.IconMarginRight = 0;
            this.reportsButton.IconRightVisible = true;
            this.reportsButton.IconRightZoom = 0D;
            this.reportsButton.IconVisible = true;
            this.reportsButton.IconZoom = 38D;
            this.reportsButton.IsTab = false;
            this.reportsButton.Location = new System.Drawing.Point(0, 451);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.reportsButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.reportsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.reportsButton.selected = false;
            this.reportsButton.Size = new System.Drawing.Size(190, 37);
            this.reportsButton.TabIndex = 10;
            this.reportsButton.Text = "Reportes";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportsButton.Textcolor = System.Drawing.Color.White;
            this.reportsButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Activecolor = System.Drawing.Color.DimGray;
            this.usersButton.BackColor = System.Drawing.Color.OrangeRed;
            this.usersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usersButton.BorderRadius = 0;
            this.usersButton.ButtonText = "Usuarios";
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.DisabledColor = System.Drawing.Color.Gray;
            this.usersButton.Iconcolor = System.Drawing.Color.Transparent;
            this.usersButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("usersButton.Iconimage")));
            this.usersButton.Iconimage_right = null;
            this.usersButton.Iconimage_right_Selected = null;
            this.usersButton.Iconimage_Selected = null;
            this.usersButton.IconMarginLeft = 15;
            this.usersButton.IconMarginRight = 0;
            this.usersButton.IconRightVisible = true;
            this.usersButton.IconRightZoom = 0D;
            this.usersButton.IconVisible = true;
            this.usersButton.IconZoom = 38D;
            this.usersButton.IsTab = false;
            this.usersButton.Location = new System.Drawing.Point(0, 409);
            this.usersButton.Name = "usersButton";
            this.usersButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.usersButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.usersButton.OnHoverTextColor = System.Drawing.Color.White;
            this.usersButton.selected = false;
            this.usersButton.Size = new System.Drawing.Size(190, 37);
            this.usersButton.TabIndex = 9;
            this.usersButton.Text = "Usuarios";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usersButton.Textcolor = System.Drawing.Color.White;
            this.usersButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Activecolor = System.Drawing.Color.DimGray;
            this.inventoryButton.BackColor = System.Drawing.Color.OrangeRed;
            this.inventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryButton.BorderRadius = 0;
            this.inventoryButton.ButtonText = "Inventario";
            this.inventoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryButton.DisabledColor = System.Drawing.Color.Gray;
            this.inventoryButton.Iconcolor = System.Drawing.Color.Transparent;
            this.inventoryButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("inventoryButton.Iconimage")));
            this.inventoryButton.Iconimage_right = null;
            this.inventoryButton.Iconimage_right_Selected = null;
            this.inventoryButton.Iconimage_Selected = null;
            this.inventoryButton.IconMarginLeft = 15;
            this.inventoryButton.IconMarginRight = 0;
            this.inventoryButton.IconRightVisible = true;
            this.inventoryButton.IconRightZoom = 0D;
            this.inventoryButton.IconVisible = true;
            this.inventoryButton.IconZoom = 38D;
            this.inventoryButton.IsTab = false;
            this.inventoryButton.Location = new System.Drawing.Point(0, 366);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.inventoryButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.inventoryButton.OnHoverTextColor = System.Drawing.Color.White;
            this.inventoryButton.selected = false;
            this.inventoryButton.Size = new System.Drawing.Size(190, 37);
            this.inventoryButton.TabIndex = 8;
            this.inventoryButton.Text = "Inventario";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inventoryButton.Textcolor = System.Drawing.Color.White;
            this.inventoryButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.Activecolor = System.Drawing.Color.DimGray;
            this.productsButton.BackColor = System.Drawing.Color.OrangeRed;
            this.productsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productsButton.BorderRadius = 0;
            this.productsButton.ButtonText = "Productos";
            this.productsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsButton.DisabledColor = System.Drawing.Color.Gray;
            this.productsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.productsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("productsButton.Iconimage")));
            this.productsButton.Iconimage_right = null;
            this.productsButton.Iconimage_right_Selected = null;
            this.productsButton.Iconimage_Selected = null;
            this.productsButton.IconMarginLeft = 15;
            this.productsButton.IconMarginRight = 0;
            this.productsButton.IconRightVisible = true;
            this.productsButton.IconRightZoom = 0D;
            this.productsButton.IconVisible = true;
            this.productsButton.IconZoom = 38D;
            this.productsButton.IsTab = false;
            this.productsButton.Location = new System.Drawing.Point(0, 323);
            this.productsButton.Name = "productsButton";
            this.productsButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.productsButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.productsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.productsButton.selected = false;
            this.productsButton.Size = new System.Drawing.Size(190, 37);
            this.productsButton.TabIndex = 7;
            this.productsButton.Text = "Productos";
            this.productsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productsButton.Textcolor = System.Drawing.Color.White;
            this.productsButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Activecolor = System.Drawing.Color.DimGray;
            this.salesButton.BackColor = System.Drawing.Color.OrangeRed;
            this.salesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salesButton.BorderRadius = 0;
            this.salesButton.ButtonText = "Ventas";
            this.salesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesButton.DisabledColor = System.Drawing.Color.Gray;
            this.salesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.salesButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("salesButton.Iconimage")));
            this.salesButton.Iconimage_right = null;
            this.salesButton.Iconimage_right_Selected = null;
            this.salesButton.Iconimage_Selected = null;
            this.salesButton.IconMarginLeft = 15;
            this.salesButton.IconMarginRight = 0;
            this.salesButton.IconRightVisible = true;
            this.salesButton.IconRightZoom = 0D;
            this.salesButton.IconVisible = true;
            this.salesButton.IconZoom = 38D;
            this.salesButton.IsTab = false;
            this.salesButton.Location = new System.Drawing.Point(0, 280);
            this.salesButton.Name = "salesButton";
            this.salesButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.salesButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.salesButton.OnHoverTextColor = System.Drawing.Color.White;
            this.salesButton.selected = false;
            this.salesButton.Size = new System.Drawing.Size(190, 37);
            this.salesButton.TabIndex = 6;
            this.salesButton.Text = "Ventas";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.salesButton.Textcolor = System.Drawing.Color.White;
            this.salesButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.Activecolor = System.Drawing.Color.DimGray;
            this.clientButton.BackColor = System.Drawing.Color.OrangeRed;
            this.clientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientButton.BorderRadius = 0;
            this.clientButton.ButtonText = "Clientes";
            this.clientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButton.DisabledColor = System.Drawing.Color.Gray;
            this.clientButton.Iconcolor = System.Drawing.Color.Transparent;
            this.clientButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("clientButton.Iconimage")));
            this.clientButton.Iconimage_right = null;
            this.clientButton.Iconimage_right_Selected = null;
            this.clientButton.Iconimage_Selected = null;
            this.clientButton.IconMarginLeft = 15;
            this.clientButton.IconMarginRight = 0;
            this.clientButton.IconRightVisible = true;
            this.clientButton.IconRightZoom = 0D;
            this.clientButton.IconVisible = true;
            this.clientButton.IconZoom = 38D;
            this.clientButton.IsTab = false;
            this.clientButton.Location = new System.Drawing.Point(0, 237);
            this.clientButton.Name = "clientButton";
            this.clientButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.clientButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.clientButton.OnHoverTextColor = System.Drawing.Color.White;
            this.clientButton.selected = false;
            this.clientButton.Size = new System.Drawing.Size(190, 37);
            this.clientButton.TabIndex = 5;
            this.clientButton.Text = "Clientes";
            this.clientButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clientButton.Textcolor = System.Drawing.Color.White;
            this.clientButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // cashboxButton
            // 
            this.cashboxButton.Activecolor = System.Drawing.Color.DimGray;
            this.cashboxButton.BackColor = System.Drawing.Color.OrangeRed;
            this.cashboxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cashboxButton.BorderRadius = 0;
            this.cashboxButton.ButtonText = "Caja";
            this.cashboxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashboxButton.DisabledColor = System.Drawing.Color.Gray;
            this.cashboxButton.Iconcolor = System.Drawing.Color.Transparent;
            this.cashboxButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("cashboxButton.Iconimage")));
            this.cashboxButton.Iconimage_right = null;
            this.cashboxButton.Iconimage_right_Selected = null;
            this.cashboxButton.Iconimage_Selected = null;
            this.cashboxButton.IconMarginLeft = 15;
            this.cashboxButton.IconMarginRight = 0;
            this.cashboxButton.IconRightVisible = true;
            this.cashboxButton.IconRightZoom = 0D;
            this.cashboxButton.IconVisible = true;
            this.cashboxButton.IconZoom = 38D;
            this.cashboxButton.IsTab = false;
            this.cashboxButton.Location = new System.Drawing.Point(0, 194);
            this.cashboxButton.Name = "cashboxButton";
            this.cashboxButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.cashboxButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.cashboxButton.OnHoverTextColor = System.Drawing.Color.White;
            this.cashboxButton.selected = false;
            this.cashboxButton.Size = new System.Drawing.Size(190, 37);
            this.cashboxButton.TabIndex = 4;
            this.cashboxButton.Text = "Caja";
            this.cashboxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cashboxButton.Textcolor = System.Drawing.Color.White;
            this.cashboxButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashboxButton.Click += new System.EventHandler(this.cashboxButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.Activecolor = System.Drawing.Color.Transparent;
            this.mainButton.BackColor = System.Drawing.Color.OrangeRed;
            this.mainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainButton.BorderRadius = 0;
            this.mainButton.ButtonText = "Principal";
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.DisabledColor = System.Drawing.Color.Gray;
            this.mainButton.Iconcolor = System.Drawing.Color.Transparent;
            this.mainButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("mainButton.Iconimage")));
            this.mainButton.Iconimage_right = null;
            this.mainButton.Iconimage_right_Selected = null;
            this.mainButton.Iconimage_Selected = null;
            this.mainButton.IconMarginLeft = 15;
            this.mainButton.IconMarginRight = 0;
            this.mainButton.IconRightVisible = true;
            this.mainButton.IconRightZoom = 0D;
            this.mainButton.IconVisible = true;
            this.mainButton.IconZoom = 38D;
            this.mainButton.IsTab = false;
            this.mainButton.Location = new System.Drawing.Point(0, 151);
            this.mainButton.Name = "mainButton";
            this.mainButton.Normalcolor = System.Drawing.Color.OrangeRed;
            this.mainButton.OnHovercolor = System.Drawing.Color.DimGray;
            this.mainButton.OnHoverTextColor = System.Drawing.Color.White;
            this.mainButton.selected = false;
            this.mainButton.Size = new System.Drawing.Size(190, 37);
            this.mainButton.TabIndex = 3;
            this.mainButton.Text = "Principal";
            this.mainButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainButton.Textcolor = System.Drawing.Color.White;
            this.mainButton.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(190, 42);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(710, 492);
            this.containerPanel.TabIndex = 3;
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
        private Bunifu.Framework.UI.BunifuFlatButton mainButton;
        private Bunifu.Framework.UI.BunifuFlatButton cashboxButton;
        private Bunifu.Framework.UI.BunifuFlatButton clientButton;
        private Bunifu.Framework.UI.BunifuFlatButton salesButton;
        private Bunifu.Framework.UI.BunifuFlatButton productsButton;
        private Bunifu.Framework.UI.BunifuFlatButton inventoryButton;
        private Bunifu.Framework.UI.BunifuFlatButton usersButton;
        private Bunifu.Framework.UI.BunifuFlatButton reportsButton;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}