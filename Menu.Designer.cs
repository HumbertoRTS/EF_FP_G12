namespace EF_FP_G12
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtitulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbproductos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbclientes = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtitulo,
            this.toolStripSeparator1,
            this.tsbproductos,
            this.toolStripSeparator2,
            this.tsbclientes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(637, 38);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtitulo
            // 
            this.tsbtitulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtitulo.Image")));
            this.tsbtitulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtitulo.Name = "tsbtitulo";
            this.tsbtitulo.Size = new System.Drawing.Size(33, 35);
            this.tsbtitulo.Text = "Salir";
            this.tsbtitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtitulo.Click += new System.EventHandler(this.tsbtitulo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbproductos
            // 
            this.tsbproductos.Image = ((System.Drawing.Image)(resources.GetObject("tsbproductos.Image")));
            this.tsbproductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbproductos.Name = "tsbproductos";
            this.tsbproductos.Size = new System.Drawing.Size(65, 35);
            this.tsbproductos.Text = "Productos";
            this.tsbproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbproductos.Click += new System.EventHandler(this.tsbproductos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbclientes
            // 
            this.tsbclientes.Image = ((System.Drawing.Image)(resources.GetObject("tsbclientes.Image")));
            this.tsbclientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbclientes.Name = "tsbclientes";
            this.tsbclientes.Size = new System.Drawing.Size(53, 35);
            this.tsbclientes.Text = "Clientes";
            this.tsbclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbclientes.Click += new System.EventHandler(this.tsbclientes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 395);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtitulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbproductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbclientes;
    }
}

