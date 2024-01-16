using System;

class Pattern2
{
    static void Main()
    {
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter a number: ");
            string userNum = Console.ReadLine();

            if (int.TryParse(userNum, out int userNumber))
            {
                if (userNumber <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.\n");
                }
                else
                {
                    int sum = 0;

                    Console.Write("Formula: ");
                    for (int i = 1; i <= userNumber; i++)
                    {
                        sum += i;
                        Console.Write(i);

                        if (i < userNumber)
                        {
                            Console.Write(" + ");
                        }
                        
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Output: {sum}");

                    validInput = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
                validInput = false;
            }
        }
    }
}
