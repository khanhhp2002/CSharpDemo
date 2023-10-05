namespace CSharpDemo;

public class Test{
        public string subject { get; set; }
        public float point { get; set; }

        public Test(string subject, float point)
        {
            this.subject = subject;
            this.point = point;
        }
        public override string ToString()
        {
            return "Test: " + subject + " " + point;
        }
    }
