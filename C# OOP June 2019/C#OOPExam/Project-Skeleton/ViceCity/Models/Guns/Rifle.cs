using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int InitialBulletrsPerBarrel = 50;
        private const int InitialTotalBullets = 500;
        private const int ShotsFired = 5;

        public Rifle(string name)
            : base(name, InitialBulletrsPerBarrel, InitialTotalBullets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel == 0)
            {
                this.BulletsPerBarrel += 50;
                this.TotalBullets -= 50;
            }

            this.BulletsPerBarrel -= ShotsFired;

            return ShotsFired;
        }
    }
}
