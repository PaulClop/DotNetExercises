using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow
{
    public class Calculator
    {
        public double Calculate(double nr1, double nr2, char op) => op switch
        {
            '+' => nr1 + nr2,
            '-' => nr1 - nr2,
            '*' => nr1 * nr2,
            '/' when nr2 != 0 => nr1 / nr2,
            '/' => throw new DivideByZeroException("Eroare: impartire la 0"),
            _ => throw new ArgumentException($"Operator invalid: {op}")
        };
    }
}
