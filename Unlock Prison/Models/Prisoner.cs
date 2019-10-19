using System;
using System.Collections.Generic;
using System.Text;

namespace Unlock_Prison.Models
{
    class Prisoner
    {
        private Dial dial;

        public Prisoner(Dial dial) 
        {
            this.dial = dial;
        }

        public void unlockDial()
        {
            var locked = true;
            while (locked)
            {
                for (int i = 0; i < dial.sections.Length; i++)
                {
                    if (dial.sections[i] == true)
                    {
                        Console.WriteLine("The lock has been unlocked at position {0}", i + 1);
                        locked = false;
                        break;
                    }
                }
            }
        }
    }
}
