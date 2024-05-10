namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        WoodHouseBuilder woodHouseBuilder = new WoodHouseBuilder(); // Creates a wood house builder
        CivilEngineer civilEngineer = new CivilEngineer(woodHouseBuilder); // Initializes a civil engineer with the wood house builder

        civilEngineer.ConstructHouse(); // Engineer constructs the house
        House woodenHouse = civilEngineer.GetHouse(); // Gets the constructed house

        Console.WriteLine(woodenHouse.ToString()); // Displays the house details
        Console.ReadKey(); // Waits for a key press to close the console window
    }
}

//Hous-HousBuilder->wood->stone->Engineer