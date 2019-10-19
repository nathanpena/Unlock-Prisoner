using System;
using System.Collections.Generic;
using System.Text;

namespace Unlock_Prison.Interfaces
{
    public interface IDial
    {
        bool[] Sections { set; get; }
        int UnlockedSection { set; get; }
        bool IsLocked { set; get; }


        void CreateLockSections();
        void Unlock();
        string Message(int index);
    }
}
