using System;

namespace TicTac
{
    public class Board
    {
        public const int Dimension = 3;
        public string [,] BOARD {get; set;}

        private string Horizontal  = "+--";
        private string Vertical = "| ";

        public void tabuleiro(string Horizontal, string Vertical)
        {
            this.Horizontal = Horizontal;
            this.Vertical = Vertical;
            
        }


        public void DisplayBoard()
        {
            BOARD = new string [Dimension,Dimension];

            Console.WriteLine("   0  1   2");
            for (int l = 0; l < Dimension; l++)
            {
                Console.Write("  ");
                for (int c = 0; c < Dimension; c++)
                {
                    Console.Write(Horizontal);
                }

                Console.Write("+\n");

                for (int c = 0; c < Dimension; c++)
                {
                    if (c == 0)
                        Console.Write(l + " ");

                    Console.Write(Vertical + BOARD[l, c] + " ");
                }

                Console.Write("|\n");
            }


            Console.Write("  ");
            for (int c = 0; c < Dimension; c++)
            {
                Console.Write(Horizontal);
            }

            Console.Write("+\n\n");
        }

        


    }
}