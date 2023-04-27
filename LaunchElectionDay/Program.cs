using System.Diagnostics;
using LaunchElectionDay;

var thisElection = CreateElection();
Console.WriteLine($"Welcome to the {thisElection.GetYear()} Election!");
int option = -1;

while (option != 0) 
{
    option = MainMenu(thisElection);
    processSelection(thisElection, option);
}

static void displayCandidates(Race race)
{
    Console.WriteLine($"Candidate count: {race.Candidates.Count}");
    foreach (var c in race.Candidates)
    {
        Console.WriteLine($" {c.Name}, {c.Party}, {c.Votes} votes");
    }
}

static void displayRaces(Election elect)
{
    var races = elect.GetRaces();
    Console.WriteLine($"Race count: {races.Count}");
    foreach (var race in races)
    {
        var raceOpen = race.IsOpen ? "Open" : "Closed";
        Console.WriteLine($" {race.Office}: {raceOpen}, Candidates: {race.Candidates.Count}");
    }
}

static Election CreateElection()
{
    var election = new Election("2023");
    var cityCouncil = new Race("City Council District 10");
    var mayor = new Race("Raleigh Mayoral Race");

    var diana = new Candidate("Diana D", "Democrat");
    var camilla = new Candidate("Camilla B", "Libertarian");

    var barack = new Candidate("Barack O", "Democrat");
    var bernie = new Candidate("Bernie S", "Independent");
    var george = new Candidate("George W", "Republican");

    cityCouncil.RegisterCandidate(diana);
    cityCouncil.RegisterCandidate(camilla);

    mayor.RegisterCandidate(barack);
    mayor.RegisterCandidate(bernie);
    mayor.RegisterCandidate(george);

    election.AddRace(cityCouncil);
    election.AddRace(mayor);

    CastRandomVotes(election);

    return election;
}

static void CastRandomVotes(Election elect)
{
    foreach(var candidate in elect.GetAllCandidates())
    {
        Random rnd = new Random();
        int num = rnd.Next(50);
        for (int i = 0; i < num; i++)
        {
            candidate.VoteFor();
        }
    }
}

static int MainMenu(Election elect)
{
    Console.WriteLine();
    Console.WriteLine("Main Menu");
    Console.WriteLine(" 0 - Quit");
    Console.WriteLine(" 1 - List All Races");
    Console.WriteLine(" 2 - List All Candidates");
    Console.WriteLine(" 3 - End Election");
    Console.WriteLine(" 4 - Vote For Candidate");
    Console.WriteLine(" 5 - Clear Screen");

    Console.Write("Select an option 0-5: ");
    return Convert.ToInt32(Console.ReadLine());
}

static void processSelection(Election elect, int option)
{
    Console.WriteLine();

    if (option == 0) // Quit
    {
        Console.WriteLine("Thank you for participating! Your vote matters!");
    }
    else if (option == 1) // All Races
    {
        displayRaces(elect);
    }
    else if (option == 2) // All Candidates
    {
        var races = elect.GetRaces();
        foreach (var race in races)
        {
            var raceOpen = race.IsOpen ? "Open" : "Closed";
            Console.WriteLine($"{race.Office}: {raceOpen}");
            displayCandidates(race);
            Console.WriteLine();
        }
    }
    else if (option == 3) // End Election
    {
        var races = elect.GetRaces();
        foreach (var race in races)
        {
            race.Close();
        }
        Console.WriteLine("All Races Closed!");
    }
    else if (option == 4) // Vote for candidate
    {
        Console.WriteLine("This function is under construction.");
    }
    else if (option == 5) // Clear screen
    {
        Console.Clear();
    }
    else // Invalid entry
    {
        Console.WriteLine("Invalid entry, please try again.");
    }
}