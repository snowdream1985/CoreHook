﻿using System;
using JsonRpc.Standard.Contracts;
using JsonRpc.Standard.Server;

namespace CoreHook.FileMonitor.Service
{
    public class FileMonitorService : JsonRpcService
    {
        private FileMonitorSessionFeature Session => RequestContext.Features.Get<FileMonitorSessionFeature>();

        [JsonRpcMethod]
        public void OnCreateFile(string[] fileNames)
        {
            foreach (var fileName in fileNames)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}
