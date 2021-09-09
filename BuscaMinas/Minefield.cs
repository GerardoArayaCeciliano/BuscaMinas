using System;

namespace BuscaMinas
{
    class Minefield
    {
        
        //private readonly String[,] sectors = new String[7, 7];
        Cell[,] cells = new Cell[7,7];
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
            for (int x = 0; x <10; x++)
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
        public void  Shearch( int x,int y)
        {
             ShearchTop(x, y);
             ShearchTopRight(x, y);
             ShearchTopLeftt(x, y);
             ShearchDown(x, y);
             ShearchDownRight(x, y);
             ShearchDownLeftt(x, y);
             ShearchLeft(x, y);
             ShearchRight(x, y);
        }
        private void ShearchTop(int px,int py)
        {
            for (int x = px-1; x >= 0; x--)
            {
                
                if (cells[x, py].Value == " "&& !cells[x, py].State &&!cells[x,py].Flags) 
                {
                    cells[x, py].State = true;
                    cells[x, py].ValuePanel();
                } else if (cells[x, py].Value != " " && cells[x, py].Value!= "💣" && !cells[x, py].State && !cells[x, py].Flags)
                {
                    cells[x, py].State = true;
                    cells[x, py].ValuePanel();
                    x = -1;
                }
                else
                {
                    x = -1;
                }
            }
        }
        private void ShearchTopRight(int px, int py)
        {
            for (int x = px-1; x >= 0; x--)
            {
                py++;
                if (py<7) 
                {
                    if (cells[x, py].Value == " " && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                    }
                    else if (cells[x, py].Value != " " && cells[x, py].Value != "💣" && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                        x = -1;
                    }
                    else
                    {
                        x = -1;
                    }
                }

                
            }
        }
        private void ShearchTopLeftt(int px, int py)
        {
            for (int x = px - 1; x >= 0; x--)
            {
                py--;
                if (py >-1)
                {
                    if (cells[x, py].Value == " " && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                    }
                    else if (cells[x, py].Value != " " && cells[x, py].Value != "💣" && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                        x = -1;
                    }
                    else
                    {
                        x = -1;
                    }
                }


            }
        }
        private void ShearchDown(int px, int py)
        {
            for (int x = px+1; x<7; x++)
            {

                if (cells[x, py].Value == " " && !cells[x, py].State && !cells[x, py].Flags)
                {
                    cells[x, py].State = true;
                    cells[x, py].ValuePanel();
                }
                else if (cells[x, py].Value != " " && cells[x, py].Value != "💣" && !cells[x, py].State && !cells[x, py].Flags)
                {
                    cells[x, py].State = true;
                    cells[x, py].ValuePanel();
                    x = 7;
                }
                else
                {
                    x = 7;
                }
            }
        }
        private void ShearchDownRight(int px, int py)
        {
            for (int x = px + 1; x < 7; x++)
            {
                py++;
                if (py < 7)
                {
                    if (cells[x, py].Value == " " && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                    }
                    else if (cells[x, py].Value != " " && cells[x, py].Value != "💣" && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                        x = 7;
                    }
                    else
                    {
                        x = 7;
                    }
                }
            }
        }
        private void ShearchDownLeftt(int px, int py)
        {
            for (int x = px + 1; x <7; x++)
            {
                py--;
                if (py > -1)
                {
                    if (cells[x, py].Value == " " && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                    }
                    else if (cells[x, py].Value != " " && cells[x, py].Value != "💣" && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                        x =7;
                    }
                    else
                    {
                        x = 7;
                    }
                }
            }
        }
        private void ShearchLeft(int x, int y)
        {
            //y--
            for (int py = y - 1; py >= 0; py--) 
            {
                if (cells[x, py].Value == " " && !cells[x, py].State && !cells[x, py].Flags)
                {
                    cells[x, py].State = true;
                    cells[x, py].ValuePanel();
                }
                else if (cells[x, py].Value != " " && cells[x, py].Value != "💣" && !cells[x, py].State && !cells[x, py].Flags)
                {
                    cells[x, py].State = true;
                    cells[x, py].ValuePanel();
                    py = -1;
                }
                else
                {
                    py = -1;
                }
            }
        }
       private void ShearchRight(int x, int y)
        {
            for (int py = y + 1; py<7; py++)
            {
                
                    if (cells[x, py].Value == " " && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                      
                }
                    else if (cells[x, py].Value != " " && cells[x, py].Value != "💣" && !cells[x, py].State && !cells[x, py].Flags)
                    {
                        cells[x, py].State = true;
                        cells[x, py].ValuePanel();
                        py = 7;
                    }
                    else
                    {
                        py = 7;
                    }
                
            }
        }
      
    }


}
