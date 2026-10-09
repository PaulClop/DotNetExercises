using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please input your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + "!");

            //float a, b;
            //Console.WriteLine("a = ");
            //a = float.Parse(Console.ReadLine());

            //Console.WriteLine("b = ");
            //b = float.Parse(Console.ReadLine());

            //Console.WriteLine("a + b = {0}", a + b);

            // $"a + b = {a + b}"

            int n, x;
            var numbers = new List<int>();
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                x = int.Parse(Console.ReadLine());
                if (x != 0 && x % 100 == 0)
                    break;
                numbers.Add(x);
            }

            Console.WriteLine();
            foreach (int num in numbers)
                Console.WriteLine(num);
        }
    }
}
