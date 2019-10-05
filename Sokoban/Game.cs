﻿using System;
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
        }

        //geeft nu alleen nog door hoe breedt en hoe hoog het doolhof is. 
        public void InitMaze()
        {
            maze.Width = parser.calculatetWidthofMaze();
            maze.Height = parser.calculateHeightofMaze();
            //idk of die for loop nog klopt
            for (int x = 0; x < this.maze.Width; x++)
            {
                for (int y = 0; y < this.maze.Height; y++)
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
                            this.maze.Grid[x, y].MoveObject = new Crate();
                            break;

                        case "X": //Bestemming
                            this.maze.Grid[x, y] = new Destination();
                            break;

                        case "@": //Truck
                            this.maze.Grid[x, y] = new Floor();
                            this.maze.Grid[x, y].MoveObject = new Truck();
                            break;

                        case "~": //Valkuil
                            this.maze.Grid[x, y] = new DestroyableTile();
                            break;

                        case "$": //Medewerker wakker
                            this.maze.Grid[x, y] = new Floor();
                            this.maze.Grid[x, y].MoveObject = new Coworker();
                            break;

                        case "Z": //Medewerker slaapt
                            this.maze.Grid[x, y] = new Floor();
                            this.maze.Grid[x, y].MoveObject = new Coworker();
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