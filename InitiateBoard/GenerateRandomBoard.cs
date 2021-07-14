using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;
using InitiateSymbols;

namespace InitiateBoard
{
    public class GenerateRandomBoard
    {

        public Symbol[,] Generate(GameInfo gameInfo, Symbol[] symbols)
        {
            var gameBoardNumber = 0;
            var gameBoardSymbols = new Symbol[gameInfo.boardColumn, gameInfo.boardRow];
            for(int column = 0; column < gameInfo.boardColumn; column++)
            {
                for(int row = 0; row < gameInfo.boardRow; row++)
                {
                    var generateRandomNumber = new GenerateRandomNumber();
                    var transformNumberInSymbol = new TransformNumberInSymbol();
                    gameBoardNumber = generateRandomNumber.Generate(gameInfo, symbols);
                    if (gameBoardNumber == 0)
                    {
                        Console.WriteLine("SCATTER");
                    }
                    gameBoardSymbols[column, row] = transformNumberInSymbol.Transform(gameInfo, symbols, gameBoardNumber);
                }
            }

            return gameBoardSymbols;
        }

    }
}
