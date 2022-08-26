// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Collections.Generic;
using CandidateApp.ConsoleApp.Models.Candidate;


namespace CandidateApp.ConsoleApp.Brokers.StorageBrokers
{
    public partial interface IStorageBroker
    {
        Candidate InsertCandidate(Candidate candidate);
        List<Candidate> SelectAllCandidates();
    }
}
