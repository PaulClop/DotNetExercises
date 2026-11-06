namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -----------------
            // ### Problem 1   | ----------------------------------------
            // _________________

            //string input;
            //int noA = 0, noD = 0, noS = 0;
            //Console.WriteLine("Input = ");
            //input = Console.ReadLine()?.Trim() ?? string.Empty;

            //foreach (char c in input)
            //{
            //    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            //    {
            //        noA++;
            //        continue;
            //    }

            //    if (c >= '0' && c <= '9')
            //    {
            //        noD++;
            //        continue;
            //    }

            //    noS++;
            //}

            //Console.WriteLine($"noA = {noA}; noD = {noD}; noS = {noS}");

            // -----------------
            // ### Problem 2   | ----------------------------------------
            // _________________

            //int distance, h, m, s;
            //double speed = 0;

            //Console.Write("distance = ");
            //if (!int.TryParse(Console.ReadLine(), out distance))
            //{
            //    distance = 0;
            //}

            //Console.Write("h = ");
            //if (!int.TryParse(Console.ReadLine(), out h))
            //{
            //    h = 0;
            //}

            //Console.Write("m = ");
            //if (!int.TryParse(Console.ReadLine(), out m))
            //{
            //    m = 0;
            //}

            //Console.Write("s = ");
            //if (!int.TryParse(Console.ReadLine(), out s))
            //{
            //    s = 0;
            //}

            //if (h == 0 && m == 0 & s == 0) s = 1;

            //// 50_000, 1, 35, 36

            //long t;
            //t = h * 3600 + m * 60 + s;

            //speed = distance / (double)t;

            //Console.WriteLine("Speed m/s: {0}", speed);

            //speed = speed / 1000 * 3600;

            //Console.WriteLine("Speed km/h: {0}", speed);

            //Console.WriteLine("Speed miles/h: {0}", speed * 0.621371);

            // -----------------
            // ### Problem 3   | ----------------------------------------
            // _________________

            //int n;
            //Console.Write("n = ");
            //if (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    n = 0;
            //}

            //Console.WriteLine($"{n:b}");

            //if (n == 0)
            //{
            //    Console.Write("0");
            //    return;
            //}

            //if (n < 0)
            //{
            //    Console.Write("-");
            //    n = -n; // Note: int.MinValue would overflow here
            //}

            //print_int_to_byte(n);

            // -----------------
            // ### Problem 4   | ----------------------------------------
            // _________________

            int x;
            Console.Write("x = ");
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                x = 0;
            }

            int y;
            Console.Write("y = ");
            if (!int.TryParse(Console.ReadLine(), out y))
            {
                y = 0;
            }

            if (x == 0 && y == 0)
            {
                Console.Write($"Punctul ({x}, {y}) se afla in origine.");
                return;
            }

            if (x < 0)
            {
                if (y < 0)
                {
                    Console.Write($"Punctul ({x}, {y}) se afla in cadranul 3.");
                    return;
                }
                else
                {
                    Console.Write($"Punctul ({x}, {y}) se afla in cadranul 2.");
                    return;
                }
            }

            if (y < 0)
            {
                Console.Write($"Punctul ({x}, {y}) se afla in cadranul 4.");
                return;
            }

            Console.Write($"Punctul ({x}, {y}) se afla in cadranul 1.");
            return;
        }

        public static void print_int_to_byte(int n)
        {
            if (n == 0) return;

            print_int_to_byte(n / 2);
            Console.Write("{0}", n % 2);
        }
    }
}
