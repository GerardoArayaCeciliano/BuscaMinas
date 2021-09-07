
namespace BuscaMinas
{
    partial class Cell
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.panelCell = new System.Windows.Forms.Panel();
            this.panelCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(21, 15);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = ":)";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // panelCell
            // 
            this.panelCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelCell.Controls.Add(this.lblNumber);
            this.panelCell.Location = new System.Drawing.Point(0, 0);
            this.panelCell.Name = "panelCell";
            this.panelCell.Size = new System.Drawing.Size(63, 46);
            this.panelCell.TabIndex = 1;
            // 
            // Cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCell);
            this.Name = "Cell";
            this.Size = new System.Drawing.Size(66, 48);
            this.panelCell.ResumeLayout(false);
            this.panelCell.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Panel panelCell;
    }
}
