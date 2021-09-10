using System;
using System.Linq;
using System.Windows.Forms;

namespace BuscaMinas
{
    class Minefield
    {

       
        private Cell[,] cells = new Cell[7,7];
        private int score=0;
       

        public Minefield()
        {
            
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    cells[x, y] = new Cell();
                    cells[x, y].SetValue(" ",false,false,x,y);
                }
            }
        }

        public void PrintField()
        {
            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write(cells[f, c].Value + " ");
                }
                Console.WriteLine();
            }
        }

        public void Build()
        {
            this.GenerateMines();
            this.CalculateFieldValues();
        }

        private void GenerateMines()
        {
            for (int x = 0; x <8; x++)
            {
                bool flag = false;
                do
                {
                    Random rnd = new Random();
                    int randX = rnd.Next(7);
                    int randY= rnd.Next(7);
                    if (cells[randX, randY].Value != "💣")
                    {
                        cells[randX, randY].Value = "💣";
                        flag = true;
                    }
                } while (!flag);
            }
        }

        private void CalculateFieldValues()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    int count = 0;
                    if (cells[x, y].Value != "💣")
                    {
                        count += AnalizeTopLeft(x, y) ? 1 : 0;
                        count += AnalizeTop(x, y) ? 1 : 0;
                        count += AnalizeTopRight(x, y) ? 1 : 0;

                        count += AnalizeLeft(x, y) ? 1 : 0;
                        count += AnalizeRight(x, y) ? 1 : 0;

                        count += AnalizeDownLeft(x, y) ? 1 : 0;
                        count += AnalizeDown(x, y) ? 1 : 0;
                        count += AnalizeDownRight(x, y) ? 1 : 0;

                        if (count > 0) 
                        { 
                            cells[x, y].Value = count.ToString();
                        }
                        
                    }
                }
            }
        }

        private bool AnalizeTop(int x, int y)
        {
            if (x != 0)
            {
                return (cells[x - 1, y].Value == "💣");
            }
            return false;
        }

        private bool AnalizeTopRight(int x, int y)
        {
            if (x != 0 && y!=6)
            {
                return (cells[x - 1, y + 1].Value== "💣");
            }
            return false;
        }

        private bool AnalizeTopLeft(int x, int y)
        {
            if (x != 0 && y != 0)
            {
                return (cells[x - 1, y - 1].Value== "💣");
            }   
            return false;       
        }

        private bool AnalizeDown(int x, int y)
        {
            if (x != 6)
            {
                return (cells[x + 1, y].Value == "💣");
            }
            return false;
        }

        private bool AnalizeDownRight(int x, int y)
        {
            if (x != 6 && y != 6)
            {
                return (cells[x + 1, y + 1].Value == "💣");
            }
            return false;
        }

        private bool AnalizeDownLeft(int x, int y)
        {
            if (x != 6 && y != 0)
            {
                return (cells[x + 1, y - 1].Value== "💣");
            }
            return false;
        }

        private bool AnalizeLeft(int x, int y)
        {
            if (y != 0)
            {
                return (cells[x, y - 1].Value == "💣");
            }
            return false;
        }

        private bool AnalizeRight(int x, int y)
        {
            if (y != 6)
            {
                return (cells[x, y + 1].Value == "💣");
            }
            return false;
        }

        public Cell GetSector(int x,int y) 
        {
            return cells[x, y];
        }

        public void  SearchAround(int x,int y, int profundity)
        {
            Form1 form = (Form1)Application.OpenForms["Form1"];

            if (Enumerable.Range(0, 7).Contains(x) && Enumerable.Range(0, 7).Contains(y))
            {
                if(this.cells[x, y].Value != "💣" && !cells[x, y].Flag && (!cells[x, y].State || profundity == 0)) 
                {
                    this.cells[x, y].Discover();
                    this.score = this.score + 100;
                    form.score(this.score);
                    //aqui se valida el gane
                    if (this.score == 4100)
                    {
                        this.ShowSolution();
                        form.win(this.score);

                    }
                    if(this.cells[x, y].Value == " ")
                    {
                        this.SearchAround(x - 1, y - 1, profundity + 1);
                        this.SearchAround(x, y - 1, profundity + 1);
                        this.SearchAround(x + 1, y - 1, profundity + 1);

                        this.SearchAround(x - 1, y, profundity + 1);
                        this.SearchAround(x + 1, y, profundity + 1);

                        this.SearchAround(x - 1, y + 1, profundity + 1);
                        this.SearchAround(x, y + 1, profundity + 1);
                        this.SearchAround(x + 1, y + 1, profundity + 1);

                    }
                }
                /// aqui se valida la derrota
                if (this.cells[x, y].Value == "💣")
                {
                    this.ShowSolution();
                    form.lose(this.score);

                  

                }

            }
            
        }


        public void ShowSolution()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    this.cells[x, y].Discover();
                }
            }


        }

        public void clearcell()
        {
           

            Cell[,] cells = new Cell[7, 7];

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    cells[x, y] = new Cell();
                    cells[x, y].SetValue(" ", false, false, x, y);
                }
            }

            this.PrintField();
            this.Build();

        }







    }


}
