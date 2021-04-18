/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintDotNet.SystemLayer
{
    public static class LogicalProcessorInfoExtensions
    {
        public static int GetPhysicalCoreCount(this LogicalProcessorInfo processorInfo)
        {
            int coreCount = 0;
            foreach (LogicalProcessorCoreInfo coreInfo in processorInfo.Cores)
            {
                if (coreInfo.SharesFunctionalUnits)
                {
                    ++coreCount;
                }
                else
                {
                    int coreProcessorCount = UInt64Util.CountBits(coreInfo.ProcessorMask);
                    coreCount += coreProcessorCount;
                }
            }

            return coreCount;
        }

        public static int GetLogicalCoreCount(this LogicalProcessorInfo processorInfo)
        {
            ulong procMask = 0;
            foreach (LogicalProcessorCoreInfo coreInfo in processorInfo.Cores)
            {
                procMask |= coreInfo.ProcessorMask;
            }

            int coreCount = UInt64Util.CountBits(procMask);

            Debug.Assert(coreCount == Environment.ProcessorCount);
            return coreCount;
        }
    }
}
