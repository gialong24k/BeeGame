using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeGame
{
    internal class GenBee
    {
        private List<Bee> beeList = new List<Bee>();

        public GenBee()
        {
            for (int i = 0; i < 10; i++)
            {
                beeList.Add(new WorkerBee());
                beeList.Add(new DroneBee());
                beeList.Add(new QueenBee());
            }
        }

        public void Shoot()
        {
            Random rand = new Random(); foreach (var bee in beeList)
            {
                int damage = rand.Next(1, 60);
                bee.attack(damage);
            }
        }
        public void Output()
        {
            foreach (var bee in beeList)
            {
                string type = bee.GetType().Name;
                string status = bee.isDeath() ? "Dead" : "Alive";
                Console.WriteLine($"{type} - Health: {bee.Heath}, Status: {status}");
            }
        }
    }
}
