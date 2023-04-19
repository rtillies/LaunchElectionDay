using System.Diagnostics;
using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");

Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);

var race = new Race("City Council District 10");

Console.WriteLine(race.Office);

Console.WriteLine(race.Candidates);

////var diana = new Candidate("Diana D", "Democrat");
//race.RegisterCandidate(diana);

//Console.WriteLine(race.Candidates);
