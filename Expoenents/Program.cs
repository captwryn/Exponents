using System;
class MainClass
{
    public static void Main()
    {
        Console.Write("Please enter a integer: ");
        string entry = Console.ReadLine();
        int number = int.Parse(entry);
        int status = 1;
        int x = 1;

        while (status < 2)
        {
            if (x <= number)
            {
                Console.WriteLine($"{x}\t{x * x}\t {x * x * x}");
                x++;
            }
            else
            {
                Console.Write("\nWould you like to continue? (y/n) ");
                string resp = Console.ReadLine();

                if (resp == "y")
                {
                    x = 1;
                    Console.Write("\nPlease enter a integer: ");
                    entry = Console.ReadLine();
                    number = int.Parse(entry);
                }
                else
                {
                    status = 2;
                }
            }
        }
    }
}