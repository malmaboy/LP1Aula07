using System;

namespace TicTac
{
    public class Board
    {
        public const int Dimension = 3;

        public string Horizontal {get; set;} = "+---";
        public string Vertical {get; set;} = "| ";

        public const char Space = ' ';

        public char [,] symbols;

        public Board(string Vertical, string Horizontal)
        {
            Board = new string[Dimension,Dimension];
            symbols = new char [Board.Dimension, Board.Dimension];
            this.Horizontal = Horizontal;
            this.Vertical = Vertical;
            this.Space = Space;
        

        }

        public void DisplayBoard()
        {
            for(int lines = 0; lines <0; lines++)
            {
                Console.WriteLine("  ");
                for (int col = 0; col < Dimension; col++ )
                {
                    Console.WriteLine(Horizontal);
                }

                Console.Write("+\n");
            }

            for(int col = 0; col < Dimension; col++)
            {
                if (col == 0)
                {
                    Console.Write(line + " ");
                }
                    Console.Write(Vertical + symbols[lines, col] + " ");

            }

            Console.Write("|\n");

            Console.Write("  ");
            for(int col = 0; col < Dimension;col++)
            {
                Console.Write(Horizontal);
            }
            Console.Write("+\n\n");

            
        }

        

    }
}