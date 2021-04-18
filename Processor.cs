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
    /// <summary>
    /// Provides static methods and properties related to the CPU.
    /// </summary>
    public static class Processor
    {
        private static string cpuName;
        private static readonly ProcessorArchitecture architecture = GetProcessArchitecture();
        private static readonly ProcessorArchitecture nativeArchitecture = GetNativeArchitecture();
        private static bool allowSetFeatures = true;

        static Processor()
        {
        }

        public static unsafe LogicalProcessorInfo GetLogicalProcessorInformation()
        {
            int returnLength = 0;
            bool bResult = NativeMethods.GetLogicalProcessorInformation(null, ref returnLength);
            if (!bResult && returnLength == 0)
            {
                NativeUtilities.ThrowOnWin32Error("GetLogicalProcessorInformation() returned false");
            }

            using (SafeCoTaskMemAllocHandle buffer = SafeCoTaskMemAllocHandle.Alloc((int)returnLength))
            {
                NativeStructs.SYSTEM_LOGICAL_PROCESSOR_INFORMATION* pBuffer = (NativeStructs.SYSTEM_LOGICAL_PROCESSOR_INFORMATION*)buffer.Address;
                bResult = NativeMethods.GetLogicalProcessorInformation(pBuffer, ref returnLength);

                int elementSize = sizeof(NativeStructs.SYSTEM_LOGICAL_PROCESSOR_INFORMATION);
                int count = returnLength / elementSize;

                int coresCount = 0;
                int cachesCount = 0;
                int numaNodesCount = 0;
                int packagesCount = 0;

                for (int i = 0; i < count; ++i)
                {
                    switch (pBuffer[i].Relationship)
                    {
                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationCache:
                            ++cachesCount;
                            break;

                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationNumaNode:
                            ++numaNodesCount;
                            break;

                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorCore:
                            ++coresCount;
                            break;

                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorPackage:
                            ++packagesCount;
                            break;

                        default:
                            // don't count it
                            break;
                    }
                }

                LogicalProcessorCoreInfo[] cores = new LogicalProcessorCoreInfo[coresCount];
                LogicalProcessorCacheInfo[] caches = new LogicalProcessorCacheInfo[cachesCount];
                LogicalProcessorNumaNodeInfo[] numaNodes = new LogicalProcessorNumaNodeInfo[numaNodesCount];
                LogicalProcessorPackageInfo[] packages = new LogicalProcessorPackageInfo[packagesCount];

                int coresIndex = 0;
                int cachesIndex = 0;
                int numaNodesIndex = 0;
                int packagesIndex = 0;

                for (int i = 0; i < count; ++i)
                {
                    ulong processorMask = pBuffer[i].ProcessorMask.ToUInt64();

                    switch (pBuffer[i].Relationship)
                    {
                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationCache:
                            NativeStructs.CACHE_DESCRIPTOR cacheDescriptor = pBuffer[i].Cache;
                            LogicalProcessorCacheInfo cacheInfo = new LogicalProcessorCacheInfo(processorMask, cacheDescriptor.Level, cacheDescriptor.Associativity, cacheDescriptor.LineSize, cacheDescriptor.Size);
                            caches[cachesIndex] = cacheInfo;
                            ++cachesIndex;
                            break;

                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationNumaNode:
                            LogicalProcessorNumaNodeInfo numaNodeInfo = new LogicalProcessorNumaNodeInfo(processorMask, pBuffer[i].NumaNode_NodeNumber);
                            numaNodes[numaNodesIndex] = numaNodeInfo;
                            ++numaNodesIndex;
                            break;

                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorCore:
                            bool sharesFunctionalUnits = (pBuffer[i].ProcessorCore_Flags == 1);
                            LogicalProcessorCoreInfo coreInfo = new LogicalProcessorCoreInfo(processorMask, sharesFunctionalUnits);
                            cores[coresIndex] = coreInfo;
                            ++coresIndex;
                            break;

                        case NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorPackage:
                            LogicalProcessorPackageInfo packageInfo = new LogicalProcessorPackageInfo(processorMask);
                            packages[packagesIndex] = packageInfo;
                            ++packagesIndex;
                            break;

                        default:
                            break;
                    }
                }

                LogicalProcessorInfo info = new LogicalProcessorInfo(cores, caches, numaNodes, packages);
                return info;
            }
        }

        private static ProcessorArchitecture Convert(ushort wProcessorArchitecture)
        {
            ProcessorArchitecture platform;

            switch (wProcessorArchitecture)
            {
                case NativeConstants.PROCESSOR_ARCHITECTURE_AMD64:
                    platform = ProcessorArchitecture.X64;
                    break;

                case NativeConstants.PROCESSOR_ARCHITECTURE_INTEL:
                    platform = ProcessorArchitecture.X86;
                    break;

                default:
                case NativeConstants.PROCESSOR_ARCHITECTURE_UNKNOWN:
                    platform = ProcessorArchitecture.Unknown;
                    break;
            }

            return platform;
        }

        /// <summary>
        /// Returns the processor architecture that the current process is using.
        /// </summary>
        /// <remarks>
        /// Note that if the current process is 32-bit, but the OS is 64-bit, this
        /// property will still return X86 and not X64.
        /// </remarks>
        public static ProcessorArchitecture Architecture
        {
            get
            {
                return architecture;
            }
        }

        /// <summary>
        /// Returns the processor architecture of the installed operating system.
        /// </summary>
        /// <remarks>
        /// Note that this may differ from the Architecture property if, for instance,
        /// this is a 32-bit process on a 64-bit OS.
        /// </remarks>
        public static ProcessorArchitecture NativeArchitecture
        {
            get
            {
                return nativeArchitecture;
            }
        }

        private static ProcessorArchitecture GetProcessArchitecture()
        {
            NativeStructs.SYSTEM_INFO sysInfo = new NativeStructs.SYSTEM_INFO();
            NativeMethods.GetSystemInfo(out sysInfo);
            ProcessorArchitecture architecture = Convert(sysInfo.wProcessorArchitecture);
            return architecture;
        }

        private static ProcessorArchitecture GetNativeArchitecture()
        {
            NativeStructs.SYSTEM_INFO sysInfo = new NativeStructs.SYSTEM_INFO();
            NativeMethods.GetNativeSystemInfo(out sysInfo);
            ProcessorArchitecture architecture = Convert(sysInfo.wProcessorArchitecture);
            return architecture;
        }

        private static Guid processorClassGuid = new Guid("{50127DC3-0F36-415E-A6CC-4CB3BE910B65}");

        private static string GetCpuName()
        {
            IntPtr hDiSet = IntPtr.Zero;
            string cpuName = null;

            try
            {
                hDiSet = NativeMethods.SetupDiGetClassDevsW(ref processorClassGuid, null, IntPtr.Zero, NativeConstants.DIGCF_PRESENT);

                if (hDiSet == NativeConstants.INVALID_HANDLE_VALUE)
                {
                    NativeUtilities.ThrowOnWin32Error("SetupDiGetClassDevsW returned INVALID_HANDLE_VALUE");
                }

                bool bResult = false;
                uint memberIndex = 0;

                while (true)
                {
                    NativeStructs.SP_DEVINFO_DATA spDevinfoData = new NativeStructs.SP_DEVINFO_DATA();
                    spDevinfoData.cbSize = (uint)Marshal.SizeOf(typeof(NativeStructs.SP_DEVINFO_DATA));

                    bResult = NativeMethods.SetupDiEnumDeviceInfo(hDiSet, memberIndex, ref spDevinfoData);

                    if (!bResult)
                    {
                        int error = Marshal.GetLastWin32Error();

                        if (error == NativeConstants.ERROR_NO_MORE_ITEMS)
                        {
                            break;
                        }
                        else
                        {
                            throw new Win32Exception("SetupDiEnumDeviceInfo returned false, GetLastError() = " + error.ToString());
                        }
                    }

                    uint lengthReq = 0;
                    bResult = NativeMethods.SetupDiGetDeviceInstanceIdW(hDiSet, ref spDevinfoData, IntPtr.Zero, 0, out lengthReq);

                    if (bResult)
                    {
                        NativeUtilities.ThrowOnWin32Error("SetupDiGetDeviceInstanceIdW(1) returned true");
                    }

                    if (lengthReq == 0)
                    {
                        NativeUtilities.ThrowOnWin32Error("SetupDiGetDeviceInstanceIdW(1) returned false, but also 0 for lengthReq");
                    }

                    IntPtr str = IntPtr.Zero;
                    string regPath = null;

                    try
                    {
                        // Note: We cannot use Memory.Allocate() here because this property is
                        // usually retrieved during app shutdown, during which the heap may not
                        // be available.
                        str = Marshal.AllocHGlobal(checked((int)(sizeof(char) * (1 + lengthReq))));
                        bResult = NativeMethods.SetupDiGetDeviceInstanceIdW(hDiSet, ref spDevinfoData, str, lengthReq, out lengthReq);

                        if (!bResult)
                        {
                            NativeUtilities.ThrowOnWin32Error("SetupDiGetDeviceInstanceIdW(2) returned false");
                        }

                        regPath = Marshal.PtrToStringUni(str);
                    }
                    finally
                    {
                        if (str != IntPtr.Zero)
                        {
                            Marshal.FreeHGlobal(str);
                            str = IntPtr.Zero;
                        }
                    }

                    string keyName = @"SYSTEM\CurrentControlSet\Enum\" + regPath;
                    using (RegistryKey procKey = Registry.LocalMachine.OpenSubKey(keyName, false))
                    {
                        const string friendlyName = "FriendlyName";

                        if (procKey != null)
                        {
                            object valueObj = procKey.GetValue(friendlyName);
                            string value = valueObj as string;

                            if (value != null)
                            {
                                cpuName = value;
                            }
                        }
                    }

                    if (cpuName != null)
                    {
                        break;
                    }

                    ++memberIndex;
                }
            }
            finally
            {
                if (hDiSet != IntPtr.Zero)
                {
                    NativeMethods.SetupDiDestroyDeviceInfoList(hDiSet);
                    hDiSet = IntPtr.Zero;
                }
            }

            return cpuName;
        }

        /// <summary>
        /// Returns the name of the CPU that is installed. If more than 1 CPU is installed,
        /// then the name of the first one is retrieved.
        /// </summary>
        /// <remarks>
        /// This is the name that shows up in Windows Device Manager in the "Processors" node.
        /// Note to implementors: This is only ever used for diagnostics (e.g., crash log).
        /// </remarks>
        public static string CpuName
        {
            get
            {
                if (cpuName == null)
                {
                    cpuName = GetCpuName();
                }

                return cpuName;
            }
        }

        public static int MaxLogicalCpuCount
        {
            get
            {
                return IntPtr.Size * 8;
            }
        }

        [Obsolete("Use Environment.ProcessorCount instead")]
        public static int LogicalCpuCount
        {
            get
            {
                return Environment.ProcessorCount;
            }
        }

        [Obsolete("Use Environment.ProcessorCount instead")]
        public static int ConcreteLogicalCpuCount
        {
            get
            {
                return Environment.ProcessorCount;
            }
        }

        /// <summary>
        /// Gets the approximate speed of the processor, in megahurtz.
        /// </summary>
        /// <remarks>
        /// No accuracy is guaranteed, and precision is dependent on the operating system.
        /// If there is an error determining the CPU speed, then 0 will be returned.
        /// </remarks>
        public static int ApproximateSpeedMhz
        {
            get
            {
                const string keyName = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
                const string valueName = @"~MHz";
                int mhz = 0;

                try
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyName, false))
                    {
                        if (key != null)
                        {
                            object value = key.GetValue(valueName);
                            mhz = (int)value;
                        }
                    }
                }
                catch (Exception)
                {
                    mhz = 0;
                }

                return mhz;
            }
        }

        public static ProcessorFeature Features
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            get
            {
                return PdnNativeMethods.GetProcessorFeatures();
            }
        }

        public static bool IsFeaturePresent(ProcessorFeature feature)
        {
            if (feature == 0)
            {
                return false;
            }

            return (PdnNativeMethods.GetProcessorFeatures() & feature) != 0;
        }

        public static void LockSetFeatures()
        {
            allowSetFeatures = false;
        }

        public static void SetFeatures(ProcessorFeature features)
        {
            if (allowSetFeatures)
            {
                PdnNativeMethods.SetProcessorFeatures(features);
            }
        }

        internal static ProcessorFeature RawFeatures
        {
            get
            {
                return PdnNativeMethods.GetRawProcessorFeatures();
            }
        }

        internal static ProcessorFeature RawUsableFeatures
        {
            get
            {
                return PdnNativeMethods.GetRawUsableProcessorFeatures();
            }
        }
    }
}
