using System;

namespace Workbook_Lab_2
{
    class Program
    {

        static void Main(string[] args)
        {

            int length, width;
            string yesOrNo;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            Console.WriteLine("Enter width.");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter length.");
            length = Convert.ToInt32(Console.ReadLine());

            double result = (width * length);

            double perimeter = 2 * length + 2 * width;

            Console.WriteLine("The area of the room is " + result);
            Console.WriteLine("The perimeter of the room is " + perimeter);

            Console.WriteLine("Continue? Y/N");

            string v = yesOrNo = Console.ReadLine();


            if (v == "Y")
            {


                {
                    Console.WriteLine("Enter width.");
                    width = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter length.");
                    length = Convert.ToInt32(Console.ReadLine());

                    result = width * length;

                    perimeter = 2 * length + 2 * width;

                    Console.WriteLine("The area of the room is " + result);

                    Console.WriteLine("The perimeter of the room is " + perimeter);

                    Console.WriteLine("Continue? Y/N");
                    v = Console.ReadLine();
                }



            }
        }
    }
}