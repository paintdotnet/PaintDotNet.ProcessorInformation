/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using PaintDotNet.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace PaintDotNet
{
    public static class UInt64Util
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong RotateLeft(ulong x, int count)
        {
            if (count < 0)
            {
                return RotateRight(x, -count);
            }

            int countP = count & 63;
            ulong xP = (x << countP) | (x >> (64 - countP));
            return xP;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong RotateRight(ulong x, int count)
        {
            if (count < 0)
            {
                return RotateLeft(x, -count);
            }

            int countP = count & 63;
            ulong xP = (x >> countP) | (x << (64 - countP));
            return xP;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CountBits(ulong x)
        {
            int count = 0;

            while (x > 0)
            {
                x &= x - 1;
                ++count;
            }

            return count;
        }

        // https://stackoverflow.com/a/11398748/1191082
        private static readonly byte[] multiplyByDeBruijnBitPosition =
            new byte[64]
            {
                63,  0, 58,  1, 59, 47, 53,  2,
                60, 39, 48, 27, 54, 33, 42,  3,
                61, 51, 37, 40, 49, 18, 28, 20,
                55, 30, 34, 11, 43, 14, 22,  4,
                62, 57, 46, 52, 38, 26, 32, 41,
                50, 36, 17, 19, 29, 10, 13, 21,
                56, 45, 25, 31, 35, 16,  9, 12,
                44, 24, 15,  8, 23,  7,  6,  5
            };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int HighestBit(ulong x)
        {
            ulong v = x;
            v |= v >> 1;
            v |= v >> 2;
            v |= v >> 4;
            v |= v >> 8;
            v |= v >> 16;
            v |= v >> 32;

            ulong i = unchecked((((v - (v >> 1)) * 0x07EDD5E59A4E28C2L)) >> 58);
            int r = multiplyByDeBruijnBitPosition[i];

            return r;
        }
    }
}
