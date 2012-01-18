﻿using System;
using InlineScheduler.Advanced.State;

namespace InlineScheduler.Advanced
{
    public interface ISchedulerContext
    {
        DateTime CurrentTime { get; }        
        int GetNextRandom(int from, int to);

        IStateProvider State { get; }
    }
}