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
    public struct LogicalProcessorCacheInfo
    {
        private ulong processorMask;
        private byte level;
        private byte associativity;
        private ushort lineSize;
        private uint size;

        public ulong ProcessorMask
        {
            get
            {
                return this.processorMask;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
        }

        public int Associativity
        {
            get
            {
                return this.associativity;
            }
        }

        public int LineSize
        {
            get
            {
                return this.lineSize;
            }
        }

        public int Size
        {
            get
            {
                return (int)this.size;
            }
        }

        internal LogicalProcessorCacheInfo(ulong processorMask, byte level, byte associativity, ushort lineSize, uint size)
        {
            this.processorMask = processorMask;
            this.level = level;
            this.associativity = associativity;
            this.lineSize = lineSize;
            this.size = size;
        }
    }
}