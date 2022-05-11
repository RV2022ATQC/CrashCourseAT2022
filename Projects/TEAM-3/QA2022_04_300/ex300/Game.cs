using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex300
{
    internal class Game
    {
        List<string> words;
        string file_name = "words.txt";
        string word;
        Graphic c3;
        int count;           //загальна кiлькiсть спроб
        int count_step;
        int level;
        char[] charX;

        public Game(Graphic _c)
        {
            words = new List<string>();
            ReadFile(file_name);
            level = 2;
            word = Choice_word();
            c3 = _c;
            Menu();
        }

        private void ReadFile(string _fn)
        {
            words.Clear();
            using (StreamReader reader = new StreamReader(_fn))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }
        }

        string Choice_word()
        {
            Random r = new Random();
            string tmp = words.ElementAt(r.Next(0, words.Count - 1));
            count = tmp.Length * level;
            count_step = 0;
            charX = new char[tmp.Length];
            for (int i = 0; i < tmp.Length; i++) { charX[i] += '\0'; }
            return tmp;
        }

        string Show_wordX()
        {
            string tmp = "";
            for (int i = 0; i < charX.Length; i++)
            {
                if (charX[i] == '\0') tmp += "*";
                else tmp += charX[i];
            }
            return tmp;
        }

        void Menu()
        {
            int ask = 0;
            string str_ask;
            do
            {
                Console.Clear();
                Console.WriteLine("Слово загадане, в якому {0} букв {1}\n", word.Length, Show_wordX());
                Console.WriteLine("1. Загадати нове слово");
                Console.WriteLine("2. Змiнити рiвень складностi. Рiвень : {0}",level);
                Console.WriteLine("3. Ввести букву");
                Console.WriteLine("4. Ввести слово");
                Console.WriteLine("0. Вийти з гри\n");
                c3.Show(count_step, count);
                Console.WriteLine("\nВи викорристали {0} з {1} спроб", count_step, count);
                str_ask = Console.ReadLine();
                try { ask = int.Parse(str_ask); }
                catch (Exception ex) { ask = 100; }
                finally
                {
                    switch (ask)
                    {
                        case 1:
                            {
                                word = Choice_word();
                                break;
                            }

                        case 2:
                            {
                                Console.Write("Загальна кiлькiсть спроб на вгадування, [кiлькiсть букв у загаданому словi] * [рiвень]\nПiсля змiни рiвня складностi буде вибрано iнше слово\nВведiть новий рiвень складностi гри : ");
                                level = Int32.Parse(Console.ReadLine());
                                word = Choice_word();
                                break;
                            }

                        case 3:
                            {
                                char tmp_ch;
                                Console.Write("Введiть букву, яка на вашу думку присутня в словi яке було загадане : ");
                                try { tmp_ch = Convert.ToChar(Console.ReadLine().ToLower()); }
                                catch (Exception ex) { tmp_ch=' '; }

                                count_step++;

                                if (word.Contains(tmp_ch))
                                {
                                    for (int i = 0; i < word.Length; i++)
                                    {
                                        if (word[i] == tmp_ch) charX[i] = tmp_ch;
                                    }

                                    Console.WriteLine("Така буква є в цьому словi : {0}", Show_wordX());
                                }
                                else { Console.WriteLine("Такої букви немає є в цьому словi : {0}", Show_wordX()); }
                                if (word == Show_wordX() || count_step == count) ask = 0;
                                break;
                            }

                        case 4:
                            {
                                Console.Write("Введiть слово, яке на вашу думку яке було загадане : ");
                                string u_word = Console.ReadLine().ToLower();
                                count_step++;
                                if (u_word == word)
                                {
                                    Console.WriteLine("Ви вгадали слово");
                                    Console.ReadKey();
                                    ask = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Ви не вгадали слово");
                                    Console.ReadKey();
                                }
                                if (word == Show_wordX() || count_step == count) { ask = 0; }
                                break;
                            }
                        default: break;
                    }
                }
            } while (ask != 0);
            if (!Win() && (count_step == count))
            {
                Console.WriteLine("Слово не вгадане i Ви використали усi спроби\nБуло загадане слово {0}", word);
                Console.ReadKey();
            }
        }

        bool Win()
        {
            if (word == Show_wordX())
            {
                Console.ReadKey();
                return true;
            }
            else return false;
        }
    }
}
