using NUnit.Framework;
using final_task;
using System.Collections.Generic;
using System;
using System.IO;

namespace Test_Vehicles
{
    [TestFixture]
    public class Tests
    {
        public static List<Vehicle> vehicles;

        [OneTimeSetUp]
        public void NewVehicles()
        {
            List<Vehicle> vehicle = new List<Vehicle>();
            vehicle.Add(new Bus("Navigo", 2000, "T", 400_000));
            vehicle.Add(new Car("Mini", 2022, "Cuper", 8_000));
            vehicle.Add(new Bike("Trek Daytona", 2015, "Shimano Nexus 7"));
            vehicles = new List<Vehicle>(vehicle);
        }

        [Test]
        public void Test_to_string_Car()
        {
            //Arrange 
            string Brand = "Ford";
            uint Year = 2009;
            string Model = "Fusion";
            uint Race = 4_000;
            Car car = new Car(Brand, Year, Model, Race);
            string expect = ("Car" + "\tBrand: " + Brand + "\tModel: " + Model + "\tYear of production: " + Year + "\tRace: " + Race);

            //Act
            string carstr = car.ToString();

            //Assert
            Assert.AreEqual(expect, carstr);
        }

        [Test]
        public void Test_to_string_Bus()
        {
            //Arrange                                                         
            string Brand = "brand bus";
            uint Year = 2010;
            string Model = "model bus";
            uint Race = 8_000;
            Bus bus = new Bus(Brand, Year, Model, Race);
            string expect = ("Bus" + "\tBrand: " + Brand + "\tModel: " + Model + "\tYear of production: " + Year + "\tRace: " + Race);

            //Act
            string busstr = bus.ToString();

            //Assert
            Assert.AreEqual(expect, busstr);
        }


        [Test]
        public void Test_to_string_Bike([Values("str1", "str2")] string str)
        {
            //Arrange
            var random = new Random();
            uint year = (uint)random.Next(1900, 2022);
            Bike bike = new Bike(str, year, str);
            string expect = ("Bike" + "\tBrand: " + str + "\tModel: " + str + "\tYear of production: " + year);

            //Act
            string bikestr = bike.ToString();

            //Assert
            System.Console.WriteLine(expect);
            System.Console.WriteLine(bikestr);
            Assert.AreEqual(expect, bikestr);
        }

        [Test]
        public void Test_Older_then_10()
        {
            //Arrange
            List<Vehicle> older_then_10 = new List<Vehicle>();

            //Act
            older_then_10 = vehicles.FindAll(el => el.Older_then_10());

            //Assert
            bool check = true;
            foreach (var item in older_then_10)
            {
                if (!item.Older_then_10())
                    check = false;
            }
            Assert.IsTrue(check);
        }

        [Test]
        public void Test_Sort()
        {
            //Arrange
            Bus expectBus = new Bus("Navigo", 2000, "T", 400_000);
            Car expectCar = new Car("Mini", 2022, "Cuper", 8_000);
            Bike expectBike = new Bike("Trek Daytona", 2015, "Shimano Nexus 7");

            //Act
            vehicles.Sort();

            //Assert
            Assert.AreEqual(expectCar, vehicles[0]);
            Assert.AreEqual(expectBus, vehicles[1]);
            Assert.AreEqual(expectBike, vehicles[2]);
        }

        [Test]
        public void TestSerialization()
        {   //Arrange
            string xmlFile = "Vehicles.xml";

            //Act
            Program.Serialize(vehicles);

            //Assert
            Assert.IsTrue(File.Exists(xmlFile));
        }

        [Test]
        public void TestDeserialization()
        {   //Arrange
            Program.Serialize(vehicles);
            List<Vehicle> actuallist = new List<Vehicle>();

            //Act
            actuallist = Program.Deserialize();

            //Assert
            Assert.AreEqual(vehicles, actuallist);
        }

        [Test]
        public void Test_ToFile()
        {   //Arrange
            string txtFile = "Vehicle.txt";

            //Act
            Program.ToFile(vehicles);

            //Assert
            Assert.IsTrue(File.Exists(txtFile));
        }
    }

}