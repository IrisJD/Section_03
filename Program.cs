using System;

namespace Section_03
{
    class Program
    {
        static void Main(string[] args)
        {
            MMSA();
            Dublicates();
        }

        public static void MMSA()
        {
            //Function to calculate the minimum, maximum, sum and average of all numbers in an array.

            double min = int.MaxValue, max = int.MinValue, sum = 0, avg = 0;

            Console.WriteLine("Hello, this is a function which calculates the minimum, maximum, sum and average of all numbers in an array.\n ");
            Console.WriteLine("How many numbers would you like to enter?\n");
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());

                sum += numbers[i];

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

            }

            avg = sum / numbers.Length;

            Console.WriteLine("The Minimum is:" + min);
            Console.WriteLine("The Maximum is:" + max);
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);

            Console.ReadKey();
        }



        public static void Dublicates()
        {
            //Function which removes duplicates from an array

            double[] array = new double[100];            
            double num;
            int i, j, k;

            Console.WriteLine("\nThis function removes dublicates from an array.");
            Console.WriteLine("How many numbers would you like to have in your array:\n");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your numbers:");
            for (i = 0; i < num; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    if (array[i] == array[j])
                    {
                        for (k = j; k < num; k++)
                        {
                            array[k] = array[k + 1];
                        }
                        num--;
                        j--;
                    }
                }
            }
            Console.WriteLine("\nFinal array:");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }               
    }
}

            
   
