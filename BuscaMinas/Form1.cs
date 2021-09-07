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
        {///
            for(int x = 0; x < 7; x++) 
            {
                for(int y = 0; y < 7; y++) 
                {
                    Cell c = new Cell();
                    c.setNumber(mine.getMine(x,y));
                    containerCell.Controls.Add(c);
                }
            }
        }

    }
}
