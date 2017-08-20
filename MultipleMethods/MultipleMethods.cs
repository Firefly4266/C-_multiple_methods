using System;

public class MultipleMethods
{
    public static void Main(String[] args)
    {
        InputWrapper iw = new InputWrapper();
        int[] primes = { 2, 3, 5, 7, 11, 13 };
        for (int i = 0; i < primes.Length; i++)
        {
            Console.Write("{0} ", primes[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Enter numbers to search for, {0} to exit", -1);
        int target = iw.getInt("Enter number: ");
        while (target != -1)
        {
            int index = Search(primes, target);
            if (index == -1)
            {
                Console.WriteLine("{0} was not found in this array.", target);
                break;
            }
            else
            {
                Console.WriteLine("{0} was located at index {1}.", target, index);
                target = iw.getInt("Enter number: ");
            }
        }
    }
    public static int Search(int[] array, int target)
    {
        int j = 0;
        bool found = false;
        while (!found && j < array.Length)
        {
            if (target == array[j])
            {
                found = true;
            }
            else
            {
                j++;
            }
        }
        if (found)
        {
            return j;
        }
        else
        {
            return -1;
        }
    }
}