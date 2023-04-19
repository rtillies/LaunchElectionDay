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

        //[Fact]
        //public void Candidate_VoteFor_IncreasesVotes()
        //{
        //    var diana = new Candidate("Diana D", "Democrat");
        //    Assert.Equal(0, diana.Votes);
        //    diana.VoteFor();
        //    diana.VoteFor();
        //    diana.VoteFor();
        //    Assert.Equal(3, diana.Votes);
        //}
    }
}
