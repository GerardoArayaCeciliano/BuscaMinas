
namespace BuscaMinas
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
            this.containerCell = new System.Windows.Forms.FlowLayoutPanel();
            this.chronoDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // containerCell
            // 
            this.containerCell.BackColor = System.Drawing.Color.White;
            this.containerCell.Location = new System.Drawing.Point(91, 25);
            this.containerCell.Name = "containerCell";
            this.containerCell.Size = new System.Drawing.Size(527, 396);
            this.containerCell.TabIndex = 0;
            this.containerCell.Paint += new System.Windows.Forms.PaintEventHandler(this.containerCell_Paint);
            // 
            // chronoDisplay
            // 
            this.chronoDisplay.AutoSize = true;
            this.chronoDisplay.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chronoDisplay.Location = new System.Drawing.Point(723, 41);
            this.chronoDisplay.Name = "chronoDisplay";
            this.chronoDisplay.Size = new System.Drawing.Size(34, 23);
            this.chronoDisplay.TabIndex = 1;
            this.chronoDisplay.Text = "--:--";
            this.chronoDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.chronoDisplay);
            this.Controls.Add(this.containerCell);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel containerCell;
        private System.Windows.Forms.Label chronoDisplay;
    }
}

