/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using PaintDotNet.Rendering;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace PaintDotNet.SystemLayer
{
    internal static class NativeStructs
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct LARGE_INTEGER
        {
            [FieldOffset(0)]
            public uint LowPart;

            [FieldOffset(4)]
            public int HighPart;

            [FieldOffset(0)]
            public long QuadPart;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ULARGE_INTEGER
        {
            [FieldOffset(0)]
            public uint LowPart;

            [FieldOffset(4)]
            public uint HighPart;

            [FieldOffset(0)]
            public ulong QuadPart;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LUID
        {
            public uint LowPart;
            public uint HighPart;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LUID_AND_ATTRIBUTES
        {
            public LUID Luid;
            public uint Attributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TOKEN_PRIVILEGES
        {
            public uint PrivilegeCount;
            public LUID_AND_ATTRIBUTES Privilege; // this is actually a LUID_AND_ATTRIBUTES[0] in the header files. we only ever need to take one privilege though so this is fine
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct STATSTG 
        {  
            public IntPtr pwcsName;  
            public NativeConstants.STGTY type;  
            public ulong cbSize;
            public System.Runtime.InteropServices.ComTypes.FILETIME mtime;
            public System.Runtime.InteropServices.ComTypes.FILETIME ctime;
            public System.Runtime.InteropServices.ComTypes.FILETIME atime;  
            public uint grfMode;  
            public uint grfLocksSupported;  
            public Guid clsid;  
            public uint grfStateBits;  
            public uint reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
        public struct KNOWNFOLDER_DEFINITION
        {
            public NativeConstants.KF_CATEGORY category;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszName;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszCreator;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszDescription;
            public Guid fidParent;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszRelativePath;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszParsingName;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszToolTip;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszLocalizedName;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszIcon;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszSecurity;
            public uint dwAttributes;
            public NativeConstants.KF_DEFINITION_FLAGS kfdFlags;
            public Guid ftidType;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct PROPERTYKEY
        {
            public Guid fmtid;
            public uint pid;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
        public struct COMDLG_FILTERSPEC
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszName;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszSpec;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            public ushort wProcessorArchitecture;
            public ushort wReserved;
            public uint dwPageSize;
            public IntPtr lpMinimumApplicationAddress;
            public IntPtr lpMaximumApplicationAddress;
            public UIntPtr dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public ushort wProcessorLevel;
            public ushort wProcessorRevision;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct OSVERSIONINFOEX
        {
            public static int SizeOf
            {
                get
                {
                    return Marshal.SizeOf(typeof(OSVERSIONINFOEX));
                }
            }

            public uint dwOSVersionInfoSize;
            public uint dwMajorVersion;
            public uint dwMinorVersion;
            public uint dwBuildNumber;
            public uint dwPlatformId;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;

            public ushort wServicePackMajor;

            public ushort wServicePackMinor;
            public ushort wSuiteMask;
            public byte wProductType;
            public byte wReserved;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public UIntPtr dwData;
            public uint cbData;
            public IntPtr lpData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SHELLEXECUTEINFO
        {
            public uint cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)] public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)] public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)] public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)] public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)] public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon_or_hMonitor;
            public IntPtr hProcess;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORYSTATUSEX 
        {  
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFOHEADER
        {
            public uint biSize;
            public int biWidth;
            public int biHeight;
            public ushort biPlanes;
            public ushort biBitCount;
            public uint biCompression;
            public uint biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public uint biClrUsed;
            public uint biClrImportant;
        }

        public struct ICONINFO
            : IDisposable
        {
            [MarshalAs(UnmanagedType.Bool)]
            public bool fIcon;
            public uint xHotspot;
            public uint yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;

            public void Dispose()
            {
                if (this.hbmMask != IntPtr.Zero)
                {
                    NativeMethods.DeleteObject(this.hbmMask);
                    this.hbmMask = IntPtr.Zero;
                }

                if (this.hbmColor != IntPtr.Zero)
                {
                    NativeMethods.DeleteObject(this.hbmColor);
                    this.hbmColor = IntPtr.Zero;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CIEXYZ
        {
            public int ciexyzX;
            public int ciexyzY;
            public int ciexyzZ;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CIEXYZTRIPLE
        {
            public CIEXYZ ciexyzRed;
            public CIEXYZ ciexyzGreen;
            public CIEXYZ ciexyzBlue;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPV5HEADER 
        {
            public uint bV5Size;
            public int bV5Width;
            public int bV5Height;
            public ushort bV5Planes;
            public ushort bV5BitCount;
            public uint bV5Compression;
            public uint bV5SizeImage;
            public int bV5XPelsPerMeter;
            public int bV5YPelsPerMeter;
            public uint bV5ClrUsed;
            public uint bV5ClrImportant;
            public uint bV5RedMask;
            public uint bV5GreenMask;
            public uint bV5BlueMask;
            public uint bV5AlphaMask;
            public uint bV5CSType;
            public CIEXYZTRIPLE bV5Endpoints;
            public uint bV5GammaRed;
            public uint bV5GammaGreen;
            public uint bV5GammaBlue;
            public uint bV5Intent;
            public uint bV5ProfileData;
            public uint bV5ProfileSize;
            public uint bV5Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFO
        {
            public BITMAPINFOHEADER bmiHeader;
            public RGBQUAD bmiColors;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION 
        {
            public IntPtr BaseAddress;  
            public IntPtr AllocationBase;  
            public uint AllocationProtect;
            public IntPtr RegionSize;  
            public uint State;  
            public uint Protect;  
            public uint Type;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct COMBOBOXINFO
        {
            public uint cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public uint stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndItem;
            public IntPtr hwndList;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PAINTSTRUCT
        {
            public IntPtr hdc;
            [MarshalAs(UnmanagedType.Bool)] public bool fErase;
            public NativeStructs.RECT rcPaint;
            [MarshalAs(UnmanagedType.Bool)] public bool fRestore;
            [MarshalAs(UnmanagedType.Bool)] public bool fIncUpdate;

            public uint rgbReserved0;
            public uint rgbReserved1;
            public uint rgbReserved2;
            public uint rgbReserved3;
            public uint rgbReserved4;
            public uint rgbReserved5;
            public uint rgbReserved6;
            public uint rgbReserved7;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct LOGFONTW
            : IEquatable<LOGFONTW>
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;

            // Split the lfFaceName string across several fields. This way we can
            // have a blittable type and take the address of it from managed code.
            // LF_FACESIZE is 32, multiplied by 2 bytes per char is 64.
            private uint lfFaceName1;
            private uint lfFaceName2;
            private uint lfFaceName3;
            private uint lfFaceName4;
            private uint lfFaceName5;
            private uint lfFaceName6;
            private uint lfFaceName7;
            private uint lfFaceName8;
            private uint lfFaceName9;
            private uint lfFaceName10;
            private uint lfFaceName11;
            private uint lfFaceName12;
            private uint lfFaceName13;
            private uint lfFaceName14;
            private uint lfFaceName15;
            private uint lfFaceName16;

            private const int lfFaceNameSize = 2 * NativeConstants.LF_FACESIZE;

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
            public unsafe string lfFaceName
            {
                get
                {
                    fixed (uint* plfFaceName = &this.lfFaceName1)
                    {
                        using (var bytes = ArrayUtil.Rent<byte>(lfFaceNameSize))
                        {
                            Marshal.Copy((IntPtr)plfFaceName, bytes.Array, 0, lfFaceNameSize);
                            string faceName1 = Encoding.Unicode.GetString(bytes.Array);
                            int indexOf0 = faceName1.IndexOf('\0');
                            string faceName2 = faceName1.Substring(0, indexOf0);
                            return faceName2;
                        }
                    }
                }

                set
                {
                    if (value.Length >= NativeConstants.LF_FACESIZE)
                    {
                        throw new ArgumentException("Max length for this is " + NativeConstants.LF_FACESIZE);
                    }

                    if (value.Length == 0 || value[value.Length - 1] != '\0')
                    {
                        value += '\0';
                    }

                    byte[] bytes = Encoding.Unicode.GetBytes(value);

                    if (bytes.Length > lfFaceNameSize)
                    {
                        throw new ArgumentException("The encoded string was too big");
                    }

                    fixed (uint* plfFaceName = &this.lfFaceName1)
                    {
                        BufferUtil.Clear(plfFaceName, lfFaceNameSize);
                        Marshal.Copy(bytes, 0, (IntPtr)plfFaceName, Math.Min(bytes.Length, lfFaceNameSize));
                    }
                }
            }

            public override bool Equals(object obj)
            {
                return EquatableUtil.Equals(this, obj);
            }

            public bool Equals(LOGFONTW other)
            {
                return this.lfHeight == other.lfHeight &&
                       this.lfWidth == other.lfWidth &&
                       this.lfEscapement == other.lfEscapement &&
                       this.lfOrientation == other.lfOrientation &&
                       this.lfWeight == other.lfWeight &&
                       this.lfItalic == other.lfItalic &&
                       this.lfUnderline == other.lfUnderline &&
                       this.lfStrikeOut == other.lfStrikeOut &&
                       this.lfCharSet == other.lfCharSet &&
                       this.lfOutPrecision == other.lfOutPrecision &&
                       this.lfClipPrecision == other.lfClipPrecision &&
                       this.lfQuality == other.lfQuality &&
                       this.lfPitchAndFamily == other.lfPitchAndFamily &&
                       (0 == string.Compare(this.lfFaceName, other.lfFaceName, StringComparison.InvariantCulture));
            }

            public override int GetHashCode()
            {
                return HashCodeUtil.CombineHashCodes(
                    this.lfFaceName.GetHashCode(), 
                    this.lfHeight, 
                    this.lfQuality);                
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct ENUMLOGFONTEXW
        {
            public LOGFONTW elfLogFont;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NativeConstants.LF_FULLFACESIZE)]
            public string elfFullName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NativeConstants.LF_FACESIZE)]
            public string elfStyle;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NativeConstants.LF_FACESIZE)]
            public string elfScript;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct TEXTMETRICW
        {
            public int tmHeight;
            public int tmAscent;
            public int tmDescent;
            public int tmInternalLeading;
            public int tmExternalLeading;
            public int tmAveCharWidth;
            public int tmMaxCharWidth;
            public int tmWeight;
            public int tmOverhang;
            public int tmDigitizedAspectX;
            public int tmDigitizedAspectY;
            public char tmFirstChar;
            public char tmLastChar;
            public char tmDefaultChar;
            public char tmBreakChar;
            public byte tmItalic;
            public byte tmUnderlined;
            public byte tmStruckOut;
            public byte tmPitchAndFamily;
            public byte tmCharSet;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct OUTLINETEXTMETRICW_Base
        {
            public uint otmSize;
            public TEXTMETRICW otmTextMetrics;
            public byte otmFiller;
            public PANOSE otmPanoseNumber;
            public uint otmfsSelection;
            public uint otmfsType;
            public int otmsCharSlopeRise;
            public int otmsCharSlopeRun;
            public int otmItalicAngle;
            public uint otmEMSquare;
            public int otmAscent;
            public int otmDescent;
            public uint otmLineGap;
            public uint otmsCapEmHeight;
            public uint otmsXHeight;
            public RECT otmrcFontBox;
            public int otmMacAscent;
            public int otmMacDescent;
            public uint otmMacLineGap;
            public uint otmusMinimumPPEM;
            public POINT otmptSubscriptSize;
            public POINT otmptSubscriptOffset;
            public POINT otmptSuperscriptSize;
            public POINT otmptSuperscriptOffset;
            public uint otmsStrikeoutSize;
            public int otmsStrikeoutPosition;
            public int otmsUnderscoreSize;
            public int otmsUnderscorePosition;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct OUTLINETEXTMETRICW_Unsafe
        {
            public OUTLINETEXTMETRICW_Base baseStruct;
            private IntPtr otmpFamilyName;
            private IntPtr otmpFaceName;
            private IntPtr otmpStyleName;
            private IntPtr otmpFullName;

            public unsafe OUTLINETEXTMETRICW_Safe GetSafeCopy()
            {
                fixed (OUTLINETEXTMETRICW_Unsafe* pThis = &this)
                {
                    IntPtr pThisPtr = (IntPtr)pThis;

                    OUTLINETEXTMETRICW_Safe safeCopy = new OUTLINETEXTMETRICW_Safe();
                    safeCopy.baseStruct = this.baseStruct;

                    safeCopy.otmpFamilyName = Marshal.PtrToStringUni(new IntPtr(pThisPtr.ToInt64() + this.otmpFamilyName.ToInt64()));
                    safeCopy.otmpFaceName = Marshal.PtrToStringUni(new IntPtr(pThisPtr.ToInt64() + this.otmpFaceName.ToInt64()));
                    safeCopy.otmpStyleName = Marshal.PtrToStringUni(new IntPtr(pThisPtr.ToInt64() + this.otmpStyleName.ToInt64()));
                    safeCopy.otmpFullName = Marshal.PtrToStringUni(new IntPtr(pThisPtr.ToInt64() + this.otmpFullName.ToInt64()));

                    return safeCopy;
                }
            }
        }

        public class OUTLINETEXTMETRICW_Safe
        {
            public OUTLINETEXTMETRICW_Base baseStruct;
            public string otmpFamilyName;
            public string otmpFaceName;
            public string otmpStyleName;
            public string otmpFullName;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PANOSE
        {
            public byte bFamilyType;
            public byte bSerifStyle;
            public byte bWeight;
            public byte bProportion;
            public byte bContrast;
            public byte bStrokeVariation;
            public byte bArmStyle;
            public byte bLetterform;
            public byte bMidline;
            public byte bXHeight;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NEWTEXTMETRICW
        {
            public int tmHeight;
            public int tmAscent;
            public int tmDescent;
            public int tmInternalLeading;
            public int tmExternalLeading;
            public int tmAveCharWidth;
            public int tmMaxCharWidth;
            public int tmWeight;
            public int tmOverhang;
            public int tmDigitizedAspectX;
            public int tmDigitizedAspectY;
            public char tmFirstChar;
            public char tmLastChar;
            public char tmDefaultChar;
            public char tmBreakChar;
            public byte tmItalic;
            public byte tmUnderlined;
            public byte tmStruckOut;
            public byte tmPitchAndFamily;
            public byte tmCharSet;

            public uint ntmFlags; 
            public uint ntmSizeEM; 
            public uint ntmCellHeight; 
            public uint ntmAvgWidth;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NEWTEXTMETRICEXW
        {
            public NEWTEXTMETRICW ntmTm;
            public FONTSIGNATURE ntmFontSig;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FONTSIGNATURE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public uint[] fsUsb;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public uint[] fcCsb;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LOGBRUSH 
        { 
            public uint lbStyle; 
            public uint lbColor; 
            public int  lbHatch; 
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct RGNDATAHEADER 
        { 
            public uint dwSize; 
            public uint iType; 
            public uint nCount; 
            public uint nRgnSize; 
            public RECT rcBound; 
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGNDATA
        {
            public RGNDATAHEADER rdh;

            public unsafe static RECT *GetRectsPointer(RGNDATA *me)
            {
                return (RECT *)((byte *)me + sizeof(RGNDATAHEADER));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;

            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static POINT FromGdipPoint(System.Drawing.Point pt)
            {
                return new POINT(pt.X, pt.Y);
            }

            public static implicit operator Point2Int32(POINT pt)
            {
                return new Point2Int32(pt.x, pt.y);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            public RECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }

            public System.Drawing.Rectangle ToGdipRectangle()
            {
                return new System.Drawing.Rectangle(this.left, this.top, this.right - this.left, this.bottom - this.top);
            }

            public RectInt32 ToRectInt32()
            {
                return PaintDotNet.Rendering.RectInt32.FromEdges(this.left, this.top, this.right, this.bottom);
            }

            public static RECT FromRectInt32(PaintDotNet.Rendering.RectInt32 rect)
            {
                RECT rc = new RECT();
                rc.left = rect.X;
                rc.top = rect.Y;
                rc.right = rect.X + rect.Width;
                rc.bottom = rect.Y + rect.Height;
                return rc;
            }

            public static RECT FromGdipRectangle(System.Drawing.Rectangle rect)
            {
                RECT rc = new RECT();
                rc.left = rect.Left;
                rc.top = rect.Top;
                rc.right = rect.Right;
                rc.bottom = rect.Bottom;
                return rc;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ABC
        {
            public int abcA;
            public uint abcB;
            public int abcC;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct GCP_RESULTS
        {
            public uint lStructSize;
            public short* lpOutString;
            public uint* lpOrder;
            public int* lpDx;
            public int* lpCaretPos;
            public byte* lpClass;
            public short* lpGlyphs;
            public uint nGlyphs;
            public int nMaxFit;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SIZE
        {
            public int cx;
            public int cy;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct PropertyItem
        {
            public int id;
            public uint length;
            public short type;
            public void *value;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct WINTRUST_DATA
        {
            public uint cbStruct;
            public IntPtr pPolicyCallbackData;
            public IntPtr pSIPClientData;
            public uint dwUIChoice;
            public uint fdwRevocationChecks;
            public uint dwUnionChoice;
            public void *pInfo; // pFile, pCatalog, pBlob, pSgnr, or pCert
            public uint dwStateAction;
            public IntPtr hWVTStateData;
            public IntPtr pwszURLReference;
            public uint dwProvFlags;
            public uint dwUIContext;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct WINTRUST_FILE_INFO
        {
            public uint cbStruct;
            public char *pcwszFilePath;
            public IntPtr hFile;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct WINHTTP_CURRENT_USER_IE_PROXY_CONFIG
        {
            public bool fAutoDetect;
            public IntPtr lpszAutoConfigUrl;
            public IntPtr lpszProxy;
            public IntPtr lpszProxyBypass;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SP_DEVINFO_DATA
        {
            public uint cbSize;
            public Guid ClassGuid;
            public uint DevInst;
            public UIntPtr Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MSG
        {
            public IntPtr hwnd;
            public uint message;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public NativeStructs.POINT pt;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NONCLIENTMETRICSW
        {
            public uint cbSize;
            public int iBorderWidth;
            public int iScrollWidth;
            public int iScrollHeight;
            public int iCaptionWidth;
            public int iCaptionHeight;
            public NativeStructs.LOGFONTW lfCaptionFont;
            public int iSmCaptionWidth;
            public int iSmCaptionHeight;
            public NativeStructs.LOGFONTW lfSmCaptionFont;
            public int iMenuWidth;
            public int iMenuHeight;
            public NativeStructs.LOGFONTW lfMenuFont;
            public NativeStructs.LOGFONTW lfStatusFont;
            public NativeStructs.LOGFONTW lfMessageFont;
            public int iPaddedBorderWidth;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DTTOPTS
        {
            public uint dwSize;
            public uint dwFlags;
            public int crText;
            public int crBorder;
            public int crShadow;
            public int iTextShadowType;
            public NativeStructs.POINT ptShadowOffset;
            public int iBorderSize;
            public int iFontPropId;
            public int iColorPropId;
            public int iStateId;
            [MarshalAs(UnmanagedType.Bool)] public bool fApplyOverlay;
            public int iGlowSize;
            public IntPtr pfnDrawTextCallback; // ???
            public IntPtr lParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct NCCALCSIZE_PARAMS
        {
            public RECT rgrc0;
            public RECT rgrc1;
            public RECT rgrc2;
            public WINDOWPOS* lppos;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public uint flags;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct THUMBBUTTON
        {
            [MarshalAs(UnmanagedType.U4)]
            public NativeEnums.THBMASK dwMask;

            public uint iId;
            public uint iBitmap;
            public IntPtr hIcon;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szTip;

            [MarshalAs(UnmanagedType.U4)]
            public NativeEnums.THBFLAGS dwFlags;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct BP_PAINTPARAMS
        {
            public uint cbSize;
            public uint dwFlags;
            public NativeStructs.RECT* prcExclude;
            public NativeStructs.BLENDFUNCTION* pBlendFunction;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BP_ANIMATIONPARAMS
        {
            public uint cbSize;
            public uint dwFlags;
            public NativeEnums.BP_ANIMATIONSTYLE style;
            public uint dwDuration;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SHSTOCKICONINFO
        {
            public uint cbSize;
            public IntPtr hIcon;
            public int iSysImageIndex;
            public int iIcon;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = NativeConstants.MAX_PATH)]
            public ushort[] szPath;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WTA_OPTIONS
        {
            public uint dwFlags;
            public uint dwMask;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TITLEBARINFOEX
        {
            public uint cbSize;
            public RECT rcTitleBar;

            public uint rgstate0;
            public uint rgstate1;
            public uint rgstate2;
            public uint rgstate3;
            public uint rgstate4;
            public uint rgstate5;

            public RECT rgrect0;
            public RECT rgrect1;
            public RECT rgrect2;
            public RECT rgrect3;
            public RECT rgrect4;
            public RECT rgrect5;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TPMPARAMS
        {
            public uint cbSize;
            public RECT rcExclude;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TRACKMOUSEEVENT
        {
            public uint cbSize;
            public uint dwFlags;
            public IntPtr hwndTrack;
            public uint dwHoverTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPLACEMENT
        {
            public uint length;
            public uint flags;
            public uint showCmd;
            public POINT ptMinPosition;
            public POINT ptMaxPosition;
            public RECT rcNormalPosition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TIMECAPS
        {
            public uint wPeriodMin;
            public uint wPeriodMax;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public struct CRITICAL_SECTION
        {
            private IntPtr DebugInfo;

            private uint LockCount;
            private uint RecursionCount;
            private IntPtr OwningThread;
            private IntPtr LockSemaphore;
            private UIntPtr SpinCount;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CONDITION_VARIABLE
        {
            private IntPtr Ptr;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEMOVEPOINT
        {
            public int x;
            public int y;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTER_DEVICE_CURSOR_INFO 
        {
            public uint cursorId;
            public PaintDotNet.Input.PointerDeviceCursorType cursor;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct POINTER_DEVICE_INFO 
        {
            public uint displayOrientation;
            public IntPtr device; // HANDLE
            public PaintDotNet.Input.PointerDeviceType pointerDeviceType;
            public IntPtr monitor; // HMONITOR
            public uint startingCursorId;
            public ushort maxActiveContacts;
            public fixed char productString[NativeConstants.POINTER_DEVICE_PRODUCT_STRING_MAX];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTER_DEVICE_PROPERTY
        {
            public int logicalMin;
            public int logicalMax;
            public int physicalMin;
            public int physicalMax;
            public int unit;
            public uint unitExponent;
            public ushort usagePageId;
            public ushort usageId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTER_PEN_INFO
        {
            public PaintDotNet.Input.RawPointerInfo pointerInfo;
            public PaintDotNet.Input.RawPenFlags penFlags;
            public PaintDotNet.Input.RawPenMask penMask;
            public uint pressure;
            public uint rotation;
            public int tiltX;
            public int tiltY;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTER_TOUCH_INFO 
        {
            public PaintDotNet.Input.RawPointerInfo pointerInfo;
            public NativeEnums.TOUCH_FLAGS touchFlags;
            public NativeEnums.TOUCH_MASK touchMask;
            public RECT rcContact;
            public RECT rcContactRaw;
            public uint orientation;
            public uint pressure;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TOUCHPREDICTIONPARAMETERS
        {
            public uint cbSize;
            public uint dwLatency;
            public uint dwSampleTime;
            public uint bUseHWTimeStamp;

            public const uint TOUCHPREDICTIONPARAMETERS_DEFAULT_LATENCY = 8;
            public const uint TOUCHPREDICTIONPARAMETERS_DEFAULT_SAMPLETIME = 8;
            public const uint TOUCHPREDICTIONPARAMETERS_DEFAULT_USE_HW_TIMESTAMP = 1;
            public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_DELTA = 0.001f;
            public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MIN = 0.9f;
            public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MAX = 0.999f;
            public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_LEARNING_RATE = 0.001f;
            public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_EXPO_SMOOTH_ALPHA = 0.99f;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DROPFILES
        {
            public uint pFiles;

            public POINT pt;

            //[MarshalAs(UnmanagedType.Bool)]
            private uint _fNC;

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
            public bool fNC
            {
                get
                {
                    return this._fNC != 0;
                }

                set
                {
                    this._fNC = value ? 1U : 0U;
                }
            }

            //[MarshalAs(UnmanagedType.Bool)]
            private uint _fWide;

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
            public bool fWide
            {
                get
                {
                    return this._fWide != 0;
                }

                set
                {
                    this._fWide = value ? 1U : 0U;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GESTURECONFIG
        {
            public uint dwID;
            public uint dwWant;
            public uint dwBlock;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GESTUREINFO
        {
            public uint cbSize;
            public uint dwFlags;
            public uint dwID;
            public IntPtr hwndTarget;
            public NativeStructs.POINTS ptsLocation;
            public uint dwInstanceID;
            public uint dwSequenceID;
            public ulong ullArguments;
            public uint cbExtraArgs;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTS
        {
            public short x;
            public short y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CACHE_DESCRIPTOR
        {
            public byte Level;
            public byte Associativity;
            public ushort LineSize;
            public uint Size;
            public NativeEnums.PROCESSOR_CACHE_TYPE Type;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
        {
            public UIntPtr ProcessorMask;
            public NativeEnums.LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

            private Union union;

            /// <summary>
            /// If the value of this member is 1, the logical processors identified by the value of the ProcessorMask 
            /// member share functional units, as in Hyperthreading or SMT. Otherwise, the identified logical processors 
            /// do not share functional units.
            /// 
            /// This is valid only if the Relationship member is RelationProcessorCore.
            /// </summary>
            public byte ProcessorCore_Flags
            {
                get
                {
                    return this.union.ProcessorCore_Flags;
                }
            }

            /// <summary>
            /// Identifies the NUMA node. The valid values of this parameter are 0 to the highest NUMA node number 
            /// inclusive. A non-NUMA multiprocessor system will report that all processors belong to one NUMA node.
            /// 
            /// This is valid only if the Relationship member is RelationNumaNode.
            /// </summary>
            public int NumaNode_NodeNumber
            {
                get
                {
                    return this.union.NumaNode_NodeNumber;
                }
            }

            /// <summary>
            /// A CACHE_DESCRIPTOR structure that identifies the characteristics of a particular cache. There is 
            /// one record returned for each cache reported. Some or all caches may not be reported, depending on 
            /// the mechanism used by the processor to identify its caches. Therefore, do not assume the absence 
            /// of any particular caches. Caches are not necessarily shared among logical processors.
            /// 
            /// This is valid only if the Relationship member is RelationCache.
            /// </summary>
            public NativeStructs.CACHE_DESCRIPTOR Cache
            {
                get
                {
                    return this.union.Cache;
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            private struct Union
            {
                [FieldOffset(0)]
                public byte ProcessorCore_Flags;

                [FieldOffset(0)]
                public int NumaNode_NodeNumber;

                [FieldOffset(0)]
                public NativeStructs.CACHE_DESCRIPTOR Cache;

                [FieldOffset(0)]
                public ulong Reserved0;

                [FieldOffset(8)]
                public ulong Reserved1;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct MONITORINFOEXW
        {
            public uint cbSize;
            public RECT rcMonitor;
            public RECT rcWork;
            public uint dwFlags;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szDevice;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct DEVMODEW
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;

            public ushort dmSpecVersion;
            public ushort dmDriverVersion;
            public ushort dmSize;
            public ushort dmDriverExtra;
            public uint dmFields;

            /*public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;
            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;*/
            // These next 4 int fields are a union with the above 8 shorts, but we don't need them right now
            public int dmPositionX;
            public int dmPositionY;
            public uint dmDisplayOrientation;
            public uint dmDisplayFixedOutput;

            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;

            public short dmLogPixels;
            public uint dmBitsPerPel;
            public uint dmPelsWidth;
            public uint dmPelsHeight;

            public uint dmNupOrDisplayFlags;
            public uint dmDisplayFrequency;

            public uint dmICMMethod;
            public uint dmICMIntent;
            public uint dmMediaType;
            public uint dmDitherType;
            public uint dmReserved1;
            public uint dmReserved2;
            public uint dmPanningWidth;
            public uint dmPanningHeight;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct APPBARDATA
        {
            public uint cbSize;
            public IntPtr hWnd;
            public uint uCallbackMessage;
            public uint uEdge;
            public RECT rc;
            public IntPtr lParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte SystemStatusFlag;
            public uint BatteryLifeTime;
            public uint BatteryFullLifeTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct POWERBROADCAST_SETTING
        {
            public Guid PowerSetting;
            public uint DataLength;
            public byte Data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct TASKDIALOGCONFIG
        {
            public static int CbSize { get; } = Marshal.SizeOf<TASKDIALOGCONFIG>();

            public int cbSize;
            public IntPtr hwndParent;
            public IntPtr hInstance;
            public NativeEnums.TASKDIALOG_FLAGS dwFlags;
            public NativeEnums.TASKDIALOG_COMMON_BUTTON_FLAGS dwCommonButtons;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszWindowTitle;

            public IntPtr hMainIcon;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszMainInstruction;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszContent;

            public int cButtons;
            public NativeStructs.TASKDIALOG_BUTTON* pButtons;

            public int nDefaultButton;

            public int cRadioButtons;
            public NativeStructs.TASKDIALOG_BUTTON* pRadioButtons;

            public int nDefaultRadioButton;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszVerificationText;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszExpandedInformation;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszExpandedControlText;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszCollapsedControlText;

            public IntPtr hFooterIcon;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszFooter;

            public IntPtr pfCallback;
            public IntPtr lpCallbackData;

            public int cxWidth;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TASKDIALOG_BUTTON
        {
            public int nButtonID;
            public IntPtr pwszButtonText;
        }
    }
}
