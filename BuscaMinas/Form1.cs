using System;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class Form1 : Form
    {
        private Minefield minefield = new Minefield();
        private Chrono chrono;
        public bool gameStarted;
        public Form1()
        {
            
            InitializeComponent();

            minefield.Build();
            minefield.PrintField();
            InitializeContainer();
            this.gameStarted = false;
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
                    containerCell.Controls.Add(minefield.GetSector(x, y));
                }
            }
        }

        private void containerCell_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SearchCell(int x,int y)
        {
            minefield.SearchAround(x, y, 0);
            //LLAMAR EL METODO Para revisar las casillas
           // MessageBox.Show(minefield.getMine(x,y).ToString());

        }

        public void StartChrono() 
        {
            gameStarted = true;
            this.chrono = new Chrono(this.chronoDisplay);
            this.chrono.Start();
        }

        private void label1_Click(object sender, EventArgs e){}
    }
}
