using System;
using Unlock_Prison.Models;

namespace Unlock_Prison
{
    class Program
    {
        static void Main(string[] args)
        {
            var dial = new Dial() ;
            var prisoner = new Prisoner(dial);
            prisoner.unlockDial();
        }
    }
}
