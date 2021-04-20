using System;


namespace ConsoleAppshapes
{
    class Program
    {
        static void Main(string[] args)
        {
        SelectObject:

            Console.WriteLine("\n\nSelect object: ");
            Console.WriteLine("\n\n1. Square");
            Console.WriteLine("2. Retangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle\n\n");
            Console.WriteLine("Please enter the number of your desired object: ");

            byte shape = byte.Parse(Console.ReadLine());

            switch (shape)
            {
                case 1:

                    {
                        int squareSize;

                        Console.WriteLine("Please enter square side size");
                        squareSize = Int32.Parse(Console.ReadLine());

                        for (int row = 1; row <= squareSize; row++)
                        {
                            for (int column = 1; column <= squareSize; column++)
                            {
                                string string1;

                                string1 = " * ";
                               
                                Console.Write(string1);
                            }
                            Console.WriteLine();
                        }
                        {


                            Console.WriteLine("Square circumference " + (4 * squareSize));
                            Console.WriteLine("Square areal " + (squareSize * squareSize));
                            Console.ReadKey();

                        }

                    }
                    break;


                case 2:
                    {
                        int retangle1;
                        Console.WriteLine("Please enter retangle side 1");
                        retangle1 = Int32.Parse(Console.ReadLine());

                        int retangle2;
                        Console.WriteLine("Please enter retangle side 2");
                        retangle2 = Int32.Parse(Console.ReadLine());

                        for (int row = 1; row <= retangle1; row++)
                        {
                            for (int column = 1; column <= retangle2; column++)
                            {
                                string string1;

                                string1 = " * ";

                                Console.Write(string1);
                            }
                            Console.WriteLine();
                        }


                        Console.WriteLine("Retangle circumference " + (retangle1 + retangle2) * 2);
                        Console.WriteLine("Retangle area " + (retangle1 * retangle2));
                        Console.ReadKey();
                    }
                    break;







                case 3:

                    {
                        int number, i, j, count = 1;
                        Console.Write("Please enter triangle height ");
                        number = int.Parse(Console.ReadLine());
                        count = number - 1;
                        for (j = 1; j <= number; j++)
                        {
                            for (i = 1; i <= count; i++)
                                Console.Write(" ");
                            count--;
                            for (i = 1; i <= 2 * j - 1; i++)
                                Console.Write("*");
                            Console.WriteLine();
                        }

                        //// Console.WriteLine("Triangle circumference " + (retangle1 + retangle2) * 2);
                        Console.WriteLine("Triengle area " + (number * number / 2));
                        Console.ReadKey();
                    }
                    break;




                case 4:

                    {
                        double radius;
                        double thickness = 0.4;
                        char symbol = '*';

                        do
                        {
                            Console.Write("Please enter circle radius: ");
                            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                            {
                                Console.WriteLine("radius have to be positive number");
                            }
                        }
                        while (radius <= 0);

                        Console.WriteLine();
                        double rIn = radius - thickness, rOut = radius + thickness;

                        for (double y = radius; y >= -radius; --y)
                        {
                            for (double x = -radius; x < rOut; x += 0.5)
                            {
                                double value = x * x + y * y;
                                if (value >= rIn * rIn && value <= rOut * rOut)
                                {
                                    Console.Write(symbol);
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();

                        }
                        Console.WriteLine("Circle circumference " + (2 * Math.PI * radius));
                        Console.WriteLine("Circle area " + (Math.PI * radius * radius));
                        Console.ReadKey();
                    }
                    break;

                default:
                    Console.WriteLine("Wrong input. Please try again");

                    goto SelectObject;
            }
            Continue:
            Console.WriteLine("\n\n Would you like to select another shape? - (yes or no)");
            Console.WriteLine("\n\n Please use small letters \n\n");

            string awnser = (Console.ReadLine());


            if (awnser == "yes")
            {
                goto SelectObject;
            }

            if (awnser == "no")
            {

            }
             else 
                {
                goto Continue;
                }

            Console.ReadKey();

        }
    }
}