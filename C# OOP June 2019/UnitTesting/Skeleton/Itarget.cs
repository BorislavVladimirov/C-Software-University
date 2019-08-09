using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public interface Itarget
    {
        void TakeAttack(int attackPoints);

        int Health { get; }

        int GiveExperience();

        bool IsDead();
    }
}
