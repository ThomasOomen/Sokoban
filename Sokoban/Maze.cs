﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private int _width;
        private int _height;
        private Wall _objectWall;
        private Floor _objectFloor;
        private Crate _objectCrate;
        private Destination _objectDestination;
        private Truck _objectTruck;
        private DestroyableTile _objectDestroyableTile;
        private Coworker _objectCoworker;
        private Square[,] _grid { get; set; }

        public Square[,] Grid
        {
            get
            {
                return _grid;
            }
            set
            {
                _grid = value;
            }
        }

        //breedte van het doolhof
        public int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }

        //hoogte van het doolhof
        public int Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        internal void createMazeObjects(char character, int x , int y)
        {
            string objectChar = Char.ToString(character);
            switch (objectChar)
            {
                case "#": //Muur
                    _objectWall = new Wall(x, y);
                    break;

                case ".": //Vloer
                    _objectFloor = new Floor(x, y);
                    break;

                case "o": //Krat
                    _objectCrate = new Crate(x, y);
                    _objectFloor = new Floor(x, y);
                    break;

                case "X": //Bestemming
                    _objectDestination = new Destination(x, y);
                    break;

                case "@": //Truck
                    _objectTruck = new Truck(x, y);
                    _objectFloor = new Floor(x, y);
                    break;

                case "~": //Valkuil
                    _objectDestroyableTile = new DestroyableTile(x, y);
                    break;

                case "$": //Medewerker
                    _objectCoworker = new Coworker(x, y);
                    _objectFloor = new Floor(x, y);
                    break;
                default:
                    break;

            }
        }

        internal void getTruckLocation()
        {
            Console.WriteLine("truck heeft x locatie: " + _objectTruck.xLoc);
            Console.WriteLine("truck heeft y locatie: " + _objectTruck.yLoc);

        }

        internal void truckDirection(int direction)
        {
            _objectTruck.move(direction);
        }
    }
}