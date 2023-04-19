using System.Diagnostics;

namespace LaunchElectionDay.UnitTests
{
    public class CandidateTests
    {
        [Fact]
        public void Candidate_Constructor_WhenInstantiatedSetsProperties()
        {
            var diana = new Candidate("Diana D", "Democrat");
            Assert.Equal("Diana D", diana.Name);
            Assert.Equal("Democrat", diana.Party);
        }

        [Fact]
        public void Candidate_VoteFor_IncreasesVotes()
        {
            var diana = new Candidate("Diana D", "Democrat");
            Assert.Equal(0, diana.Votes);
            diana.VoteFor();
            diana.VoteFor();
            diana.VoteFor();
            Assert.Equal(3, diana.Votes);
        }

        [Fact]
        public void Race_Constructor_SetsProperties()
        {
            var race = new Race("City Council District 10");
            Assert.Equal("City Council District 10", race.Office);
            Assert.Empty(race.Candidates);
        }

        [Fact]
        public void Race_RegisterCandidate_AddCandidateToList()
        {
            var race = new Race("City Council District 10");
            var diana = new Candidate("Diana D", "Democrat");
            race.RegisterCandidate(diana);

            Assert.Equal(diana, race.Candidates[0]);
        }

        [Fact]
        public void Election_Constructor_SetsProperties()
        {
            var election = new Election("2023");
            Assert.Equal("2023", election.GetYear());
            Assert.Empty(election.GetRaces());
        }

        [Fact]
        public void Election_AddRace_AddsToRaceList()
        {
            var election = new Election("2023");
            var race = new Race("City Council District 10");
            election.AddRace(race);
            Assert.Equal(race, election.GetRaces().Last());
        }

        [Fact]
        public void Election_GetAllCandidates_ReturnsAllCandidatesInAllRaces()
        {
            var election = new Election("2023");
            var cityCouncil = new Race("City Council District 10");
            var mayor = new Race("Raleigh Mayoral Race");

            var diana = new Candidate("Diana D", "Democrat");
            var camilla = new Candidate("Camilla B", "Libertarian");

            var barack = new Candidate("Barack O", "Democrat");
            var bernie = new Candidate("Bernie S", "Independent");

            cityCouncil.RegisterCandidate(diana);
            cityCouncil.RegisterCandidate(camilla);

            mayor.RegisterCandidate(barack);
            mayor.RegisterCandidate(bernie);

            election.AddRace(cityCouncil);
            election.AddRace(mayor);

            var expected = new List<Candidate>
            { diana, camilla, barack, bernie };

            Assert.Equal(expected, election.GetAllCandidates());
        }

        [Fact]
        public void Election_GetVoteCounts_ReturnsDictionaryOfCandidateNamesAndVotes()
        {
            var election = new Election("2023");
            var cityCouncil = new Race("City Council District 10");
            var mayor = new Race("Raleigh Mayoral Race");

            var diana = new Candidate("Diana D", "Democrat");
            diana.VoteFor();
            diana.VoteFor();
            diana.VoteFor();

            var camilla = new Candidate("Camilla B", "Libertarian");
            camilla.VoteFor();
            camilla.VoteFor();
            camilla.VoteFor();
            camilla.VoteFor();

            var barack = new Candidate("Barack O", "Democrat");
            barack.VoteFor();
            barack.VoteFor();
            barack.VoteFor();
            barack.VoteFor();
            barack.VoteFor();

            var bernie = new Candidate("Bernie S", "Independent");
            bernie.VoteFor();
            bernie.VoteFor();
            bernie.VoteFor();
            bernie.VoteFor();
            bernie.VoteFor();
            bernie.VoteFor();

            cityCouncil.RegisterCandidate(diana);
            cityCouncil.RegisterCandidate(camilla);

            mayor.RegisterCandidate(barack);
            mayor.RegisterCandidate(bernie);

            election.AddRace(cityCouncil);
            election.AddRace(mayor);

            var expected = new Dictionary<string, int>
            {
                { "Diana D", 3 },
                { "Camilla B", 4 },
                { "Barack O", 5 },
                { "Bernie S", 6 }
            };

            Assert.Equal(expected, election.GetVoteCounts());
        }
    }
}
