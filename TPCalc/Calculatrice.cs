using System;

namespace TPCalc
{
    public class Calculatrice
    {
        public decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Soustraction(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Division(decimal a, decimal b)
        {
            if (b != 0)
            {
                return (decimal)a / b;
            }
            else
            {
                Console.WriteLine("Erreur : Division par zéro !");
                return 0;
            }
        }
        public decimal Modulo(decimal a, decimal b)
        {
            if (b != 0)
            {
                return a % b;
            }
            else
            {
                Console.WriteLine("Erreur : Modulo par zéro !");
                return 0;
            }
        }
    }
}
