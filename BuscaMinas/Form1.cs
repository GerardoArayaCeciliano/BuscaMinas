using System;
using System.Drawing;
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
            this.lbl_message.Visible = false;
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

        public void lose(int score)
        {
            this.lbl_message.Visible = true;
            this.lbl_message.Text = "You lose";
            this.lbl_message.ForeColor = Color.Red;
            this.score(score);
            chrono.Pause();
        }

        public void win(int score)
        {
            this.lbl_message.Visible = true;
            this.lbl_message.Text = "You Win";
            this.lbl_message.ForeColor = Color.Green;
            
            chrono.Pause();
        }

        public void score(int score)
        {
            this.lbl_score.Text = score.ToString();
        }



        private void label1_Click(object sender, EventArgs e){}

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_retry_Click(object sender, EventArgs e)
        {
            this.lbl_message.Visible = false;
            this.lbl_score.Text = "0";
            this.containerCell.Controls.Clear();
            minefield = new Minefield();
            minefield.clearcell();
            InitializeContainer();
            chrono.Start();
            chrono.Reset();


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
