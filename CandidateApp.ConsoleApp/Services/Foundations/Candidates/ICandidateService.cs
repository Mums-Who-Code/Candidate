// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateApp.ConsoleApp.Models.Candidate;

namespace CandidateApp.ConsoleApp.Services.Foundations.Candidates
{
    public interface ICandidateService
    {
        Candidate AddCandidate(Candidate candidate);
    }
}
