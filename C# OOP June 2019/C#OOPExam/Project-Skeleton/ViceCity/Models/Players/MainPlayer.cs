using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const int InitialLifePoint = 100;
        private const string MainName = "Tommy Vercetti";
        
        public MainPlayer() 
            : base(MainName, InitialLifePoint)
        {
        }
    }
}
