using System;

namespace BuscaMinas
{
    class Minefield
    {
        private readonly String[,] sectors = new String[7, 7];

        public Minefield()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    sectors[x, y] = " ";
                }
            }
        }

        public void PrintField()
        {
            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write(sectors[f, c] + " ");
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
            for (int x = 0; x < 8; x++)
            {
                bool flag = false;
                do
                {
                    Random rnd = new Random();
                    int randX = rnd.Next(7);
                    int randY= rnd.Next(7);
                    if (sectors[randX, randY] != "💣")
                    {
                        sectors[randX, randY] = "💣";
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
                    if (sectors[x, y] != "💣")
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
                            sectors[x, y] = count.ToString();
                        }
                        
                    }
                }
            }
        }
        private bool AnalizeTop(int x, int y)
        {
            if (x != 0)
            {
                return (sectors[x - 1, y] == "💣");
            }
            return false;
        }
        private bool AnalizeTopRight(int x, int y)
        {
            if (x != 0 && y!=6)
            {
                return (sectors[x - 1, y + 1] == "💣");
            }
            return false;
        }
        private bool AnalizeTopLeft(int x, int y)
        {
            if (x != 0 && y != 0)
            {
                return (sectors[x - 1, y - 1] == "💣");
            }   
            return false;       
        }
        private bool AnalizeDown(int x, int y)
        {
            if (x != 6)
            {
                return (sectors[x + 1, y] == "💣");
            }
            return false;
        }
        private bool AnalizeDownRight(int x, int y)
        {
            if (x != 6 && y != 6)
            {
                return (sectors[x + 1, y + 1] == "💣");
            }
            return false;
        }
        private bool AnalizeDownLeft(int x, int y)
        {
            if (x != 6 && y != 0)
            {
                return (sectors[x + 1, y - 1] == "💣");
            }
            return false;
        }
        private bool AnalizeLeft(int x, int y)
        {
            if (y != 0)
            {
                return (sectors[x, y - 1] == "💣");
            }
            return false;
        }
        private bool AnalizeRight(int x, int y)
        {
            if (y != 6)
            {
                return (sectors[x, y + 1] == "💣");
            }
            return false;
        }
        public String GetSector(int x,int y) 
        {
            return sectors[x, y];
        }
    }

}
