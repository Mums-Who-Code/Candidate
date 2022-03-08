// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

namespace CandidateApp.Tests.Unit.Services.Foundations.Candidates
{
    public partial class CandidateServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfCandidateIsNullAndLogit()
        {
            //given
            Candidate nullCandidate = null;
            var nullCandidateException = new NullCandidateException();

            var expectedCandidateValidationException =
                new CandidateValidationException(nullCandidateException);

            //when
            Action addCandidateAction = () => this.candidateService.AddCandidate(nullCandidate);

            //then
            Assert.Throws<CandidateValidationException>(addCandidateAction);

            this.loggingBrokerMock.Verify(broker =>
                broker.LogError(It.Is(SameExceptionAs(
                expectedCandidateValidationException))),
                    Times.Once);
        }
        private static Expression<Func<Xeption, bool>> SameExceptionAs(Xeption expectedException)
        {
            return actualException =>
                actualException.Message == expectedException.Message
                && actualException.InnerException.Message == expectedException.InnerException;
        }
    }
}
