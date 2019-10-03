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

        public void InitMaze()
        {
            for (int x = 0; x < this.maze._width; x++)
            {
                for (int y = 0; y < this.maze._height; y++)
                {
                    string c = this.parser.CharArray[x, y].ToString();
                    switch (c)
                    {
                        case "#": //Muur
                            this.maze.Grid[x, y] = new Wall();
                            break;

                        case ".": //Vloer
                            this.maze.Grid[x, y] = new Floor();
                            break;

                        case "o": //Krat
                            this.maze.Grid[x, y] = new Floor();
                            //plaats krat op vloer
                            break;

                        case "X": //Bestemming
                            this.maze.Grid[x, y] = new Destination();
                            //maak van vloer een bestemming
                            break;

                        case "@": //Truck
                            this.maze.Grid[x, y] = new Floor();
                            //plaats truck op vloer
                            break;

                        case "~": //Valkuil
                            this.maze.Grid[x, y] = new DestroyableTile();
                            break;

                        case "$": //Medewerker wakker
                            this.maze.Grid[x, y] = new Floor();
                            //plaats wakkere medewerker op vloer
                            break;

                        case "Z": //Medewerker slaapt
                            this.maze.Grid[x, y] = new Floor();
                            //plaats slapende medewerker op vloer
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void exitGame()
        {
            Environment.Exit(0);
        }
    }
}