using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public interface IWeapon
    {
        void Attack(Itarget target);

        int AttackPoints { get; }

        int DurabilityPoints { get; }

        void Attack(Dummy target);
    }
}
