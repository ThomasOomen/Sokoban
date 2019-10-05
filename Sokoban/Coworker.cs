using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Coworker : MoveableObjects
    {
        public bool _isSleeping;

        public bool IsSleeping
        {
            get
            {
                return _isSleeping;
            }
            set
            {
                _isSleeping = value;
            }
        }

        public void WakeOrSleep() //berekent of de coworker wakker wordt, in slaap valt, wakker blijf of in slaap blijft
        {
            Random r = new Random();
            if (_isSleeping)
            {
                int wakePercentage = 10;
                int randomValue99 = r.Next(100);
                if (randomValue99 < wakePercentage)
                {
                    _isSleeping = false;
                }
            }
            else
            {
                int sleepPercentage = 25;
                int randomValue99 = r.Next(100);
                if (randomValue99 < sleepPercentage)
                {
                    _isSleeping = true;
                }
            }
        }
        public override void move() //als de coworker wakker is gaat hij een willekeurige kant op
        {
            if (_isSleeping)
            {
                WakeOrSleep();
            }
            else
            {
                WakeOrSleep();
                Random r = new Random();
                int direction = r.Next(4);

                switch (direction)
                {
                    case 0:
                        this.Xposition--;
                        break;
                    case 1:
                        this.Xposition++;
                        break;
                    case 2:
                        this.Yposition--;
                        break;
                    case 3:
                        this.Yposition++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}