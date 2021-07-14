using System;
using System.Collections.Generic;
using System.Text;
using Information;
using Initiate;
using InitiateBoard;

namespace SweetBonanzaGame
{
    public class StartGame
    {

        public void Start(GameInfo gameInfo)
        {
            var initSymbols = new InitSymbols();
            initSymbols.Initiate(gameInfo, out Symbol[] symbols);

            Console.Write("Enter Betsize (0.20, 0.40, 0.60, 0.80, 1.00 --> 100, 120, 140, 160, 180, 200 (to a max of 500€): ");
            double betSize = double.Parse(Console.ReadLine());

            for (; ; )
            {
                Console.Write("Chose Option (Information, BetSize, Spin, End): ");
                string input = Console.ReadLine().ToLower();
                if (input == "information")
                {
                    var printSymbols = new PrintSymbols();
                    printSymbols.Print(symbols);
                }
                else if(input == "betsize")
                {
                    Console.WriteLine("Enter Betsize: (0.20, 0.40, 0.60, 0.80, 1.00 --> 100, 120, 140, 160, 180, 200 (to a max of 500€): ");
                    betSize = double.Parse(Console.ReadLine());
                }
                else if (input == "spin")
                {
                    var startSpin = new StartSpin();
                    startSpin.Start(gameInfo, symbols, betSize);
                }
                else if (input == "end")
                {
                    return;
                }

                Console.WriteLine();
            }
        }
    }
}
