namespace EF_FP_G12
{
    partial class RegistroProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            this.btnstock = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lbltituloreg = new System.Windows.Forms.Label();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.lbllistprod = new System.Windows.Forms.Label();
            this.gbdatprod = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.gbdatprod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstock
            // 
            this.btnstock.AutoSize = true;
            this.btnstock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.Image = ((System.Drawing.Image)(resources.GetObject("btnstock.Image")));
            this.btnstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstock.Location = new System.Drawing.Point(566, 149);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(154, 38);
            this.btnstock.TabIndex = 23;
            this.btnstock.Text = "Stock Productos";
            this.btnstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = true;
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(566, 235);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(154, 38);
            this.btncancelar.TabIndex = 22;
            this.btncancelar.Text = "Cancelar Registro";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.AutoSize = true;
            this.btnregistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnregistrar.Image")));
            this.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrar.Location = new System.Drawing.Point(566, 103);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(154, 38);
            this.btnregistrar.TabIndex = 21;
            this.btnregistrar.Text = "Registrar Producto";
            this.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // lbltituloreg
            // 
            this.lbltituloreg.AutoSize = true;
            this.lbltituloreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloreg.Location = new System.Drawing.Point(188, 22);
            this.lbltituloreg.Name = "lbltituloreg";
            this.lbltituloreg.Size = new System.Drawing.Size(266, 32);
            this.lbltituloreg.TabIndex = 20;
            this.lbltituloreg.Text = "Registrar Producto";
            // 
            // dgvprod
            // 
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Location = new System.Drawing.Point(88, 326);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.ReadOnly = true;
            this.dgvprod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprod.Size = new System.Drawing.Size(544, 136);
            this.dgvprod.TabIndex = 19;
            // 
            // lbllistprod
            // 
            this.lbllistprod.AutoSize = true;
            this.lbllistprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistprod.Location = new System.Drawing.Point(90, 302);
            this.lbllistprod.Name = "lbllistprod";
            this.lbllistprod.Size = new System.Drawing.Size(130, 15);
            this.lbllistprod.TabIndex = 18;
            this.lbllistprod.Text = "Lista de Productos:";
            // 
            // gbdatprod
            // 
            this.gbdatprod.Controls.Add(this.txtprecio);
            this.gbdatprod.Controls.Add(this.txtcantidad);
            this.gbdatprod.Controls.Add(this.txtcategoria);
            this.gbdatprod.Controls.Add(this.txtnombre);
            this.gbdatprod.Controls.Add(this.txtcodigo);
            this.gbdatprod.Controls.Add(this.lblcodigo);
            this.gbdatprod.Controls.Add(this.lblprecio);
            this.gbdatprod.Controls.Add(this.lblcantidad);
            this.gbdatprod.Controls.Add(this.lblcategoria);
            this.gbdatprod.Controls.Add(this.lblnombre);
            this.gbdatprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatprod.Location = new System.Drawing.Point(88, 73);
            this.gbdatprod.Name = "gbdatprod";
            this.gbdatprod.Size = new System.Drawing.Size(471, 211);
            this.gbdatprod.TabIndex = 17;
            this.gbdatprod.TabStop = false;
            this.gbdatprod.Text = "Datos del Producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(106, 159);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(323, 21);
            this.txtprecio.TabIndex = 13;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(106, 128);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(323, 21);
            this.txtcantidad.TabIndex = 12;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(106, 99);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(323, 21);
            this.txtcategoria.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(108, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(323, 21);
            this.txtnombre.TabIndex = 10;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(108, 36);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(327, 21);
            this.txtcodigo.TabIndex = 9;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(29, 39);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(56, 15);
            this.lblcodigo.TabIndex = 8;
            this.lblcodigo.Text = "Código:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(37, 162);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(52, 15);
            this.lblprecio.TabIndex = 6;
            this.lblprecio.Text = "Precio:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(26, 129);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(68, 15);
            this.lblcantidad.TabIndex = 4;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(21, 98);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(73, 15);
            this.lblcategoria.TabIndex = 2;
            this.lblcategoria.Text = "Categoría:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(27, 68);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(62, 15);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Image = ((System.Drawing.Image)(resources.GetObject("btnborrar.Image")));
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrar.Location = new System.Drawing.Point(566, 192);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(154, 37);
            this.btnborrar.TabIndex = 24;
            this.btnborrar.Text = "Eliminar Producto";
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.UseVisualStyleBackColor = false;
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 514);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnstock);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lbltituloreg);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.lbllistprod);
            this.Controls.Add(this.gbdatprod);
            this.Name = "RegistroProductos";
            this.Text = "RegistroProductos";
            this.Load += new System.EventHandler(this.RegistroProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.gbdatprod.ResumeLayout(false);
            this.gbdatprod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label lbltituloreg;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.Label lbllistprod;
        private System.Windows.Forms.GroupBox gbdatprod;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btnborrar;
    }
}