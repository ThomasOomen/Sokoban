using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sokoban
{
    public class Parser
        {
        private string _path;
        private FileStream _fileStream;
        private StreamReader _streamReader;
        private Maze _maze;

        public void calculateSize() //Berekent de breedte en hoogte van het doolhof (MOET NOG GETEST WORDEN)
        {
            this._fileStream = new FileStream(this._path, FileMode.Open, FileAccess.Read);
            this._streamReader = new StreamReader((Stream)this._fileStream);
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
                
            }


        }
        }
}
