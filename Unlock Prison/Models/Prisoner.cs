using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Unlock_Prison.Interfaces;

namespace Unlock_Prison.Models
{
    public class Prisoner
    {
        public IDial iDial;

        public Prisoner(IDial iDial)
        {
            this.iDial = iDial;
        }

        public void UnlockDial()
        {
            while (iDial.IsLocked)
            {
                for (var i = 0; i < iDial.Sections.Length; i++)
                {
                    if (iDial.Sections[i] != true) continue;
                    Console.WriteLine(iDial.Message(i) + "\n");
                    iDial.Unlock();
                    break;
                }
            }
        }

    }
}
