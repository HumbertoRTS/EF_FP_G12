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
            this.btnstockcatg = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lbltituloreg = new System.Windows.Forms.Label();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.lbllistprod = new System.Windows.Forms.Label();
            this.gbdatprod = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.gbdatprod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstockcatg
            // 
            this.btnstockcatg.AutoSize = true;
            this.btnstockcatg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstockcatg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstockcatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockcatg.Image = ((System.Drawing.Image)(resources.GetObject("btnstockcatg.Image")));
            this.btnstockcatg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstockcatg.Location = new System.Drawing.Point(566, 149);
            this.btnstockcatg.Name = "btnstockcatg";
            this.btnstockcatg.Size = new System.Drawing.Size(147, 38);
            this.btnstockcatg.TabIndex = 23;
            this.btnstockcatg.Text = "Stock Productos";
            this.btnstockcatg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstockcatg.UseVisualStyleBackColor = false;
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
            this.btncancelar.Location = new System.Drawing.Point(566, 193);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(147, 38);
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
            this.btnregistrar.Size = new System.Drawing.Size(147, 38);
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
            this.dgvprod.Size = new System.Drawing.Size(471, 136);
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
            this.gbdatprod.Controls.Add(this.txtcodigo);
            this.gbdatprod.Controls.Add(this.lblcodigo);
            this.gbdatprod.Controls.Add(this.txtprecio);
            this.gbdatprod.Controls.Add(this.lblprecio);
            this.gbdatprod.Controls.Add(this.txtcantidad);
            this.gbdatprod.Controls.Add(this.lblcantidad);
            this.gbdatprod.Controls.Add(this.txtcategoria);
            this.gbdatprod.Controls.Add(this.lblcategoria);
            this.gbdatprod.Controls.Add(this.txtnombre);
            this.gbdatprod.Controls.Add(this.lblnombre);
            this.gbdatprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatprod.Location = new System.Drawing.Point(88, 73);
            this.gbdatprod.Name = "gbdatprod";
            this.gbdatprod.Size = new System.Drawing.Size(471, 211);
            this.gbdatprod.TabIndex = 17;
            this.gbdatprod.TabStop = false;
            this.gbdatprod.Text = "Datos del Producto";
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
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(106, 159);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(327, 21);
            this.txtprecio.TabIndex = 7;
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
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(106, 126);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(327, 21);
            this.txtcantidad.TabIndex = 5;
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
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(106, 95);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(327, 21);
            this.txtcategoria.TabIndex = 3;
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
            // txtnombre
            // 
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtnombre.Location = new System.Drawing.Point(106, 65);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(327, 21);
            this.txtnombre.TabIndex = 1;
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
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 514);
            this.Controls.Add(this.btnstockcatg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lbltituloreg);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.lbllistprod);
            this.Controls.Add(this.gbdatprod);
            this.Name = "RegistroProductos";
            this.Text = "RegistroProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.gbdatprod.ResumeLayout(false);
            this.gbdatprod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstockcatg;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label lbltituloreg;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.Label lbllistprod;
        private System.Windows.Forms.GroupBox gbdatprod;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
    }
}