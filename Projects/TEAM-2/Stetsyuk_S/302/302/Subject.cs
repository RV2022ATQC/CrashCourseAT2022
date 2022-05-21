namespace _302
{
    public class Subject
    {

        public Subject(string Name, List<int> Marks)
        {
            this.Name = Name;
            marks = new List<int>(Marks);
        }
        public string Name { get; set; }

        private List<int> marks;
        public List<int> Marks
        {
            get { return marks; }
            set { marks = new List<int>(value); }
        }

        public double Average()
        {
            return Marks.Average();
        }
    }
}