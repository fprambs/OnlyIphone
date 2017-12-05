namespace OnlyIphone
{
    partial class providers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(providers));
            this.button1 = new System.Windows.Forms.Button();
            this.providerdataGridView = new System.Windows.Forms.DataGridView();
            this.dayNameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.providerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(42, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // providerdataGridView
            // 
            this.providerdataGridView.AllowUserToAddRows = false;
            this.providerdataGridView.AllowUserToDeleteRows = false;
            this.providerdataGridView.AllowUserToOrderColumns = true;
            this.providerdataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.providerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providerdataGridView.Location = new System.Drawing.Point(33, 81);
            this.providerdataGridView.Name = "providerdataGridView";
            this.providerdataGridView.ReadOnly = true;
            this.providerdataGridView.Size = new System.Drawing.Size(493, 150);
            this.providerdataGridView.TabIndex = 1;
            // 
            // dayNameLabel
            // 
            this.dayNameLabel.AutoSize = true;
            this.dayNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dayNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNameLabel.ForeColor = System.Drawing.Color.Black;
            this.dayNameLabel.Location = new System.Drawing.Point(29, 43);
            this.dayNameLabel.Name = "dayNameLabel";
            this.dayNameLabel.Size = new System.Drawing.Size(261, 23);
            this.dayNameLabel.TabIndex = 26;
            this.dayNameLabel.Text = "Listado de Proveedores";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(451, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 27;
            this.button2.Text = "Actualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dayNameLabel);
            this.Controls.Add(this.providerdataGridView);
            this.Controls.Add(this.button1);
            this.Name = "providers";
            this.Size = new System.Drawing.Size(710, 492);
            this.Load += new System.EventHandler(this.providers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView providerdataGridView;
        private System.Windows.Forms.Label dayNameLabel;
        private System.Windows.Forms.Button button2;
    }
}
