using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int InitialBulletrsPerBarrel = 10;
        private const int InitialTotalBullets = 100;
        private int ShotsFired = 1;

        public Pistol(string name)
            : base(name, InitialBulletrsPerBarrel, InitialTotalBullets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel == 0)
            {
                this.BulletsPerBarrel += 10;
                this.TotalBullets -= 10;
            }

            this.BulletsPerBarrel -= ShotsFired;

            return this.ShotsFired;
        }
    }
}
