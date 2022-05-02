using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

/* Створити колекцію транспорту, додати кілька різних видів транспорту та автомобілів до цієї колекції
реалізуйте виведення автомобілів старіших ніж 10 років
відсортуйте інформацію за брендом та моделлю
збережіть колекцію у файл
реалізуйте опрацювання виключень (Exceptions)
сереалізуйте (Serialize) колекцію в XML файл
десереалізуйте колекцію з XML файла
напишіть unit тести до реалізованих функцій*/


namespace final
{
    // Создать объект типа IComparer для объектов класса Inventory.
    class CompInv1 : IComparer
    {
        // Реалізовано интерфейс IComparer.
        public int Compare(object x, object y)
        {
            Transport a, b;
            a = (Transport)x;
            b = (Transport)y;
            return string.Compare(a.kind, b.kind, StringComparison.Ordinal);
        }
    }
    class CompInv2 : IComparer
    {
        // Реалізовано интерфейс IComparer.
        public int Compare(object x, object y)
        {
            Transport a, b;
            a = (Transport)x;
            b = (Transport)y;
            return string.Compare(a.vehicle, b.vehicle, StringComparison.Ordinal);
        }
    }

    class CompInv3 : IComparer
    {
        // Реалізовано интерфейс IComparer.
        public int Compare(object x, object y)
        {
            Transport a, b;
            a = (Transport)x;
            b = (Transport)y;
            return string.Compare(a.brend, b.brend, StringComparison.Ordinal);
        }
    }
    class CompInv4 : IComparer
    {
        // Реалізовано интерфейс IComparer.
        public int Compare(object x, object y)
        {
            Transport a, b;
            a = (Transport)x;
            b = (Transport)y;
            if (a.brend == b.brend)
                return string.Compare(a.model, b.model, StringComparison.Ordinal);
            else
                return 0;
        }
    }
    [Serializable]
    public class Transport
    {
        [XmlElement()]
        public string kind;
        [XmlElement()]
        public string vehicle;
        [XmlElement()]
        public string brend;
        [XmlElement()]
        public string model;
        [XmlElement()]
        public int year_of_production;
        public Transport(string _kind, string _vehicle, string _brend,string _model,int year)
        {
            kind = _kind;
            vehicle = _vehicle;
            brend = _brend;
            model = _model;
            year_of_production = year;

        }
        public Transport()
        { }
        public override string ToString()
        {
            return
            String.Format("Kind: {0} Vehicle : {1} Brand: {2} Model: {3} Year: {4} ",
            kind, vehicle, brend, model, year_of_production);
        }
    }
    class Program
    {
        #region SerializationExamples

        //серіалізація у XML
        public static async void XmlSerializationExample(List<Transport> tCollection)
        {
            Console.WriteLine($"---------------XMLSerializationExample----------------");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Transport>));
            Stream fileStream = new FileStream("e:\\tCollection.xml", FileMode.Create);
            try
            {
                serializer.Serialize(fileStream, tCollection);
                fileStream.Close();
                Console.WriteLine("Serialization completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("You can check serealized XML file.  Press ENTER to continue...");
            Console.ReadLine();
        }
        public static  List<Transport> DeserializeObject(string filename)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Transport>));
            List<Transport> t;
            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                t = (List<Transport>)serializer.Deserialize(reader);
            }
            return t;
        }
        #endregion SerializationExamples
        static void Main(string[] args)
        {
            CompInv3 comp3 = new CompInv3();
            CompInv4 comp4 = new CompInv4();
            ArrayList inv = new ArrayList();
            // Добавить элементы в список.
            inv.Add(new Transport("land ","car", "renault", "kadjar",2022));
            inv.Add(new Transport("land ", "car", "renault", "logan", 2021));
            inv.Add(new Transport("land ", "car", "renault", "duster", 2022));
            inv.Add(new Transport("land ", "car", "renault", "logan", 2006));
            inv.Add(new Transport("land ", "car", "renault", "duster", 2010));
            inv.Add(new Transport("land", "car", "fiat", "tipo", 2000));
            inv.Add(new Transport("water", "ship", "yamaha", "island", 2003));
            inv.Add(new Transport("earth", "airplane", "fighter ", "f-16", 2022));
            Console.WriteLine("Колекція до сортування:");
            foreach (Transport i in inv)
            {
                Console.WriteLine(" " + i);
            }
            Console.WriteLine();
            // Отсортировать список, используя интерфейс IComparer.
            inv.Sort(comp3);
          inv.Sort(comp4);
            Console.WriteLine("Колекція після сортування:");
            foreach (Transport i in inv)
            {
                Console.WriteLine(" " + i);
            }
            Console.WriteLine("Авто старші 10 років:");
            foreach (Transport i in inv)
            {
                 if (i.vehicle=="car"&& 2022-i.year_of_production>=10) Console.WriteLine(" " + i);
            }
            //запис колекції в файл
            StreamWriter log_out = null;
            try
            {
                log_out = new StreamWriter("e:\\logfile.txt");
                // Переадресувати стандартный вивід в файл logfile.txt.
                Console.SetOut(log_out);
                foreach (Transport i in inv)
                {
                    Console.WriteLine(" " + i);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Помилка ввода-вивода\n" + exc.Message);
            }
            finally
            {
                if (log_out != null) log_out.Close();
               
            }

            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            //серилізація
            List<Transport> tCollection=new List<Transport>();
            tCollection.Add(new Transport("land ", "car", "renault", "kadjar", 2022));
            tCollection.Add(new Transport("land ", "car", "renault", "logan", 2021));
            tCollection.Add(new Transport("land ", "car", "renault", "duster", 2022));
            tCollection.Add(new Transport("land ", "car", "renault", "logan", 2006));
            tCollection.Add(new Transport("land ", "car", "renault", "duster", 2010));
            tCollection.Add(new Transport("land", "car", "fiat", "tipo", 2000));
            tCollection.Add(new Transport("water", "ship", "yamaha", "island", 2003));
            tCollection.Add(new Transport("earth", "airplane", "fighter ", "f-16", 2022));
            XmlSerializationExample(tCollection);
            Console.WriteLine("Deserialization");
           List<Transport> ti=DeserializeObject("e:\\tCollection.xml");
            foreach (Transport i in ti)
            {
                Console.WriteLine(" " + i);
            }
            Console.ReadLine();

        }
        
    }
    
}
