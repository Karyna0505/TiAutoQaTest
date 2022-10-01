using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            double Ax, Ay, Bx, By, Cx, Cy;

            Console.WriteLine("Enter coordinate x of dot A:");
            Ax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of dot A:");
            Ay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot B:");
            Bx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of dot B:");
            By = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot C:");
            Cx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of dot C:");
            Cy = Convert.ToDouble(Console.ReadLine());


            double AB = Math.Sqrt(
                Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2)
            );
            double BC = Math.Sqrt(
                Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2)
            );
            double AC = Math.Sqrt(
                Math.Pow(Cx - Ax, 2) + Math.Pow(Cy - Ay, 2)
            );

            Console.WriteLine("Length of AB is:" + AB);
            Console.WriteLine("Length of BC is:" + BC);
            Console.WriteLine("Length of AC is:" + AC);


            bool isEquilateral = (AB == BC && BC == AC && AB == AC);

            if (isEquilateral)
            {
                Console.WriteLine("Triangle is Equilateral");
            }
            else
            {
                Console.WriteLine("Triangle is NOT Equilateral");
            }

            bool isIsosceles = (AB == BC || BC == AC || AB == AC);

            if (isIsosceles)
            {
                Console.WriteLine("Triangle is Isosceles");

            }
            else
            {
                Console.WriteLine("Triangle is NOT Isosceles");
            }


            bool isRight = (
                Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2)) <= 0.1 ||
                Math.Pow(AB, 2) - (Math.Pow(BC, 2) + Math.Pow(AC, 2)) <= 0.1 ||
                Math.Pow(AC, 2) - (Math.Pow(AB, 2) + Math.Pow(BC, 2)) <= 0.1
            );

            if (isRight)
            {
                Console.WriteLine("Triangle is Right");
            }
            else
            {
                Console.WriteLine("Triangle is NOT Right");
            }

            double P = AB + BC + AC;

            Console.WriteLine("Perimeter:" + P);

            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i <= P; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}