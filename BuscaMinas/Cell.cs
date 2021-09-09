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

       
        public void SetValue(String Value,bool State,bool Flags,int x,int y) 
        {
            this.Value = Value;
            this.State = State;
            this.Flags = Flags;
            this.x = x;
            this.y = y;
        }

      
        public void ValuePanel()
        {
            lblNumber.Text = this.Value;
            panelCell.BackColor = Color.LightGray; ;
            panelCell.Enabled = false;

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
                lblNumber.Text = "🚩";
                this.Flags = true;
            }
            
        }
    }
}
