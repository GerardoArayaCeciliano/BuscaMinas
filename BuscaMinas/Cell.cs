using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class Cell : UserControl
    {
        public Cell()
        {
            InitializeComponent();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
        public void setNumber(int number) 
        {
            lblNumber.Text = number.ToString();
        }

        private void panelCell_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(lblNumber.Text);
            panelCell.BackColor = Color.Yellow;

        }

        private void panelCell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCell_MouseHover(object sender, EventArgs e)
        {
           panelCell.BackColor = Color.Blue;
        }

        private void panelCell_MouseLeave(object sender, EventArgs e)
        {
           panelCell.BackColor = Color.OrangeRed;
        }

       
    }
}
