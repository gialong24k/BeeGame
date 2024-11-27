using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeGame
{
    internal class Bee
    {
        private int heath;

        public Bee(int initHeath) 
        {
            heath = initHeath;
        }

        public int Heath { get => heath; set => heath = value; }

        public bool isDeath() { return heath <= 0; }

        public void attack(int heath)
        {
            if (!isDeath()) { 
                this.heath -= heath;
            }
        }
    }
}
