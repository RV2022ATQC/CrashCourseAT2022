using final_task;
using System.Xml.Serialization;

//  *Створити колекцію транспорту, додати кілька різних видів
//  транспорту та автомобілів до цієї колекції
//  реалізуйте виведення автомобілів старіших ніж 10 років
//  відсортуйте інформацію за брендом
//  збережіть колекцію у файл
//  реалізуйте опрацювання виключень (Exceptions)
//  сереалізуйте(Serialize) колекцію в XML файл
//  десереалізуйте колекцію з XML файла
//напишіть unit тести до реалізованих функцій

public class Program
{
    public static readonly string xmlfile = "Vehicles.xml";
    public static readonly string txtfile = "Vehicle.txt";

    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        //Додавання об'єктів до колекції
        vehicles.Add(new Car("Mini", 2022, "Cuper", 8_000));
        vehicles.Add(new Car("Mazda", 2010, "Rx7", 30_000));
        vehicles.Add(new Bus("Navigo", 2000, "T", 400_000));
        vehicles.Add(new Bike("Trek Daytona", 2015, "Shimano Nexus 7"));
        vehicles.Add(new Bus("ULYSO", 2007, "B", 200_000));
        vehicles.Add(new Car("Mercedes-Benz", 2005, "w206", 50_000));


        Console.WriteLine("All Vehicle:");
        foreach (var item in vehicles)
        {
            Console.WriteLine(item);
        }


        //Show transport, which are older than 10 years
        Console.WriteLine("\n\nTransport, which are older than 10 years");
        foreach (var vehicle in vehicles)
        {
            if (vehicle.Older_then_10())
                Console.WriteLine(vehicle);
        }

        //Write down to file
        ToFile(vehicles);

        //Sort
        Console.WriteLine("\n\nVehicle after sort");
        vehicles.Sort();
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }

        Serialize(vehicles);

        List<Vehicle> newlist = Deserialize();

        Console.WriteLine("\n\nNew list from xml:");
        foreach (var vehicle in newlist)
        {
            Console.WriteLine(vehicle);
        }
    }




    public static void ToFile(List<Vehicle> vehicles)
    {
        StreamWriter File_out = null;
        try
        {
            File_out = new StreamWriter(txtfile);
            Console.SetOut(File_out);

            foreach (var i in vehicles)
            {
                Console.WriteLine(" " + i);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Eror: " + ex.Message);
        }
        finally
        {
            if (File_out is not null)
                File_out.Close();
            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);

        }
    }

    public static void Serialize(List<Vehicle> vehicles)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>));
        Stream fileStream = new FileStream(xmlfile, FileMode.Create);
        try
        {
            serializer.Serialize(fileStream, vehicles);
            Console.WriteLine("\n\nSerialization into xml is successful");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n\nError: " + ex.Message);
        }
        finally { fileStream.Close(); }
    }

    public static List<Vehicle> Deserialize()
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>));
        List<Vehicle> newlist = new List<Vehicle>();
        try
        {
            Stream reader = new FileStream(xmlfile, FileMode.Open);
            newlist = (List<Vehicle>)serializer.Deserialize(reader);
            Console.WriteLine("\n\nDeserialization is successful");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n\nError: " + ex.Message);
        }
        return newlist;
    }
}