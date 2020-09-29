namespace CJPlus.Rapid
{
    using System;

    public static class RapidEngineFactory
    {
        public static IP2PServer CreateP2PServer()
        {
            return new P2PServer();
        }

        public static GInterface1 CreatePassiveEngine()
        {
            return new IRapidPassiveEngine();
        }

        public static GInterface7 CreateServerEngine()
        {
            return new ServerEngine();
        }
    }
}

