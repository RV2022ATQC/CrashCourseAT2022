using System;

namespace ex320
{
    public class XML_figure // Class for searizable. Univrsal class for all type figures
    {
        public string type;
        public string name;
        public w_color color;
        public DateTime datecreate;
        public double size1;
        public double size2;
        public double size3;

        public XML_figure()
        {
            type = "";
            name = "";
            color = w_color.black;
            datecreate = DateTime.Now;
            size1 = 0;
            size2 = 0;
            size3 = 0;
        }
        public XML_figure(string _t, string _n, w_color _c, DateTime _d, double _s1, double _s2 = 0, double _s3 = 0)
        {
            type = _t;
            name = _n;
            color = _c;
            datecreate = _d;
            size1 = _s1;
            size2 = _s2;
            size3 = _s3;
        }
    }
}
