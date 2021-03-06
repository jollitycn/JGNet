﻿namespace CJBasic.Threading.Engines
{
    using global::CJBasic;
    using System;

    public interface ICycleEngine
    {
        event CbGeneric<Exception> EngineStopped;

        void Start();
        void Stop();

        int DetectSpanInSecs { get; set; }

        bool IsRunning { get; }
    }
}

