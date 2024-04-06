using System;

class Program
{
    static void Main(string[] args)
    {
        int basepower = 10;
        int speed = 0;
        char oscillate = 'N';

        while (true)
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
            if (int.TryParse(Console.ReadLine(), out speed) && (speed >= 1 && speed <= 3))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
            }
        }

        while (true)
        {
            Console.Write("Oscillate Fan? (Y/N): ");
            oscillate = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (oscillate == 'Y' || oscillate == 'N')
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
            }
        }

        int output = basepower * speed;

        if (oscillate == 'Y')
        {
            for (int i = 1; i <= output; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("~");
                }
                Console.WriteLine();
            }
            for (int i = output - 1; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("~");
                }
                Console.WriteLine();
            }
        }
        else if (oscillate == 'N')
        {
            switch (output)
            {
                case 10:
                    for (int i = 1; i <= output; i++)
                    {
                        Console.WriteLine("~~~~~~~~~~");
                    }
                    Console.WriteLine();
                    break;
                case 20:
                    for (int i = 1; i <= output; i++)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
                    }
                    Console.WriteLine();
                    break;
                case 30:
                    for (int i = 1; i <= output; i++)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}