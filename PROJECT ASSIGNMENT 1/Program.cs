using System;

class VirtualPetSimulator
{
    private string petType;
    private string petName;
    private int hunger;
    private int happiness;
    private int health;

    public VirtualPet(string type, string name)
    {
        petType = type;
        petName = name;
        hunger = 5;
        happiness = 5;
        health = 5;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the Virtual Pet Simulator!");
        Console.WriteLine($"Your new pet is a {petType} named {petName}.");
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Pet Stats: Hunger={hunger}/10, Happiness={happiness}/10, Health={health}/10");
    }

    public void Feed()
    {
        Console.WriteLine($"Feeding {petName}...");
        hunger = Math.Max(0, hunger - 2);
        health = Math.Min(10, health + 1);
        Console.WriteLine($"{petName} is full and healthier now!");
        DisplayStats();
    }

    public void Play()
    {
        Console.WriteLine($"Playing with {petName}...");
        happiness = Math.Min(10, happiness + 2);
        hunger = Math.Min(10, hunger + 1);
        Console.WriteLine($"{petName} is having a great time!");
        DisplayStats();
    }

    public void Rest()
    {
        Console.WriteLine($"Letting {petName} rest...");
        health = Math.Min(10, health + 2);
        happiness = Math.Max(0, happiness - 1);
        Console.WriteLine($"{petName} is rested and feeling better!");
        DisplayStats();
    }

    public void CheckStatus()
    {
        DisplayStats();
        if (hunger <= 2 || happiness <= 2 || health <= 2)
        {
            Console.WriteLine("Warning: Your pet is in critical condition. Please take care!");
        }
    }

    public void SimulateTimePassage()
    {
        // Simulate the passage of time
        hunger = Math.Min(10, hunger + 1);
        happiness = Math.Max(0, happiness - 1);

        // You can add more effects based on time passage if needed

        Console.WriteLine($"Time passes for {petName}...");
        DisplayStats();
    }
}

class Program
{
   public  static void Main()
    {   
        Console.WriteLine("Enter the sort of pet you have (e.g., cat, dog, rabbit): ");
        string petType = Console.ReadLine();

        Console.WriteLine("Enter your pet's name: ");
        string petName = Console.ReadLine();

        JagdeepPet myPet = new JagdeepPet(petType, petName);
        myPet.DisplayWelcomeMessage();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("_________Main Menu:______");
            Console.WriteLine("|   1. Feed the Pet           |");
            Console.WriteLine("|   2. Play with the Pet      |");
            Console.WriteLine("|   3. Let the Pet Rest       |");
            Console.WriteLine("|   4. Check Pet Status       |");
            Console.WriteLine("|   5. Exit                   |");
            Console.WriteLine("|_____________________________|");
            

            Console.WriteLine("Choose an option (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myPet.Feed();
                    break;
                case "2":
                    myPet.Play();
                    break;
                case "3":
                    myPet.Rest();
                    break;
                case "4":
                    myPet.CheckStatus();
                    break;
                //case "5":
                  //  myPet.SimulateTimePassage(one hour);
                   // break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for playing the Virtual Pet Simulator!");
    }
}
