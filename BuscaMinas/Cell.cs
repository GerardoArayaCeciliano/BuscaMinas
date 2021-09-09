using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaMinas
{
    
    public partial class Cell : UserControl
    {
        public String Value { get; set; }
        public bool Flags { get; set; }
        public bool State { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Cell()
        {
            InitializeComponent();
        }

        private void LblNumber_OnClick(object sender, EventArgs e)
        {

        }
        public void SetValue(String Value,bool State,bool Flags,int x,int y) 
        {
            this.Value = Value;
            this.State = State;
            this.Flags = Flags;
            this.x = x;
            this.y = y;
        }

        private void PanelCell_OnClick(object sender, EventArgs e)
        {
            //  MessageBox.Show(lblNumber.Text);
             
          

        }
        public void ValuePanel()
        {
            lblNumber.Text = this.Value;
            panelCell.BackColor = Color.LightGray; ;
            panelCell.Enabled = false;

        }

        private void panelCell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCell_OnMouseHover(object sender, EventArgs e)
        {// 
         // panelCell.BackColor = Color.LightGray;
        }

        private void PanelCell_OnMouseLeave(object sender, EventArgs e)
        {
          //panelCell.BackColor =Color.Gray;
        }

        private void panelCell_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Form1 form = (Form1)Application.OpenForms["Form1"];
            if (e.Button == MouseButtons.Left)
            {
                lblNumber.Text = this.Value;
                this.State = true;
                panelCell.BackColor = Color.Gray;
                panelCell.Enabled = false;
                form.searchCell(this.x, this.y);
            }
            else
            {
                ///Falta crear el metodo para volverla ☠️ y desactivar las banderas
                ///Falta bloquar las casillas que tienen bandera para que no se pueda abrir 
                lblNumber.Text = "🚩";
                this.Flags = true;
            }
            
        }
    }
}
