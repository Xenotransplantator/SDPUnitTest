using System;

namespace MathLibrary
{
    namespace PrimeNumbers
    {
        public static class PrimeNumber
        {
            public static bool IsPrime(int number)
            {
                if (number < 0)
                {
                    throw new ArgumentException("Liczba nie moze byc ujemna !!");
                }

                if (number == 0 || number == 1)
                {
                    return false;
                }

                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
