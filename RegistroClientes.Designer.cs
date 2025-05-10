namespace EF_FP_G12
{
    partial class RegistroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroClientes));
            this.lbltitulocli = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblape = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.gbdatoscli = new System.Windows.Forms.GroupBox();
            this.txtnomcli = new System.Windows.Forms.TextBox();
            this.txtapeclie = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.dgvregclie = new System.Windows.Forms.DataGridView();
            this.btnregcli = new System.Windows.Forms.Button();
            this.btncancelarcli = new System.Windows.Forms.Button();
            this.gbdatoscli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregclie)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulocli
            // 
            this.lbltitulocli.AutoSize = true;
            this.lbltitulocli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulocli.Location = new System.Drawing.Point(246, 27);
            this.lbltitulocli.Name = "lbltitulocli";
            this.lbltitulocli.Size = new System.Drawing.Size(279, 31);
            this.lbltitulocli.TabIndex = 0;
            this.lbltitulocli.Text = "Registro de Clientes";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(42, 37);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(74, 16);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Nombres:";
            // 
            // lblape
            // 
            this.lblape.AutoSize = true;
            this.lblape.Location = new System.Drawing.Point(39, 74);
            this.lblape.Name = "lblape";
            this.lblape.Size = new System.Drawing.Size(77, 16);
            this.lblape.TabIndex = 2;
            this.lblape.Text = "Apellidos:";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(79, 109);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(37, 16);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "DNI:";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Location = new System.Drawing.Point(56, 144);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(60, 16);
            this.lblcel.TabIndex = 4;
            this.lblcel.Text = "Celular:";
            // 
            // gbdatoscli
            // 
            this.gbdatoscli.Controls.Add(this.txtcelular);
            this.gbdatoscli.Controls.Add(this.txtapeclie);
            this.gbdatoscli.Controls.Add(this.txtdni);
            this.gbdatoscli.Controls.Add(this.txtnomcli);
            this.gbdatoscli.Controls.Add(this.lblnom);
            this.gbdatoscli.Controls.Add(this.lblcel);
            this.gbdatoscli.Controls.Add(this.lblape);
            this.gbdatoscli.Controls.Add(this.lbldni);
            this.gbdatoscli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatoscli.Location = new System.Drawing.Point(108, 92);
            this.gbdatoscli.Name = "gbdatoscli";
            this.gbdatoscli.Size = new System.Drawing.Size(512, 181);
            this.gbdatoscli.TabIndex = 5;
            this.gbdatoscli.TabStop = false;
            this.gbdatoscli.Text = "Datos del Cliente";
            // 
            // txtnomcli
            // 
            this.txtnomcli.Location = new System.Drawing.Point(122, 34);
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.Size = new System.Drawing.Size(286, 22);
            this.txtnomcli.TabIndex = 6;
            // 
            // txtapeclie
            // 
            this.txtapeclie.Location = new System.Drawing.Point(122, 71);
            this.txtapeclie.Name = "txtapeclie";
            this.txtapeclie.Size = new System.Drawing.Size(286, 22);
            this.txtapeclie.TabIndex = 7;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(122, 141);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(286, 22);
            this.txtcelular.TabIndex = 8;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(122, 108);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(286, 22);
            this.txtdni.TabIndex = 9;
            // 
            // dgvregclie
            // 
            this.dgvregclie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregclie.Location = new System.Drawing.Point(42, 295);
            this.dgvregclie.Name = "dgvregclie";
            this.dgvregclie.ReadOnly = true;
            this.dgvregclie.Size = new System.Drawing.Size(593, 187);
            this.dgvregclie.TabIndex = 6;
            // 
            // btnregcli
            // 
            this.btnregcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregcli.Image = ((System.Drawing.Image)(resources.GetObject("btnregcli.Image")));
            this.btnregcli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregcli.Location = new System.Drawing.Point(651, 109);
            this.btnregcli.Name = "btnregcli";
            this.btnregcli.Size = new System.Drawing.Size(137, 39);
            this.btnregcli.TabIndex = 7;
            this.btnregcli.Text = "Registrar Cliente";
            this.btnregcli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregcli.UseVisualStyleBackColor = true;
            this.btnregcli.Click += new System.EventHandler(this.btnregcli_Click);
            // 
            // btncancelarcli
            // 
            this.btncancelarcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarcli.Image = ((System.Drawing.Image)(resources.GetObject("btncancelarcli.Image")));
            this.btncancelarcli.Location = new System.Drawing.Point(651, 166);
            this.btncancelarcli.Name = "btncancelarcli";
            this.btncancelarcli.Size = new System.Drawing.Size(137, 35);
            this.btncancelarcli.TabIndex = 8;
            this.btncancelarcli.Text = "Cancelar";
            this.btncancelarcli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelarcli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelarcli.UseVisualStyleBackColor = true;
            this.btncancelarcli.Click += new System.EventHandler(this.btncancelarcli_Click);
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 542);
            this.Controls.Add(this.btncancelarcli);
            this.Controls.Add(this.btnregcli);
            this.Controls.Add(this.dgvregclie);
            this.Controls.Add(this.gbdatoscli);
            this.Controls.Add(this.lbltitulocli);
            this.Name = "RegistroClientes";
            this.Text = "RegistroClientes";
            this.gbdatoscli.ResumeLayout(false);
            this.gbdatoscli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregclie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulocli;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblape;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.GroupBox gbdatoscli;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtapeclie;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnomcli;
        private System.Windows.Forms.DataGridView dgvregclie;
        private System.Windows.Forms.Button btnregcli;
        private System.Windows.Forms.Button btncancelarcli;
    }
}