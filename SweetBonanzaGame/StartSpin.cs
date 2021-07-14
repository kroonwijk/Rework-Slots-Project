using System;
using System.Collections.Generic;
using System.Text;
using Information;
using InitiateSymbols;
using InitiateBoard;

namespace SweetBonanzaGame
{
    class StartSpin
    {

        public void Start(GameInfo gameInfo, Symbol[] symbols, double betSize)
        {
            var board = new Board();
            board.Initiate(gameInfo, symbols, out Symbol[,] gameBoard);

            double win = 0;
            bool hit = true;
            var showBoard = new ShowBoard();
            while (hit == true)
            {
                var checkHits = new CheckHits();
                hit = checkHits.Check(gameInfo, symbols, gameBoard);
                var removeSymbol = new List<Symbol>();

                if(hit == true)
                {
                    if (win >= 1)
                    {
                        var calculateWin = new CalculateWin();
                        win = calculateWin.Calculate(gameInfo, symbols, gameBoard, win, betSize, out removeSymbol);
                    }
                    else
                    {
                        var calculateWin = new CalculateWin();
                        win = calculateWin.Calculate(gameInfo, symbols, gameBoard, betSize, out removeSymbol);
                    }

                    showBoard.Show(gameBoard, win);

                    var removeHitSymbols = new RemoveHitSymbols();
                    gameBoard = removeHitSymbols.Remove(gameBoard, removeSymbol);
                }
            }

            showBoard.Show(gameBoard, win);
            return;
        }

    }
}
