/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using PaintDotNet.Interop;
using System;
using System.Runtime.InteropServices;

namespace PaintDotNet.MemoryManagement
{
    public sealed class SafeCoTaskMemAllocHandle
        : SafeHandleZeroIsInvalid
    {
        public static SafeCoTaskMemAllocHandle Alloc(int cb)
        {
            SafeCoTaskMemAllocHandle safeHandle = new SafeCoTaskMemAllocHandle();
            IntPtr pBuffer = Marshal.AllocCoTaskMem(cb);
            safeHandle.TakeHandle(ref pBuffer);
            return safeHandle;
        }

        public IntPtr Address
        {
            get
            {
                return this.handle;
            }
        }

        private SafeCoTaskMemAllocHandle()
            : base(true)
        {
        }

        public SafeCoTaskMemAllocHandle(bool ownsHandle)
            : base(ownsHandle)
        {
        }

        public SafeCoTaskMemAllocHandle(IntPtr pBuffer, bool ownsHandle)
            : base(ownsHandle)
        {
            SetHandle(pBuffer);
        }

        private void TakeHandle(ref IntPtr pBuffer)
        {
            SetHandle(pBuffer);
            pBuffer = IntPtr.Zero;
        }

        protected override bool ReleaseHandle()
        {
            Marshal.FreeCoTaskMem(this.handle);
            return true;
        }
    }
}
