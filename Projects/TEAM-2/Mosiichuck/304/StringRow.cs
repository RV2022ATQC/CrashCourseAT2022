using System;

namespace _304
{
    class StringRow
    {
        private char[] str;
        public StringRow()
        {
            str = new char[80];
        }

        public StringRow(int lenght)
        {
            str = new char[lenght];
        }

        public StringRow(string str)
        {
            this.str = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                this.str[i] = str[i];
            }
        }

        public void ReadLine(string str)
        {
            if (str.Length > this.str.Length)
            {
                for (int i = 0; i < this.str.Length; i++)
                {
                    this.str[i] = str[i];
                }
            }
            else
            {
                for(int i=0;i<str.Length;i++)
                {
                    this.str[i]=str[i];
                }
            }
        }

        public void PrintLine()
        {
            Console.WriteLine(new string(str));
        }
    }
}
