using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_road
{
    class Items
    {
        private string[] fishs = { "forel", "catfish", "carp", "beluga", "gossip" };
        public string getFish()
        {
            string catchedFish = "ERROR in Items.getFish";
            Random rand = new Random();
            int randomCounter = 0, randomCounterEnd = rand.Next(0,fishs.Length);

            foreach(var i in fishs)
            {
                if (randomCounter == randomCounterEnd)
                    catchedFish = i;
            randomCounter++;
            }
            return catchedFish;
        }


        private ConsoleKey[] keys = { ConsoleKey.A, ConsoleKey.N, ConsoleKey.P, ConsoleKey.X };
        public ConsoleKey getRandomKey()
        {
            ConsoleKey randKey = ConsoleKey.E;
            Random rand = new Random();
            int randomCounter = 0, randomCounterEnd = rand.Next(0, keys.Length);

            foreach (var i in keys)
            {
                if (randomCounter == randomCounterEnd)
                    randKey = i;
                randomCounter++;
            }
            return randKey;
        }
    }
}
