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
    }
}
