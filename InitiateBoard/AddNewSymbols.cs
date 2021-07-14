using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;
using InitiateSymbols;

namespace InitiateBoard
{
    public class AddNewSymbols
    {

        public Symbol[,] Add(GameInfo gameInfo, Symbol[] symbols, Symbol[,] GameBoard)
        {
            for (int column = 0; column < gameInfo.boardColumn; column++)
            {
                for (int row = 0; row < gameInfo.boardRow; row++)
                {
                    if(GameBoard[column, row] == null)
                    {
                        var transformNumberInSymbol = new TransformNumberInSymbol();
                        var generateRandomNumber = new GenerateRandomNumber();
                        GameBoard[column, row] = transformNumberInSymbol.Transform(gameInfo, symbols, generateRandomNumber.Generate(gameInfo, symbols));
                    }
                }
            }

            return GameBoard;
        }

    }
}
