using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Fishing_road
{
    class Fishing:Items
    {
        private Random rand = new Random();

        private void GetOK()
        {
            Console.WriteLine("\n\t///////////\n\t//  O K  //\n\t///////////");
            Console.ReadLine();
        }

        private string StartOfGetingFish(ConsoleKey needKey)
        {    
            
            bool isCatched = false, isFailedPicking=false;
            ConsoleKey currentKey;
            string catchedFish = string.Empty;
            int loseFishCounter = 0, loseFishMaximum;
            loseFishMaximum = rand.Next(2, 5);


            
            Task.Factory.StartNew(() =>// waiting for a push in another thread
            {
                currentKey = Console.ReadKey().Key;
                while (currentKey != needKey && loseFishCounter < loseFishMaximum )
                {
                    currentKey = Console.ReadKey().Key; 
                    if (currentKey != needKey)
                    isFailedPicking = true;
                };
                isCatched = true;

            }); 

            while (!isCatched && loseFishCounter< loseFishMaximum) 
            {
                Console.Clear();
                Console.WriteLine($"\n\t  PICK\n\n\n___________|___________\n\tPRESS {needKey}");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine($"\n\t  PICK\n\n\t   |\n___________0___________\n\tPRESS {needKey}");
                Thread.Sleep(800);
                loseFishCounter++;
            } 

            if(loseFishCounter== loseFishMaximum || isFailedPicking ==true)
            {
                Console.WriteLine("\n\nYou lost your fish  :(((");
                isFailedPicking = true;
            }
            else
            {
               
                catchedFish = getFish();
                Console.WriteLine($"\n\nYou get {catchedFish} , my congratulations)))");  
            }
                GetOK();
            return catchedFish;
        } 

        public List<string> Start(List<string> inventory = null)//main
        {
            ConsoleKey keyToPull = getRandomKey();
            int waitingCounter = rand.Next(1,4);
            string catchedFish;

            Console.Clear();
            Console.WriteLine("Throw the rod");
            Console.WriteLine("\n\t///////////\n\t// THROW //\n\t///////////");
            Console.ReadLine();

            for(int i = 0; i < waitingCounter; i++)
            {
                Console.Clear();
                Console.WriteLine("\n\t  WAIT\n\n\t   |\n___________0___________");
                Thread.Sleep(2000);
            }

            catchedFish = StartOfGetingFish(keyToPull);
            if (inventory != null && catchedFish != "")
            inventory.Add(catchedFish);
            return inventory;
        }
    }
}
