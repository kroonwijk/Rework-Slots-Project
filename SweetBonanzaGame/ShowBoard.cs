using System;
using System.Collections.Generic;
using System.Text;
using Information;
using Initiate;
using InitiateBoard;

namespace SweetBonanzaGame
{
    class ShowBoard
    {

        public void Show(Symbol[,] gameBoard, double win)
        {
            Console.WriteLine();
            for (int column = 0; column < gameBoard.GetLength(0); column++)
            {
                for (int row = 0; row < gameBoard.GetLength(1); row++)
                {
                    Console.Write($"|  {gameBoard[column, row].symbolName}  |");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"WIN: €{win:0.00}");
        }

    }
}
