using System.Text;

namespace CSharpDemo;

public class Student
    {
        //Properties
        public string name { get; set; }
        public int age { get; set; }
        public List<Test> testList { get; set; }

        //Constructers
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            testList = new List<Test>();
        }

        public Student(string name, int age, List<Test> test)
        {
            this.name = name;
            this.age = age;
            this.testList = test;
        }

        public Student()
        {
            testList = new List<Test>();
        }

        //Methods
        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine("Student: " + name + " " + age);
            foreach(Test b in testList)
            {
                a.AppendLine(b.ToString());
            }
            return a.ToString();
        }
    }
