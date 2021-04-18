/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using System;

namespace PaintDotNet.SystemLayer
{
    // NOTE: Keep this synchronized with ProcessorFeature over in SystemLayer.Native/InstructionSet.h
    [Flags]
    public enum ProcessorFeature
        : ulong
    {
        None = 0,
        SSE = (1 << 1),
        SSE2 = (1 << 2),
        SSE3 = (1 << 3),
        SSSE3 = (1 << 4),
        SSE4_1 = (1 << 5),
        SSE4_2 = (1 << 6),
        AVX = (1 << 8),
        AVX2 = (1 << 12)
    }
}
