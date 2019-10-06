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
        private Maze maze;

        private int _mazeWidth;
        private int _mazeHeight;

        public Game()
        {
            outputView = new OutputView();
            inputView = new InputView();
            parser = new Parser();
            maze = new Maze();

            startUpGame();
        }

        public void startUpGame()
        {
            outputView.showStartUp();
            //als return van getMazelevel -100 wordt exitGame() methode aangeroepen.
            mazeLevel = inputView.getMazeLevel();
            if (mazeLevel != -100)
            {
                playGame();
            }
            else
            {

            }
            
            
        }

        public void playGame()
        {
            inputView.AskForInput();
            parser.initMazePath(mazeLevel);
            InitMaze();
            mainGameLoop();
        }

        public void mainGameLoop()
        {
            Console.WriteLine("woop");
            while(true)
            {
                int input = inputView.ReadInputKey();
                switch(input)
                {
                    case 1:
                        maze.truckDirection(input);
                        break;

                    case 2:
                        maze.truckDirection(input);
                        break;

                    case 3:
                        maze.truckDirection(input);
                        break;

                    case 4:
                        maze.truckDirection(input);
                        break;

                    case -101:
                        resetGame();
                        break;

                    case -102:
                        exitGame();
                        break;
                }

                maze.getTruckLocation();
                update();
            }


        }

        public void InitMaze()
        {
            _mazeHeight =  parser.calculateHeightofMaze();
            _mazeWidth = parser.calculatetWidthofMaze();
            maze.Width = _mazeWidth;
            maze.Height = _mazeHeight;
            
            parser.createMazeArray();
            parser.printArray();
            maze.SetGrid();

            for (int y = 0; y < _mazeHeight; y++)
            {
                for(int x = 0; x < _mazeWidth; x++)
                { 
                    char character = parser.getMazeArray()[x, y];
                    maze.createMazeObjects(character, x , y);
                }
            } 
        }

        //Reset het spel (niet geimplementeerd)
        public void resetGame()
        {
            Console.WriteLine("Reset game");
        }

        //Sluit de game.
        public void exitGame()
        {
            Environment.Exit(0);
        }

        public void update()
        {
            this.maze.Grid[this.maze.getTruck.Xposition, this.maze.getTruck.Yposition].MoveObject = this.maze.getTruck;
            for (int i = 0; i < this._mazeWidth; i++)
            {
                for (int j = 0; j < this._mazeHeight; j++)
                {
                    if (this.maze.Grid[i,j].IsEmpty() && this.maze.Grid[i,j] != null)
                    {
                        this.maze.Grid[i, j].SetDisplayChar();
                    }
                }
            }
            maze.printArray();
        }
    }
}