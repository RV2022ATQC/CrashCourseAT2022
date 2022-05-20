namespace _302
{
    class Student
    {
        public string Name { get; set; }
        public int Math { get; set; }
        public int Prog { get; set; }
        public int Ukr { get; set; }
        public Student(string name, int math, int prog, int ukr)
        {
            Name = name;
            Math = math;
            Prog = prog;
            Ukr = ukr;
        }

        public override string ToString()
        {
            return "Student " + Name + " has grades in math: " + Math + ", prog: " + Prog + ", ukr: " + Ukr;
        }
    }
}
