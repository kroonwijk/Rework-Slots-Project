using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Initiate;
using Information;

namespace InitiateBoard
{
    public class Board
    {

        public void Initiate(GameInfo gameInfo, Symbol[] symbols, out Symbol[,] gameBoardSymbols)
        {
            var generateRandomBoard = new GenerateRandomBoard();
            gameBoardSymbols = generateRandomBoard.Generate(gameInfo, symbols);
        }

        public void Initiate(GameInfo gameInfo, Symbol[] symbols, Symbol[,] oldGamdeBoard, out Symbol[,] gameBoardSymbols)
        {
            var generateRandomBoard = new GenerateRandomBoard();
            gameBoardSymbols = generateRandomBoard.Generate(gameInfo, symbols);
        }

    }
}
