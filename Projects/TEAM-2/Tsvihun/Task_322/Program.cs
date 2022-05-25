using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_322
{
    internal class Program
    {
        public static List<Goods> goods = new List<Goods>();
        public static void ShowGoods()
        {
            foreach (var good in goods) { Console.WriteLine(good.ToString()); }
        }

        // Show products made in previous year and sorted by price
        public static void ShowGoodsOfPreviousYear()
        {
            // I use not product date, but entry date - because there are no product dates for general products (see task)
            Console.WriteLine("--- Products made in previous year ---");
            var selectedGoods = from element in goods
                                 where element.EntryDate.Year == DateTime.Now.Year-1
                                 orderby element.EntryPrice
                                 select element;
            foreach (var good in selectedGoods) { Console.WriteLine(good.ToString()); }
        }

        // Show food products sorted by shelf life
        public static void ShowSortedFoodGoods()
        {
            Console.WriteLine("--- Food roducts by shelf life ---");
            var selectedGoods = from element in goods
                                where element.GetType().Name == "FoodGoods"     // better to check if element is of class FoodGoods
                                orderby element.BestBefore
                                select element;
            foreach (var good in selectedGoods) { Console.WriteLine(good.ToString()); }

        }

        // Serialization goods collection to xml file
        public static void SaveGoodsToFile()
        {
            Console.WriteLine($"***** Saving goods list to file... *****");
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Goods>), new[] { typeof(List<FoodGoods>) });
            try
            {
                using (var fileStream = new FileStream("goodsCollection.xml", FileMode.Create))
                {
                    serializer.Serialize(fileStream, goods);
                }
                Console.WriteLine("*** Saved. ***");
            }
            catch (Exception ex)
            {
                Console.Write("*** Error! Not saved. *** ");
                Console.WriteLine(ex.Message);
            }
            

            
        }

        // Serialization goods collection to json file
        public static async Task SerializeGoodsToJson()
        {
            Console.WriteLine($"***** Serializing goods list to json... *****");

            using (var fileStream = new FileStream("goodsCollection.json", FileMode.OpenOrCreate))
            {
                string jsonString = JsonConvert.SerializeObject(goods);
                //Console.WriteLine(jsonString);
                byte[] jsonByteArray = System.Text.Encoding.Default.GetBytes(jsonString);
                fileStream.Write(jsonByteArray, 0, jsonByteArray.Length);
                Console.WriteLine("*** Saved. ***");
            }
            

        }

        // Load goods collection from json file
        public static void LoadGoodsFromJson(string fileName)
        {
            Console.WriteLine($"***** Loading goods from json file {fileName} *****");
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    var collection = JsonConvert.DeserializeObject<List<Goods>>(reader.ReadLine());
                    Console.WriteLine("*** Loaded. ***");
                    //foreach (var good in collection) { Console.WriteLine(good.Name); }
                }
            }
            catch (Exception ex)
            {
                Console.Write("*** Error! Not loaded. *** ");
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            #region Create products
            Goods cup = new Goods("Cup", 40, new DateTime(2021,09,10), 20);
            Goods coffeCup = new Goods("Coffee cup", 30, new DateTime(2020,04,21), 200);
            Goods knife = new Goods("Knife", 65, new DateTime(2021,09,10), 50);
            Goods plate = new Goods("Plate", 50, new DateTime(2021,11,15), 100);
            Goods deepPlate = new Goods("Deep plate", 55, new DateTime(2021,11,15), 100);
            Goods spoon = new Goods("Spoon", 15, new DateTime(2022,01,19), 80);
            Goods teaSpoon = new Goods("Tea spoon", 10, new DateTime(2020,04,21), 80);
            Goods fork = new Goods("Fork", 15, new DateTime(2022,01,19), 80);
            FoodGoods sugar = new FoodGoods("Sugar", 32, new DateTime(2021, 12, 25), 400, "Kg", new DateTime(2021,12,11), "365");
            FoodGoods oil= new FoodGoods("Sunfolwer oil", 55, new DateTime(2022, 05, 02), 100, "L", new DateTime(2022,04,24), "60");
            FoodGoods flour= new FoodGoods("Flour", 15, new DateTime(2022, 04, 18), 200, "Kg", new DateTime(2022,04,17), "90");
            FoodGoods bread= new FoodGoods("Bread", 20, new DateTime(2022, 05, 23), 40, "Pcs", new DateTime(2022,05,23), "3");
            FoodGoods egg= new FoodGoods("Eggs", 30, new DateTime(2022, 05, 13), 10, "Dozen", new DateTime(2022,05,11), "21");
            #endregion

            #region Input-Output methods
            /*  sugar.ShowName();
            sugar.ShowEntryPrice();
            sugar.ShowEntryDate();
            sugar.ShowAmount();
            sugar.ShowProductionDate();
            sugar.ShowShelfLife();

            sugar.SetName();
            sugar.SetEntryPrice();
            sugar.SetEntryDate();
            sugar.SetQuantity();
            sugar.SetPruductionDate();
            sugar.SetShelfLife();
        */
            #endregion

            // Console.WriteLine(sugar.ToString());
            // Console.WriteLine(sugar.GetExpirationDays());

            #region Filling collection
            goods.Add(cup);
            goods.Add(coffeCup);
            goods.Add(knife);
            goods.Add(plate);
            goods.Add(deepPlate);
            goods.Add(spoon);
            goods.Add(teaSpoon);
            goods.Add(fork);
            goods.Add(sugar);
            goods.Add(flour);
            goods.Add(bread);
            goods.Add(egg);
            goods.Add(oil);
            goods.Add(new Goods("Napkin", 0.5m, new DateTime(2022, 03, 29), 10000));
            #endregion

            ShowGoods();
        /*  ShowGoodsOfPreviousYear();
            ShowSortedFoodGoods();
            SaveGoodsToFile();
                    
            SerializeGoodsToJson();
            LoadGoodsFromJson("goodsCollection.json");
        */

        }
    }
}
