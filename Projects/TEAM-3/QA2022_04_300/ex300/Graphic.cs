using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex300
{
    internal class Graphic:IGraphic
    {
        public void Show(int _curr, int _max)
        {
            string line1 = "  " + (char)('\u2554') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2555') + " " + " ";
            line1+= "\n  " + (char)('\u2551') + "\n  " + (char)('\u2551') + "\n  " + (char)('\u2551') +  "\n " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588') + "   " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588');
            string line2 = "  " + (char)('\u2554') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2555') + " " + " ";
            line2 += "\n  " + (char)('\u2551')+ "     O" + "\n  " + (char)('\u2551') + "\n  " + (char)('\u2551') + "\n " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588') + "   " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588');
            string line3 = "  " + (char)('\u2554') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2555') + " " + " ";
            line3 += "\n  " + (char)('\u2551') + "     O" + "\n  " + (char)('\u2551') + "    /" + (char)('\u2588') + "\\" + "\n  " + (char)('\u2551') + "\n " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588') + "   " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588');
            string line4 = "  " + (char)('\u2554') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2555') + " " + " ";
            line4 += "\n  " + (char)('\u2551') + "     O" + "\n  " + (char)('\u2551') + "    /" + (char)('\u2588') + "\\" + "\n  " + (char)('\u2551') + "    / \\" + "\n " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588') + "   " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588');
            string line5 = "  " + (char)('\u2554') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2550') + (char)('\u2555') + " " + " ";
            line5 += "\n  " + (char)('\u2551') + "     O" + "\n  " + (char)('\u2551') + "    /" + (char)('\u2588') + "\\" + "\n  " + (char)('\u2551') + "    / \\" + "\n " + (char)('\u2588') + (char)('\u2588') + (char)('\u2588');


            double pers1 = 100 / _max * _curr;
            
            if(pers1 <= 20)
            {
                Console.WriteLine(line1);
            }
            if (pers1 > 20 && pers1 <= 40)
            {
                Console.WriteLine(line2);
            }
            if (pers1 > 40 && pers1 <= 60)
            {
                Console.WriteLine(line3);
            }
            if (pers1 > 60 && pers1 < 100)
            {
                Console.WriteLine(line4);
            }
            if (_curr == _max)
            {
                Console.WriteLine(line5);
            }
        }
    }
}
