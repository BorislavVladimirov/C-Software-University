using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    interface IIdentifiable : INameable
    {
        string Name { get; }

        string Id { get; }
    }
}
