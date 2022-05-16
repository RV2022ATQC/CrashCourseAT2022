namespace _302
{
    public class Group
    {
        public string Name { get; set; }

        private List<Student> students;
        public List<Student> Students
        {
            get { return students; }
            set { students = new List<Student>(value); }
        }

        public Group(string Name)
        {
            this.Name = Name;
            Students = new List<Student>();
        }

        public Group(string Name, List<Student> Students)
        {
            this.Students = new List<Student>(Students);
            this.Name = Name;
        }

        public double GetAverageMark(string subject)
        {
            double sum = 0;
            foreach (Student student in Students)
            {
                sum += student.AverageMark(subject);
            }

            return (sum / Students.Count);
        }
    }
}