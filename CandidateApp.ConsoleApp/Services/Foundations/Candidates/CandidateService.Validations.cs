// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CandidateApp.ConsoleApp.Models.Candidate;
using CandidateApp.ConsoleApp.Models.Candidates.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.ConsoleApp.Services.Foundations.Candidates
{
    public partial class CandidateService
    {
        private static void ValidateCandidate(Candidate candidate)
        {
            if (candidate == null)
            {
                throw new NullCandidateException();
            }
        }
    }
}
