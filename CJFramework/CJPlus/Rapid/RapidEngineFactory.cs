namespace CJPlus.Rapid
{
    using System;

    public static class RapidEngineFactory
    {
        public static IP2PServer CreateP2PServer()
        {
            return new P2PServer();
        }

        public static IRapidPassiveEngine CreatePassiveEngine()
        {
            return new RapidPassiveEngine();
        }

        public static IServerEngine CreateServerEngine()
        {
            return new ServerEngine();
        }
    }
}

