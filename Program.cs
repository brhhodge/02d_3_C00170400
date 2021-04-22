// Brian hodge
// C00170400
// CMPS 358
// Assignment #02d_3

using System;

namespace _02d_3_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            String name_1 = "Bob E.";
            NameThatPerson(name_1);
            String name_2 = null;
            NameThatPerson(name_2);

            Console.WriteLine("Average Length: " + getAvgLength());
            Console.WriteLine();
            Console.WriteLine("Sum of non-null elements: " + sumOfArrays());


            static int getAvgLength()
            {
                int sumOfLengths = 0;
                int averageLength;
                for (int i = 0; i < 10; i++)
                {
                    sumOfLengths += (Populate().Length);
                    
                } averageLength = (sumOfLengths/10);
                return averageLength;
            }

            int sumOfArrays()
            {
                int? sum_1d = 0;
                int sum_2d;
                for (int i = 0; i < 20; i++)
                {
                    sum_1d += Populate().Length;

                } sum_2d = sum_1d ?? 0;
                return sum_2d;
            }
            

        }

        public static void NameThatPerson(String n)
        {
            Console.WriteLine("Length: " + n?.Length);
            String name = n ?? "Anonymous";
            Console.WriteLine(name);
            Console.WriteLine();


        }

        static int?[] Populate()
        {
            Random random = new Random();
            int?[] a = new int?[random.Next(10) + 10];

            for(int i = 0; i < a.Length; i++)
                if (random.Next(2) == 1)
                    a[i] = random.Next(10) + 1;
            return a;
        }

    }

}
