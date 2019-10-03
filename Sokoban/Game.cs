using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Game
    {
        private int mazeLevel = 0;
        
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
            parser = new Parser();
            startUpGame();
        }

        public void startUpGame()
        {
            outputView.showStartUp();
            //als return van getMazelevel -100 wordt exitGame() methode aangeroepen.
            mazeLevel = inputView.getMazeLevel();
            if (mazeLevel != -100)
            {
                Console.WriteLine(mazeLevel);

                playGame();
                
            }
            else
            {

            }
            
            
        }

        public void playGame()
        {
            inputView.AskForInput();
            Console.WriteLine(inputView.ReadInputKey());

            
        }

        public void Method2()
        {
            throw new System.NotImplementedException();
        }

        public void exitGame()
        {
            Environment.Exit(0);
        }
    }
}