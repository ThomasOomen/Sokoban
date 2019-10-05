using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Sokoban
{
    public class Parser
    {
        //public String line;
        private int _path;
        private FileStream _fileStream;
        private StreamReader _streamReader;
        private Maze _maze;
        private Char[,] _charArray { get; set; }

        public Char[,] CharArray
        {
            get
            {
                return _charArray;
            }
            set
            {
                _charArray = value;
            }
        }

        //initialeerd het path van de maze. speler moet wel het spel opnieuw opstarten als ie een ander doolhof wilt spelen. 
        public void initMazePath(int mazeLevel)
        {
            _path = mazeLevel;
            this._streamReader = new StreamReader(@"doolhof" + _path + ".txt");
        }


        //vult de 2d array met alle tekens per regel
        public void FillArray(int levelNumber) 
        {
            calculateSize();
            String line = _streamReader.ReadLine();
            int y = 0;

            while (y < this._maze.Height)
            {
                int x = 0;
                foreach (Char c in line)
                {
                    this._charArray[x, y] = c;
                    x++;
                }
                y++;
                line = _streamReader.ReadLine();
            }
        }

        //Leest breed een 1 regel is van het doolhof.(breedte van een regel)
        public int calculatetWidthofMaze()
        {
            string widthMaze = this._streamReader.ReadLine();
            return widthMaze.Length;
        }

        //leest hoog het doolhof is. (lengte van een colom).
        public int calculateHeightofMaze()
        {
            int heightMaze = File.ReadAllLines(@"doolhof" + _path + ".txt").Length;
            Console.WriteLine("doolhoof is " + heightMaze + " hoog");
            return heightMaze;
        }
    }
}



