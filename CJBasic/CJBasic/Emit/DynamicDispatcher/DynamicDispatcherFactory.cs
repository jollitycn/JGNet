﻿namespace CJBasic.Emit.DynamicDispatcher
{
    using System;
    using System.Collections.Generic;

    public static class DynamicDispatcherFactory
    {
        private static global::CJBasic.Emit.DynamicDispatcher.DynamicDispatcherEmitter DynamicDispatcherEmitter = new global::CJBasic.Emit.DynamicDispatcher.DynamicDispatcherEmitter();

        public static TIDispatch CreateDispatcher<TIDispatch>(IEnumerable<TIDispatch> excuters)
        {
            lock (DynamicDispatcherEmitter)
            {
                return (TIDispatch) Activator.CreateInstance(DynamicDispatcherEmitter.CreateDispatcherType(typeof(TIDispatch)), new object[] { excuters });
            }
        }
    }
}

