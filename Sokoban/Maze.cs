using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private int _tempXlocTruck;
        private int _tempYlocTruck;
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

        internal void createMazeObjects(Char character, int x , int y)
        {
            string objectChar = Char.ToString(character);
            switch (objectChar)
            {
                case "#": //Muur
                    _objectWall = new Wall(x, y);
                    Console.WriteLine(_grid[x, y]);
                    break;

                case ".": //Vloer
                    _objectFloor = new Floor(x, y);
                    _grid[x, y] = _objectFloor;
                    Console.WriteLine(_grid[x, y] + " is gevuld met vloer" );
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

        //Test code
        internal void getTruckLocation()
        {
            Console.WriteLine("truck heeft x locatie: " + _objectTruck.Xposition);
            Console.WriteLine("truck heeft y locatie: " + _objectTruck.Yposition);

        }

        //stuurt de richting van de player input door.
        public void truckDirection(int direction)
        {
            _tempXlocTruck = _objectTruck.Xposition;
            _tempYlocTruck = _objectTruck.Yposition;

            switch (direction)
            {
                case 1:
                    _tempXlocTruck--;
                    checkColision();
                    break;

                case 2:
                    _tempYlocTruck--;
                    checkColision();
                    break;

                case 3:
                    _tempXlocTruck++;
                    checkColision();
                    break;

                case 4:
                    _tempYlocTruck++;
                    checkColision();
                    break;
            }
            _objectTruck.move(direction);
        }

        private void checkColision()
        {
            
        }

        public void moveCoWorker()
        {
            _objectCoworker.WakeOrSleep();
        }
    }
}