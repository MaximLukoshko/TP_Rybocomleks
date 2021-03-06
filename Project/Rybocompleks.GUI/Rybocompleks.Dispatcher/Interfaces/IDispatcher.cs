﻿using Rybocompleks.Data;
using System;
using System.Collections.Generic;

namespace Rybocompleks.Dispatcher
{
    public interface IDispatcher
    {
        void RunFishGrowing();
        void StopFishGrowing();
        ICollection<IShowInfo> GetShowInfo();
        IGPAllowedStates GetCurrentInstruction();
        DateTime GetCurrentTime();
    }
}
