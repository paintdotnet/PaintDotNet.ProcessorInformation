/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PaintDotNet.SystemLayer
{
    public static class ProcessorArchitectureExtensions
    {
        public static int ToBitness(this ProcessorArchitecture procArch)
        {
            switch (procArch)
            {
                case ProcessorArchitecture.Unknown:
                    throw new ArgumentException();

                case ProcessorArchitecture.X64:
                    return 64;

                case ProcessorArchitecture.X86:
                    return 32;

                default:
                    throw ExceptionUtil.InvalidEnumArgumentException(procArch, nameof(procArch));
            }
        }
    }
}
