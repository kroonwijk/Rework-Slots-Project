using System;
using Initiate;
using Information;
using InitiateBoard;

namespace Test_dll
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameInfo = new GameInfo();
            gameInfo.name = "SweetBonanza";
            gameInfo.boardRow = 6;
            gameInfo.boardColumn = 5;
            gameInfo.bonusActive = false;
            gameInfo.bonusOnlySymbols = 1;

            var initSymbols = new InitSymbols();
            initSymbols.Initiate(gameInfo, out Symbol[] symbols);


            Console.WriteLine("DONE");
        }
    }
}
