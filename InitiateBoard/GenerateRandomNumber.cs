using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Initiate;
using Information;

namespace InitiateBoard
{
    public class GenerateRandomNumber
    {
        public int Generate(GameInfo gameinfo, Symbol[] symbols)
        {

            int chance = 0;
            if (gameinfo.bonusActive == true)
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    var symbol = symbols[i];
                    chance += symbol.symbolChance;
                }
            }
            else
            {
                for (int i = 0; i < symbols.Length - gameinfo.bonusSymbols; i++)
                {
                    var symbol = symbols[i];
                    chance += symbol.symbolChance;
                }
            }

            var random = new Random();
            int randomNumber = random.Next(0, chance-1);

            return randomNumber;
        }
    }
}
