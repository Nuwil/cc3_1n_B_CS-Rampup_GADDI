using System;

public class RampUp2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("====================================================\n\t\t\t\t   GADDI, Noel J.\n====================================================");
        double updateWeight, updateLength, updateFah;
        
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Weights in Pounds (lbs): ");
            string userWeight = Console.ReadLine();

            try
            {
                updateWeight = double.Parse(userWeight);
                double resultKilo = updateWeight * 0.45359237;
                Console.WriteLine($"Weight Converted to Kilo (kg): {resultKilo}\n====================================================\n");
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! PLEASE ENTER NUMBERS ONLY!");
                validInput = false;
            }
        }
        //===========END OF WEIGHT CONVERTER=============//

        validInput = false;
        while (!validInput)
        {
            Console.Write("Length in Miles (mi): ");
            string userLength = Console.ReadLine();

            try
            {
                updateLength = double.Parse(userLength);
                double resultMiles = updateLength * 1.609344;
                Console.WriteLine($"Length in Kilometers (km): {resultMiles}\n====================================================\n");
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! PLEASE ENTER NUMBERS ONLY!");
            }
        }
        //===========END OF LENGTH CONVERTER=============//

        validInput = false;
        while (!validInput)
        {
            Console.Write("Temperature in Fahrenheit (*F): ");
            string userFah = Console.ReadLine();

            try
            {
                updateFah = double.Parse(userFah);
                double resultCelcius = (updateFah - 32) * 5 / 9;
                Console.WriteLine($"Temperature in Celsius (*C): {resultCelcius}\n====================================================\n");
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! PLEASE ENTER NUMBERS ONLY!");
            }
        }
        //===========END OF TEMPERATURE CONVERTER=============//

        validInput = false;
        while(!validInput){
            try
            {
                double sum = 0;
    
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Age of Student {i}: ");
                    string studentAgeInput = Console.ReadLine();
    
                    double studentAge = double.Parse(studentAgeInput);
                    sum += studentAge;
                }
    
                double average = sum / 10;
                Console.WriteLine($"The average age of the Students is: {average:F2}\n====================================================\n");
    
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! PLEASE ENTER NUMBERS ONLY!");
            }
        }
        //===========END OF AVERAGE AGE OF STUDENT=============//

        //===Characters===//
         string char1 = "Noel";
         string char2 = "Gully";
         string char3 = "Alex";
         string char4 = "Angel";
         string char5 = "Gorlock The Destroyer";
         string evilChar = "Dr. Darkness";
         //===Weapons===//
         string weaponNoel = "Thor's Hammer";
         string weaponGully = "Artemis' Bow";
         string weaponEvil = "Scepter of Shadows";
         //===Items===//
         string itemAlex = "Helmet of Knowledge";
         string itemAngel = "Staff of Elements";
         string itemGorlock = "Armor of Protection";
         //===Abilities===//
         string abNoel = "Strength";
         string abGully = "Agility";
         string abAlex = "Intelligence";
         string abAngel = "Wisdom";
         string abGorlock = "Magic";
         string abEvil = "Dark Magic";
         //===Story===//
         Console.WriteLine($"Once upon a time, in a far-off land, there lived five brave heroes named {char1} 'The Hammer' (equipped with {weaponNoel}), {char2} 'The Archer' (armed with {weaponGully}), {char3} 'The Brainiac' (with the {itemAlex}), {char4} 'The Sorceress' (wielding the {itemAngel}), and {char5} 'The Guardian' (clad in the {itemGorlock}). They were each skilled in different areas, such as {abNoel}, {abGully}, {abAlex}, {abAngel}, and {abGorlock}. Together, they embarked on a quest to defeat the evil sorcerer, {evilChar} (armed with the {weaponEvil}), who threatened to destroy their kingdom. Along the way, they encountered many challenges and obstacles but always found a way to overcome them thanks to their diverse skills and teamwork.\n");
         Console.WriteLine($"One day, while journeying through a dense forest, they stumbled upon a mysterious cave. As they ventured deeper into the darkness, they discovered an ancient treasure trove filled with powerful weapons and magical artifacts. But suddenly, {evilChar} appeared before them, wielding his {abEvil} and determined to claim the treasure for himself. The heroes knew they had to stop him at all costs. In a thrilling battle, they fought bravely against {evilChar} and his minions, using everything they had learned on their journey. With their combined might, they managed to defeat the villainous sorcerer and save the kingdom from destruction. The people rejoiced at their victory, hailing the five heroes as saviors of the realm. And so, they returned home, proud of their accomplishment and ready for whatever new adventures lay ahead. \n====================================================\n");
        //===========END OF STORY=============//
        
        validInput = false;
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
                    Console.WriteLine("====================================================\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                validInput = false;
            }
        }
        //===========END OF PATTERN 1=============//


        validInput = false;
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
                    Console.WriteLine("====================================================\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
                validInput = false;
            }
        }
        //===========END OF PATTERN 2=============//
        validInput = false;
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
                    for (int i = n; i >= 1; i--)
                    {
                        for (int o = 1; o <= i; o++)
                        {
                            Console.Write(o + " ");
                        }
                        Console.WriteLine();
                        validInput = true;
                    }
                    Console.WriteLine("====================================================\n\t\t\t\tEND OF CSHARPRAMPUP\n====================================================");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                validInput = false;
            }
        }
        //===========END OF PATTERN 3=============//
        //===========END OF EVERYTHING TY=============//
    }
}
