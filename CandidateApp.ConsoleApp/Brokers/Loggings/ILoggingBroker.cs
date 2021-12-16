// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;

namespace CandidateApp.ConsoleApp.Brokers.Loggings
{
    public interface ILoggingBroker
    {
        void LogError(Exception exception);
    }
}
