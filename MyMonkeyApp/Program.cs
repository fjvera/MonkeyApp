using MyMonkeyApp;

static string GetMonkeyAsciiArt(string monkeyName)
{
    switch (monkeyName.ToLower())
    {
        case "baboon":
            return "  .--.  \n (o.o) \n  |=|  \n __|__ ";
        case "capuchin monkey":
            return "  (\\_/)\n ( •_•)\n / >🍌 ";
        case "blue monkey":
            return "  (o.o)\n  /|\\ \n  / \\ ";
        case "squirrel monkey":
            return "  (\\_/)\n ( •_•)\n / >🐿️ ";
        case "golden lion tamarin":
            return "  (='.'=)\n  (\"\")_(\"\") ";
        default:
            return "  (o.o)\n  /|\\ \n  / \\ ";
    }
}

while (true)
{
    Console.WriteLine("\nMonkey Console Application");
    Console.WriteLine("1. List all monkeys");
    Console.WriteLine("2. Get details for a monkey by name");
    Console.WriteLine("3. Get a random monkey");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option: ");
    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            var monkeys = MonkeyHelper.GetMonkeys();
            Console.WriteLine("\nAvailable Monkeys:");
            foreach (var monkey in monkeys)
            {
                Console.WriteLine($"- {monkey.Name}");
            }
            break;
        case "2":
            Console.Write("Enter monkey name: ");
            var name = Console.ReadLine();
            var selectedMonkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
            if (selectedMonkey != null)
            {
                Console.WriteLine($"\n{GetMonkeyAsciiArt(selectedMonkey.Name)}");
                Console.WriteLine($"Name: {selectedMonkey.Name}\nLocation: {selectedMonkey.Location}\nPopulation: {selectedMonkey.Population}\nDetails: {selectedMonkey.Details}\nAccess Count: {MonkeyHelper.GetAccessCount(selectedMonkey.Name)}");
            }
            else
            {
                Console.WriteLine("Monkey not found.");
            }
            break;
        case "3":
            var randomMonkey = MonkeyHelper.GetRandomMonkey();
            Console.WriteLine($"\n{GetMonkeyAsciiArt(randomMonkey.Name)}");
            Console.WriteLine($"Random Monkey: {randomMonkey.Name}\nLocation: {randomMonkey.Location}\nPopulation: {randomMonkey.Population}\nDetails: {randomMonkey.Details}\nAccess Count: {MonkeyHelper.GetAccessCount(randomMonkey.Name)}");
            break;
        case "4":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}