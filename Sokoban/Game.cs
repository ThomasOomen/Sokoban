using System;
using System.Collections.Generic;
using System.Text;
using Sokoban.View;

namespace Sokoban
{
    public class Game
    {
        private Parser parser;
        private Truck truck;
        private Playfield playfield;
        private Crate crate;
        private Coworker coworker;
        private InputView inputview;
        private OutputView outputview;

        public void startGame()
        {
            outputview = new OutputView();
        }

        public void moveTruck()
        {
            throw new System.NotImplementedException();
        }

        public void printField()
        {
            throw new System.NotImplementedException();
        }

        public void moveCrate()
        {
            throw new System.NotImplementedException();
        }


    }
}