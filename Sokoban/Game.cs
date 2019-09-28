using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Game
    {
        private InputView inputView;
        private OutputView outputView;
        private Parser parser;
        private Truck truck;
        private Crate crate;
        private Coworker coworker;
        private Maze maze;

        public Game()
        {
            outputView = new OutputView();
            inputView = new InputView();
            startUpGame();
        }

        public void startUpGame()
        {
            outputView.showStartUp();
            Console.WriteLine(inputView.getMazeLevel());

        }

        public void Method1()
        {
            throw new System.NotImplementedException();
        }

        public void Method2()
        {
            throw new System.NotImplementedException();
        }

        public void Method3()
        {
            throw new System.NotImplementedException();
        }
    }
}