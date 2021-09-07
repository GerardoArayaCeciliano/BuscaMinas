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

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
        public void setNumber(int number) 
        {
            lblNumber.Text = number.ToString();
        }

        private void Cell_Load(object sender, EventArgs e)
        {

        }
    }
}
