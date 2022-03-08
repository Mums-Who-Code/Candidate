// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

namespace CandidateApp.Tests.Unit.Services.Foundations.Candidates
{
    public partial class CandidateServiceTests
    {
        private readonly ICandidateService candidateService;
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;

        public CandidateServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();
            this.candidateService = new CandidateService(
                this.storageBrokerMock.Object,
                this.loggingBrokerMock.Object);
        }

        private Candidate CreateRandomCandidate() =>
            CreateCandidateFiller().Create();

        private static Filler<Candidate> CreateCandidateFiller() =>
          new Filler<Candidate>();
    }
}
