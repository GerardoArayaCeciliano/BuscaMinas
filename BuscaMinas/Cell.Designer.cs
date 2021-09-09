
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
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(20, 13);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(31, 24);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "☠️";
            // 
            // panelCell
            // 
            this.panelCell.BackColor = System.Drawing.Color.Gray;
            this.panelCell.Controls.Add(this.lblNumber);
            this.panelCell.Location = new System.Drawing.Point(0, 0);
            this.panelCell.Name = "panelCell";
            this.panelCell.Size = new System.Drawing.Size(66, 48);
            this.panelCell.TabIndex = 1;
            this.panelCell.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCell_Click);
            this.panelCell.MouseLeave += new System.EventHandler(this.PanelCell_OnMouseLeave);
            this.panelCell.MouseHover += new System.EventHandler(this.PanelCell_OnMouseHover);
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
