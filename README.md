# Election Day

## Preparation

* Fork this Repository
* Clone YOUR fork
* Compete as many iterations as time allows
* Push your solution to your fork
* Send a link to your fork to your instructors (this is not graded, but we want to see how far folks got)

## Iteration 1

Create a `Candidate` class that responds to the following interaction pattern. There are also tests you should run to check that your code works as expected!

```c#
var diana = new Candidate("Diana D", "Democrat");

Console.WriteLine(diana.Name);
=> "Diana D"

Console.WriteLine(diana.Party);
=> "Democrat"

Console.WriteLine(diana.Votes);
=> 3

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);
=> 0
```

## Iteration 2 (Your goal is to complete through this iteration!)

Create a `Race` class that responds to the following interaction pattern.

The `RegisterCandidate` method must take a Candidate object as an argument and doesn't return anything.

```c#
var race = new Race("City Council District 10");

race.Office
=> "City Council District 10"

race.Candidates
=> []

var diana = new Candidate("Diana D", "Democrat");
race.RegisterCandidate(diana);

race.Candidates
=> [#<Candidate:0x00007f9edf376c90...>]
```

## Iteration 3 (Hungry for more exercise, it's not expected you'll get here)

Create an `Election` class that satisfies the following requirements.

You have been contacted by the local government to create a program that helps track their elections by organizing registered candidates and their votes.

| Method Name | Return Value |
| ----------- | ------------ |
| new (the constructor)         | An `Election` object that has an attribute of year (string data type). |
| GetYear        | The year of the election (string). |
| GetRaces       | An array of `Race` objects. |
| AddRace(race)   | An array of `Race` objects. |
| GetAllCandidates  | An array of all `Candidate` objects in the election. |
| GetVoteCounts | A dictionary with each candidate's name as a key and their count of votes as the value. |


## Iteration 4 (A very hungry for more exercise, it's not expected you'll get here)

Add the following methods on the `Race` class. You may need to add additional property(s) to implement this functionality.

The local government agency has contacted you about compiling addition information about each of the races.

| Method Name | Return Value |
| ----------- | ------------ |
| IsOpen        | A boolean indicating whether the race is open or not. A race should be open by default. |
| Close       | Close the race (should no longer be open). |
| GetWinner      | `false` if the race is still open. It should return the candidate with the most votes if not open. If there is a tie, it should return any candidate with the highest number of votes. |
| IsTie       | A boolean indicating if two or more candidates received the highest number of votes. |