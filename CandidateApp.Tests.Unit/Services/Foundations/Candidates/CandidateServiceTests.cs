// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateApp.ConsoleApp.Brokers.StorageBrokers;
using CandidateApp.ConsoleApp.Services.Foundations.Candidates;
using Moq;

namespace CandidateApp.Tests.Unit.Services.Foundations.Candidates
{
    public class CandidateServiceTests
    {
        private readonly ICandidateService candidateService;
        private readonly Mock<IStorageBroker> storageBrokerMock;

        public CandidateServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.candidateService = new CandidateService(
                this.storageBrokerMock.Object);
        }
    }
}
