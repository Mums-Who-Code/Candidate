// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CandidateApp.ConsoleApp.Models.Candidate;
using FluentAssertions;
using Moq;
using Xunit;

namespace CandidateApp.Tests.Unit.Services.Foundations.Candidates
{
    partial class CandidateServiceTests
    {
        [Fact]
        public void ShouldAddCandidate()
        {
            // given
            Candidate randomCandidate = CreateRandomCandidate();
            Candidate inputCandidate = randomCandidate;
            Candidate persistedCandidate = inputCandidate;
            Candidate expectedCandidate = inputCandidate;

            this.storageBrokerMock.Setup(broker =>
                broker.InsertCandidate(inputCandidate))
                .Returns(persistedCandidate);

            // when
            Candidate actualCandidate = this.candidateService.AddCandidate(inputCandidate);

            // then
            actualCandidate.Should().BeEquivalentTo(expectedCandidate);

            this.storageBrokerMock.Verify(broker =>
            broker.InsertCandidate(inputCandidate),
                        Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();


        }
    }
}
