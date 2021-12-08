// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateApp.ConsoleApp.Brokers.StorageBrokers;
using CandidateApp.ConsoleApp.Models.Candidate;

namespace CandidateApp.ConsoleApp.Services.Foundations.Candidates
{
    public class CandidateService : ICandidateService
    {
        private readonly IStorageBroker storageBroker;

        public CandidateService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public Candidate AddCandidate(Candidate candidate) =>
            throw new NotImplementedException();
    }
}
