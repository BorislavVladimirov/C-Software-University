using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    interface IIdentifiable
    {
        string Name { get; }

        string Id { get; }
    }
}
