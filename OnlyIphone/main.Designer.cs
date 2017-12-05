namespace OnlyIphone
{
    partial class main
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dayNumerLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dayNameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.rectangleShape8 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape9 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape13 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape11 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape15 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape14 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape12 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape10 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.totalcountLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.salesNumberLabel = new System.Windows.Forms.Label();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.clientsNumberLabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.ordersNumberLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productsNumberLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dayNumerLabel
            // 
            this.dayNumerLabel.AutoSize = true;
            this.dayNumerLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dayNumerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayNumerLabel.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumerLabel.ForeColor = System.Drawing.Color.Black;
            this.dayNumerLabel.Location = new System.Drawing.Point(28, 29);
            this.dayNumerLabel.Name = "dayNumerLabel";
            this.dayNumerLabel.Size = new System.Drawing.Size(186, 116);
            this.dayNumerLabel.TabIndex = 22;
            this.dayNumerLabel.Text = "31";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.monthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ForeColor = System.Drawing.Color.Black;
            this.monthLabel.Location = new System.Drawing.Point(187, 78);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(95, 23);
            this.monthLabel.TabIndex = 27;
            this.monthLabel.Text = "Octubre";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.yearLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.Black;
            this.yearLabel.Location = new System.Drawing.Point(188, 106);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(66, 23);
            this.yearLabel.TabIndex = 26;
            this.yearLabel.Text = "2017";
            // 
            // dayNameLabel
            // 
            this.dayNameLabel.AutoSize = true;
            this.dayNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dayNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNameLabel.ForeColor = System.Drawing.Color.Black;
            this.dayNameLabel.Location = new System.Drawing.Point(188, 51);
            this.dayNameLabel.Name = "dayNameLabel";
            this.dayNameLabel.Size = new System.Drawing.Size(83, 23);
            this.dayNameLabel.TabIndex = 25;
            this.dayNameLabel.Text = "Martes";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.timeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(318, 51);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 78);
            this.timeLabel.TabIndex = 28;
            // 
            // rectangleShape8
            // 
            this.rectangleShape8.BackColor = System.Drawing.Color.Crimson;
            this.rectangleShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape8.BorderColor = System.Drawing.Color.Crimson;
            this.rectangleShape8.Location = new System.Drawing.Point(37, 188);
            this.rectangleShape8.Name = "rectangleShape8";
            this.rectangleShape8.Size = new System.Drawing.Size(686, 116);
            // 
            // rectangleShape9
            // 
            this.rectangleShape9.BackColor = System.Drawing.Color.IndianRed;
            this.rectangleShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape9.BorderColor = System.Drawing.Color.IndianRed;
            this.rectangleShape9.Location = new System.Drawing.Point(37, 294);
            this.rectangleShape9.Name = "rectangleShape9";
            this.rectangleShape9.Size = new System.Drawing.Size(686, 10);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape13,
            this.rectangleShape11,
            this.rectangleShape15,
            this.rectangleShape14,
            this.rectangleShape12,
            this.rectangleShape10,
            this.rectangleShape9,
            this.rectangleShape8});
            this.shapeContainer1.Size = new System.Drawing.Size(760, 492);
            this.shapeContainer1.TabIndex = 29;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape13
            // 
            this.rectangleShape13.BackColor = System.Drawing.Color.DarkViolet;
            this.rectangleShape13.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape13.BorderColor = System.Drawing.Color.DarkViolet;
            this.rectangleShape13.Location = new System.Drawing.Point(535, 433);
            this.rectangleShape13.Name = "rectangleShape13";
            this.rectangleShape13.Size = new System.Drawing.Size(187, 10);
            // 
            // rectangleShape11
            // 
            this.rectangleShape11.BackColor = System.Drawing.Color.Purple;
            this.rectangleShape11.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape11.BorderColor = System.Drawing.Color.Purple;
            this.rectangleShape11.Location = new System.Drawing.Point(535, 347);
            this.rectangleShape11.Name = "rectangleShape11";
            this.rectangleShape11.Size = new System.Drawing.Size(187, 96);
            // 
            // rectangleShape15
            // 
            this.rectangleShape15.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.rectangleShape15.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape15.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rectangleShape15.Location = new System.Drawing.Point(288, 433);
            this.rectangleShape15.Name = "rectangleShape15";
            this.rectangleShape15.Size = new System.Drawing.Size(187, 10);
            // 
            // rectangleShape14
            // 
            this.rectangleShape14.BackColor = System.Drawing.Color.Gold;
            this.rectangleShape14.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape14.BorderColor = System.Drawing.Color.Gold;
            this.rectangleShape14.Location = new System.Drawing.Point(288, 347);
            this.rectangleShape14.Name = "rectangleShape14";
            this.rectangleShape14.Size = new System.Drawing.Size(187, 96);
            // 
            // rectangleShape12
            // 
            this.rectangleShape12.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.rectangleShape12.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape12.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.rectangleShape12.Location = new System.Drawing.Point(37, 433);
            this.rectangleShape12.Name = "rectangleShape12";
            this.rectangleShape12.Size = new System.Drawing.Size(187, 10);
            // 
            // rectangleShape10
            // 
            this.rectangleShape10.BackColor = System.Drawing.Color.YellowGreen;
            this.rectangleShape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape10.BorderColor = System.Drawing.Color.YellowGreen;
            this.rectangleShape10.Location = new System.Drawing.Point(37, 347);
            this.rectangleShape10.Name = "rectangleShape10";
            this.rectangleShape10.Size = new System.Drawing.Size(187, 96);
            // 
            // totalcountLabel
            // 
            this.totalcountLabel.AutoSize = true;
            this.totalcountLabel.BackColor = System.Drawing.Color.Crimson;
            this.totalcountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalcountLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalcountLabel.Location = new System.Drawing.Point(310, 202);
            this.totalcountLabel.Name = "totalcountLabel";
            this.totalcountLabel.Size = new System.Drawing.Size(147, 78);
            this.totalcountLabel.TabIndex = 32;
            this.totalcountLabel.Text = "$ 0";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.BackColor = System.Drawing.Color.Crimson;
            this.salesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.salesLabel.Location = new System.Drawing.Point(62, 262);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(105, 29);
            this.salesLabel.TabIndex = 31;
            this.salesLabel.Text = "Ventas";
            // 
            // salesNumberLabel
            // 
            this.salesNumberLabel.AutoSize = true;
            this.salesNumberLabel.BackColor = System.Drawing.Color.Crimson;
            this.salesNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesNumberLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.salesNumberLabel.Location = new System.Drawing.Point(54, 192);
            this.salesNumberLabel.Name = "salesNumberLabel";
            this.salesNumberLabel.Size = new System.Drawing.Size(79, 78);
            this.salesNumberLabel.TabIndex = 30;
            this.salesNumberLabel.Text = "0";
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.BackColor = System.Drawing.Color.Gold;
            this.clientsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.clientsLabel.Location = new System.Drawing.Point(306, 410);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(77, 18);
            this.clientsLabel.TabIndex = 42;
            this.clientsLabel.Text = "Clientes";
            // 
            // clientsNumberLabel
            // 
            this.clientsNumberLabel.AutoSize = true;
            this.clientsNumberLabel.BackColor = System.Drawing.Color.Gold;
            this.clientsNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsNumberLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.clientsNumberLabel.Location = new System.Drawing.Point(303, 361);
            this.clientsNumberLabel.Name = "clientsNumberLabel";
            this.clientsNumberLabel.Size = new System.Drawing.Size(43, 42);
            this.clientsNumberLabel.TabIndex = 41;
            this.clientsNumberLabel.Text = "0";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Purple;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(652, 361);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.BackColor = System.Drawing.Color.Purple;
            this.ordersLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ordersLabel.Location = new System.Drawing.Point(550, 409);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(83, 18);
            this.ordersLabel.TabIndex = 39;
            this.ordersLabel.Text = "Ordenes";
            // 
            // ordersNumberLabel
            // 
            this.ordersNumberLabel.AutoSize = true;
            this.ordersNumberLabel.BackColor = System.Drawing.Color.Purple;
            this.ordersNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersNumberLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ordersNumberLabel.Location = new System.Drawing.Point(547, 353);
            this.ordersNumberLabel.Name = "ordersNumberLabel";
            this.ordersNumberLabel.Size = new System.Drawing.Size(43, 42);
            this.ordersNumberLabel.TabIndex = 38;
            this.ordersNumberLabel.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(151, 363);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.productsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.productsLabel.Location = new System.Drawing.Point(49, 410);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(97, 18);
            this.productsLabel.TabIndex = 36;
            this.productsLabel.Text = "Productos";
            // 
            // productsNumberLabel
            // 
            this.productsNumberLabel.AutoSize = true;
            this.productsNumberLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.productsNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsNumberLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.productsNumberLabel.Location = new System.Drawing.Point(46, 361);
            this.productsNumberLabel.Name = "productsNumberLabel";
            this.productsNumberLabel.Size = new System.Drawing.Size(43, 42);
            this.productsNumberLabel.TabIndex = 35;
            this.productsNumberLabel.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(398, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.clientsNumberLabel);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.ordersNumberLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsNumberLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.totalcountLabel);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.salesNumberLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayNameLabel);
            this.Controls.Add(this.dayNumerLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "main";
            this.Size = new System.Drawing.Size(760, 492);
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dayNumerLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label dayNameLabel;
        private System.Windows.Forms.Label timeLabel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape8;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape9;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape13;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape11;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape15;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape14;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape12;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape10;
        private System.Windows.Forms.Label totalcountLabel;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label salesNumberLabel;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Label clientsNumberLabel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label ordersNumberLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label productsNumberLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
