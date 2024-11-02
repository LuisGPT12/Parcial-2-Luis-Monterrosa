namespace Parcial_2
{
    partial class Form1
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
            this.menS1 = new System.Windows.Forms.MenuStrip();
            this.enunciado1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblParcial = new System.Windows.Forms.Label();
            this.menS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menS1
            // 
            this.menS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enunciado1ToolStripMenuItem,
            this.enunciado2ToolStripMenuItem});
            this.menS1.Location = new System.Drawing.Point(0, 0);
            this.menS1.Name = "menS1";
            this.menS1.Size = new System.Drawing.Size(800, 24);
            this.menS1.TabIndex = 1;
            this.menS1.Text = "menuStrip1";
            // 
            // enunciado1ToolStripMenuItem
            // 
            this.enunciado1ToolStripMenuItem.Name = "enunciado1ToolStripMenuItem";
            this.enunciado1ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.enunciado1ToolStripMenuItem.Text = "Enunciado 1";
            this.enunciado1ToolStripMenuItem.Click += new System.EventHandler(this.enunciado1ToolStripMenuItem_Click);
            // 
            // enunciado2ToolStripMenuItem
            // 
            this.enunciado2ToolStripMenuItem.Name = "enunciado2ToolStripMenuItem";
            this.enunciado2ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.enunciado2ToolStripMenuItem.Text = "Enunciado 2";
            this.enunciado2ToolStripMenuItem.Click += new System.EventHandler(this.enunciado2ToolStripMenuItem_Click);
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.Location = new System.Drawing.Point(315, 243);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(148, 45);
            this.lblParcial.TabIndex = 3;
            this.lblParcial.Text = "Parcial 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.menS1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menS1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menS1.ResumeLayout(false);
            this.menS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menS1;
        private System.Windows.Forms.ToolStripMenuItem enunciado1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado2ToolStripMenuItem;
        private System.Windows.Forms.Label lblParcial;
    }
}

