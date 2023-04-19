using System.Diagnostics;
using LaunchElectionDay;

// New Candidate
var diana = new Candidate("Diana D", "Democrat");

// Display Candidate Name, Party, Vote Count
Console.WriteLine(diana.Name);
Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

// Candidate Votes 3x
diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

// Display Candidate Vote Count
Console.WriteLine(diana.Votes);

// New Race
var race = new Race("City Council District 10");

// Display Race Office and current Candidates
Console.WriteLine(race.Office);
displayCandidates(race);

// Register Candidate
race.RegisterCandidate(diana);

// Display current Candidates
displayCandidates(race);

static void displayCandidates(Race race)
{
    Console.WriteLine($"Candidate count: {race.Candidates.Count}");
    foreach (var c in race.Candidates)
    {
        Console.WriteLine($"{c.Name}, {c.Party}, {c.Votes} votes");
    }
}