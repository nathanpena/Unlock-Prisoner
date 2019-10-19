using System;
using System.Collections.Generic;
using System.Text;
using Unlock_Prison.Interfaces;

namespace Unlock_Prison.Models
{
    class EasyLock : IDial
    {
        public bool[] Sections { get; set; } = new bool[25];
        public int UnlockedSection { get; set; } = new Random().Next(0,11);
        public int SecondUnlockedSection { get; set; } = new Random().Next(12, 24);
        public bool IsLocked { get; set; } = true;

        public EasyLock()
        {
            CreateLockSections();
        }
        
        public void CreateLockSections()
        {
            for (var i = 0; i < Sections.Length; i++)
            {
                Sections[i] = false;
            }

            Sections[UnlockedSection] = true;
            Sections[SecondUnlockedSection] = true;
        }

        public void Unlock()
        {
            IsLocked = false;
        }

        public string Message(int index)
        {

            return $"The EasyLock has been unlocked at position {index + 1}\n" +
                   $"The EasyLock has unlocked sections at position {UnlockedSection + 1} and {SecondUnlockedSection + 1}";
        }
    }
}
