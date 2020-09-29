using System;
using System.Net;

internal interface Interface29 : IDisposable, IEngine, ICommitMessageToServer, IUdpHelper
{
    void imethod_22(IMessageHandler interface37_0, IPEndPoint ipendPoint_0);
    void SendMessage(IMessageHandler interface37_0, IPEndPoint ipendPoint_0);
}

