namespace _314
{
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        public Student(string name, string group, int age)
        {
            Name = name;
            Group = group;
            Age = age;
        }

        public override string ToString()
        {
            return "I'm " + Name + ", I'm" + Age + " student of " + Group + " group";
        }
    }
}
