using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
 

namespace _321
{
    class Program
    {
        //* Опишіть клас Будівлі, який містить поля: Дата здачі в експлуатацію, адреса конструктор з параметрами функції
        //консольного введення та виведення полів Getteres Setters Метод GetCreatedDate() що виводить повні роки від введення
        //в експлуатацію overridden ToString() метод, який викликає метод GetAddress()

        //Реалізуйте клас наслідник Житлові будівлі, який має додаткові поля: Житлова площа, Кількість квартир, Кількість поверхів.
        //Конструктор з параметрами, додаткові getters та setters. Overridden input() та output()

        //Створіть колекцію будівель, додати кілька різних будівель та житлових будівель до цієї колекції
        //реалізуйте виведення будівель, термін експлуатації яких більше 40 років
        //виведііть житлові будівлі відсортовані за кількістю поверхів

        //реалізуйте опрацювання виключень (Exceptions)

        //сереалізуйте (Serialize) колекцію в JSON файл

        //десереалізуйте колекцію з JSON файла

        //напишіть unit тести до реалізованих функцій

        static List<ResidentialBuilding> buildings = new List<ResidentialBuilding>();
        static string fileName = "buildigs.json";

        static void Main(string[] args)
        {
            bool menuContinue = true;
            int choise;

            while (menuContinue)
            {
                Console.WriteLine("1 - Show all buildings");
                Console.WriteLine("2 - Show buildings older than 40 years");
                Console.WriteLine("3 - Show all buildings sorted by count of floors:");
                Console.WriteLine("4 - Add new building");
                Console.WriteLine("5 - Delete building");
                Console.WriteLine("6 - Delete all buildings");
                Console.WriteLine("7 - Default buidings");
                Console.WriteLine("8 - Save JSON");
                Console.WriteLine("9 - Load JSON");
                Console.WriteLine("10 - Clear");
                Console.WriteLine("11 - Exit");

                try
                {
                    choise = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    choise = 0;
                }

                switch (choise)
                {
                    case 1: { ShowAllBuildings(); break; }
                    case 2: { ShowBuildingsOlderFourtyYears(); break; }
                    case 3: { ShowSortedBuildings(); break; }
                    case 4: { AddNewBuilding(); break; }
                    case 5: { DeleteBuilding(); break; }
                    case 6: { DeleteAllBuildings(); break; }
                    case 7: { DefaultBuildings(); break; }
                    case 8: { SaveJSON(); break; }
                    case 9: { LoadJSON(); break; }
                    case 10: { Console.Clear(); break; }
                    case 11: { menuContinue = false; break; }
                }
            }
            Console.WriteLine("\nBye!");
        }

        static void ShowAllBuildings()
        {
            Console.WriteLine();

            if (buildings.Count > 0)
            {
                foreach (var item in buildings)
                {
                    item.Output();
                }
            }
            else
                Console.WriteLine("No buildings!");

            Console.WriteLine();

        }

        static void ShowBuildingsOlderFourtyYears()
        {
            Console.WriteLine();

            if (buildings.Count > 0)
            {
                var buildingsOlderThanFourtyYears = buildings.Where(x => x.DateOfCommissioning.Year < (DateTime.Now.Year - 40));
                if (buildingsOlderThanFourtyYears.Count() > 0)
                {
                    foreach (var item in buildingsOlderThanFourtyYears)
                    {
                        item.Output();
                    }
                }
                else
                    Console.WriteLine("No buildings older than fourty years!");
            }
            else
                Console.WriteLine("No buildings!");

            Console.WriteLine();
        }

        static void ShowSortedBuildings()
        {
            Console.WriteLine();
            if (buildings.Count > 0)
            {
                foreach (var item in buildings.OrderBy(x => x.NumberOfFlors))
                {
                    item.Output();
                }
            }
            else
                Console.WriteLine("No buildings!");

            Console.WriteLine();
        }

        static void AddNewBuilding()
        {
            Console.WriteLine();

            ResidentialBuilding residentialBuilding = new ResidentialBuilding();
            residentialBuilding.Input();
            buildings.Add(residentialBuilding);
            Console.WriteLine("Building is succefully added!");

            Console.WriteLine();
        }

        static void DeleteBuilding()
        {
            Console.WriteLine();

            Console.Write("Enter serial number of the building: ");
            try
            {
                buildings.RemoveAt(Int32.Parse(Console.ReadLine()) - 1);
                Console.WriteLine("Building is succesullly deleted!");
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong number!");
            }

            Console.WriteLine();
        }

        static void DeleteAllBuildings()
        {
            Console.WriteLine();
            if (buildings.Count > 0)
            {
                buildings.Clear();
                Console.WriteLine("All buildings are deleted!");
            }
            else
                Console.WriteLine("No buildings!");

            Console.WriteLine();
        }

        static void DefaultBuildings()
        {
            Console.WriteLine();

            buildings = new List<ResidentialBuilding>(){
                new ResidentialBuilding("Mickiewicz Street, 34","12.04.1977",31.2,40,8),
                new ResidentialBuilding("Pushkin Street, 112","22.01.2018",51.1,112,18),
                new ResidentialBuilding("New Street, 67","29.02.1964",26.8,30,6),
                new ResidentialBuilding("Hero Street, 11","05.11.2000",40.2,66,14),
                new ResidentialBuilding("Free Street, 88","18.08.1994",37.8,55,11),
                new ResidentialBuilding("Carpenka Street, 12a","24.02.2017",77.1,1,2)
            };
            Console.WriteLine("Default buidings are loaded!");

            Console.WriteLine();
        }

        static void SaveJSON()
        {
            Console.WriteLine();

            if (buildings.Count > 0)
            {
                try
                {
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                    string jsonString = JsonConvert.SerializeObject(buildings, settings);
                    File.WriteAllText(fileName, jsonString);
                    Console.WriteLine("List is succefully saved in JSON!");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            else
                Console.WriteLine("No buildings!");

            Console.WriteLine();
        }

        static void LoadJSON()
        {
            Console.WriteLine();

            try
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                string jsonString = File.ReadAllText(fileName);
                buildings = JsonConvert.DeserializeObject<List<ResidentialBuilding>>(jsonString, settings);
                Console.WriteLine("Buildings are succesfully loaded from JSON file!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            Console.WriteLine();
        }
    }
}
