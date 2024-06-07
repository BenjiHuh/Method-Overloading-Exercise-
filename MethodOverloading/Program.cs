namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Add(3.15, 2234.24));
            Console.WriteLine(Add(4, 7, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(6, 8, false));
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private static string Add(int num1, int num2, bool isTrue)
        {
            if (isTrue)
            {
                string solution = ((num1 + num2) > 1) ? num1 + num2 + " dollars" : "1 dollar";
                return solution;
            }

            return $"{num1 + num2}";
        }
    }
}
