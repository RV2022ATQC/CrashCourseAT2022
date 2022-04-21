using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace ex320
{
    internal class UI //user interface
    {
        static string isName(Figure _f)
        {
            if (_f is Circle) return "Circle";
            else if (_f is Rectangle) return "Rectangle";
            else if (_f is Trapezoid) return "Trapezoid";
            else return "";
        }
        public static void ShowList(List<Figure> _f, int _diff_days = 0)
        {
            if (_f.Count == 0) Console.WriteLine("List is empty");
            else
            {
                int i = 1;
                foreach (Figure f in _f)
                {
                    if (_diff_days==0 || f.GetCreateDate() <= _diff_days)
                    {
                        Console.WriteLine("Item {0} of {1} from list. Figure is {2}", i, _f.Count, isName(f));
                        f.Output();
                        Console.WriteLine();
                        i++;
                    }
                }
            }
        }

        public static void AddListDefault (List<Figure> _f)
        {
            _f.Add((Figure)(new Circle("Circle1", w_color.green, new DateTime(2022, 04, 15), 12)));
            _f.Add((Figure)(new Circle("Circle2", w_color.red, new DateTime(2022, 04, 17), 10)));
            _f.Add((Figure)(new Circle("Circle3", w_color.blue, new DateTime(2022, 04, 12), 8)));
            _f.Add((Figure)(new Rectangle("Rectangle1", w_color.blue, new DateTime(2022, 04, 16), 5, 7)));
            _f.Add((Figure)(new Rectangle("Rectangle2", w_color.grey, new DateTime(2022, 04, 14), 4, 8)));
            _f.Add((Figure)(new Rectangle("Rectangle3", w_color.silver, new DateTime(2022, 04, 15), 7, 5)));
            _f.Add((Figure)(new Rectangle("Rectangle4", w_color.white, new DateTime(2022, 04, 10), 2, 6)));
            _f.Add((Figure)(new Rectangle("Rectangle5", w_color.black, new DateTime(2022, 04, 16), 7, 10)));
            _f.Add((Figure)(new Rectangle("Rectangle6", w_color.yellow, new DateTime(2022, 04, 17), 5, 12)));
            _f.Add((Figure)(new Rectangle("Rectangle7", w_color.red, new DateTime(2022, 04, 18), 7, 9)));
            _f.Add((Figure)(new Trapezoid("Trapezoid1", w_color.white, new DateTime(2022, 04, 18), 10, 5, 4)));
            _f.Add((Figure)(new Trapezoid("Trapezoid2", w_color.grey, new DateTime(2022, 04, 20), 12, 7, 5)));
            _f.Add((Figure)(new Trapezoid("Trapezoid3", w_color.silver, new DateTime(2022, 04, 17), 7, 5, 4)));
            _f.Add((Figure)(new Trapezoid("Trapezoid4", w_color.black, new DateTime(2022, 04, 19), 15, 7, 5)));
            Console.WriteLine("Figures added to the list\n");
        }

        public static void AddAnyFigure(List<Figure> _fl)
        {
            int ask = 0;
            string type_f="";

            Console.WriteLine("Choose the type of shape you want to add");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Trapezoid");
            try { ask = int.Parse(Console.ReadLine()); }
            catch (Exception ex) { ask = 0; }
            switch (ask)
            {
                case 1: 
                    {
                        Figure f = new Circle();
                        type_f = "Circle";
                        f.Input();
                        _fl.Add(f);
                        break;
                    }
                case 2:
                    {
                        Figure f = new Rectangle();
                        type_f = "Rectangle";
                        f.Input();
                        _fl.Add(f);
                        break;
                    }
                case 3:
                    {
                        Figure f = new Trapezoid();
                        type_f = "Trapezoid";
                        f.Input();
                        _fl.Add(f);
                        break;
                    }
                default: break;
            }
            Figure tmp = _fl[_fl.Count - 1];
            Console.WriteLine("\nShape ({0}) added to the end of the list\n",type_f);
            tmp.Output();
            Console.WriteLine();
        }

        public static void DeleteAnyFigure (List<Figure> _fl)
        {
            int d = 0;

            Console.Write("Select the number of the shape list you want to delete : ");
            try { d = int.Parse(Console.ReadLine()); }
            catch (Exception ex) { d = 0; }
            if (d > 0 && d <= _fl.Count)
            {
                Figure tmp = _fl[d - 1];
                Console.WriteLine("The shape {0} is deleted", isName(tmp));
                tmp.Output();
                Console.WriteLine();
                _fl.RemoveAt(d - 1);
            }
            else { Console.WriteLine("There is no such item in this list.\n"); }
        }

        public static void Sort (List<Figure> _fl) //sortered rectangles add first in list of figures
        {
            List<Rectangle> tmp_r = new List<Rectangle>(); //list with rectangles
            List<Figure> tmp_f = new List<Figure>(); // list without rectangles

            foreach (Figure f in _fl)
            {
                if (f is Rectangle) { tmp_r.Add((Rectangle)f); }
                else tmp_f.Add(f);
            }
            List<Rectangle> sort = (from r in tmp_r orderby r.Height select r).ToList();
            _fl.Clear();
            foreach (Rectangle r in sort) { _fl.Add((Figure)r); }
            foreach (Figure f in tmp_f) { _fl.Add(f); }
            Console.WriteLine("The list is sorted.\nSorted rectangles at the beginning of the list\n");
        }

        public static void SaveXML (List<Figure> _fl, string _fn)
        {
            string type_figure;
            Circle c;
            Rectangle r;
            Trapezoid t;

            List<XML_figure> xml_list = new List<XML_figure>();
            foreach (Figure f in _fl)
            {
                type_figure = isName(f);
                if (type_figure == "Circle") 
                {
                    c = (Circle)f;
                    xml_list.Add(new XML_figure("Circle", c.Name, c.Color, c.DateCreate, c.Radius)) ;
                }
                else if (type_figure == "Rectangle") 
                {
                    r= (Rectangle)f;
                    xml_list.Add(new XML_figure("Rectangle", r.Name, r.Color, r.DateCreate, r.Height, r.Width));
                }
                else if (type_figure == "Trapezoid") 
                {
                    t= (Trapezoid)f;
                    xml_list.Add(new XML_figure("Trapezoid", t.Name, t.Color, t.DateCreate, t.Base_Big, t.Base_Small, t.Height));
                }
            }

            XmlSerializer xml_f = new XmlSerializer(typeof(List<XML_figure>));
            try
            {
                using (Stream fstream = File.Create(_fn)) { xml_f.Serialize(fstream, xml_list); }
                Console.WriteLine("Information saved in file : {0}\n",_fn);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public static void LoadXML(List<Figure> _fl, string _fn)
        {
            Figure f1;
            List<XML_figure> xml_list = new List<XML_figure>();
            XmlSerializer xml_f = new XmlSerializer(typeof(List<XML_figure>));
            
            try
            {
                using (Stream fstream = File.OpenRead(_fn)) { xml_list = (List<XML_figure>)xml_f.Deserialize(fstream); }
                Console.WriteLine("Information readed from file : {0}\n", _fn);
                _fl.Clear();
                foreach (XML_figure f in xml_list)
                {
                    if (f.type == "Circle")
                    {
                        f1 = new Circle(f.name, f.color, f.datecreate, f.size1);
                        _fl.Add(f1);
                    }
                    else if (f.type == "Rectangle")
                    {  
                        f1 = new Rectangle(f.name, f.color, f.datecreate, f.size1, f.size2);
                        _fl.Add(f1);
                    }
                    else if (f.type == "Trapezoid")
                    {
                        f1 = new Trapezoid(f.name, f.color, f.datecreate, f.size1, f.size2, f.size3);
                        _fl.Add(f1);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public static void Menu(List<Figure> _fl, string _fn)
        {
            int ask = 0;
            string str_ask;
            do
            {
                Console.WriteLine("1.  Show all list of figures");
                Console.WriteLine("2.  Clear all list of figures");
                Console.WriteLine("3.  Add in list of default figures");
                Console.WriteLine("4.  Add any figures in list of figures");
                Console.WriteLine("5.  Delete any figures from list of figures");
                Console.WriteLine("6.  Show figures younger than 7 days");
                Console.WriteLine("7.  Sort rectangle in list of figures");
                Console.WriteLine("8.  Save list of figures in XML file");
                Console.WriteLine("9.  Load list of figures from XML file");
                Console.WriteLine("10. Clear of screen");
                Console.WriteLine("0.  Exit");
                str_ask = Console.ReadLine();
                try { ask = int.Parse(str_ask); }
                catch (Exception ex) { ask = 100; }
                finally
                {
                    switch (ask)
                    {
                        case 1: { ShowList(_fl); break; }
                        case 2: { _fl.Clear(); Console.WriteLine("List is empty"); break; }
                        case 3: { AddListDefault(_fl); break; }
                        case 4: { AddAnyFigure(_fl); break; }
                        case 5: { DeleteAnyFigure(_fl); break; }
                        case 6: { ShowList(_fl, 7); break; }
                        case 7: { Sort(_fl); break; }
                        case 8: { SaveXML(_fl, _fn); break; }
                        case 9: { LoadXML(_fl, _fn); break; }
                        case 10: { Console.Clear(); break; }
                        default: break;
                    }
                }
            } while (ask != 0);
        }
    }
}