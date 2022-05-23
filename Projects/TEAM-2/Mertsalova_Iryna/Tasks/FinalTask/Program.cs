using FinalTask.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinalTask
{
    class Program
    {
        // *Опишіть клас Тварини, який містить поля: РікНародження, Колір
        // конструктор з параметрами, функції консольного введення та виведення полів Getteres Setters
        // Метод GetAge() що виводить повні роки, overridden ToString() метод, який викликає метод Voice()

        // Реалізуйте клас наслідник Fish, який має додаткові поля Kind(морська\річкова), Species.
        // Конструктор з параметрами, додаткові getters та setters.Overridden input() та output()

        // Створіть колекцію тварин, додати кілька різних тварин та риб до цієї колекції
        // реалізуйте виведення риб старіших ніж 3 роки, відсортуйте інформацію за видом (Species)
        // збережіть колекцію у файл, реалізуйте опрацювання виключень (Exceptions)
        // сереалізуйте (Serialize) колекцію в XML файл, десереалізуйте колекцію з XML файла
        // напишіть unit тести до реалізованих функцій

        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal("cat", 2020, "grey"),
                new Fish("bychok", 2021, "dark-yellow", "river","bychok zvychaynyy"),
                new Fish("korop", 2022, "dark", "river","korop zvychaynyy"),
                new Animal("parrot", 2020, "different-colors"),
                new Fish("losos'", 2021, "brown", "sea","losos' zvychaynyy"),
                new Animal("dog", 2019, "black"),
                new Fish("karas'", 2020, "dark-brown", "river", "karas' zvychaynyy"),
                new Animal("horse", 2015, "brown")
            };
            
            // write to txt file
            write_txt_file(animals);

            // serealization 
            XmlSerializationExample(animals);
            Console.WriteLine("Deserialization");
            DeserializeObject($"{Directory.GetParent(Environment.CurrentDirectory)}/serializer.xml");
        }

        private static void write_txt_file(List<Animal> animals)
        {
            StreamWriter log_out = null;
            try
            {
                log_out = new StreamWriter($"{Directory.GetParent(Environment.CurrentDirectory)}/file.txt");
                Console.SetOut(log_out);
                foreach (var item in animals)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Writing completed");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error output/input\n" + exc.Message);
            }
            finally
            {
                if (log_out != null)
                {
                    log_out.Close();
                }
            }
            var stOutput = new StreamWriter(Console.OpenStandardOutput());
            stOutput.AutoFlush = true;
            Console.SetOut(stOutput);        
        }

        private static void XmlSerializationExample(List<Animal> animals)
        {
            Console.WriteLine($"---------------XMLSerializationExample----------------");
            Stream fileStream = new FileStream($"{Directory.GetParent(Environment.CurrentDirectory)}/serializer.xml", FileMode.Create);

            try
            {
                foreach (var item in animals)
                {
                    XmlSerializer serializer = new XmlSerializer(item.GetType());
                    serializer.Serialize(fileStream, item);
                }
                Console.WriteLine("Serialization completed");
                fileStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("You can check serealized XML file.");
            Console.ReadLine();
            fileStream.Close();
        }
        private static void DeserializeObject(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>));
            List<Animal> an;
            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                try
                {
                    an = (List<Animal>)serializer.Deserialize(reader);
                    Console.WriteLine(an.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
