﻿using System;
using System.Collections.Generic;
using System.Text;
using Information;

namespace SweetBonanzaGame
{
    public class SetGameInfo
    {

        public GameInfo Set()
        {
            var gameInfo = new GameInfo();
            gameInfo.name = "SweetBonanza";
            gameInfo.boardRow = 6;
            gameInfo.boardColumn = 5;
            gameInfo.bonusActive = false;
            gameInfo.bonusSymbols = 1;

            return gameInfo;
        }

    }
}
