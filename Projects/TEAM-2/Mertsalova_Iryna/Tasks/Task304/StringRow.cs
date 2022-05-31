using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task304
{
    public class StringRow
    {
        private string line;
        StringBuilder str = new StringBuilder();
        public string getLine()
        {
            return this.line;
        }
        public void setLine(string _line)
        {
            if (_line.Length != 0)
            {
                this.line = _line;
            }
            else
            {
                this.line = "null";
            }
        }

        public StringRow()
        {
            str.Length = 80;
            setLine(str.ToString());
        }

        public StringRow(int rowSize)
        {
            str.Length = rowSize;
            setLine(str.ToString());
        }

        public StringRow(string _line)
        {
            setLine(_line);
        }

        public void fillLine()
        {
            Console.Write(" Enter new line: ");
            string newLine = Console.ReadLine();
            setLine(newLine);
            printLine();
        }

        public void printLine()
        {
            Console.WriteLine($" Your line: \n {getLine()}\n");
        }
    }
}
