﻿namespace Elephanet
{
    public interface IStoreConventions
    {
        IJsonConverter JsonConverter { get; }
        TableInfo TableInfo { get; }
    }
}
