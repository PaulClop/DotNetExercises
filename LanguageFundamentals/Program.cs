namespace LanguageFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -----------------
            // ### Problem 1   | ----------------------------------------
            // _________________

            //int a, b;
            //Console.WriteLine("a, b =");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            //Console.Write($"a = {a} iar b = {b}");
            //Console.WriteLine();

            //(a, b) = (b, a);

            //Console.Write($"a = {a} iar b = {b}");

            //(a, b) = swapbits(a, b);
            //Console.WriteLine();
            //Console.Write($"a = {a} iar b = {b}");

            // -----------------
            // ### Problem 2   | ----------------------------------------
            // _________________

            int a, b;
            Console.WriteLine("a*x + b = 0");
            Console.WriteLine("a, b = ");
            do
            {
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Pentru a*x + b = 0 => x = {0}", -b / a);


        }

        public static (int, int) swapbits(int a, int b)
        {
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            return (a, b);
        }
    }
}
