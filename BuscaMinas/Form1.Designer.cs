﻿
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_retry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // containerCell
            // 
            this.containerCell.BackColor = System.Drawing.Color.White;
            this.containerCell.Location = new System.Drawing.Point(121, 31);
            this.containerCell.Margin = new System.Windows.Forms.Padding(4);
            this.containerCell.Name = "containerCell";
            this.containerCell.Size = new System.Drawing.Size(703, 487);
            this.containerCell.TabIndex = 0;
            this.containerCell.Paint += new System.Windows.Forms.PaintEventHandler(this.containerCell_Paint);
            // 
            // chronoDisplay
            // 
            this.chronoDisplay.AutoSize = true;
            this.chronoDisplay.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chronoDisplay.Location = new System.Drawing.Point(964, 50);
            this.chronoDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chronoDisplay.Name = "chronoDisplay";
            this.chronoDisplay.Size = new System.Drawing.Size(46, 29);
            this.chronoDisplay.TabIndex = 1;
            this.chronoDisplay.Text = "--:--";
            this.chronoDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(915, 163);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(161, 34);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "Message";
            this.lbl_message.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_retry
            // 
            this.btn_retry.Location = new System.Drawing.Point(951, 358);
            this.btn_retry.Name = "btn_retry";
            this.btn_retry.Size = new System.Drawing.Size(75, 38);
            this.btn_retry.TabIndex = 3;
            this.btn_retry.Text = "Re Try";
            this.btn_retry.UseVisualStyleBackColor = true;
            this.btn_retry.Click += new System.EventHandler(this.btn_retry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(917, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(1003, 248);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(23, 22);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "0";
            this.lbl_score.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 554);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_retry);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.chronoDisplay);
            this.Controls.Add(this.containerCell);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel containerCell;
        private System.Windows.Forms.Label chronoDisplay;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_retry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
    }
}

