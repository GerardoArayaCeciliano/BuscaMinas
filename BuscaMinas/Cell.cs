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
        int number;
        int x, y;
        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
        public void setNumber(int number,int x,int y) 
        {
            this.number = number;
            this.x = x;
            this.y = y;
            //lblNumber.Text = number.ToString();
            //lblNumber.Enabled = true;
        }

        private void panelCell_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(lblNumber.Text);

            lblNumber.Text = number.ToString();
            panelCell.BackColor = Color.Yellow;
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.searchCell(x,y);
        }

        private void panelCell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCell_MouseHover(object sender, EventArgs e)
        {// 
          panelCell.BackColor = Color.Blue;
        }

        private void panelCell_MouseLeave(object sender, EventArgs e)
        {
         //  panelCell.BackColor =Color.Green;
        }

       
    }
}
