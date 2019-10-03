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
        private Char[,] _charArray;


        public void calculateSize() //Berekent de breedte en hoogte van het doolhof (MOET NOG GETEST WORDEN)
        {
            //this._fileStream = new FileStream(this._path, FileMode.Open, FileAccess.Read);
            this._streamReader = new StreamReader(@"doolhof" + _path + ".txt");
            var text = _streamReader.ReadToEnd();
            Console.WriteLine(text);
            Console.ReadLine();
            this._maze._height = 0;
            this._maze._width = 0;

            String line = _streamReader.ReadLine();

            while (line != null)
            {
                this._maze._height++;
                if (line.Length > this._maze._width)
                {
                    this._maze._width = line.Length;
                }
                line = _streamReader.ReadLine();
            }
            this._charArray = new Char[this._maze._width, this._maze._height];

        }

        public void FillArray(int levelNumber) //vult de 2d array met alle tekens per regel
        {
            _path = levelNumber;
            calculateSize();

            String line = _streamReader.ReadLine();
            int y = 0;

            while (y < this._maze._height)
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

        public void test()
        {
            TextReader tr = new StreamReader(@"doolhof6.txt");
            string myText = tr.ReadLine();
            Console.WriteLine(myText + "woop");
        }
    }
}



