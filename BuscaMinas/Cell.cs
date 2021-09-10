using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaMinas
{
    
    public partial class Cell : UserControl
    {
        public String Value { get; set; }
        public bool Flag { get; set; }
        public bool State { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public Cell()
        {
            InitializeComponent();
        }

       
        public void SetValue(String Value,bool State,bool Flags,int x,int y) 
        {
            this.Value = Value;
            this.State = State;
            this.Flag = Flags;
            this.X = x;
            this.Y = y;
        }

      
        public void Discover()
        {
            lblNumber.Text = this.Value;
            this.State = true;
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
                this.Discover();
                form.SearchCell(this.X, this.Y);
                
                if (!form.gameStarted)
                {
                    form.StartChrono();
                }
            }
            else
            {
                ///Falta crear el metodo para volverla ☠️ y desactivar las banderas
                lblNumber.Text = "🚩";
                this.Flag = true;
            }
            
        }
    }
}
