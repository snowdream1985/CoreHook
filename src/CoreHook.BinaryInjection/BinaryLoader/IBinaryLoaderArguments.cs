﻿
namespace CoreHook.BinaryInjection.BinaryLoader
{
    public interface IBinaryLoaderArguments
    {
        bool Verbose { get; }
        string PayloadFileName { get; }
        string CoreRootPath { get; }
        string CoreLibrariesPath { get; }
    }
}
