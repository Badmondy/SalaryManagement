namespace SalaryManagement;
class Program
{
    static void Main(string[] args)
    {

       Menu();


    }

    private static void CreateNewPayCheck(string fName, string lName)
    {
        Employee e1 = new Employee()
        {
            FirstName = fName,
            LastName = lName

        };

        if (e1.Salary(e1.FirstName.ToLower()) != 0)
        {
            Console.WriteLine($"Namn: {e1.FullName()}\nMånadslön: {e1.Salary(e1.FirstName.ToLower())}\nSystem tid för avläsning: {e1.Execution()}");
        }
        else
        {
            Console.WriteLine($"{fName} {lName} Finns inte i vårat system!");
        }
    }

    public static void Menu()
    {
        string welcome = @"
                            ┌──────────────────────────────────────────────────┐
                            │                                                  │
                            │                                                  │
                            │              Brönnestad lönesystem               │
                            │                                                  │
                            │                  -Welcome home-                  │
                            │                                                  │
                            │                                                  │
                            │                                                  │
                            │     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░   ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▒▓▓▓▓▓▓▓▓░ ▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▓ ▒▓▓▓▓▒▓▒▓▓▒▒ ▓▓▓▓▒ ▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓ ▓ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▓ ▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▒▒▒▒▒▓▓▒▒▒░▒▓▓▒▒▒░▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓▓▓▒▓▓▓▓▓▓▒▓▓▓▓ ▓▒▓▓▓▓▓▓▓▓     |
                            |     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     │
                            │                                                  │
                            │           Create new paycheck [Press 1]          │
                            │                                                  │
                            │ Contact support if problem occurs ( +46 4342444) |
                            └──────────────────────────────────────────────────┘";
        string goBackMessage = $"#- Press [ESCAPE TO GO BACK]-#";
        bool menuIsOpen = true;
        Console.WriteLine(welcome);
    do{
        ConsoleKeyInfo pressedKey = Console.ReadKey();
        switch (pressedKey.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine($"Skriv in förnamn på mottagaren:");
                string? inputtedFirstName = Console.ReadLine();
                Console.WriteLine($"Skriv in efternamn på mottagaren:");
                string? inputtedLastName = Console.ReadLine();

                if (string.IsNullOrEmpty(inputtedFirstName) || string.IsNullOrEmpty(inputtedLastName))
                {
                    Console.WriteLine($"Du måste fylla i förnamn och efternamn!");
                    Console.WriteLine(goBackMessage);
                }
                else
                {
                    Console.Clear();
                    CreateNewPayCheck(inputtedFirstName, inputtedLastName);
                    Console.WriteLine(goBackMessage);
                }
                break;
            case ConsoleKey.Escape:
                Console.Clear();
                Menu();
                break;
        }
    }while(menuIsOpen);
    }
}
