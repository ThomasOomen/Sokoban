using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class InputView
    {
        private int selectedMazelevel;
        private char inputChar;

        //Vraagt naar maze level 1 t/m 4 of naar de character s als de verkeerde wordt ingevuld print ie een ?, anders returnt ie de waarde van het doolhof level
        //als er s ingevuld wordt returnt ie -100, die -100 geeft aan dat de speler wilt stoppen. 
        public int getMazeLevel()
        {
            selectedMazelevel = 0;
            while ((selectedMazelevel < 1 || selectedMazelevel > 5) && inputChar != 's')
            {
                Console.WriteLine("Kies een doolhof 1 - 4, s = stop");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                inputChar = consoleKeyInfo.KeyChar;
                Console.WriteLine();
                if (inputChar >= '1' && inputChar <= '4')
                    selectedMazelevel = Convert.ToInt32(char.ToString(consoleKeyInfo.KeyChar));
                else if (inputChar != 's')
                    Console.WriteLine("> ?");
            }
            if (inputChar == 's')
                selectedMazelevel = -100;
            return selectedMazelevel;
        }
    }
}