namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -----------------
            // ### Problem 1   | ----------------------------------------
            // _________________

            //Console.Write("a: ");
            //double a;
            //double.TryParse(Console.ReadLine(), out a);

            //Console.Write("Operatie (+, -, *, /): ");
            //char op = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("b: ");
            //double b;
            //double.TryParse(Console.ReadLine(), out b);

            //double result = Calculator(a, b, op);
            //Console.WriteLine("Rezultat: " + result);

            //Calculator calculator = new Calculator();
            //double result2 = calculator.Calculate(a, b, op);
            //Console.WriteLine("Rezultat2: " + result);

            // -----------------
            // ### Problem 2   | ----------------------------------------
            // _________________

            Console.Write("a: ");
            int a;
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("b: ");
            int b;
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("{0}", Power.ToThePowerOf(a, b));
            Console.WriteLine("{0}", Power.ToThePowerOfV2(a, b));
        }

        static double Calculator(double nr1, double nr2, char op)
        {
            double result = 0;

            switch (op)
            {
                case '+':
                    result = nr1 + nr2;
                    break;

                case '-':
                    result = nr1 - nr2;
                    break;

                case '*':
                    result = nr1 * nr2;
                    break;

                case '/':
                    if (nr2 != 0)
                    {
                        result = nr1 / nr2;
                    }
                    else
                    {
                        throw new DivideByZeroException("Eroare: impartire la 0");
                    }
                    break;

                default:
                    throw new ArgumentException($"Operator invalid: {op}");
                    
            }

            return result;
        }


    }
}
