// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CandidateApp.ConsoleApp.Models.Candidate;

namespace CandidateApp.ConsoleApp.Brokers.StorageBrokers
{
    partial interface IStorageBroker
    {
        Candidate InsertCandidate(Candidate candidate);

    }
}
