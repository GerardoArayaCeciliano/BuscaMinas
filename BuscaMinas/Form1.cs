using System;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class Form1 : Form
    {
        Minefield minefield = new Minefield();
       // private readonly Cell[,] MatCell = new Cell[7, 7];
        public Form1()
        {
         
            InitializeComponent();

            minefield.Build();
            minefield.PrintField();
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
                   // MatCell[x, y] = new Cell();
                    //MatCell[x,y].SetValue(minefield.GetSector(x, y), x, y);
                    containerCell.Controls.Add(minefield.GetSector(x, y));
                }
            }
        }

        private void containerCell_Paint(object sender, PaintEventArgs e)
        {

        }
        public void searchCell(int x,int y)
        {
            minefield.Shearch(x, y);
            //LLAMAR EL METODO Para revisar las casillas
           // MessageBox.Show(minefield.getMine(x,y).ToString());

        }
    }
}
