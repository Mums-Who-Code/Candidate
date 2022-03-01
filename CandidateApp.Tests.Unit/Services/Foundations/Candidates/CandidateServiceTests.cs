// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Moq;
using Tynamix.ObjectFiller;

namespace CandidateApp.Tests.Unit.Services.Foundations.Candidates
{
    public partial class CandidateServiceTests
    {
        private readonly ICandidateService candidateService;
        private readonly Mock<IStorageBroker> storageBrokerMock;

        public CandidateServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.candidateService = new CandidateService(
                this.storageBrokerMock.Object);
        }

        private Candidate CreateRandomCandidate() =>
            CreateCandidateFiller().Create();

        private static Filler<Candidate> CreateCandidateFiller() =>
          new Filler<Candidate>();
    }
}
