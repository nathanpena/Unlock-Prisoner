using System;
using System.Collections.Generic;
using System.Text;

namespace Unlock_Prison.Models
{
    class Dial
    {
        public bool[] sections = new bool[100];
        public int unlockedSection = new Random().Next(0, 99);

        public Dial()
        {
            createLockSections();
        }

        private void createLockSections()
        {
            for (int i = 0; i < sections.Length; i++)
            {
                sections[i] = false;
            }

            sections[unlockedSection] = true;
        }
    }
}
