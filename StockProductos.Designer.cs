namespace EF_FP_G12
{
    partial class StockProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProductos));
            this.btnsalirstock = new System.Windows.Forms.Button();
            this.dgvstock = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lbltitulostock = new System.Windows.Forms.Label();
            this.lblstockcat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalirstock
            // 
            this.btnsalirstock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirstock.Image = ((System.Drawing.Image)(resources.GetObject("btnsalirstock.Image")));
            this.btnsalirstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirstock.Location = new System.Drawing.Point(248, 322);
            this.btnsalirstock.Name = "btnsalirstock";
            this.btnsalirstock.Size = new System.Drawing.Size(95, 39);
            this.btnsalirstock.TabIndex = 18;
            this.btnsalirstock.Text = "Salir";
            this.btnsalirstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalirstock.UseVisualStyleBackColor = true;
            this.btnsalirstock.Click += new System.EventHandler(this.btnsalirstock_Click);
            // 
            // dgvstock
            // 
            this.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstock.Location = new System.Drawing.Point(27, 119);
            this.dgvstock.Name = "dgvstock";
            this.dgvstock.ReadOnly = true;
            this.dgvstock.Size = new System.Drawing.Size(543, 182);
            this.dgvstock.TabIndex = 17;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(163, 79);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(385, 20);
            this.txtbuscar.TabIndex = 16;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtstockcat_TextChanged);
            // 
            // lbltitulostock
            // 
            this.lbltitulostock.AutoSize = true;
            this.lbltitulostock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulostock.Location = new System.Drawing.Point(175, 23);
            this.lbltitulostock.Name = "lbltitulostock";
            this.lbltitulostock.Size = new System.Drawing.Size(272, 32);
            this.lbltitulostock.TabIndex = 15;
            this.lbltitulostock.Text = "Stock de Productos";
            this.lbltitulostock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblstockcat
            // 
            this.lblstockcat.AutoSize = true;
            this.lblstockcat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockcat.Location = new System.Drawing.Point(54, 82);
            this.lblstockcat.Name = "lblstockcat";
            this.lblstockcat.Size = new System.Drawing.Size(109, 14);
            this.lblstockcat.TabIndex = 14;
            this.lblstockcat.Text = "Buscar Producto:";
            // 
            // StockProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 391);
            this.Controls.Add(this.btnsalirstock);
            this.Controls.Add(this.dgvstock);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lbltitulostock);
            this.Controls.Add(this.lblstockcat);
            this.Name = "StockProductos";
            this.Text = "StockProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalirstock;
        private System.Windows.Forms.DataGridView dgvstock;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbltitulostock;
        private System.Windows.Forms.Label lblstockcat;
    }
}