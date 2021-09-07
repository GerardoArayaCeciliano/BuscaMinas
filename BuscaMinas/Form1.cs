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
    public partial class Form1 : Form
    {
        Mines mine = new Mines();
        public Form1()
        {
         
            InitializeComponent();
            mine.InitializeMine();
            mine.CreateMine();
            mine.CellNumber();
            mine.prinCell();
            InitializeContainer();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeContainer()
        {
            for(int x = 0; x < 7; x++) 
            {
                for(int y = 0; y < 7; y++) 
                {
                    Cell cell= new Cell();
                    cell.setNumber(mine.getMine(x,y),x,y);
                    containerCell.Controls.Add(cell);
                }
            }
        }

        private void containerCell_Paint(object sender, PaintEventArgs e)
        {

        }
        public void searchCell(int x,int y)
        {
            //LLAMAR EL METODO Para revisar las casillas
           // MessageBox.Show(mine.getMine(x,y).ToString());

        }
    }
}
