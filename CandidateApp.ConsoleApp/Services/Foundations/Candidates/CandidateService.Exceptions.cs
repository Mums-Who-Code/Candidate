// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CandidateApp.ConsoleApp.Models.Candidate;
using CandidateApp.ConsoleApp.Models.Candidates.Exceptions;
using Xeptions;

namespace CandidateApp.ConsoleApp.Services.Foundations.Candidates
{
    public partial class CandidateService
    {
        private delegate Candidate ReturningCandidateFunction();

        private Candidate TryCatch(ReturningCandidateFunction returningCandidateFunction)
        {
            try
            {
                return returningCandidateFunction();
            }
            catch (NullCandidateException nullCandidateException)
            {
                throw CreateAndLogValidationExcecption(nullCandidateException);
            }
            catch (InvalidCandidateException invalidCandidateException)
            {
                throw CreateAndLogValidationExcecption(invalidCandidateException);
            }
        }

        private CandidateValidationException CreateAndLogValidationExcecption(Xeption exception)
        {
            var candidateValidationException = new CandidateValidationException(exception);
            this.loggingBroker.LogError(candidateValidationException);

            throw candidateValidationException;
        }
    }
}
