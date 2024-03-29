﻿using System;
using System.Collections.Generic;
using System.Text;
using Unlock_Prison.Interfaces;

namespace Unlock_Prison.Models
{
    class Dial : IDial
    {
        public bool[] Sections { get; set; } = new bool[100];
        public int UnlockedSection { get; set; } = new Random().Next(0, 99);
        public bool IsLocked { get; set;} = true;

        public Dial()
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
        }

        public void Unlock()
        {
           IsLocked = false;
        }

        public string Message(int index)
        {

            return $"The DialLock has been unlocked at position {index + 1}\n" +
                   $"The DialLock has an unlocked section at position {UnlockedSection + 1}";
        }
    }
}
