﻿using System;
using XrmFramework.RemoteDebugger.Client;
using XrmFramework.RemoteDebugger.Common;

namespace XrmFramework.RemoteDebugger
{
    static class Program
    {
        static void Main(string[] args)
        {
            var remoteDebugger = new RemoteDebugger<AzureRelayHybridConnectionMessageManager>();

            remoteDebugger.Start();
        }
    }
}