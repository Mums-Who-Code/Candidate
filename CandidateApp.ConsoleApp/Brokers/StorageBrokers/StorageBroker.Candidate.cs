// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Collections.Generic;
using CandidateApp.ConsoleApp.Models.Candidate;

namespace CandidateApp.ConsoleApp.Brokers.StorageBrokers
{
    public partial class StorageBroker : IStorageBroker
    {
        List<Candidate> Candidates = new List<Candidate>();

        public Candidate InsertCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);

            return candidate;
        }
        public List<Candidate> SelectAllCandidates() => Candidates;
    }
}