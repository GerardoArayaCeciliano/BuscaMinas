using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaMinas
{
    
    public partial class Cell : UserControl
    {
        private String value;
        private int x, y;

        public Cell()
        {
            InitializeComponent();
        }

        private void LblNumber_OnClick(object sender, EventArgs e)
        {

        }
        public void SetValue(String value,int x,int y) 
        {
            this.value = value;
            this.x = x;
            this.y = y;
           // lblNumber.Text = number.ToString();
        }

        private void PanelCell_OnClick(object sender, EventArgs e)
        {
            //  MessageBox.Show(lblNumber.Text);

            lblNumber.Text = value;
            panelCell.BackColor = Color.Gray;
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.searchCell(x,y);
        }

        private void panelCell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCell_OnMouseHover(object sender, EventArgs e)
        {// 
          panelCell.BackColor = Color.LightGray;
        }

        private void PanelCell_OnMouseLeave(object sender, EventArgs e)
        {
          panelCell.BackColor =Color.Gray;
        }

       
    }
}
