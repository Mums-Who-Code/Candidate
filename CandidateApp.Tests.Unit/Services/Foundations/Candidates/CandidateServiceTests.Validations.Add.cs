// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CandidateApp.ConsoleApp.Models.Candidate;
using CandidateApp.ConsoleApp.Models.Candidates.Exceptions;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

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

            this.storageBrokerMock.Verify(broker =>
                broker.InsertCandidate(It.IsAny<Candidate>()),
                Times.Never);

            this.loggingBrokerMock.VerifyNoOtherCalls();
            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
