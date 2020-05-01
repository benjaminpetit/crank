﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Benchmarks.Models
{
    public enum WebHost
    {
        KestrelSockets,
        KestrelLibuv,
        HttpSys,
        IISInProcess,
        IISOutOfProcess,
        Docker,
        CCore
    }
}