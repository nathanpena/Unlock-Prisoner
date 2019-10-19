using System;
using Unlock_Prison.Interfaces;
using Unlock_Prison.Models;

namespace Unlock_Prison
{
    class Program
    {
        static void Main(string[] args)
        {
            var prisoner = new Prisoner(new ComplexLock());
            prisoner.UnlockDial();

            prisoner.iDial = new Dial();
            prisoner.UnlockDial();

            prisoner.iDial = new EasyLock();
            prisoner.UnlockDial();
            
        }
    }
}
