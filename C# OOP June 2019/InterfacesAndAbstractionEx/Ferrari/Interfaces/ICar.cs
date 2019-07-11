using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari.Interfaces
{
    public interface ICar : IBreakable, IGasable
    {
        string Model { get;}
    }
}
