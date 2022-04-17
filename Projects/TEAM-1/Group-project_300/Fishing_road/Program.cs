using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_road
{
    class Program
    {


        static void Instructor(Fishing fishing)//There must be teaching about all game opportunities
        {

            Console.WriteLine("la - la - la, now start fishing");
            Console.WriteLine("\n\t///////////\n\t//  O K  //\n\t///////////");
            Console.ReadLine(); 
            fishing.Start();
        }


        static void Main(string[] args)
        {
            int varriantOfActivity;
            List<string> inventory = new List<string>();      
            Fishing fishing = new Fishing();


            Instructor(fishing);


            do
            {
                Console.Clear();
               

                Console.WriteLine("Where do you want to go:\n\n1  -  Go fishing\n2  -  Go to the shop\n3  -  Look achivments\n4  -  EXIT");
                 varriantOfActivity = int.Parse(Console.ReadLine());
                switch (varriantOfActivity)
                {
                    case 1://fishing
                        inventory = fishing.Start(inventory);
                        break;
                    case 2://shop
                        for(int i= 0; i < inventory.Count;i++)
                        {
                            Console.Write(inventory[i]+" , ");
                        }  
                        Console.ReadLine();
                        break;
                    case 3://achievements
                        break;
                    case 4://Exit
                        Console.WriteLine("Bye-bye.");
                        break;
                    default:
                        break;
                }
            }
            while (varriantOfActivity!=4);


        }
    }
}
