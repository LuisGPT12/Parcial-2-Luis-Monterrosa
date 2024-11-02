namespace Parcial_2
{
    partial class frmComprasMedicamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCambiarData = new System.Windows.Forms.Button();
            this.dgvCompraMostrar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxMedicinas = new System.Windows.Forms.ComboBox();
            this.txtboxStockCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstbCarrito = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarAlCarrito = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraMostrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAgregarAlCarrito);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lstbCarrito);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtboxStockCompra);
            this.panel1.Controls.Add(this.cmbBoxMedicinas);
            this.panel1.Controls.Add(this.btnCambiarData);
            this.panel1.Controls.Add(this.dgvCompraMostrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 517);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCambiarData
            // 
            this.btnCambiarData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarData.Location = new System.Drawing.Point(388, 416);
            this.btnCambiarData.Name = "btnCambiarData";
            this.btnCambiarData.Size = new System.Drawing.Size(83, 27);
            this.btnCambiarData.TabIndex = 5;
            this.btnCambiarData.Text = "Enviar";
            this.btnCambiarData.UseVisualStyleBackColor = true;
            this.btnCambiarData.Click += new System.EventHandler(this.btnCambiarData_Click);
            // 
            // dgvCompraMostrar
            // 
            this.dgvCompraMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraMostrar.Location = new System.Drawing.Point(49, 177);
            this.dgvCompraMostrar.Name = "dgvCompraMostrar";
            this.dgvCompraMostrar.ReadOnly = true;
            this.dgvCompraMostrar.Size = new System.Drawing.Size(348, 157);
            this.dgvCompraMostrar.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-54, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 71);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vender Medicamentos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBoxMedicinas
            // 
            this.cmbBoxMedicinas.FormattingEnabled = true;
            this.cmbBoxMedicinas.Location = new System.Drawing.Point(456, 186);
            this.cmbBoxMedicinas.Name = "cmbBoxMedicinas";
            this.cmbBoxMedicinas.Size = new System.Drawing.Size(162, 21);
            this.cmbBoxMedicinas.TabIndex = 6;
            // 
            // txtboxStockCompra
            // 
            this.txtboxStockCompra.Location = new System.Drawing.Point(768, 186);
            this.txtboxStockCompra.Name = "txtboxStockCompra";
            this.txtboxStockCompra.Size = new System.Drawing.Size(82, 20);
            this.txtboxStockCompra.TabIndex = 7;
            this.txtboxStockCompra.TextChanged += new System.EventHandler(this.txtboxStockCompra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione los medicamentos a comprar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese la cantidad";
            // 
            // lstbCarrito
            // 
            this.lstbCarrito.FormattingEnabled = true;
            this.lstbCarrito.Location = new System.Drawing.Point(476, 296);
            this.lstbCarrito.Name = "lstbCarrito";
            this.lstbCarrito.Size = new System.Drawing.Size(290, 108);
            this.lstbCarrito.TabIndex = 10;
            this.lstbCarrito.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lstbCarrito.DoubleClick += new System.EventHandler(this.lstbCarrito_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Carrito";
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(601, 227);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(146, 27);
            this.btnAgregarAlCarrito.TabIndex = 12;
            this.btnAgregarAlCarrito.Text = "Agregar al carrito";
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarAlCarrito.Click += new System.EventHandler(this.btnAgregarAlCarrito_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(796, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(861, 311);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 23);
            this.lblTotal.TabIndex = 14;
            // 
            // frmComprasMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 514);
            this.Controls.Add(this.panel1);
            this.Name = "frmComprasMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComprasMedicamento";
            this.Load += new System.EventHandler(this.frmComprasMedicamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraMostrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCambiarData;
        private System.Windows.Forms.DataGridView dgvCompraMostrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxMedicinas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstbCarrito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxStockCompra;
        private System.Windows.Forms.Button btnAgregarAlCarrito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
    }
}