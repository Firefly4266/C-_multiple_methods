using System;

public class MultipleMethods
{
    public static void Main(String[] args)
    {
        InputWrapper iw = new InputWrapper();
        int [] primes = {2, 3, 5, 7, 11, 13 };
        for (int i = 0; i < primes.Length; i++)
        {
            Console.Write("{0} ", primes[i]);
        }
            Console.WriteLine();
    }
}