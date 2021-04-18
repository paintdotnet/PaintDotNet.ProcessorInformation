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
    public struct LogicalProcessorCoreInfo
    {
        private ulong processorMask;
        private bool sharesFunctionalUnits;

        public ulong ProcessorMask
        {
            get
            {
                return this.processorMask;
            }
        }

        public bool SharesFunctionalUnits
        {
            get
            {
                return this.sharesFunctionalUnits;
            }
        }

        internal LogicalProcessorCoreInfo(ulong processorMask, bool sharesFunctionalUnits)
        {
            this.processorMask = processorMask;
            this.sharesFunctionalUnits = sharesFunctionalUnits;
        }
    }
}