using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngimeSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngimeSpeed { get; }
    
        public int EnginePower { get; }
    }
}
