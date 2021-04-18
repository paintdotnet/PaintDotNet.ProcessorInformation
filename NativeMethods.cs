/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace PaintDotNet.SystemLayer
{
    [SuppressUnmanagedCodeSecurity]
    internal static class NativeMethods
    {
        public static bool SUCCEEDED(int hr)
        {
            return hr >= 0;
        }

        public static bool FAILED(int hr)
        {
            return hr < 0;
        }

        public static short LOWORD(IntPtr value)
        {
            return unchecked((short)((long)value & 0xffff));
        }

        public static short HIWORD(IntPtr value)
        {
            return unchecked((short)((long)value >> 16));
        }

        public static short GET_KEYSTATE_WPARAM(IntPtr wParam)
        {
            return LOWORD(wParam);
        }

        public static short GET_WHEEL_DELTA_WPARAM(IntPtr wParam)
        {
            return HIWORD(wParam);
        }

        public static IntPtr MAKEINTRESOURCEW(int i)
        {
            ushort w = unchecked((ushort)i);
            IntPtr ip = (IntPtr)w;
            return ip;
        }

        public static int GET_X_LPARAM(IntPtr lParam)
        {
            return (int)LOWORD(lParam);
        }

        public static int GET_Y_LPARAM(IntPtr lParam)
        {
            return (int)HIWORD(lParam);
        }

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern void SetLastError(uint dwErrCode);

        public static void SetLastError(NativeErrors dwErrCode)
        {
            SetLastError((uint)dwErrCode);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr LoadLibraryW(
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern bool FreeLibrary(
            IntPtr hModule);

        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool EnumProcessModules(
            IntPtr hProcess,
            IntPtr* lphModule,
            uint cb,
            out uint lpcbNeeded);

        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool EnumProcessModulesEx(
            IntPtr hProcess,
            IntPtr* lphModule,
            uint cb,
            out uint lpcbNeeded,
            uint dwFilterFlag);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetModuleHandleW(
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetModuleFileNameW(
            IntPtr hModule,
            IntPtr lpFilename,
            uint nSize);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetGuiResources(
            IntPtr hProcess,
            uint uiFlags);

        [DllImport("gdi32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GdiFlush();

        /*
        [DllImport("comctl32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void TaskDialog(
            IntPtr hWndParent,
            IntPtr hInstance,
            [In] string pszWindowTitle,
            [In] string pszMainInstruction,
            [In] string pszContent,
            uint dwCommonButtons,
            IntPtr pszIcon,
            out int pnButton);
        */

        [DllImport("comctl32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static unsafe extern void TaskDialogIndirect(
            ref NativeStructs.TASKDIALOGCONFIG pTaskConfig,
            int* pnButton,
            int* pnRadioButton,
            int* pfVerificationFlagChecked);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern uint GetMessageTime();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern unsafe int GetMouseMovePointsEx(
            int cbSize,
            ref NativeStructs.MOUSEMOVEPOINT lppt,
            NativeStructs.MOUSEMOVEPOINT* lpptBuf,
            int nBufPoints,
            uint resolution);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeValueW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSystemName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName,
            out NativeStructs.LUID lpLuid);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustTokenPrivileges(
            IntPtr tokenHandle,
            [MarshalAs(UnmanagedType.Bool)] bool disableAllPrivileges,
            ref NativeStructs.TOKEN_PRIVILEGES NewState,
            uint BufferLength,
            out NativeStructs.TOKEN_PRIVILEGES PreviousState,
            out uint ReturnLength);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void SHGetFolderPathW(
            IntPtr hwndOwner,
            int nFolder,
            IntPtr hToken,
            uint dwFlags,
            StringBuilder lpszPath);

        [DllImport("shell32.dll", PreserveSig = true)]
        public static extern int SHOpenFolderAndSelectItems(
            IntPtr pidlFolder,
            uint cidl,
            IntPtr apidl,
            uint dwFlags);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, PreserveSig = true)]
        public static extern IntPtr ILCreateFromPathW(
            [MarshalAs(UnmanagedType.LPWStr)] string pszPath);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr DefWindowProc(
            IntPtr hWnd,
            int Msg,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(
            IntPtr hWnd,
            uint uCmd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumThreadWindows(
            uint dwThreadId,
            [MarshalAs(UnmanagedType.FunctionPtr)] NativeDelegates.EnumThreadWndProc lpEnumFunc,
            IntPtr lParam);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(
            uint dwDesiredAccess,
            [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
            uint dwProcessId);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenProcessToken(
            IntPtr ProcessHandle,
            uint DesiredAccess,
            out IntPtr TokenHandle);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DuplicateTokenEx(
            IntPtr hExistingToken,
            uint dwDesiredAccess,
            IntPtr lpTokenAttributes,
            NativeConstants.SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            NativeConstants.TOKEN_TYPE TokenType,
            out IntPtr phNewToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessWithTokenW(
            IntPtr hToken,
            uint dwLogonFlags,
            IntPtr lpApplicationName,
            IntPtr lpCommandLine,
            uint dwCreationFlags,
            IntPtr lpEnvironment,
            IntPtr lpCurrentDirectory,
            IntPtr lpStartupInfo,
            out NativeStructs.PROCESS_INFORMATION lpProcessInfo);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint RegisterClipboardFormatW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetClipboardData(
            uint uFormat,
            IntPtr hMem);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EmptyClipboard();

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseClipboard();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint EnumClipboardFormats(uint format);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetClipboardData(uint format);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static unsafe extern int GetClipboardFormatNameW(
            uint format,
            char* lpszFormatName,
            int cchMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsClipboardFormatAvailable(uint format);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerifyVersionInfo(
            ref NativeStructs.OSVERSIONINFOEX lpVersionInfo,
            uint dwTypeMask,
            ulong dwlConditionMask);

        [DllImport("kernel32.dll")]
        public static extern ulong VerSetConditionMask(
            ulong dwlConditionMask,
            uint dwTypeBitMask,
            byte dwConditionMask);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProductInfo(
            uint dwOSMajorVersion,
            uint dwOSMinorVersion,
            uint dwSpMajorVersion,
            uint dwSpMinorVersion,
            out uint pdwReturnedProductType);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(
            IntPtr hDevice,
            uint dwIoControlCode,
            IntPtr lpInBuffer,
            uint nInBufferSize,
            IntPtr lpOutBuffer,
            uint nOutBufferSize,
            ref uint lpBytesReturned,
            IntPtr lpOverlapped);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShellExecuteExW(ref NativeStructs.SHELLEXECUTEINFO lpExecInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx(ref NativeStructs.MEMORYSTATUSEX lpBuffer);

        [DllImport("shell32.dll", SetLastError = false)]
        public static extern void SHAddToRecentDocs(uint uFlags, IntPtr pv);

        [DllImport("Wintrust.dll", PreserveSig = true, SetLastError = false)]
        public static extern unsafe int WinVerifyTrust(
            IntPtr hWnd,
            ref Guid pgActionID,
            ref NativeStructs.WINTRUST_DATA pWinTrustData);

        [DllImport("SetupApi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr SetupDiGetClassDevsW(
            ref Guid ClassGuid,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string Enumerator,
            IntPtr hwndParent,
            uint Flags);

        [DllImport("SetupApi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetupDiDestroyDeviceInfoList(IntPtr DeviceInfoSet);

        [DllImport("SetupApi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetupDiEnumDeviceInfo(
            IntPtr DeviceInfoSet,
            uint MemberIndex,
            ref NativeStructs.SP_DEVINFO_DATA DeviceInfoData);

        [DllImport("SetupApi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetupDiGetDeviceInstanceIdW(
            IntPtr DeviceInfoSet,
            ref NativeStructs.SP_DEVINFO_DATA DeviceInfoData,
            IntPtr DeviceInstanceId,
            uint DeviceInstanceIdSize,
            out uint RequiredSize);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, ref NativeStructs.RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(
            IntPtr hWnd,
            IntPtr hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComboBoxInfo(
            IntPtr hwndCombo,
            ref NativeStructs.COMBOBOXINFO pcbi);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr WindowFromPoint(NativeStructs.POINT Point);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr ChildWindowFromPoint(
            IntPtr hWndParent,
            NativeStructs.POINT Point);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr WindowFromDC(IntPtr hdc);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetAncestor(IntPtr hwnd, uint gaFlags);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern int GetWindowPlacement(
            IntPtr hWnd,
            ref NativeStructs.WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint TrackPopupMenuEx(
            IntPtr hmenu,
            uint fuFlags,
            int x,
            int y,
            IntPtr hwnd,
            IntPtr lptpm); // TPMPARAMS

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackMouseEvent(
            ref NativeStructs.TRACKMOUSEEVENT lpEventTrack);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawMenuBar(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawCaption(
            IntPtr hwnd,
            IntPtr hdc,
            ref NativeStructs.RECT lprc,
            uint uFlags);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetSystemMenu(
            IntPtr hWnd,
            [MarshalAs(UnmanagedType.Bool)] bool bRevert);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern int EnableMenuItem(
            IntPtr hMenu,
            uint uIDEnableItem,
            uint uEnable);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow(
            IntPtr hWnd,
            [MarshalAs(UnmanagedType.Bool)] bool bEnable);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindow(
            IntPtr hWnd,
            [MarshalAs(UnmanagedType.Bool)] bool bInvert);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr SetCursor(IntPtr hCursor);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyCursor(IntPtr hCursor);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr LoadCursorW(IntPtr hInstance, IntPtr lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr LoadIconW(IntPtr hInstance, IntPtr lpIconName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr LoadImageW(
            IntPtr hinst,
            IntPtr lpszName,
            uint uType,
            int cxDesired,
            int cyDestired,
            uint fuLoad);

        [DllImport("dwmapi.dll")]
        public unsafe static extern int DwmGetWindowAttribute(
            IntPtr hwnd,
            uint dwAttribute,
            void* pvAttribute,
            uint cbAttribute);

        [DllImport("dwmapi.dll")]
        public unsafe static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            uint dwAttribute,
            void* pvAttribute,
            uint cbAttribute);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern uint GetCurrentThreadId();

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern IntPtr GetCurrentThread();

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern uint GetCurrentProcessId();

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadPriority(
            IntPtr hThread,
            int nPriority);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr CreateFileMappingW(
            IntPtr hFile,
            IntPtr lpFileMappingAttributes,
            uint flProtect,
            uint dwMaximumSizeHigh,
            uint dwMaximumSizeLow,
            [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr OpenFileMappingW(
            uint dwDesiredAccess,
            [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
            [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr MapViewOfFile(
            IntPtr hFileMappingObject,
            uint dwDesiredAccess,
            uint dwFileOffsetHigh,
            uint dwFileOffsetLow,
            UIntPtr dwNumberOfBytesToMap);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowScrollBar(
            IntPtr hWnd,
            int wBar,
            [MarshalAs(UnmanagedType.Bool)] bool bShow);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionEx(ref NativeStructs.OSVERSIONINFOEX lpVersionInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLayeredWindowAttributes(
            IntPtr hwnd,
            out uint pcrKey,
            out byte pbAlpha,
            out uint pdwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes(
            IntPtr hwnd,
            uint crKey,
            byte bAlpha,
            uint dwFlags);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern int SetGraphicsMode(
            IntPtr hdc,
            int iMode);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        public static extern int EnumFontFamiliesExW(
            IntPtr hdc,
            ref NativeStructs.LOGFONTW lpLogFont,
            [MarshalAs(UnmanagedType.FunctionPtr)] NativeDelegates.EnumFontFamExProcW lpEnumFontFamExProc,
            IntPtr lParam,
            uint dwFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        public static extern IntPtr CreateFontIndirectW(
            ref NativeStructs.LOGFONTW lplf);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern uint GetFontLanguageInfo(IntPtr hdc);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        public static extern int DrawTextW(
            IntPtr hdc,
            string lpString,
            int nCount,
            ref NativeStructs.RECT lpRect,
            uint uFormat);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextMetricsW(
            IntPtr hdc,
            out NativeStructs.TEXTMETRICW lptm);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern uint GetOutlineTextMetricsW(
            IntPtr hdc,
            uint cbData,
            IntPtr lpOTM);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern uint SetTextAlign(IntPtr hdc, uint fMode);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern uint SetTextColor(IntPtr hdc, uint crColor);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern uint SetBkColor(IntPtr hdc, uint crColor);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern int SetBkMode(IntPtr hdc, int iBkMode);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern SafeIconHandle CreateIconIndirect(ref NativeStructs.ICONINFO piconInfo);

        [DllImport("user32.dll", EntryPoint = "CreateIconIndirect", SetLastError = true)]
        public static extern SafeCursorHandle CreateCursorIndirect(ref NativeStructs.ICONINFO piconInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(
            SafeIconHandle hIcon,
            out NativeStructs.ICONINFO piconinfo);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern IntPtr CreateDIBSection(
            IntPtr hdc,
            ref NativeStructs.BITMAPINFO pbmi,
            uint iUsage,
            out IntPtr ppvBits,
            IntPtr hSection,
            uint dwOffset);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr CreateFileW(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public unsafe static extern bool WriteFile(
            IntPtr hFile,
            void* lpBuffer,
            uint nNumberOfBytesToWrite,
            out uint lpNumberOfBytesWritten,
            IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public unsafe static extern bool WriteFile(
            SafeFileHandle hFile,
            void* lpBuffer,
            uint nNumberOfBytesToWrite,
            out uint lpNumberOfBytesWritten,
            IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public unsafe static extern bool ReadFile(
            SafeFileHandle sfhFile,
            void* lpBuffer,
            uint nNumberOfBytesToRead,
            out uint lpNumberOfBytesRead,
            IntPtr lpOverlapped);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplaceFileW(
            [MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName,
            uint dwReplaceFlags,
            IntPtr lpExclude,
            IntPtr lpReserved);

        [DllImport("kernel32.dll", SetLastError = true)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetHandleInformation(
            IntPtr hObject,
            uint dwMask,
            uint dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr BeginPaint(
            IntPtr hwnd,
            ref NativeStructs.PAINTSTRUCT lpPaint);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPaint(
            IntPtr hwnd,
            ref NativeStructs.PAINTSTRUCT lpPaint);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool GetUpdateRect(
            IntPtr hWnd,
            NativeStructs.RECT* lpRect,
            [MarshalAs(UnmanagedType.Bool)] bool bErase);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern int GetUpdateRgn(
            IntPtr hWnd,
            IntPtr hRgn,
            [MarshalAs(UnmanagedType.Bool)] bool bErase);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern uint GetWindowThreadProcessId(
            IntPtr hWnd,
            out uint lpdwProcessId);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr FindWindowW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern ushort GetAsyncKeyState(int nVirtKey);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern ushort GetKeyState(int nVirtKey);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern uint GetInputState();

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageW(
            out NativeStructs.MSG lpMsg,
            IntPtr hWnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax,
            uint wRemoveMsg);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage(
            ref NativeStructs.MSG lpMsg);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr DispatchMessageW(
            ref NativeStructs.MSG lpMsg);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr SendMessageW(
            IntPtr hWnd,
            uint msg,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal extern static bool PostMessageW(
            IntPtr handle,
            uint msg,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "SetWindowLongW")]
        public static extern uint SetClassLongW_x86(
            IntPtr hWnd,
            int nIndex,
            uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "SetWindowLongPtrW")]
        public static extern UIntPtr SetClassLongPtrW_x64(
            IntPtr hWnd,
            int nIndex,
            UIntPtr dwNewLong);

        public static UIntPtr SetClassLongPtrW(IntPtr hWnd, int nIndex, UIntPtr dwNewLong)
        {
            NativeMethods.SetLastError(NativeErrors.ERROR_SUCCESS);

            if (Processor.Architecture == ProcessorArchitecture.X64)
            {
                return SetClassLongPtrW_x64(hWnd, nIndex, dwNewLong);
            }
            else
            {
                return (UIntPtr)SetClassLongW_x86(hWnd, nIndex, unchecked((uint)dwNewLong.ToUInt32()));
            }
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "GetWindowLongW")]
        public static extern uint GetWindowLongW_x86(
            IntPtr hWnd,
            int nIndex);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "GetWindowLongPtrW")]
        public static extern UIntPtr GetWindowLongPtrW_x64(
            IntPtr hWnd,
            int nIndex);

        public static UIntPtr GetWindowLongPtrW(IntPtr hWnd, int nIndex)
        {
            if (Processor.Architecture == ProcessorArchitecture.X64)
            {
                return GetWindowLongPtrW_x64(hWnd, nIndex);
            }
            else
            {
                return (UIntPtr)GetWindowLongW_x86(hWnd, nIndex);
            }
        }

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongW")]
        public static extern uint SetWindowLongW_x86(
            IntPtr hWnd,
            int nIndex,
            uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtrW")]
        public static extern IntPtr SetWindowLongPtrW_x64(
            IntPtr hWnd,
            int nIndex,
            UIntPtr dwNewLong);

        public static IntPtr SetWindowLongPtrW(IntPtr hWnd, int nIndex, UIntPtr dwNewLong)
        {
            NativeMethods.SetLastError(NativeErrors.ERROR_SUCCESS);

            if (Processor.Architecture == ProcessorArchitecture.X64)
            {
                return SetWindowLongPtrW_x64(hWnd, nIndex, dwNewLong);
            }
            else
            {
                return (IntPtr)SetWindowLongW_x86(hWnd, nIndex, unchecked((uint)dwNewLong.ToUInt32()));
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceCounter(out ulong lpPerformanceCount);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceFrequency(out ulong lpFrequency);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint WaitForSingleObject(
            IntPtr hHandle,
            uint dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint WaitForMultipleObjects(
            uint nCount,
            IntPtr[] lpHandles,
            [MarshalAs(UnmanagedType.Bool)] bool bWaitAll,
            uint dwMilliseconds);

        public static uint WaitForMultipleObjects(IntPtr[] lpHandles, bool bWaitAll, uint dwMilliseconds)
        {
            return WaitForMultipleObjects((uint)lpHandles.Length, lpHandles, bWaitAll, dwMilliseconds);
        }

        [DllImport("gdi32.dll", SetLastError = true)]
        internal unsafe static extern uint GetRegionData(
            IntPtr hRgn,
            uint dwCount,
            NativeStructs.RGNDATA* lpRgnData);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern int SelectClipRgn(
            IntPtr hdc,
            IntPtr hrgn);

        [DllImport("gdi32.dll", SetLastError = false)]
        public unsafe static extern IntPtr CreateRectRgnIndirect(NativeStructs.RECT* lprc);

        [DllImport("gdi32.dll", SetLastError = false)]
        internal unsafe static extern IntPtr CreateRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern int IntersectClipRect(
            IntPtr hdc,
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect);

        [DllImport("user32.dll", SetLastError = true)]
        internal extern static int FillRect(
            IntPtr hDC,
            ref NativeStructs.RECT lprc,
            IntPtr hbr);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal extern static IntPtr CreateSolidBrush(uint crColor);

        [DllImport("gdi32.dll", SetLastError = false)]
        internal extern static IntPtr SelectObject(
            IntPtr hdc,
            IntPtr hgdiobj);

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteObject(IntPtr hObject);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DestroyIcon(IntPtr hIcon);

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteDC(IntPtr hdc);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern int ReleaseDC(
            IntPtr hWnd,
            IntPtr hDC);

        [DllImport("gdi32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BeginPath(IntPtr hdc);

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPath(IntPtr hdc);

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlattenPath(IntPtr hdc);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static unsafe extern int GetPath(
            IntPtr hdc,
            NativeStructs.POINT* lpPoints,
            byte* lpTypes,
            int nSize);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern int GetClipRgn(IntPtr hdc, IntPtr hrgn);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal extern static IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern IntPtr CreateCompatibleBitmap(
            IntPtr hdc,
            int nWidth,
            int nHeight);

        [DllImport("gdi32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OffsetViewportOrgEx(
            IntPtr hdc,
            int nXOffset,
            int nYOffset,
            out NativeStructs.POINT lpPoint);

        [DllImport("msimg32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AlphaBlend(
          IntPtr hdcDest,
          int xoriginDest,
          int yoriginDest,
          int wDest,
          int hDest,
          IntPtr hdcSrc,
          int xoriginSrc,
          int yoriginSrc,
          int wSrc,
          int hSrc,
          NativeStructs.BLENDFUNCTION ftn);

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal extern static bool BitBlt(
            IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            uint dwRop);

        [DllImport("gdi32.dll", SetLastError = false)]
        public extern static unsafe int StretchDIBits(
            IntPtr hdc,
            int XDest,
            int YDest,
            int nDestWidth,
            int nDestHeight,
            int XSrc,
            int YSrc,
            int nSrcWidth,
            int nSrcHeight,
            IntPtr lpBits,
            NativeStructs.BITMAPINFO* lpBitsInfo,
            uint iUsage,
            uint dwRop);

        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static IntPtr LocalFree(IntPtr hMem);

        // https://docs.microsoft.com/en-us/windows/desktop/api/shellapi/nf-shellapi-commandlinetoargvw
        [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern SafeLocalMemoryHandle CommandLineToArgvW(
            [MarshalAs(UnmanagedType.LPWStr)] string lpCmdLine,
            out int pNumArgs);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAlloc(
            IntPtr lpAddress,
            UIntPtr dwSize,
            uint flAllocationType,
            uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualFree(
            IntPtr lpAddress,
            UIntPtr dwSize,
            uint dwFreeType);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualProtect(
            IntPtr lpAddress,
            UIntPtr dwSize,
            uint flNewProtect,
            out uint lpflOldProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualQuery(
            IntPtr lpAddress,
            out NativeStructs.MEMORY_BASIC_INFORMATION lpBuffer,
            IntPtr dwLength);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern IntPtr HeapAlloc(IntPtr hHeap, uint dwFlags, UIntPtr dwBytes);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern UIntPtr HeapSize(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr HeapCreate(
            uint flOptions,
            IntPtr dwInitialSize,
            IntPtr dwMaximumSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapDestroy(IntPtr hHeap);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal unsafe static extern uint HeapSetInformation(
            IntPtr HeapHandle,
            int HeapInformationClass,
            void* HeapInformation,
            uint HeapInformationLength);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetProcessHeap();

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern void GetSystemInfo(out NativeStructs.SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern void GetNativeSystemInfo(out NativeStructs.SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process(
            IntPtr hProcess,
            [MarshalAs(UnmanagedType.Bool)] out bool Wow64Process);

        [DllImport("winhttp.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WinHttpGetIEProxyConfigForCurrentUser(
            ref NativeStructs.WINHTTP_CURRENT_USER_IE_PROXY_CONFIG pProxyConfig);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalAlloc(
            uint uFlags,
            IntPtr dwBytes);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalSize(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnlock(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalFree(IntPtr hMem);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public unsafe static extern bool InvalidateRect(
            IntPtr hWnd,
            NativeStructs.RECT *lpRect,
            [MarshalAs(UnmanagedType.Bool)] bool bErase);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool RedrawWindow(
            IntPtr hWnd,
            NativeStructs.RECT* lprcUpdate,
            IntPtr hrgnUpdate,
            uint flags);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("gdi32.dll", SetLastError = false)]
        public static extern int GetDeviceCaps(
            IntPtr hdc,
            int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoW(
            uint uiAction,
            uint uiParam,
            IntPtr pvParam,
            uint fWinIni);

        [DllImport("uxtheme.dll", SetLastError = false)]
        public static extern IntPtr OpenThemeData(
            IntPtr hwnd,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string pszClassList);

        [DllImport("uxtheme.dll", SetLastError = false, PreserveSig = false)]
        public static extern void CloseThemeData(IntPtr hTheme);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void DrawThemeTextEx(
            IntPtr hTheme,
            IntPtr hdc,
            int iPartId,
            int iStateId,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string pszText,
            int iCharCount,
            uint dwFlags,
            ref NativeStructs.RECT pRect,
            [In] ref NativeStructs.DTTOPTS pOptions);

        [DllImport("uxtheme.dll", SetLastError = false, PreserveSig = false)]
        public static extern void SetWindowThemeAttribute(
            IntPtr hwnd,
            NativeEnums.WINDOWTHEMEATTRIBUTETYPE eAttribute,
            IntPtr pvAttribute,
            int cbAttribute);

        [DllImport("uxtheme.dll", PreserveSig = false, SetLastError = false)]
        public static extern void BufferedPaintInit();

        [DllImport("uxtheme.dll", PreserveSig = false, SetLastError = false)]
        public static extern void BufferedPaintUnInit();

        [DllImport("uxtheme.dll", SetLastError = false)]
        public static unsafe extern IntPtr BeginBufferedAnimation(
            IntPtr hwnd,
            IntPtr hdcTarget,
            ref NativeStructs.RECT rcTarget,
            NativeEnums.BP_BUFFERFORMAT dwFormat,
            [In] NativeStructs.BP_PAINTPARAMS* pPaintParams,
            [In] ref NativeStructs.BP_ANIMATIONPARAMS pAnimationParams,
            out IntPtr phdcFrom,
            out IntPtr phdcTo);

        [DllImport("uxtheme.dll", PreserveSig = false, SetLastError = false)]
        public static extern void EndBufferedAnimation(
            IntPtr hbpAnimation,
            [MarshalAs(UnmanagedType.Bool)] bool fUpdateTarget);

        [DllImport("uxtheme.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BufferedPaintRenderAnimation(
            IntPtr hwnd,
            IntPtr hdcTarget);

        [DllImport("uxtheme.dll", SetLastError = false)]
        public static extern int BufferedPaintStopAllAnimations(IntPtr hwnd);

        [DllImport("uxtheme.dll", SetLastError = true)]
        public static unsafe extern IntPtr BeginBufferedPaint(
            IntPtr hdcTarget,
            [In] ref NativeStructs.RECT prcTarget,
            NativeEnums.BP_BUFFERFORMAT dwFormat,
            [In] NativeStructs.BP_PAINTPARAMS* pPaintParams,
            out IntPtr phdc);

        [DllImport("uxtheme.dll", SetLastError = false, PreserveSig = false)]
        public static unsafe extern void BufferedPaintSetAlpha(
            IntPtr hBufferedPaint,
            NativeStructs.RECT* prc,
            byte alpha);

        [DllImport("uxtheme.dll", SetLastError = false, PreserveSig = false)]
        public static unsafe extern void EndBufferedPaint(
            IntPtr hBufferedPaint,
            [MarshalAs(UnmanagedType.Bool)] bool fUpdateTarget);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, SetLastError = false, PreserveSig = false)]
        public static extern void GetCurrentThemeName(
            StringBuilder pszThemeFileName,
            int dwMaxNameChars,
            StringBuilder pszColorBuff,
            int dwMaxColorChars,
            StringBuilder pszSizeBuff,
            int cchMaxSizeChars);

        [DllImport("uxtheme.dll", SetLastError = false, PreserveSig = false)]
        public extern static void GetThemeTransitionDuration(
            IntPtr hTheme,
            int iPartId,
            int iStateIdFrom,
            int iStateIdTo,
            int iPropId,
            out int duration);

        [DllImport("dwmapi.dll", SetLastError = false, PreserveSig = false)]
        public static extern void DwmExtendFrameIntoClientArea(
            IntPtr hwnd,
            ref NativeStructs.MARGINS pMarInset);

        [DllImport("dwmapi.dll", SetLastError = false, PreserveSig = false)]
        public static extern void DwmIsCompositionEnabled(
            [MarshalAs(UnmanagedType.Bool)] out bool pfEnabled);

        [DllImport("dwmapi.dll", SetLastError = false)]
        public static extern bool DwmDefWindowProc(
            IntPtr hwnd,
            uint msg,
            IntPtr wParam,
            IntPtr lParam,
            out IntPtr plResult);

        [DllImport("kernel32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsProcessorFeaturePresent(uint ProcessorFeature);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        public static extern int RegOpenKeyExW(
            uint hKey,
            string lpSubKey,
            uint ulOptions,
            uint samDesired,
            ref IntPtr phkResult);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        public static extern int RegCloseKey(IntPtr hKey);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        public static extern int RegQueryValueExW(
            IntPtr hKey,
            string lpValueName,
            IntPtr lpReserved,
            ref uint pdwType,
            IntPtr pvData,
            ref uint pcbData);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        public static extern int RegEnumValueW(
            IntPtr hkey,
            uint dwIndex,
            IntPtr lpValueName,
            ref uint lpcchValueName,
            IntPtr lpReserved,
            IntPtr lpType,
            IntPtr lpData,
            ref uint lpcbData);

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr MonitorFromWindow(
            IntPtr hwnd,
            uint flags);

        [DllImport("user32.dll", SetLastError = false, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfoW(
            IntPtr hMonitor,
            ref NativeStructs.MONITORINFOEXW lpmi);

        [DllImport("user32.dll", SetLastError = false, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsW(
            [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName,
            uint iModeNum,
            ref NativeStructs.DEVMODEW lpDevMode);

        [DllImport("shell32.dll", SetLastError = false)]
        public static extern IntPtr SHAppBarMessage(
            uint dwMessage,
            ref NativeStructs.APPBARDATA pData);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = false, PreserveSig = false)]
        public static extern void SHGetStockIconInfo(
            NativeEnums.SHSTOCKICONID siid,
            uint uFlags,
            [In] [Out] ref NativeStructs.SHSTOCKICONINFO psii);

        [DllImport("shell32.dll")]
        internal static extern void SHChangeNotify(
            uint wEventId,
            uint uFlags,
            IntPtr dwItem1,
            IntPtr dwItem2);

        [DllImport("advapi32.dll", SetLastError = false)]
        public static extern uint RegNotifyChangeKeyValue(
            SafeRegistryHandle hKey,
            [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree,
            uint dwNotifyFilter,
            SafeWaitHandle hEvent,
            [MarshalAs(UnmanagedType.Bool)] bool fAsynchronous);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateWaitableTimer(
            IntPtr lpTimerAttributes, // SECURITY_ATTRIBUTES
            [MarshalAs(UnmanagedType.Bool)] bool bManualReset,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWaitableTimer(
            SafeHandle hTimer,
            [In] ref NativeStructs.LARGE_INTEGER pDueTime, // 100ns increments
            uint lPeriod,                                  // milliseconds
            IntPtr pfnCompletionRoutine,
            IntPtr lpArgToCompletionRoutine,
            [MarshalAs(UnmanagedType.Bool)] bool fResume);

        [DllImport("ktmw32.dll", SetLastError = true)]
        public static extern SafeTransactionHandle CreateTransaction(
            IntPtr lpTransactionAttributes,
            IntPtr UOW,
            uint CreateOptions,
            uint IsolationLevel,
            uint IsolationFlags,
            uint Timeout,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string Description);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern SafeFileHandle CreateFileTransacted(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile,
            SafeTransactionHandle hTransaction,
            IntPtr pusMiniVersion,
            IntPtr pExtendedParameter);

        [DllImport("ktmw32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CommitTransaction(SafeTransactionHandle TransactionHandle);

        [DllImport("ktmw32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RollbackTransaction(SafeTransactionHandle TransactionHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static unsafe extern int WaitForMultipleObjectsEx(
            int nCount,
            [In] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IntPtr[] lpHandles,
            [MarshalAs(UnmanagedType.Bool)] bool bWaitAll,
            int dwMilliseconds,
            [MarshalAs(UnmanagedType.Bool)] bool bAlertable);

        [DllImport("user32.dll", SetLastError = true)]
        public static unsafe extern uint MsgWaitForMultipleObjectsEx(
            int nCount,
            IntPtr* pHandles,
            uint dwMilliseconds,
            uint dwWakeMask,
            uint dwFlags);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern int SleepEx(
            int dwMilliseconds,
            [MarshalAs(UnmanagedType.Bool)] bool bAlertable);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        [DllImport("winmm.dll", SetLastError = false)]
        public static extern uint timeBeginPeriod(uint uPeriod);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        [DllImport("winmm.dll", SetLastError = false)]
        public static extern uint timeEndPeriod(uint uPeriod);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        [DllImport("winmm.dll", SetLastError = false)]
        public static extern uint timeGetTime();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        [DllImport("winmm.dll", SetLastError = false)]
        public static extern uint timeGetDevCaps(
            ref NativeStructs.TIMECAPS ptc,
            uint cbtc);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern void InitializeCriticalSection(NativeStructs.CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool InitializeCriticalSectionAndSpinCount(
            NativeStructs.CRITICAL_SECTION *lpCriticalSection,
            uint dwSpinCount);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern void EnterCriticalSection(NativeStructs.CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern void LeaveCriticalSection(NativeStructs.CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern void DeleteCriticalSection(NativeStructs.CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern void InitializeConditionVariable(NativeStructs.CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool SleepConditionVariableCS(
            NativeStructs.CONDITION_VARIABLE *ConditionVariable,
            NativeStructs.CRITICAL_SECTION *CriticalSection,
            uint dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern void WakeConditionVariable(NativeStructs.CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static unsafe extern void WakeAllConditionVariable(NativeStructs.CONDITION_VARIABLE* ConditionVariable);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerDevice(
            IntPtr device, // HANDLE
            out NativeStructs.POINTER_DEVICE_INFO pointerDevice);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerDeviceCursors(
            IntPtr device, // HANDLE
            ref int cursorCount,
            NativeStructs.POINTER_DEVICE_CURSOR_INFO* deviceCursors);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerDeviceProperties(
            IntPtr device, // HANDLE
            ref int propertyCount,
            NativeStructs.POINTER_DEVICE_PROPERTY* pointerProperties);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerDeviceRects(
            IntPtr device, // HANDLE
            out NativeStructs.RECT pointerDeviceRect,
            out NativeStructs.RECT displayRect);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerDevices(
            ref int deviceCount,
            NativeStructs.POINTER_DEVICE_INFO* pointerDevices);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetRawPointerDeviceData(
            uint pointerId,
            int historyCount,
            int propertiesCount,
            NativeStructs.POINTER_DEVICE_PROPERTY* pProperties,
            uint *pValues);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterPointerDeviceNotifications(
            IntPtr window, // HWND
            [MarshalAs(UnmanagedType.Bool)] bool notifyRange);

        public static ushort GET_POINTERID_WPARAM(IntPtr wParam)
        {
            return unchecked((ushort)LOWORD(wParam));
        }

        public static PaintDotNet.Input.RawPointerMessageFlags GET_POINTER_MESSAGE_FLAGS_WPARAM(IntPtr wParam)
        {
            return (PaintDotNet.Input.RawPointerMessageFlags)(uint)HIWORD(wParam);
        }

        public static bool IS_POINTER_FLAG_SET_WPARAM(IntPtr wParam, PaintDotNet.Input.RawPointerMessageFlags flag)
        {
            return ((uint)HIWORD(wParam) & (uint)flag) == (uint)flag;
        }

        public static bool IS_POINTER_NEW_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.New);
        }

        public static bool IS_POINTER_INRANGE_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.InRange);
        }

        public static bool IS_POINTER_INCONTACT_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.InContact);
        }

        public static bool IS_POINTER_FIRSTBUTTON_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.FirstButton);
        }

        public static bool IS_POINTER_SECONDBUTTON_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.SecondButton);
        }

        public static bool IS_POINTER_THIRDBUTTON_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.ThirdButton);
        }

        public static bool IS_POINTER_FOURTHBUTTON_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.FourthButton);
        }

        public static bool IS_POINTER_FIFTHBUTTON_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.FifthButton);
        }

        public static bool IS_POINTER_PRIMARY_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.Primary);
        }

        public static bool HAS_POINTER_CONFIDENCE_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.Confidence);
        }

        public static bool IS_POINTER_CANCELED_WPARAM(IntPtr wParam)
        {
            return IS_POINTER_FLAG_SET_WPARAM(wParam, PaintDotNet.Input.RawPointerMessageFlags.Canceled);
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableMouseInPointer(
            [MarshalAs(UnmanagedType.Bool)] bool fEnable);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsMouseInPointerEnabled();

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SkipPointerFrameMessages(
            uint pointerId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerCursorId(
            uint pointerId,
            out uint cursorId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerFrameInfo(
            uint pointerId,
            ref int pointerCount,
            PaintDotNet.Input.RawPointerInfo* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerFrameInfoHistory(
            uint pointerId,
            ref int entriesCount,
            ref int pointerCount,
            PaintDotNet.Input.RawPointerInfo* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerFramePenInfo(
            uint pointerId,
            ref int pointerCount,
            NativeStructs.POINTER_PEN_INFO* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerFramePenInfoHistory(
            uint pointerId,
            ref int entriesCount,
            ref int pointerCount,
            NativeStructs.POINTER_PEN_INFO* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerFrameTouchInfo(
            uint pointerId,
            ref int pointerCount,
            NativeStructs.POINTER_TOUCH_INFO* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerFrameTouchInfoHistory(
            uint pointerId,
            ref int entriesCount,
            ref int pointerCount,
            NativeStructs.POINTER_TOUCH_INFO* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerInfo(
            uint pointerId,
            out PaintDotNet.Input.RawPointerInfo pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerInfoHistory(
            uint pointerId,
            ref int entriesCount,
            PaintDotNet.Input.RawPointerInfo* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerPenInfo(
            uint pointerId,
            out NativeStructs.POINTER_PEN_INFO pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerPenInfoHistory(
            uint pointerId,
            ref int entriesCount,
            NativeStructs.POINTER_PEN_INFO* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerTouchInfo(
            uint pointerId,
            out NativeStructs.POINTER_TOUCH_INFO pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool GetPointerTouchInfoHistory(
            uint pointerId,
            ref int entriesCount,
            NativeStructs.POINTER_TOUCH_INFO* pointerInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerType(
            uint pointerId,
            out PaintDotNet.Input.PointerInputType pointerType);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetUnpredictedMessagePos();

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool GetWindowFeedbackSetting(
            IntPtr hwnd,
            NativeEnums.FEEDBACK_TYPE feedback,
            uint dwFlags,
            [In] [Out] ref int size,
            void* configuration);

        [DllImport("user32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool SetWindowFeedbackSetting(
            IntPtr hwnd,
            NativeEnums.FEEDBACK_TYPE feedback,
            uint dwFlags,
            int size,
            void* configuration);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GlobalAddAtomW(string lpString);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalDeleteAtom(IntPtr nAtom);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPropW(
            IntPtr hwnd,
            string lpString,
            UIntPtr hData);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool SetGestureConfig(
            IntPtr hwnd,
            uint dwReserved,
            uint cIDs,
            NativeStructs.GESTURECONFIG* pGestureConfig,
            int cbSize);

        public static unsafe bool SetGestureConfig(
            IntPtr hwnd,
            uint dwGestureID,
            uint dwGestureWant,
            uint dwGestureBlock)
        {
            NativeStructs.GESTURECONFIG gestureConfig = new NativeStructs.GESTURECONFIG();
            gestureConfig.dwID = dwGestureID;
            gestureConfig.dwWant = dwGestureWant;
            gestureConfig.dwBlock = dwGestureBlock;
            bool bResult = SetGestureConfig(hwnd, 0, 1, &gestureConfig, sizeof(NativeStructs.GESTURECONFIG));
            return bResult;
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetGestureInfo(
            IntPtr hGestureInfo,
            ref NativeStructs.GESTUREINFO pGestureInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool GetGestureExtraArgs(
            IntPtr hGestureInfo,
            uint cbExtraArgs,
            byte* pExtraArgs);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseGestureInfoHandle(IntPtr hGestureInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool GetLogicalProcessorInformation(
            NativeStructs.SYSTEM_LOGICAL_PROCESSOR_INFORMATION* Buffer,
            ref int ReturnLength);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern int GetCurrentPackageFullName(
            ref int packageFullNameLength,
            IntPtr packageFullName);

        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern int GetCurrentPackageFamilyName(
            ref int packageFamilyNameLength,
            IntPtr packageFamilyName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemPowerStatus(
            out NativeStructs.SYSTEM_POWER_STATUS lpSystemPowerStatus);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern SafePowerSettingNotificationHandle RegisterPowerSettingNotification(
            IntPtr hRecipient,
            in Guid PowerSettingGuid,
            uint Flags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterPowerSettingNotification(IntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();
    }
}
