namespace CS50
{
    public class GetUserInput
    {
        public static int Get_Int(string message)
        {
            int tmp;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out tmp));
            return tmp;
        }

        public static float Get_Float(string message)
        {
            float tmp;
            do
            {
                Console.Write(message);
            } while (!float.TryParse(Console.ReadLine(), out tmp));
            return tmp;
        }

        public static string Get_String(string message)
        {
            string tmp;
            do{
                Console.Write(message);
                tmp = Console.ReadLine();
            } while (string.IsNullOrEmpty(tmp));
            return tmp;
        }
    }
}
