// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

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

            //when
            this.candidateService.AddCandidate(nullCandidate);

            //then

        }
    }
}
