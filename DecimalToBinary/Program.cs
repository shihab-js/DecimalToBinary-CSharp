using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the necessary variables
            int number, i;

            //create a array
            int[] a = new int[10];

            //print show message
            Console.Write("Please Enter number to convert: ");

            //get input from user
            number = int.Parse(Console.ReadLine());

            //create a for loop to continue the program until number is greater than 0
            for (i = 0; number > 0; i++)
            {
                a[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary of the givien number is: ");

            //again use loop to print the binary number 
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
