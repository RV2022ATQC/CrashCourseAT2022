namespace _302
{
    public class Student
    {
        public Student(string Name)
        {
            this.Name = Name;
            Subjects = new List<Subject>();
        }

        public string Name { get; set; }


        private List<Subject> subjects;
        public List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = new List<Subject>(value); }
        }

        public double AverageMark(string subject)
        {
            var index = Subjects.FindIndex(el => el.Name == subject);
            return Subjects[index].Average();
        }
    }
}