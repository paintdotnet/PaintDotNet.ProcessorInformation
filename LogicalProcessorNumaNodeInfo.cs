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
    public struct LogicalProcessorNumaNodeInfo
    {
        private ulong processorMask;
        private int nodeNumber;

        public ulong ProcessorMask
        {
            get
            {
                return this.processorMask;
            }
        }

        public int NodeNumber
        {
            get
            {
                return this.nodeNumber;
            }
        }

        internal LogicalProcessorNumaNodeInfo(ulong processorMask, int nodeNumber)
        {
            this.processorMask = processorMask;
            this.nodeNumber = nodeNumber;
        }
    }
}