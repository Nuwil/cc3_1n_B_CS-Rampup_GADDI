using System;

class Pattern1
{
    static void Main()
    {
        bool validInput = false;
        while(!validInput){
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();

            if (int.TryParse(userNum, out int n))
            {
                if (n <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int o = 1; o <= i; o++)
                        {
                            Console.Write(o + " ");
                        }
                        Console.WriteLine();
                        validInput = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                validInput = false;
            }
        }


    }
}
