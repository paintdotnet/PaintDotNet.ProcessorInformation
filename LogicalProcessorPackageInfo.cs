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
    public struct LogicalProcessorPackageInfo
    {
        private ulong processorMask;

        public ulong ProcessorMask
        {
            get
            {
                return this.processorMask;
            }
        }

        internal LogicalProcessorPackageInfo(ulong processorMask)
        {
            this.processorMask = processorMask;
        }
    }
}