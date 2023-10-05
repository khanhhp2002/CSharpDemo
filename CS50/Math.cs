namespace CS50
{
    public class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static float Divide(int a, int b)
        {
            return (float)a / b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Modulo(int a, int b)
        {
            return a % b;
        }

        public static int Power(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        public static int Factorial(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int GCD(int a, int b)
        {
            int tmp;
            while (b != 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }

        public static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

    }
}
