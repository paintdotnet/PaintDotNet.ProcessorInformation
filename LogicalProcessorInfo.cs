/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using Microsoft.Win32;
using PaintDotNet.MemoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PaintDotNet.SystemLayer
{
    public sealed class LogicalProcessorInfo
    {
        private IReadOnlyList<LogicalProcessorCoreInfo> cores;
        private IReadOnlyList<LogicalProcessorCacheInfo> caches;
        private IReadOnlyList<LogicalProcessorNumaNodeInfo> numaNodes;
        private IReadOnlyList<LogicalProcessorPackageInfo> packages;

        public IReadOnlyList<LogicalProcessorCoreInfo> Cores
        {
            get
            {
                return this.cores;
            }
        }

        public IReadOnlyList<LogicalProcessorCacheInfo> Caches
        {
            get
            {
                return this.caches;
            }
        }

        public IReadOnlyList<LogicalProcessorNumaNodeInfo> NumaNodes
        {
            get
            {
                return this.numaNodes;
            }
        }

        public IReadOnlyList<LogicalProcessorPackageInfo> Packages
        {
            get
            {
                return this.packages;
            }
        }

        internal LogicalProcessorInfo(
            IReadOnlyList<LogicalProcessorCoreInfo> cores,
            IReadOnlyList<LogicalProcessorCacheInfo> caches,
            IReadOnlyList<LogicalProcessorNumaNodeInfo> numaNodes,
            IReadOnlyList<LogicalProcessorPackageInfo> packages)
        {
            this.cores = cores;
            this.caches = caches;
            this.numaNodes = numaNodes;
            this.packages = packages;
        }
    }
}