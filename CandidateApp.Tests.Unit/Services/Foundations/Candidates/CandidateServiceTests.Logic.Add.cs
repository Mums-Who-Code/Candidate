// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CandidateApp.ConsoleApp.Models.Candidate;
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

            // when
            this.candidateService.AddCandidate(inputCandidate);

            // then
        }
    }
}
