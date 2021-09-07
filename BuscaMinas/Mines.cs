using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    class Mines
    {
        int[,] mine = new int[7, 7];

        public void InitializeMine()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    mine[x, y] = 0;
                }
            }
        }
        public void prinCell()
        {
            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write(mine[f, c] + " ");

                }
                Console.WriteLine();
            }
        }

            public void CreateMine()
        {
            for (int x = 0; x < 10; x++)
            {
                bool flag = false;
                do
                {
                    
                    Random rnd = new Random();
                    int randX = rnd.Next(7);
                    int randY= rnd.Next(7);
                    if (mine[randX, randY] != -1)
                    {
                        mine[randX, randY] = -1;
                        flag = true;
                    }
                } while (!flag);
            }
        }
        public void CellNumber()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    int cont = 0;
                    if (mine[x, y] != -1)
                    {
                        if (Top(x, y))
                        {
                            cont++;
                        }
                        if (TopRight(x, y))
                        {
                            cont++;
                        }
                        if (TopLeft(x, y))
                        {
                            cont++;
                        }
                        if (Down(x, y))
                        {
                            cont++;
                        }
                        if (DownLeft(x, y))
                        {
                            cont++;
                        }
                        if (DownRight(x, y))
                        {
                            cont++;
                        }
                        if (Right(x, y))
                        {
                            cont++;
                        }
                        if (Left(x, y))
                        {
                            cont++;
                        }
                        mine[x, y] = cont;

                    }
                }
            }
        }
        public bool Top(int x, int y)
        {
            if (x != 0)
            {
                if (mine[x - 1, y] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool TopRight(int x, int y)
        {
            if (x != 0 && y!=6)
            {
                if (mine[x - 1, y+1] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool TopLeft(int x, int y)
        {
            if (x != 0 && y != 0)
            {
                if (mine[x - 1, y - 1] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Down(int x, int y)
        {
            if (x != 6)
            {
                if (mine[x + 1, y] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool DownRight(int x, int y)
        {
            if (x != 6 && y != 6)
            {
                if (mine[x +1, y + 1] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool DownLeft(int x, int y)
        {
            if (x != 6 && y != 0)
            {
                if (mine[x + 1, y - 1] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Left(int x, int y)
        {
            if (y != 0)
            {
                if (mine[x, y - 1] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Right(int x, int y)
        {
            if (y != 6)
            {
                if (mine[x, y + 1] == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public int getMine(int x,int y) 
        {
            return mine[x, y];
        }
    }


}
