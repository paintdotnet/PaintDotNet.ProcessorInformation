/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace PaintDotNet.SystemLayer
{
    internal static class NativeConstants
    {
        public const int MAX_PATH = 260;

        public const int NO_ERROR = 0;

        public const uint GDI_ERROR = 0xffffffff;

        public const CallingConvention CALLBACK = CallingConvention.StdCall;

        public static uint GA_PARENT = 1;
        public static uint GA_ROOT = 2;
        public static uint GA_ROOTOWNER = 3;

        public const uint GW_HWNDFIRST = 0;
        public const uint GW_HWNDLAST = 1;
        public const uint GW_HWNDNEXT = 2;
        public const uint GW_HWNDPREV = 3;
        public const uint GW_OWNER = 4;
        public const uint GW_CHILD = 5;
        public const uint GW_ENABLEDPOPUP = 6;

        public const int WMSZ_LEFT = 1;
        public const int WMSZ_RIGHT = 2;
        public const int WMSZ_TOP = 3;
        public const int WMSZ_TOPLEFT = 4;
        public const int WMSZ_TOPRIGHT = 5;
        public const int WMSZ_BOTTOM = 6;
        public const int WMSZ_BOTTOMLEFT = 7;
        public const int WMSZ_BOTTOMRIGHT = 8;

        public const uint SWP_DRAWFRAME = 0x20;
        public const uint SWP_FRAMECHANGED = 0x20;
        public const uint SWP_HIDEWINDOW = 0x80;
        public const uint SWP_NOACTIVATE = 0x10;
        public const uint SWP_NOCOPYBITS = 0x100;
        public const uint SWP_NOMOVE = 0x2;
        public const uint SWP_NOOWNERZORDER = 0x200;
        public const uint SWP_NOREDRAW = 0x8;
        public const uint SWP_NOREPOSITION = 0x200;
        public const uint SWP_NOSENDCHANGING = 0x400;
        public const uint SWP_NOSIZE = 0x1;
        public const uint SWP_NOZORDER = 0x4;
        public const uint SWP_SHOWWINDOW = 0x40;

        public const int SM_CXSCREEN = 0;
        public const int SM_CYSCREEN = 1;
        public const int SM_CXVSCROLL = 2;
        public const int SM_CYHSCROLL = 3;
        public const int SM_CYCAPTION = 4;
        public const int SM_CXBORDER = 5;
        public const int SM_CYBORDER = 6;
        public const int SM_CXDLGFRAME = 7;
        public const int SM_CYDLGFRAME = 8;
        public const int SM_CYVTHUMB = 9;
        public const int SM_CXHTHUMB = 10;
        public const int SM_CXICON = 11;
        public const int SM_CYICON = 12;
        public const int SM_CXCURSOR = 13;
        public const int SM_CYCURSOR = 14;
        public const int SM_CYMENU = 15;
        public const int SM_CXFULLSCREEN = 16;
        public const int SM_CYFULLSCREEN = 17;
        public const int SM_CYKANJIWINDOW = 18;
        public const int SM_MOUSEPRESENT = 19;
        public const int SM_CYVSCROLL = 20;
        public const int SM_CXHSCROLL = 21;
        public const int SM_DEBUG = 22;
        public const int SM_SWAPBUTTON = 23;
        public const int SM_RESERVED1 = 24;
        public const int SM_RESERVED2 = 25;
        public const int SM_RESERVED3 = 26;
        public const int SM_RESERVED4 = 27;
        public const int SM_CXMIN = 28;
        public const int SM_CYMIN = 29;
        public const int SM_CXSIZE = 30;
        public const int SM_CYSIZE = 31;
        public const int SM_CXFRAME = 32;
        public const int SM_CYFRAME = 33;
        public const int SM_CXMINTRACK = 34;
        public const int SM_CYMINTRACK = 35;
        public const int SM_CXDOUBLECLK = 36;
        public const int SM_CYDOUBLECLK = 37;
        public const int SM_CXICONSPACING = 38;
        public const int SM_CYICONSPACING = 39;
        public const int SM_MENUDROPALIGNMENT = 40;
        public const int SM_PENWINDOWS = 41;
        public const int SM_DBCSENABLED = 42;
        public const int SM_CMOUSEBUTTONS = 43;
        public const int SM_CXFIXEDFRAME = SM_CXDLGFRAME; /* ;win40 name change */
        public const int SM_CYFIXEDFRAME = SM_CYDLGFRAME; /* ;win40 name change */
        public const int SM_CXSIZEFRAME = SM_CXFRAME; /* ;win40 name change */
        public const int SM_CYSIZEFRAME = SM_CYFRAME; /* ;win40 name change */
        public const int SM_SECURE = 44;
        public const int SM_CXEDGE = 45;
        public const int SM_CYEDGE = 46;
        public const int SM_CXMINSPACING = 47;
        public const int SM_CYMINSPACING = 48;
        public const int SM_CXSMICON = 49;
        public const int SM_CYSMICON = 50;
        public const int SM_CYSMCAPTION = 51;
        public const int SM_CXSMSIZE = 52;
        public const int SM_CYSMSIZE = 53;
        public const int SM_CXMENUSIZE = 54;
        public const int SM_CYMENUSIZE = 55;
        public const int SM_ARRANGE = 56;
        public const int SM_CXMINIMIZED = 57;
        public const int SM_CYMINIMIZED = 58;
        public const int SM_CXMAXTRACK = 59;
        public const int SM_CYMAXTRACK = 60;
        public const int SM_CXMAXIMIZED = 61;
        public const int SM_CYMAXIMIZED = 62;
        public const int SM_NETWORK = 63;
        public const int SM_CLEANBOOT = 67;
        public const int SM_CXDRAG = 68;
        public const int SM_CYDRAG = 69;
        public const int SM_SHOWSOUNDS = 70;
        public const int SM_CXMENUCHECK = 71; /* Use instead of GetMenuCheckMarkDimensions()! */
        public const int SM_CYMENUCHECK = 72;
        public const int SM_SLOWMACHINE = 73;
        public const int SM_MIDEASTENABLED = 74;
        public const int SM_MOUSEWHEELPRESENT = 75;
        public const int SM_XVIRTUALSCREEN = 76;
        public const int SM_YVIRTUALSCREEN = 77;
        public const int SM_CXVIRTUALSCREEN = 78;
        public const int SM_CYVIRTUALSCREEN = 79;
        public const int SM_CMONITORS = 80;
        public const int SM_SAMEDISPLAYFORMAT = 81;
        public const int SM_IMMENABLED = 82;
        public const int SM_CXFOCUSBORDER = 83;
        public const int SM_CYFOCUSBORDER = 84;
        public const int SM_TABLETPC = 86;
        public const int SM_MEDIACENTER = 87;
        public const int SM_STARTER = 88;
        public const int SM_SERVERR2 = 89;
        public const int SM_MOUSEHORIZONTALWHEELPRESENT = 91;
        public const int SM_CXPADDEDBORDER = 92;
        public const int SM_DIGITIZER = 94;
        public const int SM_MAXIMUMTOUCHES = 95;
        public const int SM_REMOTESESSION = 0x1000;
        public const int SM_SHUTTINGDOWN = 0x2000;
        public const int SM_REMOTECONTROL = 0x2001;
        public const int SM_CARETBLINKINGENABLED = 0x2002;
        
        public const int ERROR = 0;
        public const int NULLREGION = 1;
        public const int SIMPLEREGION = 2;
        public const int COMPLEXREGION = 3;

        public const uint LIST_MODULES_32BIT = 0x1;
        public const uint LIST_MODULES_64BIT = 0x2;
        public const uint LIST_MODULES_ALL = 0x3;
        public const uint LIST_MODULES_DEFAULT = 0x0;

        public static readonly IntPtr IDC_ARROW = NativeMethods.MAKEINTRESOURCEW(32512);
        public static readonly IntPtr IDC_WAIT = NativeMethods.MAKEINTRESOURCEW(32514);

        public static readonly IntPtr TD_WARNING_ICON = NativeMethods.MAKEINTRESOURCEW(-1);
        public static readonly IntPtr TD_ERROR_ICON = NativeMethods.MAKEINTRESOURCEW(-2);
        public static readonly IntPtr TD_INFORMATION_ICON = NativeMethods.MAKEINTRESOURCEW(-3);

        public const uint TDCBF_OK_BUTTON = 0x0001;     // selected control return value IDOK
        public const uint TDCBF_YES_BUTTON = 0x0002;    // selected control return value IDYES
        public const uint TDCBF_NO_BUTTON = 0x0004;     // selected control return value IDNO
        public const uint TDCBF_CANCEL_BUTTON = 0x0008; // selected control return value IDCANCEL
        public const uint TDCBF_RETRY_BUTTON = 0x0010;  // selected control return value IDRETRY
        public const uint TDCBF_CLOSE_BUTTON = 0x0020;  // selected control return value IDCLOSE

        public const uint PM_NOREMOVE = 0;
        public const uint PM_REMOVE = 1;
        public const uint PM_NOYIELD = 2;
        public const uint PM_QS_INPUT = (QS_INPUT << 16);
        public const uint PM_QS_POSTMESSAGE = ((QS_POSTMESSAGE | QS_HOTKEY | QS_TIMER) << 16);
        public const uint PM_QS_PAINT = (QS_PAINT << 16);
        public const uint PM_QS_SENDMESSAGE = (QS_SENDMESSAGE << 16);

        public const int IDOK = 1;
        public const int IDCANCEL = 2;
        public const int IDABORT = 3;
        public const int IDRETRY = 4;
        public const int IDIGNORE = 5;
        public const int IDYES = 6;
        public const int IDNO = 7;

        public const int CSIDL_DESKTOP_DIRECTORY = 0x0010;        // C:\Users\[user]\Desktop\
        public const int CSIDL_MYPICTURES = 0x0027;
        public const int CSIDL_PERSONAL = 0x0005;
        public const int CSIDL_FONTS = 0x14;
        public const int CSIDL_PROGRAM_FILES = 0x0026;            // C:\Program Files\
        public const int CSIDL_APPDATA = 0x001a;                  // C:\Users\[user]\AppData\Roaming\
        public const int CSIDL_LOCAL_APPDATA = 0x001c;            // C:\Users\[user]\AppData\Local\
        public const int CSIDL_COMMON_DESKTOPDIRECTORY = 0x0019;  // C:\Users\All Users\Desktop

        public const int CSIDL_FLAG_CREATE = 0x8000;    // new for Win2K, or this in to force creation of folder

        public const uint SHGFP_TYPE_CURRENT = 0;
        public const uint SHGFP_TYPE_DEFAULT = 1;

        public const uint EWX_LOGOFF = 0x00;
        public const uint EWX_SHUTDOWN = 0x01;
        public const uint EWX_REBOOT = 0x02;
        public const uint EWX_FORCE = 0x04;
        public const uint EWX_POWEROFF = 0x08;
        public const uint EWX_FORCEIFHUNG = 0x10;
        public const uint EWX_QUICKRESOLVE = 0x20;
        public const uint EWX_RESTARTAPPS = 0x40;

        public const uint SHTDN_REASON_FLAG_COMMENT_REQUIRED = 0x01000000;
        public const uint SHTDN_REASON_FLAG_DIRTY_PROBLEM_ID_REQUIRED = 0x02000000;
        public const uint SHTDN_REASON_FLAG_CLEAN_UI = 0x04000000;
        public const uint SHTDN_REASON_FLAG_DIRTY_UI = 0x08000000;
        public const uint SHTDN_REASON_FLAG_USER_DEFINED = 0x40000000;
        public const uint SHTDN_REASON_FLAG_PLANNED = 0x80000000;

        public const uint SHTDN_REASON_MAJOR_OTHER = 0x00000000;
        public const uint SHTDN_REASON_MAJOR_NONE = 0x00000000;
        public const uint SHTDN_REASON_MAJOR_HARDWARE = 0x00010000;
        public const uint SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 0x00020000;
        public const uint SHTDN_REASON_MAJOR_SOFTWARE = 0x00030000;
        public const uint SHTDN_REASON_MAJOR_APPLICATION = 0x00040000;
        public const uint SHTDN_REASON_MAJOR_SYSTEM = 0x00050000;
        public const uint SHTDN_REASON_MAJOR_POWER = 0x00060000;
        public const uint SHTDN_REASON_MAJOR_LEGACY_API = 0x00070000;

        public const uint SHTDN_REASON_MINOR_OTHER = 0x00000000;
        public const uint SHTDN_REASON_MINOR_NONE = 0x000000ff;
        public const uint SHTDN_REASON_MINOR_MAINTENANCE = 0x00000001;
        public const uint SHTDN_REASON_MINOR_INSTALLATION = 0x00000002;
        public const uint SHTDN_REASON_MINOR_UPGRADE = 0x00000003;
        public const uint SHTDN_REASON_MINOR_RECONFIG = 0x00000004;
        public const uint SHTDN_REASON_MINOR_HUNG = 0x00000005;
        public const uint SHTDN_REASON_MINOR_UNSTABLE = 0x00000006;
        public const uint SHTDN_REASON_MINOR_DISK = 0x00000007;
        public const uint SHTDN_REASON_MINOR_PROCESSOR = 0x00000008;
        public const uint SHTDN_REASON_MINOR_NETWORKCARD = 0x00000009;
        public const uint SHTDN_REASON_MINOR_POWER_SUPPLY = 0x0000000a;
        public const uint SHTDN_REASON_MINOR_CORDUNPLUGGED = 0x0000000b;
        public const uint SHTDN_REASON_MINOR_ENVIRONMENT = 0x0000000c;
        public const uint SHTDN_REASON_MINOR_HARDWARE_DRIVER = 0x0000000d;
        public const uint SHTDN_REASON_MINOR_OTHERDRIVER = 0x0000000e;
        public const uint SHTDN_REASON_MINOR_BLUESCREEN = 0x0000000F;
        public const uint SHTDN_REASON_MINOR_SERVICEPACK = 0x00000010;
        public const uint SHTDN_REASON_MINOR_HOTFIX = 0x00000011;
        public const uint SHTDN_REASON_MINOR_SECURITYFIX = 0x00000012;
        public const uint SHTDN_REASON_MINOR_SECURITY = 0x00000013;
        public const uint SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY = 0x00000014;
        public const uint SHTDN_REASON_MINOR_WMI = 0x00000015;
        public const uint SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL = 0x00000016;
        public const uint SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 0x00000017;
        public const uint SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 0x00000018;
        public const uint SHTDN_REASON_MINOR_MMC = 0x00000019;
        public const uint SHTDN_REASON_MINOR_SYSTEMRESTORE = 0x0000001a;
        public const uint SHTDN_REASON_MINOR_TERMSRV = 0x00000020;
        public const uint SHTDN_REASON_MINOR_DC_PROMOTION = 0x00000021;
        public const uint SHTDN_REASON_MINOR_DC_DEMOTION = 0x00000022;
        public const uint SHTDN_REASON_UNKNOWN = SHTDN_REASON_MINOR_NONE;
        public const uint SHTDN_REASON_LEGACY_API = (SHTDN_REASON_MAJOR_LEGACY_API | SHTDN_REASON_FLAG_PLANNED);
        public const uint SHTDN_REASON_VALID_BIT_MASK = 0xc0ffffff;

        public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";
        public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";
        public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";
        public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";
        public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";
        public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";
        public const string SE_TCB_NAME = "SeTcbPrivilege";
        public const string SE_SECURITY_NAME = "SeSecurityPrivilege";
        public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";
        public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";
        public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";
        public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";
        public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";
        public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";
        public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";
        public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";
        public const string SE_BACKUP_NAME = "SeBackupPrivilege";
        public const string SE_RESTORE_NAME = "SeRestorePrivilege";
        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        public const string SE_DEBUG_NAME = "SeDebugPrivilege";
        public const string SE_AUDIT_NAME = "SeAuditPrivilege";
        public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";
        public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";
        public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";
        public const string SE_UNDOCK_NAME = "SeUndockPrivilege";
        public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";
        public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";
        public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";
        public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";
        public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";
        public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";
        public const string SE_RELABEL_NAME = "SeRelabelPrivilege";
        public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";
        public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";
        public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

        public const uint SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1;
        public const uint SE_PRIVILEGE_ENABLED = 2;
        public const uint SE_PRIVILEGE_REMOVED = 4;
        public const uint SE_PRIVILEGE_USED_FOR_ACCESS = 0x80000000;
        public const uint SE_PRIVILEGE_VALID_ATTRIBUTES = (SE_PRIVILEGE_ENABLED_BY_DEFAULT | SE_PRIVILEGE_ENABLED | SE_PRIVILEGE_REMOVED | SE_PRIVILEGE_USED_FOR_ACCESS);

        public enum SECURITY_IMPERSONATION_LEVEL
        {
            SecurityAnonymous = 0,
            SecurityIdentification = 1,
            SecurityImpersonation = 2,
            SecurityDelegation = 3
        }

        public enum TOKEN_TYPE
        {
            TokenPrimary = 1,
            TokenImpersonation = 2
        }

        public const uint TOKEN_ASSIGN_PRIMARY = 0x0001;
        public const uint TOKEN_DUPLICATE = 0x0002;
        public const uint TOKEN_IMPERSONATE = 0x0004;
        public const uint TOKEN_QUERY = 0x0008;
        public const uint TOKEN_QUERY_SOURCE = 0x0010;
        public const uint TOKEN_ADJUST_PRIVILEGES = 0x0020;
        public const uint TOKEN_ADJUST_GROUPS = 0x0040;
        public const uint TOKEN_ADJUST_DEFAULT = 0x0080;
        public const uint TOKEN_ADJUST_SESSIONID = 0x0100;

        public const uint TOKEN_ALL_ACCESS_P =
            STANDARD_RIGHTS_REQUIRED |
            TOKEN_ASSIGN_PRIMARY |
            TOKEN_DUPLICATE |
            TOKEN_IMPERSONATE |
            TOKEN_QUERY |
            TOKEN_QUERY_SOURCE |
            TOKEN_ADJUST_PRIVILEGES |
            TOKEN_ADJUST_GROUPS |
            TOKEN_ADJUST_DEFAULT;

        public const uint TOKEN_ALL_ACCESS = TOKEN_ALL_ACCESS_P | TOKEN_ADJUST_SESSIONID;
        public const uint TOKEN_READ = STANDARD_RIGHTS_READ | TOKEN_QUERY;
        public const uint TOKEN_WRITE = STANDARD_RIGHTS_WRITE | TOKEN_ADJUST_PRIVILEGES | TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_DEFAULT;
        public const uint TOKEN_EXECUTE = STANDARD_RIGHTS_EXECUTE;

        public const uint DUPLICATE_CLOSE_SOURCE = 0x1;
        public const uint DUPLICATE_SAME_ACCESS = 0x2;

        public const uint MAXIMUM_ALLOWED = 0x02000000;

        public const uint PROCESS_TERMINATE = 0x0001;
        public const uint PROCESS_CREATE_THREAD = 0x0002;
        public const uint PROCESS_SET_SESSIONID = 0x0004;
        public const uint PROCESS_VM_OPERATION = 0x0008;
        public const uint PROCESS_VM_READ = 0x0010;
        public const uint PROCESS_VM_WRITE = 0x0020;
        public const uint PROCESS_DUP_HANDLE = 0x0040;
        public const uint PROCESS_CREATE_PROCESS = 0x0080;
        public const uint PROCESS_SET_QUOTA = 0x0100;
        public const uint PROCESS_SET_INFORMATION = 0x0200;
        public const uint PROCESS_QUERY_INFORMATION = 0x0400;
        public const uint PROCESS_SUSPEND_RESUME = 0x0800;
        public const uint PROCESS_QUERY_LIMITED_INFORMATION = 0x1000;
        public const uint PROCESS_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFFF;

        public const uint THREAD_TERMINATE = 0x0001;
        public const uint THREAD_SUSPEND_RESUME = 0x0002;
        public const uint THREAD_GET_CONTEXT = 0x0008;
        public const uint THREAD_SET_CONTEXT = 0x0010;
        public const uint THREAD_QUERY_INFORMATION = 0x0040;
        public const uint THREAD_SET_INFORMATION = 0x0020;
        public const uint THREAD_SET_THREAD_TOKEN = 0x0080;
        public const uint THREAD_IMPERSONATE = 0x0100;
        public const uint THREAD_DIRECT_IMPERSONATION = 0x0200;
        public const uint THREAD_SET_LIMITED_INFORMATION = 0x0400;
        public const uint THREAD_QUERY_LIMITED_INFORMATION = 0x0800;
        public const uint THREAD_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xffff);

        public const uint PF_NX_ENABLED = 12;
        public const uint PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;
        public const uint PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;
        public const uint PF_SSE3_INSTRUCTIONS_AVAILABLE = 13;
        public const uint PF_XSAVE_ENABLED = 17;

        public const string IID_IOleWindow = "00000114-0000-0000-C000-000000000046";
        public const string IID_IModalWindow = "b4db1657-70d7-485e-8e3e-6fcb5a5c1802";
        public const string IID_IFileDialog = "42f85136-db7e-439c-85f1-e4075d135fc8";
        public const string IID_IFileOpenDialog = "d57c7288-d4ad-4768-be02-9d969532d960";
        public const string IID_IFileSaveDialog = "84bccd23-5fde-4cdb-aea4-af64b83d78ab";
        public const string IID_IFileDialogEvents = "973510DB-7D7F-452B-8975-74A85828D354";
        public const string IID_IFileDialogControlEvents = "36116642-D713-4b97-9B83-7484A9D00433";
        public const string IID_IFileDialogCustomize = "8016b7b3-3d49-4504-a0aa-2a37494e606f";
        public const string IID_IShellItem = "43826D1E-E718-42EE-BC55-A1E261C37BFE";
        public const string IID_IShellItemArray = "B63EA76D-1F85-456F-A19C-48159EFA858B";
        public const string IID_IKnownFolder = "38521333-6A87-46A7-AE10-0F16706816C3";
        public const string IID_IKnownFolderManager = "44BEAAEC-24F4-4E90-B3F0-23D258FBB146";
        public const string IID_IPropertyStore = "886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99";

        public const string IID_ISequentialStream = "0c733a30-2a1c-11ce-ade5-00aa0044773d";
        public const string IID_IStream = "0000000C-0000-0000-C000-000000000046";

        public const string IID_IFileOperation = "947aab5f-0a5c-4c13-b4d6-4bf7836fc9f8";
        public const string IID_IFileOperationProgressSink = "04b0f1a7-9490-44bc-96e1-4296a31252e2";

        public const string CLSID_FileOpenDialog = "DC1C5A9C-E88A-4dde-A5A1-60F82A20AEF7";
        public const string CLSID_FileSaveDialog = "C0B4E2F3-BA21-4773-8DBA-335EC946EB8B";
        public const string CLSID_KnownFolderManager = "4df0c730-df9d-4ae3-9153-aa6b82e9795a";
        public const string CLSID_FileOperation = "3ad05575-8857-4850-9277-11b85bdb8e09";

        public enum FOF
            : uint
        {
            FOF_MULTIDESTFILES = 0x0001,
            FOF_CONFIRMMOUSE = 0x0002,
            FOF_SILENT = 0x0004,                // don't display progress UI (confirm prompts may be displayed still)
            FOF_RENAMEONCOLLISION = 0x0008,     // automatically rename the source files to avoid the collisions
            FOF_NOCONFIRMATION = 0x0010,        // don't display confirmation UI, assume "yes" for cases that can be bypassed, "no" for those that can not
            FOF_WANTMAPPINGHANDLE = 0x0020,     // Fill in SHFILEOPSTRUCT.hNameMappings
            // Must be freed using SHFreeNameMappings
            FOF_ALLOWUNDO = 0x0040,             // enable undo including Recycle behavior for IFileOperation::Delete()
            FOF_FILESONLY = 0x0080,             // only operate on the files (non folders), both files and folders are assumed without this
            FOF_SIMPLEPROGRESS = 0x0100,        // means don't show names of files
            FOF_NOCONFIRMMKDIR = 0x0200,        // don't dispplay confirmatino UI before making any needed directories, assume "Yes" in these cases
            FOF_NOERRORUI = 0x0400,             // don't put up error UI, other UI may be displayed, progress, confirmations
            FOF_NOCOPYSECURITYATTRIBS = 0x0800, // dont copy file security attributes (ACLs)
            FOF_NORECURSION = 0x1000,           // don't recurse into directories for operations that would recurse
            FOF_NO_CONNECTED_ELEMENTS = 0x2000, // don't operate on connected elements ("xxx_files" folders that go with .htm files)
            FOF_WANTNUKEWARNING = 0x4000,       // during delete operation, warn if nuking instead of recycling (partially overrides FOF_NOCONFIRMATION)
            FOF_NORECURSEREPARSE = 0x8000,      // deprecated; the operations engine always does the right thing on FolderLink objects (symlinks, reparse points, folder shortcuts)

            FOF_NO_UI = (FOF_SILENT | FOF_NOCONFIRMATION | FOF_NOERRORUI | FOF_NOCONFIRMMKDIR), // don't display any UI at all

            FOFX_NOSKIPJUNCTIONS = 0x00010000,        // Don't avoid binding to junctions (like Task folder, Recycle-Bin)
            FOFX_PREFERHARDLINK = 0x00020000,         // Create hard link if possible
            FOFX_SHOWELEVATIONPROMPT = 0x00040000,    // Show elevation prompts when error UI is disabled (use with FOF_NOERRORUI)
            FOFX_EARLYFAILURE = 0x00100000,           // Fail operation as soon as a single error occurs rather than trying to process other items (applies only when using FOF_NOERRORUI)
            FOFX_PRESERVEFILEEXTENSIONS = 0x00200000, // Rename collisions preserve file extns (use with FOF_RENAMEONCOLLISION)
            FOFX_KEEPNEWERFILE = 0x00400000,          // Keep newer file on naming conflicts
            FOFX_NOCOPYHOOKS = 0x00800000,            // Don't use copy hooks
            FOFX_NOMINIMIZEBOX = 0x01000000,          // Don't allow minimizing the progress dialog
            FOFX_MOVEACLSACROSSVOLUMES = 0x02000000,  // Copy security information when performing a cross-volume move operation
            FOFX_DONTDISPLAYSOURCEPATH = 0x04000000,  // Don't display the path of source file in progress dialog
            FOFX_DONTDISPLAYDESTPATH = 0x08000000,    // Don't display the path of destination file in progress dialog
        }

        public enum STREAM_SEEK
            : uint
        {
            STREAM_SEEK_SET = 0,
            STREAM_SEEK_CUR = 1,
            STREAM_SEEK_END = 2
        }

        public enum STATFLAG
            : uint
        {
            STATFLAG_DEFAULT = 0,
            STATFLAG_NONAME = 1,
            STATFLAG_NOOPEN = 2
        }

        public enum STGTY
            : uint
        {
            STGTY_STORAGE = 1,
            STGTY_STREAM = 2,
            STGTY_LOCKBYTES = 3,
            STGTY_PROPERTY = 4
        }

        [Flags]
        public enum STGC
            : uint
        {
            STGC_DEFAULT = 0,
            STGC_OVERWRITE = 1,
            STGC_ONLYIFCURRENT = 2,
            STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,
            STGC_CONSOLIDATE = 8
        }

        public enum CDCONTROLSTATE
        {
            CDCS_INACTIVE = 0x00000000,
            CDCS_ENABLED = 0x00000001,
            CDCS_VISIBLE = 0x00000002
        }

        public enum FFFP_MODE
        {
            FFFP_EXACTMATCH,
            FFFP_NEARESTPARENTMATCH
        }

        public enum SIATTRIBFLAGS
        {
            SIATTRIBFLAGS_AND = 0x00000001, // if multiple items and the attirbutes together.
            SIATTRIBFLAGS_OR = 0x00000002, // if multiple items or the attributes together.
            SIATTRIBFLAGS_APPCOMPAT = 0x00000003, // Call GetAttributes directly on the ShellFolder for multiple attributes
        }

        public enum SIGDN : uint
        {
            SIGDN_NORMALDISPLAY = 0x00000000,                 // SHGDN_NORMAL
            SIGDN_PARENTRELATIVEPARSING = 0x80018001,         // SHGDN_INFOLDER | SHGDN_FORPARSING
            SIGDN_DESKTOPABSOLUTEPARSING = 0x80028000,        // SHGDN_FORPARSING
            SIGDN_PARENTRELATIVEEDITING = 0x80031001,         // SHGDN_INFOLDER | SHGDN_FOREDITING
            SIGDN_DESKTOPABSOLUTEEDITING = 0x8004c000,        // SHGDN_FORPARSING | SHGDN_FORADDRESSBAR
            SIGDN_FILESYSPATH = 0x80058000,                   // SHGDN_FORPARSING
            SIGDN_URL = 0x80068000,                           // SHGDN_FORPARSING
            SIGDN_PARENTRELATIVEFORADDRESSBAR = 0x8007c001,   // SHGDN_INFOLDER | SHGDN_FORPARSING | SHGDN_FORADDRESSBAR
            SIGDN_PARENTRELATIVE = 0x80080001                 // SHGDN_INFOLDER
        }

        public const uint DROPEFFECT_COPY = 1;
        public const uint DROPEFFECT_MOVE = 2;
        public const uint DROPEFFECT_LINK = 4;

        [Flags]
        public enum SFGAO : uint
        {
            SFGAO_CANCOPY = DROPEFFECT_COPY,        // Objects can be copied (0x1)
            SFGAO_CANMOVE = DROPEFFECT_MOVE,        // Objects can be moved (0x2)
            SFGAO_CANLINK = DROPEFFECT_LINK,        // Objects can be linked (0x4)
            SFGAO_STORAGE = 0x00000008,             // supports BindToObject(IID_IStorage)
            SFGAO_CANRENAME = 0x00000010,           // Objects can be renamed
            SFGAO_CANDELETE = 0x00000020,           // Objects can be deleted
            SFGAO_HASPROPSHEET = 0x00000040,        // Objects have property sheets
            SFGAO_DROPTARGET = 0x00000100,          // Objects are drop target
            SFGAO_CAPABILITYMASK = 0x00000177,
            SFGAO_ENCRYPTED = 0x00002000,           // Object is encrypted (use alt color)
            SFGAO_ISSLOW = 0x00004000,              // 'Slow' object
            SFGAO_GHOSTED = 0x00008000,             // Ghosted icon
            SFGAO_LINK = 0x00010000,                // Shortcut (link)
            SFGAO_SHARE = 0x00020000,               // Shared
            SFGAO_READONLY = 0x00040000,            // Read-only
            SFGAO_HIDDEN = 0x00080000,              // Hidden object
            SFGAO_DISPLAYATTRMASK = 0x000FC000,
            SFGAO_FILESYSANCESTOR = 0x10000000,     // May contain children with SFGAO_FILESYSTEM
            SFGAO_FOLDER = 0x20000000,              // Support BindToObject(IID_IShellFolder)
            SFGAO_FILESYSTEM = 0x40000000,          // Is a win32 file system object (file/folder/root)
            SFGAO_HASSUBFOLDER = 0x80000000,        // May contain children with SFGAO_FOLDER (may be slow)
            SFGAO_CONTENTSMASK = 0x80000000,
            SFGAO_VALIDATE = 0x01000000,            // Invalidate cached information (may be slow)
            SFGAO_REMOVABLE = 0x02000000,           // Is this removeable media?
            SFGAO_COMPRESSED = 0x04000000,          // Object is compressed (use alt color)
            SFGAO_BROWSABLE = 0x08000000,           // Supports IShellFolder, but only implements CreateViewObject() (non-folder view)
            SFGAO_NONENUMERATED = 0x00100000,       // Is a non-enumerated object (should be hidden)
            SFGAO_NEWCONTENT = 0x00200000,          // Should show bold in explorer tree
            SFGAO_STREAM = 0x00400000,              // Supports BindToObject(IID_IStream)
            SFGAO_CANMONIKER = 0x00400000,          // Obsolete
            SFGAO_HASSTORAGE = 0x00400000,          // Obsolete
            SFGAO_STORAGEANCESTOR = 0x00800000,     // May contain children with SFGAO_STORAGE or SFGAO_STREAM
            SFGAO_STORAGECAPMASK = 0x70C50008,      // For determining storage capabilities, ie for open/save semantics
            SFGAO_PKEYSFGAOMASK = 0x81044010        // Attributes that are masked out for PKEY_SFGAOFlags because they are considered to cause slow calculations or lack context (SFGAO_VALIDATE | SFGAO_ISSLOW | SFGAO_HASSUBFOLDER and others)
        }

        public enum FDE_OVERWRITE_RESPONSE
        {
            FDEOR_DEFAULT = 0x00000000,
            FDEOR_ACCEPT = 0x00000001,
            FDEOR_REFUSE = 0x00000002
        }

        public enum FDE_SHAREVIOLATION_RESPONSE
        {
            FDESVR_DEFAULT = 0x00000000,
            FDESVR_ACCEPT = 0x00000001,
            FDESVR_REFUSE = 0x00000002
        }

        public enum FDAP
        {
            FDAP_BOTTOM = 0x00000000,
            FDAP_TOP = 0x00000001,
        }

        [Flags]
        public enum FOS : uint
        {
            FOS_OVERWRITEPROMPT = 0x00000002,
            FOS_STRICTFILETYPES = 0x00000004,
            FOS_NOCHANGEDIR = 0x00000008,
            FOS_PICKFOLDERS = 0x00000020,
            FOS_FORCEFILESYSTEM = 0x00000040, // Ensure that items returned are filesystem items.
            FOS_ALLNONSTORAGEITEMS = 0x00000080, // Allow choosing items that have no storage.
            FOS_NOVALIDATE = 0x00000100,
            FOS_ALLOWMULTISELECT = 0x00000200,
            FOS_PATHMUSTEXIST = 0x00000800,
            FOS_FILEMUSTEXIST = 0x00001000,
            FOS_CREATEPROMPT = 0x00002000,
            FOS_SHAREAWARE = 0x00004000,
            FOS_NOREADONLYRETURN = 0x00008000,
            FOS_NOTESTFILECREATE = 0x00010000,
            FOS_HIDEMRUPLACES = 0x00020000,
            FOS_HIDEPINNEDPLACES = 0x00040000,
            FOS_NODEREFERENCELINKS = 0x00100000,
            FOS_DONTADDTORECENT = 0x02000000,
            FOS_FORCESHOWHIDDEN = 0x10000000,
            FOS_DEFAULTNOMINIMODE = 0x20000000
        }

        public enum KF_CATEGORY
        {
            KF_CATEGORY_VIRTUAL = 0x00000001,
            KF_CATEGORY_FIXED = 0x00000002,
            KF_CATEGORY_COMMON = 0x00000003,
            KF_CATEGORY_PERUSER = 0x00000004
        }

        [Flags]
        public enum KF_DEFINITION_FLAGS
        {
            KFDF_PERSONALIZE = 0x00000001,
            KFDF_LOCAL_REDIRECT_ONLY = 0x00000002,
            KFDF_ROAMABLE = 0x00000004,
        }

        public const uint DWMWA_NCRENDERING_ENABLED = 1;           // [get] Is non-client rendering enabled/disabled
        public const uint DWMWA_NCRENDERING_POLICY = 2;            // [set] Non-client rendering policy
        public const uint DWMWA_TRANSITIONS_FORCEDISABLED = 3;     // [set] Potentially enable/forcibly disable transitions
        public const uint DWMWA_ALLOW_NCPAINT = 4;                 // [set] Allow contents rendered in the non-client area to be visible on the DWM-drawn frame.
        public const uint DWMWA_CAPTION_BUTTON_BOUNDS = 5;         // [get] Bounds of the caption button area in window-relative space.
        public const uint DWMWA_NONCLIENT_RTL_LAYOUT = 6;          // [set] Is non-client content RTL mirrored
        public const uint DWMWA_FORCE_ICONIC_REPRESENTATION = 7;   // [set] Force this window to display iconic thumbnails.
        public const uint DWMWA_FLIP3D_POLICY = 8;                 // [set] Designates how Flip3D will treat the window.
        public const uint DWMWA_EXTENDED_FRAME_BOUNDS = 9;         // [get] Gets the extended frame bounds rectangle in screen space
        public const uint DWMWA_LAST = 10;

        public const uint DWMNCRP_USEWINDOWSTYLE = 0;
        public const uint DWMNCRP_DISABLED = 1;
        public const uint DWMNCRP_ENABLED = 2;
        public const uint DWMNCRP_LAST = 3;

        public const byte VER_EQUAL = 1;
        public const byte VER_GREATER = 2;
        public const byte VER_GREATER_EQUAL = 3;
        public const byte VER_LESS = 4;
        public const byte VER_LESS_EQUAL = 5;
        public const byte VER_AND = 6;
        public const byte VER_OR = 7;

        public const uint VER_CONDITION_MASK = 7;
        public const uint VER_NUM_BITS_PER_CONDITION_MASK = 3;

        public const uint VER_MINORVERSION = 0x0000001;
        public const uint VER_MAJORVERSION = 0x0000002;
        public const uint VER_BUILDNUMBER = 0x0000004;
        public const uint VER_PLATFORMID = 0x0000008;
        public const uint VER_SERVICEPACKMINOR = 0x0000010;
        public const uint VER_SERVICEPACKMAJOR = 0x0000020;
        public const uint VER_SUITENAME = 0x0000040;
        public const uint VER_PRODUCT_TYPE = 0x0000080;

        public const uint VER_PLATFORM_WIN32s = 0;
        public const uint VER_PLATFORM_WIN32_WINDOWS = 1;
        public const uint VER_PLATFORM_WIN32_NT = 2;

        public const int THREAD_MODE_BACKGROUND_BEGIN = 0x10000;
        public const int THREAD_MODE_BACKGROUND_END = 0x20000;

        private static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)
        {
            return (deviceType << 16) | (access << 14) | (function << 2) | method;
        }

        public const uint FILE_DEVICE_FILE_SYSTEM = 0x00000009;
        public const uint METHOD_BUFFERED = 0;

        public static readonly uint FSCTL_SET_COMPRESSION =
            CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 16, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA);

        public static ushort COMPRESSION_FORMAT_DEFAULT = 1;

        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_NORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_MAXIMIZE = 3;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SHOW = 5;
        public const int SW_MINIMIZE = 6;
        public const int SW_SHOWMINNOACTIVE = 7;
        public const int SW_SHOWNA = 8;
        public const int SW_RESTORE = 9;
        public const int SW_SHOWDEFAULT = 10;
        public const int SW_FORCEMINIMIZE = 11;
        public const int SW_MAX = 11;

        public const uint MF_BYCOMMAND = 0;

        public const uint MF_ENABLED = 0;
        public const uint MF_GRAYED = 1;
        public const uint MF_DISABLED = 2;

        public const uint SC_CLOSE = 0xf060;

        public const uint SEE_MASK_CLASSNAME = 0x00000001;
        public const uint SEE_MASK_CLASSKEY = 0x00000003;
        public const uint SEE_MASK_IDLIST = 0x00000004;
        public const uint SEE_MASK_INVOKEIDLIST = 0x0000000c;
        public const uint SEE_MASK_ICON = 0x00000010;
        public const uint SEE_MASK_HOTKEY = 0x00000020;
        public const uint SEE_MASK_NOCLOSEPROCESS = 0x00000040;
        public const uint SEE_MASK_CONNECTNETDRV = 0x00000080;
        public const uint SEE_MASK_FLAG_DDEWAIT = 0x00000100;
        public const uint SEE_MASK_DOENVSUBST = 0x00000200;
        public const uint SEE_MASK_FLAG_NO_UI = 0x00000400;
        public const uint SEE_MASK_UNICODE = 0x00004000;
        public const uint SEE_MASK_NO_CONSOLE = 0x00008000;
        public const uint SEE_MASK_ASYNCOK = 0x00100000;
        public const uint SEE_MASK_HMONITOR = 0x00200000;
        public const uint SEE_MASK_NOZONECHECKS = 0x00800000;
        public const uint SEE_MASK_NOQUERYCLASSSTORE = 0x01000000;
        public const uint SEE_MASK_WAITFORINPUTIDLE = 0x02000000;
        public const uint SEE_MASK_FLAG_LOG_USAGE = 0x04000000;

        public const uint SHARD_PIDL = 0x00000001;
        public const uint SHARD_PATHA = 0x00000002;
        public const uint SHARD_PATHW = 0x00000003;

        public const uint VER_NT_WORKSTATION = 0x0000001;
        public const uint VER_NT_DOMAIN_CONTROLLER = 0x0000002;
        public const uint VER_NT_SERVER = 0x0000003;

        public const uint LWA_COLORKEY = 0x00000001;
        public const uint LWA_ALPHA = 0x00000002;

        public const uint WS_VISIBLE = 0x10000000;
        public const uint WS_CAPTION = 0x00c00000;

        public const uint WS_EX_LAYERED = 0x00080000;
        public const uint WS_EX_COMPOSITED = 0x02000000;
        public const uint WS_EX_CLIENTEDGE = 0x00000200;

        public const int WP_CAPTION = 1;

        public const int CS_ACTIVE = 1;
        public const int CS_INACTIVE = 2;
        public const int CS_DISABLED = 3;

        public const ushort PROCESSOR_ARCHITECTURE_INTEL = 0;
        public const ushort PROCESSOR_ARCHITECTURE_IA64 = 6;
        public const ushort PROCESSOR_ARCHITECTURE_AMD64 = 9;
        public const ushort PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;

        public const uint SHVIEW_THUMBNAIL = 0x702d;

        public const int MA_ACTIVATE = 1;
        public const int MA_ACTIVATEANDEAT = 2;
        public const int MA_NOACTIVATE = 3;
        public const int MA_NOACTIVATEANDEAT = 4;

        public const int IDI_APPLICATION = 32512;
        public const int IDI_HAND = 32513;
        public const int IDI_QUESTION = 32514;
        public const int IDI_EXCLAMATION = 32515;
        public const int IDI_ASTERISK = 32516;
        public const int IDI_WINLOGO = 32517;
        public const int IDI_SHIELD = 32518;

        public const int OIC_SAMPLE = 32512;
        public const int OIC_HAND = 32513;
        public const int OIC_QUES = 32514;
        public const int OIC_BANG = 32515;
        public const int OIC_NOTE = 32516;
        public const int OIC_WINLOGO = 32517;
        public const int OIC_SHIELD = 32518;

        public const int ERROR_SUCCESS = 0;
        public const int ERROR_INSUFFICIENT_BUFFER = 122;
        public const int ERROR_ALREADY_EXISTS = 183;
        public const int ERROR_MORE_DATA = 324;
        public const int ERROR_CANCELLED = 1223;
        public const int ERROR_IO_PENDING = 0x3e5;
        public const int ERROR_NO_MORE_ITEMS = 259;
        public const int ERROR_TIMEOUT = 1460;

        public const int ERROR_UNABLE_TO_REMOVE_REPLACED = 1175;
        public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176;
        public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177;

        public const uint DIGCF_PRESENT = 2;

        public const int GWL_STYLE = -16;
        public const int GWL_EXSTYLE = -20;

        public const int GWLP_WNDPROC = -4;
        public const int GWLP_HINSTANCE = -6;
        public const int GWLP_HWNDPARENT = -8;
        public const int GWLP_USERDATA = -21;
        public const int GWLP_ID = -12;

        public const int GCLP_MENUNAME = -8;
        public const int GCLP_HBRBACKGROUND = -10;
        public const int GCLP_HCURSOR = -12;
        public const int GCLP_HICON = -14;
        public const int GCLP_HMODULE = -16;
        public const int GCLP_WNDPROC = -24;
        public const int GCLP_HICONSM = -34;

        public const uint PBS_SMOOTH = 0x01;
        public const uint PBS_MARQUEE = 0x08;
        public const int PBM_SETMARQUEE = WM_USER + 10;

        public const int SBM_SETPOS = 0x00E0;
        public const int SBM_SETRANGE = 0x00E2;
        public const int SBM_SETRANGEREDRAW = 0x00E6;
        public const int SBM_SETSCROLLINFO = 0x00E9;

        public const int BCM_FIRST = 0x1600;
        public const int BCM_SETSHIELD = BCM_FIRST + 0x000C;

        public const int BS_BITMAP = 0x80;
        public const int BM_SETIMAGE = 0xf7;

        public const int WTSAT_UNKNOWN = 0;
        public const int WTSAT_RGB = 1;
        public const int WTSAT_ARGB = 2;

        public const int IMAGE_BITMAP = 0;
        public const int IMAGE_ICON = 1;
        public const int IMAGE_CURSOR = 2;
        public const int IMAGE_ENHMETAFILE = 3;

        public const uint LR_DEFAULTCOLOR = 0x00000000;
        public const uint LR_MONOCHROME = 0x00000001;
        public const uint LR_COLOR = 0x00000002;
        public const uint LR_COPYRETURNORG = 0x00000004;
        public const uint LR_COPYDELETEORG = 0x00000008;
        public const uint LR_LOADFROMFILE = 0x00000010;
        public const uint LR_LOADTRANSPARENT = 0x00000020;
        public const uint LR_DEFAULTSIZE = 0x00000040;
        public const uint LR_VGACOLOR = 0x00000080;
        public const uint LR_LOADMAP3DCOLORS = 0x00001000;
        public const uint LR_CREATEDIBSECTION = 0x00002000;
        public const uint LR_COPYFROMRESOURCE = 0x00004000;
        public const uint LR_SHARED = 0x00008000;

        public const int CB_SHOWDROPDOWN = 0x014f;

        public const int WM_CREATE = 0x1;
        public const int WM_MOVE = 0x3;
        public const int WM_COMMAND = 0x111;
        public const int WM_MOUSEACTIVATE = 0x21;
        public const int WM_COPYDATA = 0x004a;
        public const int WM_INPUTLANGCHANGEREQUEST = 0x50;
        public const int WM_SETTEXT = 0x000C;
        public const int WM_WINDOWPOSCHANGED = 0x47;
        public const int WM_SETICON = 0x0080;
        public const int WM_NCCALCSIZE = 0x83;
        public const int WM_NCHITTEST = 0x84;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int WM_MOUSEHWHEEL = 0x020e;
        public const int WM_SIZING = 0x0214;
        public const int WM_MOVING = 0x0216;
        public const int WM_ENTERSIZEMOVE = 0x0231;
        public const int WM_EXITSIZEMOVE = 0x0232;
        public const int WM_WTSSESSION_CHANGE = 0x2b1;
        public const int WM_GETTITLEBARINFOEX = 0x033F;

        public const int HTERROR = -2;
        public const int HTTRANSPARENT = -1;
        public const int HTNOWHERE = 0;
        public const int HTCLIENT = 1;
        public const int HTCAPTION = 2;
        public const int HTSYSMENU = 3;
        public const int HTGROWBOX = 4;
        public const int HTSIZE = HTGROWBOX;
        public const int HTMENU = 5;
        public const int HTHSCROLL = 6;
        public const int HTVSCROLL = 7;
        public const int HTMINBUTTON = 8;
        public const int HTMAXBUTTON = 9;
        public const int HTLEFT = 10;
        public const int HTRIGHT = 11;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 16;
        public const int HTBOTTOMRIGHT = 17;
        public const int HTBORDER = 18;
        public const int HTREDUCE = HTMINBUTTON;
        public const int HTZOOM = HTMAXBUTTON;
        public const int HTSIZEFIRST = HTLEFT;
        public const int HTSIZELAST = HTBOTTOMRIGHT;
        public const int HTOBJECT = 19;
        public const int HTCLOSE = 20;
        public const int HTHELP = 21;

        public const int DC_ACTIVE = 0x0001;
        public const int DC_SMALLCAP = 0x0002;
        public const int DC_ICON = 0x0004;
        public const int DC_TEXT = 0x0008;
        public const int DC_INBUTTON = 0x0010;
        public const int DC_GRADIENT = 0x0020;
        public const int DC_BUTTONS = 0x1000;

        public const int WM_SETCURSOR = 0x0020;
        public const int WM_THEMECHANGED = 0x031a;

        public const uint SMTO_NORMAL = 0x0000;
        public const uint SMTO_BLOCK = 0x0001;
        public const uint SMTO_ABORTIFHUNG = 0x0002;
        public const uint SMTO_NOTIMEOUTIFNOTHUNG = 0x0008;

        public const int WM_KEYFIRST = 0x0100;
        public const int WM_KEYLAST = 0x0109;

        public const int WM_MOUSEFIRST = 0x0200;
        public const int WM_MOUSEMOVE = 0x0200;
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_LBUTTONDBLCLK = 0x0203;
        public const int WM_MOUSELAST = 0x020e;

        public const int WM_TABLET_FIRST = 0x02c0;
        public const int WM_TABLET_LAST = 0x02df;

        public const int __WM_NCINPUTFIRST = 0x00A0;
        public const int WM_NCMOUSEMOVE = 0x00A0;
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int WM_NCLBUTTONUP = 0x00A2;
        public const int WM_NCLBUTTONDBLCLK = 0x00A3;
        public const int WM_NCRBUTTONDOWN = 0x00A4;
        public const int WM_NCRBUTTONUP = 0x00A5;
        public const int WM_NCRBUTTONDBLCLK = 0x00A6;
        public const int WM_NCMBUTTONDOWN = 0x00A7;
        public const int WM_NCMBUTTONUP = 0x00A8;
        public const int WM_NCMBUTTONDBLCLK = 0x00A9;
        public const int WM_NCXBUTTONDOWN = 0x00AB;
        public const int WM_NCXBUTTONUP = 0x00AC;
        public const int WM_NCXBUTTONDBLCLK = 0x00AD;
        public const int __WM_NCINPUTLAST = 0x00AD;
        public const int WM_NCMOUSEHOVER = 0x02A0;
        public const int WM_NCMOUSELEAVE = 0x02A2;

        public const int WM_USER = 0x400;
        public const int WM_HSCROLL = 0x114;
        public const int WM_VSCROLL = 0x115;
        public const int WM_SETFOCUS = 7;
        public const int WM_QUERYENDSESSION = 0x0011;
        public const int WM_ACTIVATE = 0x006;
        public const int WM_ACTIVATEAPP = 0x01C;
        public const int WM_PAINT = 0x000f;
        public const int WM_PRINT = 0x317;
        public const int WM_PRINTCLIENT = 0x318;
        public const int WM_QUIT = 0x0012;
        public const int WM_ERASEBKGND = 0x0014;
        public const int WM_NCPAINT = 0x0085;
        public const int WM_NCACTIVATE = 0x086;
        public const int WM_SETREDRAW = 0x000B;

        public const int WM_DWMCOMPOSITIONCHANGED = 0x031e;

        public const int WVR_ALIGNTOP = 0x0010;
        public const int WVR_ALIGNLEFT = 0x0020;
        public const int WVR_ALIGNBOTTOM = 0x0040;
        public const int WVR_ALIGNRIGHT = 0x0080;
        public const int WVR_HREDRAW = 0x0100;
        public const int WVR_VREDRAW = 0x0200;
        public const int WVR_REDRAW = 0x0300;
        public const int WVR_VALIDRECTS = 0x0400;

        public const uint WS_VSCROLL = 0x00200000;
        public const uint WS_HSCROLL = 0x00100000;

        public const int PRF_CHECKVISIBLE = 0x00000001;
        public const int PRF_NONCLIENT = 0x00000002;
        public const int PRF_CLIENT = 0x00000004;
        public const int PRF_ERASEBKGND = 0x00000008;
        public const int PRF_CHILDREN = 0x00000010;
        public const int PRF_OWNED = 0x00000020;

        public const uint MWMO_ALERTABLE = 0x0002;
        public const uint MWMO_INPUTAVAILABLE = 0x0004;
        public const uint MWMO_WAITALL = 0x0001;

        public const uint QS_KEY = 0x0001;
        public const uint QS_MOUSEMOVE = 0x0002;
        public const uint QS_MOUSEBUTTON = 0x0004;
        public const uint QS_POSTMESSAGE = 0x0008;
        public const uint QS_TIMER = 0x0010;
        public const uint QS_PAINT = 0x0020;
        public const uint QS_SENDMESSAGE = 0x0040;
        public const uint QS_HOTKEY = 0x0080;
        public const uint QS_ALLPOSTMESSAGE = 0x0100;
        public const uint QS_RAWINPUT = 0x0400;
        public const uint QS_MOUSE = (QS_MOUSEMOVE | QS_MOUSEBUTTON);
        public const uint QS_INPUT = (QS_MOUSE | QS_KEY | QS_RAWINPUT);
        public const uint QS_ALLEVENTS = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY);
        public const uint QS_ALLINPUT = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY | QS_SENDMESSAGE);

        public const int VK_LBUTTON = 0x01;
        public const int VK_RBUTTON = 0x02;
        public const int VK_MBUTTON = 0x04;
        public const int VK_XBUTTON1 = 0x05;
        public const int VK_XBUTTON2 = 0x06;

        public const int VK_LCONTROL = 0xA2;
        public const int VK_RMENU = 0xA5;

        public const int MK_LBUTTON = 0x0001;
        public const int MK_RBUTTON = 0x0002;
        public const int MK_SHIFT = 0x0004;
        public const int MK_CONTROL = 0x0008;
        public const int MK_MBUTTON = 0x0010;
        public const int MK_XBUTTON1 = 0x0020;
        public const int MK_XBUTTON2 = 0x0040;

        public const int LOGPIXELSX = 88;
        public const int LOGPIXELSY = 90;

        public const uint BS_MULTILINE = 0x00002000;

        public const byte ANSI_CHARSET = 0;
        public const byte DEFAULT_CHARSET = 1;
        public const byte SYMBOL_CHARSET = 2;
        public const byte SHIFTJIS_CHARSET = 128;
        public const byte HANGEUL_CHARSET = 129;
        public const byte HANGUL_CHARSET = 129;
        public const byte GB2312_CHARSET = 134;
        public const byte CHINESEBIG5_CHARSET = 136;
        public const byte OEM_CHARSET = 255;
        public const byte JOHAB_CHARSET = 130;
        public const byte HEBREW_CHARSET = 177;
        public const byte ARABIC_CHARSET = 178;
        public const byte GREEK_CHARSET = 161;
        public const byte TURKISH_CHARSET = 162;
        public const byte VIETNAMESE_CHARSET = 163;
        public const byte THAI_CHARSET = 222;
        public const byte EASTEUROPE_CHARSET = 238;
        public const byte RUSSIAN_CHARSET = 204;
        public const byte MAC_CHARSET = 77;
        public const byte BALTIC_CHARSET = 186;

        public const uint SPI_GETDISABLEOVERLAPPEDCONTENT = 0x1040;
        public const uint SPI_SETDISABLEOVERLAPPEDCONTENT = 0x1041;
        public const uint SPI_GETCLIENTAREAANIMATION = 0x1042;
        public const uint SPI_SETCLIENTAREAANIMATION = 0x1043;
        public const uint SPI_GETCLEARTYPE = 0x1048;
        public const uint SPI_SETCLEARTYPE = 0x1049;
        public const uint SPI_GETSPEECHRECOGNITION = 0x104A;
        public const uint SPI_SETSPEECHRECOGNITION = 0x104B;

        public const uint SPI_GETBEEP = 0x0001;
        public const uint SPI_SETBEEP = 0x0002;
        public const uint SPI_GETMOUSE = 0x0003;
        public const uint SPI_SETMOUSE = 0x0004;
        public const uint SPI_GETBORDER = 0x0005;
        public const uint SPI_SETBORDER = 0x0006;
        public const uint SPI_GETKEYBOARDSPEED = 0x000A;
        public const uint SPI_SETKEYBOARDSPEED = 0x000B;
        public const uint SPI_LANGDRIVER = 0x000C;
        public const uint SPI_ICONHORIZONTALSPACING = 0x000D;
        public const uint SPI_GETSCREENSAVETIMEOUT = 0x000E;
        public const uint SPI_SETSCREENSAVETIMEOUT = 0x000F;
        public const uint SPI_GETSCREENSAVEACTIVE = 0x0010;
        public const uint SPI_SETSCREENSAVEACTIVE = 0x0011;
        public const uint SPI_GETGRIDGRANULARITY = 0x0012;
        public const uint SPI_SETGRIDGRANULARITY = 0x0013;
        public const uint SPI_SETDESKWALLPAPER = 0x0014;
        public const uint SPI_SETDESKPATTERN = 0x0015;
        public const uint SPI_GETKEYBOARDDELAY = 0x0016;
        public const uint SPI_SETKEYBOARDDELAY = 0x0017;
        public const uint SPI_ICONVERTICALSPACING = 0x0018;
        public const uint SPI_GETICONTITLEWRAP = 0x0019;
        public const uint SPI_SETICONTITLEWRAP = 0x001A;
        public const uint SPI_GETMENUDROPALIGNMENT = 0x001B;
        public const uint SPI_SETMENUDROPALIGNMENT = 0x001C;
        public const uint SPI_SETDOUBLECLKWIDTH = 0x001D;
        public const uint SPI_SETDOUBLECLKHEIGHT = 0x001E;
        public const uint SPI_GETICONTITLELOGFONT = 0x001F;
        public const uint SPI_SETDOUBLECLICKTIME = 0x0020;
        public const uint SPI_SETMOUSEBUTTONSWAP = 0x0021;
        public const uint SPI_SETICONTITLELOGFONT = 0x0022;
        public const uint SPI_GETFASTTASKSWITCH = 0x0023;
        public const uint SPI_SETFASTTASKSWITCH = 0x0024;
        public const uint SPI_SETDRAGFULLWINDOWS = 0x0025;
        public const uint SPI_GETDRAGFULLWINDOWS = 0x0026;
        public const uint SPI_GETNONCLIENTMETRICS = 0x0029;
        public const uint SPI_SETNONCLIENTMETRICS = 0x002A;
        public const uint SPI_GETMINIMIZEDMETRICS = 0x002B;
        public const uint SPI_SETMINIMIZEDMETRICS = 0x002C;
        public const uint SPI_GETICONMETRICS = 0x002D;
        public const uint SPI_SETICONMETRICS = 0x002E;
        public const uint SPI_SETWORKAREA = 0x002F;
        public const uint SPI_GETWORKAREA = 0x0030;
        public const uint SPI_SETPENWINDOWS = 0x0031;
        public const uint SPI_GETHIGHCONTRAST = 0x0042;
        public const uint SPI_SETHIGHCONTRAST = 0x0043;
        public const uint SPI_GETKEYBOARDPREF = 0x0044;
        public const uint SPI_SETKEYBOARDPREF = 0x0045;
        public const uint SPI_GETSCREENREADER = 0x0046;
        public const uint SPI_SETSCREENREADER = 0x0047;
        public const uint SPI_GETANIMATION = 0x0048;
        public const uint SPI_SETANIMATION = 0x0049;
        public const uint SPI_GETFONTSMOOTHING = 0x004A;
        public const uint SPI_SETFONTSMOOTHING = 0x004B;
        public const uint SPI_SETDRAGWIDTH = 0x004C;
        public const uint SPI_SETDRAGHEIGHT = 0x004D;
        public const uint SPI_SETHANDHELD = 0x004E;
        public const uint SPI_GETLOWPOWERTIMEOUT = 0x004F;
        public const uint SPI_GETPOWEROFFTIMEOUT = 0x0050;
        public const uint SPI_SETLOWPOWERTIMEOUT = 0x0051;
        public const uint SPI_SETPOWEROFFTIMEOUT = 0x0052;
        public const uint SPI_GETLOWPOWERACTIVE = 0x0053;
        public const uint SPI_GETPOWEROFFACTIVE = 0x0054;
        public const uint SPI_SETLOWPOWERACTIVE = 0x0055;
        public const uint SPI_SETPOWEROFFACTIVE = 0x0056;
        public const uint SPI_SETCURSORS = 0x0057;
        public const uint SPI_SETICONS = 0x0058;
        public const uint SPI_GETDEFAULTINPUTLANG = 0x0059;
        public const uint SPI_SETDEFAULTINPUTLANG = 0x005A;
        public const uint SPI_SETLANGTOGGLE = 0x005B;
        public const uint SPI_GETWINDOWSEXTENSION = 0x005C;
        public const uint SPI_SETMOUSETRAILS = 0x005D;
        public const uint SPI_GETMOUSETRAILS = 0x005E;
        public const uint SPI_SETSCREENSAVERRUNNING = 0x0061;
        public const uint SPI_SCREENSAVERRUNNING = SPI_SETSCREENSAVERRUNNING;
        public const uint SPI_GETFILTERKEYS = 0x0032;
        public const uint SPI_SETFILTERKEYS = 0x0033;
        public const uint SPI_GETTOGGLEKEYS = 0x0034;
        public const uint SPI_SETTOGGLEKEYS = 0x0035;
        public const uint SPI_GETMOUSEKEYS = 0x0036;
        public const uint SPI_SETMOUSEKEYS = 0x0037;
        public const uint SPI_GETSHOWSOUNDS = 0x0038;
        public const uint SPI_SETSHOWSOUNDS = 0x0039;
        public const uint SPI_GETSTICKYKEYS = 0x003A;
        public const uint SPI_SETSTICKYKEYS = 0x003B;
        public const uint SPI_GETACCESSTIMEOUT = 0x003C;
        public const uint SPI_SETACCESSTIMEOUT = 0x003D;
        public const uint SPI_GETSERIALKEYS = 0x003E;
        public const uint SPI_SETSERIALKEYS = 0x003F;
        public const uint SPI_GETSOUNDSENTRY = 0x0040;
        public const uint SPI_SETSOUNDSENTRY = 0x0041;
        public const uint SPI_GETSNAPTODEFBUTTON = 0x005F;
        public const uint SPI_SETSNAPTODEFBUTTON = 0x0060;
        public const uint SPI_GETMOUSEHOVERWIDTH = 0x0062;
        public const uint SPI_SETMOUSEHOVERWIDTH = 0x0063;
        public const uint SPI_GETMOUSEHOVERHEIGHT = 0x0064;
        public const uint SPI_SETMOUSEHOVERHEIGHT = 0x0065;
        public const uint SPI_GETMOUSEHOVERTIME = 0x0066;
        public const uint SPI_SETMOUSEHOVERTIME = 0x0067;
        public const uint SPI_GETWHEELSCROLLLINES = 0x0068;
        public const uint SPI_SETWHEELSCROLLLINES = 0x0069;
        public const uint SPI_GETMENUSHOWDELAY = 0x006A;
        public const uint SPI_SETMENUSHOWDELAY = 0x006B;
        public const uint SPI_GETSHOWIMEUI = 0x006E;
        public const uint SPI_SETSHOWIMEUI = 0x006F;
        public const uint SPI_GETMOUSESPEED = 0x0070;
        public const uint SPI_SETMOUSESPEED = 0x0071;
        public const uint SPI_GETSCREENSAVERRUNNING = 0x0072;
        public const uint SPI_GETDESKWALLPAPER = 0x0073;
        public const uint SPI_GETACTIVEWINDOWTRACKING = 0x1000;
        public const uint SPI_SETACTIVEWINDOWTRACKING = 0x1001;
        public const uint SPI_GETMENUANIMATION = 0x1002;
        public const uint SPI_SETMENUANIMATION = 0x1003;
        public const uint SPI_GETCOMBOBOXANIMATION = 0x1004;
        public const uint SPI_SETCOMBOBOXANIMATION = 0x1005;
        public const uint SPI_GETLISTBOXSMOOTHSCROLLING = 0x1006;
        public const uint SPI_SETLISTBOXSMOOTHSCROLLING = 0x1007;
        public const uint SPI_GETGRADIENTCAPTIONS = 0x1008;
        public const uint SPI_SETGRADIENTCAPTIONS = 0x1009;
        public const uint SPI_GETKEYBOARDCUES = 0x100A;
        public const uint SPI_SETKEYBOARDCUES = 0x100B;
        public const uint SPI_GETMENUUNDERLINES = SPI_GETKEYBOARDCUES;
        public const uint SPI_SETMENUUNDERLINES = SPI_SETKEYBOARDCUES;
        public const uint SPI_GETACTIVEWNDTRKZORDER = 0x100C;
        public const uint SPI_SETACTIVEWNDTRKZORDER = 0x100D;
        public const uint SPI_GETHOTTRACKING = 0x100E;
        public const uint SPI_SETHOTTRACKING = 0x100F;
        public const uint SPI_GETMENUFADE = 0x1012;
        public const uint SPI_SETMENUFADE = 0x1013;
        public const uint SPI_GETSELECTIONFADE = 0x1014;
        public const uint SPI_SETSELECTIONFADE = 0x1015;
        public const uint SPI_GETTOOLTIPANIMATION = 0x1016;
        public const uint SPI_SETTOOLTIPANIMATION = 0x1017;
        public const uint SPI_GETTOOLTIPFADE = 0x1018;
        public const uint SPI_SETTOOLTIPFADE = 0x1019;
        public const uint SPI_GETCURSORSHADOW = 0x101A;
        public const uint SPI_SETCURSORSHADOW = 0x101B;
        public const uint SPI_GETMOUSESONAR = 0x101C;
        public const uint SPI_SETMOUSESONAR = 0x101D;
        public const uint SPI_GETMOUSECLICKLOCK = 0x101E;
        public const uint SPI_SETMOUSECLICKLOCK = 0x101F;
        public const uint SPI_GETMOUSEVANISH = 0x1020;
        public const uint SPI_SETMOUSEVANISH = 0x1021;
        public const uint SPI_GETFLATMENU = 0x1022;
        public const uint SPI_SETFLATMENU = 0x1023;
        public const uint SPI_GETDROPSHADOW = 0x1024;
        public const uint SPI_SETDROPSHADOW = 0x1025;
        public const uint SPI_GETBLOCKSENDINPUTRESETS = 0x1026;
        public const uint SPI_SETBLOCKSENDINPUTRESETS = 0x1027;
        public const uint SPI_GETUIEFFECTS = 0x103E;
        public const uint SPI_SETUIEFFECTS = 0x103F;
        public const uint SPI_GETFOREGROUNDLOCKTIMEOUT = 0x2000;
        public const uint SPI_SETFOREGROUNDLOCKTIMEOUT = 0x2001;
        public const uint SPI_GETACTIVEWNDTRKTIMEOUT = 0x2002;
        public const uint SPI_SETACTIVEWNDTRKTIMEOUT = 0x2003;
        public const uint SPI_GETFOREGROUNDFLASHCOUNT = 0x2004;
        public const uint SPI_SETFOREGROUNDFLASHCOUNT = 0x2005;
        public const uint SPI_GETCARETWIDTH = 0x2006;
        public const uint SPI_SETCARETWIDTH = 0x2007;
        public const uint SPI_GETMOUSECLICKLOCKTIME = 0x2008;
        public const uint SPI_SETMOUSECLICKLOCKTIME = 0x2009;
        public const uint SPI_GETFONTSMOOTHINGTYPE = 0x200A;
        public const uint SPI_SETFONTSMOOTHINGTYPE = 0x200B;
        public const uint SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;
        public const uint SPI_SETFONTSMOOTHINGCONTRAST = 0x200D;
        public const uint SPI_GETFOCUSBORDERWIDTH = 0x200E;
        public const uint SPI_SETFOCUSBORDERWIDTH = 0x200F;
        public const uint SPI_GETFOCUSBORDERHEIGHT = 0x2010;
        public const uint SPI_SETFOCUSBORDERHEIGHT = 0x2011;
        public const uint SPI_GETFONTSMOOTHINGORIENTATION = 0x2012;
        public const uint SPI_SETFONTSMOOTHINGORIENTATION = 0x2013;

        public const uint FE_FONTSMOOTHINGSTANDARD = 0x0001;
        public const uint FE_FONTSMOOTHINGCLEARTYPE = 0x0002;

        public const uint INFINITE = 0xffffffff;
        public const uint STATUS_WAIT_0 = 0;
        public const uint STATUS_ABANDONED_WAIT_0 = 0x80;
        public const uint WAIT_FAILED = 0xffffffff;
        public const uint WAIT_TIMEOUT = 258;
        public const uint WAIT_ABANDONED = STATUS_ABANDONED_WAIT_0 + 0;
        public const uint WAIT_OBJECT_0 = STATUS_WAIT_0 + 0;
        public const uint WAIT_ABANDONED_0 = STATUS_ABANDONED_WAIT_0 + 0;
        public const uint STATUS_USER_APC = 0x000000C0;
        public const uint WAIT_IO_COMPLETION = STATUS_USER_APC;

        public const uint NOTIFY_FOR_ALL_SESSIONS = 1;
        public const uint NOTIFY_FOR_THIS_SESSION = 0;

        public const int BP_PUSHBUTTON = 1;
        public const int PBS_NORMAL = 1;
        public const int PBS_HOT = 2;
        public const int PBS_PRESSED = 3;
        public const int PBS_DISABLED = 4;
        public const int PBS_DEFAULTED = 5;

        public const int PS_SOLID = 0;
        public const int PS_DASH = 1;             /* -------  */
        public const int PS_DOT = 2;              /* .......  */
        public const int PS_DASHDOT = 3;          /* _._._._  */
        public const int PS_DASHDOTDOT = 4;       /* _.._.._  */
        public const int PS_NULL = 5;
        public const int PS_INSIDEFRAME = 6;
        public const int PS_USERSTYLE = 7;
        public const int PS_ALTERNATE = 8;

        public const int PS_ENDCAP_ROUND = 0x00000000;
        public const int PS_ENDCAP_SQUARE = 0x00000100;
        public const int PS_ENDCAP_FLAT = 0x00000200;
        public const int PS_ENDCAP_MASK = 0x00000F00;

        public const int PS_JOIN_ROUND = 0x00000000;
        public const int PS_JOIN_BEVEL = 0x00001000;
        public const int PS_JOIN_MITER = 0x00002000;
        public const int PS_JOIN_MASK = 0x0000F000;

        public const int PS_COSMETIC = 0x00000000;
        public const int PS_GEOMETRIC = 0x00010000;
        public const int PS_TYPE_MASK = 0x000F0000;

        public const int BS_SOLID = 0;
        public const int BS_NULL = 1;
        public const int BS_HOLLOW = BS_NULL;
        public const int BS_HATCHED = 2;
        public const int BS_PATTERN = 3;
        public const int BS_INDEXED = 4;
        public const int BS_DIBPATTERN = 5;
        public const int BS_DIBPATTERNPT = 6;
        public const int BS_PATTERN8X8 = 7;
        public const int BS_DIBPATTERN8X8 = 8;
        public const int BS_MONOPATTERN = 9;

        public const uint SRCCOPY = 0x00CC0020;     /* dest = source  */
        public const uint SRCPAINT = 0x00EE0086;    /* dest = source OR dest */
        public const uint SRCAND = 0x008800C6;      /* dest = source AND dest */
        public const uint SRCINVERT = 0x00660046;   /* dest = source XOR dest */
        public const uint SRCERASE = 0x00440328;    /* dest = source AND (NOT dest ) */
        public const uint NOTSRCCOPY = 0x00330008;  /* dest = (NOT source) */
        public const uint NOTSRCERASE = 0x001100A6; /* dest = (NOT src) AND (NOT dest) */
        public const uint MERGECOPY = 0x00C000CA;   /* dest = (source AND pattern) */
        public const uint MERGEPAINT = 0x00BB0226;  /* dest = (NOT source) OR dest */
        public const uint PATCOPY = 0x00F00021;     /* dest = pattern  */
        public const uint PATPAINT = 0x00FB0A09;    /* dest = DPSnoo  */
        public const uint PATINVERT = 0x005A0049;   /* dest = pattern XOR dest */
        public const uint DSTINVERT = 0x00550009;   /* dest = (NOT dest) */
        public const uint BLACKNESS = 0x00000042;   /* dest = BLACK  */
        public const uint WHITENESS = 0x00FF0062;   /* dest = WHITE  */

        public const uint NOMIRRORBITMAP = 0x80000000; /* Do not Mirror the bitmap in this call */
        public const uint CAPTUREBLT = 0x40000000;     /* Include layered windows */

        // StretchBlt() Modes
        public const int BLACKONWHITE = 1;
        public const int WHITEONBLACK = 2;
        public const int COLORONCOLOR = 3;
        public const int HALFTONE = 4;
        public const int MAXSTRETCHBLTMODE = 4;

        public const int HeapCompatibilityInformation = 0;
        public const int HeapEnableTerminationOnCorruption = 1;

        public const uint HEAP_NO_SERIALIZE = 0x00000001;
        public const uint HEAP_GROWABLE = 0x00000002;
        public const uint HEAP_GENERATE_EXCEPTIONS = 0x00000004;
        public const uint HEAP_ZERO_MEMORY = 0x00000008;
        public const uint HEAP_REALLOC_IN_PLACE_ONLY = 0x00000010;
        public const uint HEAP_TAIL_CHECKING_ENABLED = 0x00000020;
        public const uint HEAP_FREE_CHECKING_ENABLED = 0x00000040;
        public const uint HEAP_DISABLE_COALESCE_ON_FREE = 0x00000080;
        public const uint HEAP_CREATE_ALIGN_16 = 0x00010000;
        public const uint HEAP_CREATE_ENABLE_TRACING = 0x00020000;
        public const uint HEAP_MAXIMUM_TAG = 0x0FFF;
        public const uint HEAP_PSEUDO_TAG_FLAG = 0x8000;
        public const uint HEAP_TAG_SHIFT = 18;

        public const int MONITOR_DEFAULTTONULL = 0x00000000;
        public const int MONITOR_DEFAULTTOPRIMARY = 0x00000001;
        public const int MONITOR_DEFAULTTONEAREST = 0x00000002;

        public const uint ENUM_CURRENT_SETTINGS = unchecked((uint)-1);
        public const uint ENUM_REGISTRY_SETTINGS = unchecked((uint)-2);

        public const uint WTD_UI_ALL = 1;
        public const uint WTD_UI_NONE = 2;
        public const uint WTD_UI_NOBAD = 3;
        public const uint WTD_UI_NOGOOD = 4;

        public const uint WTD_REVOKE_NONE = 0;
        public const uint WTD_REVOKE_WHOLECHAIN = 1;

        public const uint WTD_CHOICE_FILE = 1;
        public const uint WTD_CHOICE_CATALOG = 2;
        public const uint WTD_CHOICE_BLOB = 3;
        public const uint WTD_CHOICE_SIGNER = 4;
        public const uint WTD_CHOICE_CERT = 5;

        public const uint WTD_STATEACTION_IGNORE = 0;
        public const uint WTD_STATEACTION_VERIFY = 1;
        public const uint WTD_STATEACTION_CLOSE = 2;
        public const uint WTD_STATEACTION_AUTO_CACHE = 3;
        public const uint WTD_STATEACTION_AUTO_CACHE_FLUSH = 4;

        public const uint WTD_PROV_FLAGS_MASK = 0x0000FFFF;
        public const uint WTD_USE_IE4_TRUST_FLAG = 0x00000001;
        public const uint WTD_NO_IE4_CHAIN_FLAG = 0x00000002;
        public const uint WTD_NO_POLICY_USAGE_FLAG = 0x00000004;
        public const uint WTD_REVOCATION_CHECK_NONE = 0x00000010;
        public const uint WTD_REVOCATION_CHECK_END_CERT = 0x00000020;
        public const uint WTD_REVOCATION_CHECK_CHAIN = 0x00000040;
        public const uint WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000080;
        public const uint WTD_SAFER_FLAG = 0x00000100;
        public const uint WTD_HASH_ONLY_FLAG = 0x00000200;
        public const uint WTD_USE_DEFAULT_OSVER_CHECK = 0x00000400;
        public const uint WTD_LIFETIME_SIGNING_FLAG = 0x00000800;
        public const uint WTD_CACHE_ONLY_URL_RETRIEVAL = 0x00001000;

        public static Guid WINTRUST_ACTION_GENERIC_VERIFY_V2
        {
            get
            {
                return new Guid(0xaac56b, 0xcd44, 0x11d0, 0x8c, 0xc2, 0x0, 0xc0, 0x4f, 0xc2, 0x95, 0xee);
            }
        }

        public const uint FILE_SHARE_READ = 0x00000001;
        public const uint FILE_SHARE_WRITE = 0x00000002;
        public const uint FILE_SHARE_DELETE = 0x00000004;

        public const uint FILE_READ_DATA = 0x0001;
        public const uint FILE_LIST_DIRECTORY = 0x0001;
        public const uint FILE_WRITE_DATA = 0x0002;
        public const uint FILE_ADD_FILE = 0x0002;
        public const uint FILE_APPEND_DATA = 0x0004;
        public const uint FILE_ADD_SUBDIRECTORY = 0x0004;
        public const uint FILE_CREATE_PIPE_INSTANCE = 0x0004;

        public const uint FILE_READ_EA = 0x0008;
        public const uint FILE_WRITE_EA = 0x0010;
        public const uint FILE_EXECUTE = 0x0020;
        public const uint FILE_TRAVERSE = 0x0020;
        public const uint FILE_DELETE_CHILD = 0x0040;
        public const uint FILE_READ_ATTRIBUTES = 0x0080;
        public const uint FILE_WRITE_ATTRIBUTES = 0x0100;
        public const uint FILE_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF);
        public const uint FILE_GENERIC_READ = (STANDARD_RIGHTS_READ | FILE_READ_DATA | FILE_READ_ATTRIBUTES | FILE_READ_EA | SYNCHRONIZE);
        public const uint FILE_GENERIC_WRITE = (STANDARD_RIGHTS_WRITE | FILE_WRITE_DATA | FILE_WRITE_ATTRIBUTES | FILE_WRITE_EA | FILE_APPEND_DATA | SYNCHRONIZE);
        public const uint FILE_GENERIC_EXECUTE = (STANDARD_RIGHTS_EXECUTE | FILE_READ_ATTRIBUTES | FILE_EXECUTE | SYNCHRONIZE);

        public const uint REPLACEFILE_WRITE_THROUGH = 1;
        public const uint REPLACEFILE_IGNORE_MERGE_ERRORS = 2;
        public const uint REPLACEFILE_IGNORE_ACL_ERRORS = 4;

        public const uint DELETE = 0x00010000;
        public const uint READ_CONTROL = 0x00020000;
        public const uint WRITE_DAC = 0x00040000;
        public const uint WRITE_OWNER = 0x00080000;
        public const uint SYNCHRONIZE = 0x00100000;

        public const uint STANDARD_RIGHTS_REQUIRED = 0x000F0000;
        public const uint STANDARD_RIGHTS_READ = READ_CONTROL;
        public const uint STANDARD_RIGHTS_WRITE = READ_CONTROL;
        public const uint STANDARD_RIGHTS_EXECUTE = READ_CONTROL;

        public const uint STANDARD_RIGHTS_ALL = 0x0000FFFF;
        public const uint SPECIFIC_RIGHTS_ALL = 0x001F0000;

        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const uint GENERIC_EXECUTE = 0x20000000;

        public const uint CREATE_NEW = 1;
        public const uint CREATE_ALWAYS = 2;
        public const uint OPEN_EXISTING = 3;
        public const uint OPEN_ALWAYS = 4;
        public const uint TRUNCATE_EXISTING = 5;

        public const uint FILE_ATTRIBUTE_READONLY = 0x00000001;
        public const uint FILE_ATTRIBUTE_HIDDEN = 0x00000002;
        public const uint FILE_ATTRIBUTE_SYSTEM = 0x00000004;
        public const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
        public const uint FILE_ATTRIBUTE_ARCHIVE = 0x00000020;
        public const uint FILE_ATTRIBUTE_DEVICE = 0x00000040;
        public const uint FILE_ATTRIBUTE_NORMAL = 0x00000080;
        public const uint FILE_ATTRIBUTE_TEMPORARY = 0x00000100;
        public const uint FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200;
        public const uint FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400;
        public const uint FILE_ATTRIBUTE_COMPRESSED = 0x00000800;
        public const uint FILE_ATTRIBUTE_OFFLINE = 0x00001000;
        public const uint FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000;
        public const uint FILE_ATTRIBUTE_ENCRYPTED = 0x00004000;

        public const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;
        public const uint FILE_FLAG_OVERLAPPED = 0x40000000;
        public const uint FILE_FLAG_NO_BUFFERING = 0x20000000;
        public const uint FILE_FLAG_RANDOM_ACCESS = 0x10000000;
        public const uint FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000;
        public const uint FILE_FLAG_DELETE_ON_CLOSE = 0x04000000;
        public const uint FILE_FLAG_BACKUP_SEMANTICS = 0x02000000;
        public const uint FILE_FLAG_POSIX_SEMANTICS = 0x01000000;
        public const uint FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000;
        public const uint FILE_FLAG_OPEN_NO_RECALL = 0x00100000;
        public const uint FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000;

        public const uint FILE_BEGIN = 0;
        public const uint FILE_CURRENT = 1;
        public const uint FILE_END = 2;

        public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        public const uint HANDLE_FLAG_INHERIT = 0x1;
        public const uint HANDLE_FLAG_PROTECT_FROM_CLOSE = 0x2;

        public const uint MEM_COMMIT = 0x1000;
        public const uint MEM_RESERVE = 0x2000;
        public const uint MEM_DECOMMIT = 0x4000;
        public const uint MEM_RELEASE = 0x8000;
        public const uint MEM_RESET = 0x80000;
        public const uint MEM_TOP_DOWN = 0x100000;
        public const uint MEM_PHYSICAL = 0x400000;

        public const uint PAGE_NOACCESS = 0x01;
        public const uint PAGE_READONLY = 0x02;
        public const uint PAGE_READWRITE = 0x04;
        public const uint PAGE_WRITECOPY = 0x08;
        public const uint PAGE_EXECUTE = 0x10;
        public const uint PAGE_EXECUTE_READ = 0x20;
        public const uint PAGE_EXECUTE_READWRITE = 0x40;
        public const uint PAGE_EXECUTE_WRITECOPY = 0x80;
        public const uint PAGE_GUARD = 0x100;
        public const uint PAGE_NOCACHE = 0x200;
        public const uint PAGE_WRITECOMBINE = 0x400;

        public const uint SEC_IMAGE = 0x1000000;
        public const uint SEC_RESERVE = 0x4000000;
        public const uint SEC_COMMIT = 0x8000000;
        public const uint SEC_NOCACHE = 0x10000000;

        public const uint SECTION_QUERY = 0x0001;
        public const uint SECTION_MAP_WRITE = 0x0002;
        public const uint SECTION_MAP_READ = 0x0004;
        public const uint SECTION_MAP_EXECUTE_EXPLICIT = 0x0020;

        public const uint FILE_MAP_COPY = SECTION_QUERY;
        public const uint FILE_MAP_WRITE = SECTION_MAP_WRITE;
        public const uint FILE_MAP_READ = SECTION_MAP_READ;
        public const uint FILE_MAP_EXECUTE = SECTION_MAP_EXECUTE_EXPLICIT;

        public const uint GMEM_FIXED = 0x0000;
        public const uint GMEM_MOVEABLE = 0x0002;
        public const uint GMEM_ZEROINIT = 0x0040;

        public const uint GHND = 0x0042;
        public const uint GPTR = 0x0040;

        public const uint DIB_RGB_COLORS = 0; /* color table in RGBs */
        public const uint DIB_PAL_COLORS = 1; /* color table in palette indices */

        public const uint BI_RGB = 0;
        public const uint BI_RLE8 = 1;
        public const uint BI_RLE4 = 2;
        public const uint BI_BITFIELDS = 3;
        public const uint BI_JPEG = 4;
        public const uint BI_PNG = 5;

        public const uint LCS_CALIBRATED_RGB = 0;
        public const uint LCS_WINDOWS_COLOR_SPACE = 0x57696e20;
        public const uint LCS_sRGB = 0x73524742;

        public const uint LCS_GM_BUSINESS = 1;
        public const uint LCS_GM_GRAPHICS = 2;
        public const uint LCS_GM_IMAGES = 4;
        public const uint LCS_GM_ABS_COLORIMETRIC = 8;

        public const uint ETO_OPAQUE = 0x0002;
        public const uint ETO_CLIPPED = 0x0004;
        public const uint ETO_GLYPH_INDEX = 0x0010;
        public const uint ETO_RTLREADING = 0x0080;
        public const uint ETO_NUMERICSLOCAL = 0x0400;
        public const uint ETO_NUMERICSLATIN = 0x0800;
        public const uint ETO_IGNORELANGUAGE = 0x1000;
        public const uint ETO_PDY = 0x2000;

        public const uint GCP_DBCS = 0x0001;
        public const uint GCP_REORDER = 0x0002;
        public const uint GCP_USEKERNING = 0x0008;
        public const uint GCP_GLYPHSHAPE = 0x0010;
        public const uint GCP_LIGATE = 0x0020;
        public const uint GCP_DIACRITIC = 0x0100;
        public const uint GCP_KASHIDA = 0x0400;
        public const uint GCP_ERROR = 0x8000;
        public const uint FLI_MASK = 0x103B;
        public const uint GCP_JUSTIFY = 0x00010000;
        public const uint FLI_GLYPHS = 0x00040000;
        public const uint GCP_CLASSIN = 0x00080000;
        public const uint GCP_MAXEXTENT = 0x00100000;
        public const uint GCP_JUSTIFYIN = 0x00200000;
        public const uint GCP_DISPLAYZWG = 0x00400000;
        public const uint GCP_SYMSWAPOFF = 0x00800000;
        public const uint GCP_NUMERICOVERRIDE = 0x01000000;
        public const uint GCP_NEUTRALOVERRIDE = 0x02000000;
        public const uint GCP_NUMERICSLATIN = 0x04000000;
        public const uint GCP_NUMERICSLOCAL = 0x08000000;
        public const uint GCPCLASS_LATIN = 1;
        public const uint GCPCLASS_HEBREW = 2;
        public const uint GCPCLASS_ARABIC = 2;
        public const uint GCPCLASS_NEUTRAL = 3;
        public const uint GCPCLASS_LOCALNUMBER = 4;
        public const uint GCPCLASS_LATINNUMBER = 5;
        public const uint GCPCLASS_LATINNUMERICTERMINATOR = 6;
        public const uint GCPCLASS_LATINNUMERICSEPARATOR = 7;
        public const uint GCPCLASS_NUMERICSEPARATOR = 8;
        public const uint GCPCLASS_PREBOUNDLTR = 0x80;
        public const uint GCPCLASS_PREBOUNDRTL = 0x40;
        public const uint GCPCLASS_POSTBOUNDLTR = 0x20;
        public const uint GCPCLASS_POSTBOUNDRTL = 0x10;

        public const uint GCPGLYPH_LINKBEFORE = 0x8000;
        public const uint GCPGLYPH_LINKAFTER = 0x4000;

        public const uint TA_NOUPDATECP = 0;
        public const uint TA_UPDATECP = 1;
        public const uint TA_LEFT = 0;
        public const uint TA_RIGHT = 2;
        public const uint TA_CENTER = 6;
        public const uint TA_TOP = 0;
        public const uint TA_BOTTOM = 8;
        public const uint TA_BASELINE = 24;
        public const uint TA_RTLREADING = 256;

        public const uint DT_TOP = 0x00000000;
        public const uint DT_LEFT = 0x00000000;
        public const uint DT_CENTER = 0x00000001;
        public const uint DT_RIGHT = 0x00000002;
        public const uint DT_VCENTER = 0x00000004;
        public const uint DT_BOTTOM = 0x00000008;
        public const uint DT_WORDBREAK = 0x00000010;
        public const uint DT_SINGLELINE = 0x00000020;
        public const uint DT_EXPANDTABS = 0x00000040;
        public const uint DT_TABSTOP = 0x00000080;
        public const uint DT_NOCLIP = 0x00000100;
        public const uint DT_EXTERNALLEADING = 0x00000200;
        public const uint DT_CALCRECT = 0x00000400;
        public const uint DT_NOPREFIX = 0x00000800;
        public const uint DT_INTERNAL = 0x00001000;

        public const uint DT_EDITCONTROL = 0x00002000;
        public const uint DT_PATH_ELLIPSIS = 0x00004000;
        public const uint DT_END_ELLIPSIS = 0x00008000;
        public const uint DT_MODIFYSTRING = 0x00010000;
        public const uint DT_RTLREADING = 0x00020000;
        public const uint DT_WORD_ELLIPSIS = 0x00040000;
        public const uint DT_NOFULLWIDTHCHARBREAK = 0x00080000;
        public const uint DT_HIDEPREFIX = 0x00100000;
        public const uint DT_PREFIXONLY = 0x00200000;

        public const int FW_DONTCARE = 0;
        public const int FW_THIN = 100;
        public const int FW_EXTRALIGHT = 200;
        public const int FW_LIGHT = 300;
        public const int FW_NORMAL = 400;
        public const int FW_MEDIUM = 500;
        public const int FW_SEMIBOLD = 600;
        public const int FW_BOLD = 700;
        public const int FW_EXTRABOLD = 800;
        public const int FW_HEAVY = 900;

        public const uint OUT_DEFAULT_PRECIS = 0;
        public const uint OUT_STRING_PRECIS = 1;
        public const uint OUT_CHARACTER_PRECIS = 2;
        public const uint OUT_STROKE_PRECIS = 3;
        public const uint OUT_TT_PRECIS = 4;
        public const uint OUT_DEVICE_PRECIS = 5;
        public const uint OUT_RASTER_PRECIS = 6;
        public const uint OUT_TT_ONLY_PRECIS = 7;
        public const uint OUT_OUTLINE_PRECIS = 8;
        public const uint OUT_SCREEN_OUTLINE_PRECIS = 9;
        public const uint OUT_PS_ONLY_PRECIS = 10;

        public const uint CLIP_DEFAULT_PRECIS = 0;
        public const uint CLIP_CHARACTER_PRECIS = 1;
        public const uint CLIP_STROKE_PRECIS = 2;
        public const uint CLIP_MASK = 0xf;
        public const uint CLIP_LH_ANGLES = (1 << 4);
        public const uint CLIP_TT_ALWAYS = (2 << 4);
        public const uint CLIP_EMBEDDED = (8 << 4);

        public const byte DEFAULT_QUALITY = 0;
        public const byte DRAFT_QUALITY = 1;
        public const byte PROOF_QUALITY = 2;
        public const byte NONANTIALIASED_QUALITY = 3;
        public const byte ANTIALIASED_QUALITY = 4;
        public const byte CLEARTYPE_QUALITY = 5;
        public const byte CLEARTYPE_NATURAL_QUALITY = 6;

        public const int LF_FACESIZE = 32;
        public const int LF_FULLFACESIZE = 64;

        public const uint RASTER_FONTTYPE = 0x0001;
        public const uint DEVICE_FONTTYPE = 0x0002;
        public const uint TRUETYPE_FONTTYPE = 0x0004;

        public const int GM_COMPATIBLE = 1;
        public const int GM_ADVANCED = 2;

        public const int TRANSPARENT = 1;
        public const int OPAQUE = 2;

        public const byte TMPF_FIXED_PITCH = 0x01;
        public const byte TMPF_VECTOR = 0x02;
        public const byte TMPF_DEVICE = 0x08;
        public const byte TMPF_TRUETYPE = 0x04;

        public const uint DEFAULT_PITCH = 0;
        public const uint FIXED_PITCH = 1;
        public const uint VARIABLE_PITCH = 2;
        public const uint MONO_FONT = 8;

        public const uint FF_DONTCARE = (0 << 4);
        public const uint FF_ROMAN = (1 << 4);
        public const uint FF_SWISS = (2 << 4);
        public const uint FF_MODERN = (3 << 4);
        public const uint FF_SCRIPT = (4 << 4);
        public const uint FF_DECORATIVE = (5 << 4);

        public const int MM_MAX_NUMAXES = 16;

        public const int SB_HORZ = 0;

        public const int S_OK = 0;
        public const int S_FALSE = 1;
        public const int E_FAIL = unchecked((int)0x80004005);
        public const int E_NOTIMPL = unchecked((int)0x80004001);

        public const int THBN_CLICKED = 0x1800;

        public const uint HKEY_LOCAL_MACHINE = 0x80000002;
        public const uint KEY_WOW64_64KEY = 0x0100;
        public const uint KEY_QUERY_VALUE = 0x0001;
        public const uint KEY_ENUMERATE_SUB_KEYS = 0x0008;
        public const uint KEY_NOTIFY = 0x0010;

        public const uint KEY_READ = (STANDARD_RIGHTS_READ |
                                        KEY_QUERY_VALUE |
                                        KEY_ENUMERATE_SUB_KEYS |
                                        KEY_NOTIFY) &
                                        ~SYNCHRONIZE;

        public const uint REG_MULTI_SZ = 0x00000007;
        public const uint RRF_RT_REG_BINARY = 0x00000008;
        public const uint RRF_RT_REG_DWORD = 0x00000010;
        public const uint RRF_RT_ANY = 0x0000FFFF;
        public const uint RRF_RT_DWORD = RRF_RT_REG_BINARY | RRF_RT_REG_DWORD;

        public const byte AC_SRC_OVER = 0x00;

        public const byte AC_SRC_ALPHA = 0x01;

        public const uint BPPF_ERASE = 0x1;
        public const uint BPPF_NOCLIP = 0x2;
        public const uint BPPF_NONCLIENT = 0x4;

        public const uint SHGFI_ICON = 0x000000100; // get icon
        public const uint SHGFI_DISPLAYNAME = 0x000000200; // get display name
        public const uint SHGFI_TYPENAME = 0x000000400; // get type name
        public const uint SHGFI_ATTRIBUTES = 0x000000800; // get attributes
        public const uint SHGFI_ICONLOCATION = 0x000001000; // get icon location
        public const uint SHGFI_EXETYPE = 0x000002000; // return exe type
        public const uint SHGFI_SYSICONINDEX = 0x000004000; // get system icon index
        public const uint SHGFI_LINKOVERLAY = 0x000008000; // put a link overlay on icon
        public const uint SHGFI_SELECTED = 0x000010000; // show icon in selected state
        public const uint SHGFI_ATTR_SPECIFIED = 0x000020000; // get only specified attributes
        public const uint SHGFI_LARGEICON = 0x000000000; // get large icon
        public const uint SHGFI_SMALLICON = 0x000000001; // get small icon
        public const uint SHGFI_OPENICON = 0x000000002; // get open icon
        public const uint SHGFI_SHELLICONSIZE = 0x000000004; // get shell size icon
        public const uint SHGFI_PIDL = 0x000000008; // pszPath is a pidl
        public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010; // use passed dwFileAttribute
        public const uint SHGFI_ADDOVERLAYS = 0x000000020; // apply the appropriate overlays
        public const uint SHGFI_OVERLAYINDEX = 0x000000040; // Get the index of the overlay

        public const uint SHGSI_ICONLOCATION = 0;
        public const uint SHGSI_ICON = SHGFI_ICON;
        public const uint SHGSI_SYSICONINDEX = SHGFI_SYSICONINDEX;
        public const uint SHGSI_LINKOVERLAY = SHGFI_LINKOVERLAY;
        public const uint SHGSI_SELECTED = SHGFI_SELECTED;
        public const uint SHGSI_LARGEICON = SHGFI_LARGEICON;
        public const uint SHGSI_SMALLICON = SHGFI_SMALLICON;
        public const uint SHGSI_SHELLICONSIZE = SHGFI_SHELLICONSIZE;

        public const uint SHCNE_RENAMEITEM = 0x00000001U;
        public const uint SHCNE_CREATE = 0x00000002U;
        public const uint SHCNE_DELETE = 0x00000004U;
        public const uint SHCNE_MKDIR = 0x00000008U;
        public const uint SHCNE_RMDIR = 0x00000010U;
        public const uint SHCNE_MEDIAINSERTED = 0x00000020U;
        public const uint SHCNE_MEDIAREMOVED = 0x00000040U;
        public const uint SHCNE_DRIVEREMOVED = 0x00000080U;
        public const uint SHCNE_DRIVEADD = 0x00000100U;
        public const uint SHCNE_NETSHARE = 0x00000200U;
        public const uint SHCNE_NETUNSHARE = 0x00000400U;
        public const uint SHCNE_ATTRIBUTES = 0x00000800U;
        public const uint SHCNE_UPDATEDIR = 0x00001000U;
        public const uint SHCNE_UPDATEITEM = 0x00002000U;
        public const uint SHCNE_SERVERDISCONNECT = 0x00004000U;
        public const uint SHCNE_UPDATEIMAGE = 0x00008000U;
        public const uint SHCNE_DRIVEADDGUI = 0x00010000U;
        public const uint SHCNE_RENAMEFOLDER = 0x00020000U;
        public const uint SHCNE_FREESPACE = 0x00040000U;

        public const uint SHCNF_IDLIST = 0x0000;     // LPITEMIDLIST
        public const uint SHCNF_PATHA = 0x0001;      // path name
        public const uint SHCNF_PRINTERA = 0x0002;   // printer friendly name
        public const uint SHCNF_DWORD = 0x0003;      // DWORD
        public const uint SHCNF_PATHW = 0x0005;      // path name
        public const uint SHCNF_PRINTERW = 0x0006;   // printer friendly name
        public const uint SHCNF_TYPE = 0x00FF;
        public const uint SHCNF_FLUSH = 0x1000;
        public const uint SHCNF_FLUSHNOWAIT = 0x3000; // includes SHCNF_FLUSH

        public const int TMT_TRANSITIONDURATIONS = 6000;

        public const string VSCLASS_COMBOBOX = "COMBOBOX";
        public const int CP_DROPDOWNBUTTON = 1;
        public const int CP_BACKGROUND = 2;
        public const int CP_TRANSPARENTBACKGROUND = 3;
        public const int CP_BORDER = 4;
        public const int CP_READONLY = 5;
        public const int CP_DROPDOWNBUTTONRIGHT = 6;
        public const int CP_DROPDOWNBUTTONLEFT = 7;
        public const int CP_CUEBANNER = 8;

        public const string VSCLASS_BUTTON = "BUTTON";
        public const int BP_COMMANDLINK = 6;

        public const uint REG_NOTIFY_CHANGE_NAME = 1;
        public const uint REG_NOTIFY_CHANGE_ATTRIBUTES = 2;
        public const uint REG_NOTIFY_CHANGE_LAST_SET = 4;
        public const uint REG_NOTIFY_CHANGE_SECURITY = 8;

        public const uint CF_BITMAP = 2;
        public const uint CF_DIB = 8;
        public const uint CF_DIBV5 = 17;
        public const uint CF_DIF = 5;
        public const uint CF_DSPBITMAP = 0x82;
        public const uint CF_DSPENHMETAFILE = 0x8E;
        public const uint CF_DSPMETAFILEPICT = 0x83;
        public const uint CF_DSPTEXT = 0x81;
        public const uint CF_ENHMETAFILE = 14;
        public const uint CF_GDIOBJFIRST = 0x0300;
        public const uint CF_GDIOBJLAST = 0x03ff;
        public const uint CF_HDROP = 15;
        public const uint CF_LOCALE = 16;
        public const uint CF_METAFILEPICT = 3;
        public const uint CF_OEMTEXT = 7;
        public const uint CF_OWNERDISPLAY = 0x80;
        public const uint CF_PALETTE = 9;
        public const uint CF_PENDATA = 10;
        public const uint CF_PRIVATEFIRST = 0x200;
        public const uint CF_PRIVATELAST = 0x2FF;
        public const uint CF_RIFF = 11;
        public const uint CF_SYLK = 4;
        public const uint CF_TEXT = 1;
        public const uint CF_TIFF = 6;
        public const uint CF_UNICODETEXT = 13;
        public const uint CF_WAVE = 12;

        public const uint STATE_SYSTEM_FOCUSABLE = 0x00100000;
        public const uint STATE_SYSTEM_INVISIBLE = 0x00008000;
        public const uint STATE_SYSTEM_OFFSCREEN = 0x00010000;
        public const uint STATE_SYSTEM_UNAVAILABLE = 0x00000001;
        public const uint STATE_SYSTEM_PRESSED = 0x00000007;

        public const int CCHILDREN_TITLEBAR = 5;

        public const uint DTT_TEXTCOLOR = (1 << 0);     // crText has been specified
        public const uint DTT_BORDERCOLOR = (1 << 1);   // crBorder has been specified
        public const uint DTT_SHADOWCOLOR = (1 << 2);   // crShadow has been specified
        public const uint DTT_SHADOWTYPE = (1 << 3);    // iTextShadowType has been specified
        public const uint DTT_SHADOWOFFSET = (1 << 4);  // ptShadowOffset has been specified
        public const uint DTT_BORDERSIZE = (1 << 5);    // iBorderSize has been specified
        public const uint DTT_FONTPROP = (1 << 6);      // iFontPropId has been specified
        public const uint DTT_COLORPROP = (1 << 7);     // iColorPropId has been specified
        public const uint DTT_STATEID = (1 << 8);       // IStateId has been specified
        public const uint DTT_CALCRECT = (1 << 9);      // Use pRect as and in/out parameter
        public const uint DTT_APPLYOVERLAY = (1 << 10); // fApplyOverlay has been specified
        public const uint DTT_GLOWSIZE = (1 << 11);     // iGlowSize has been specified
        public const uint DTT_CALLBACK = (1 << 12);     // pfnDrawTextCallback has been specified
        public const uint DTT_COMPOSITED = (1 << 13);   // Draws text with antialiased alpha (needs a DIB section)
        public const uint DTT_VALIDBITS = (DTT_TEXTCOLOR | DTT_BORDERCOLOR | DTT_SHADOWCOLOR | DTT_SHADOWTYPE | DTT_SHADOWOFFSET | DTT_BORDERSIZE | DTT_FONTPROP | DTT_COLORPROP | DTT_STATEID | DTT_CALCRECT | DTT_APPLYOVERLAY | DTT_GLOWSIZE | DTT_COMPOSITED);

        public const uint TRANSACTION_DO_NOT_PROMOTE = 1;

        public const uint TPM_RETURNCMD = 0x0100;
        public const uint TPM_LEFTBUTTON = 0;
        public const uint TPM_RIGHTBUTTON = 0x2;

        public const uint TME_CANCEL = 0x80000000;
        public const uint TME_HOVER = 0x00000001;
        public const uint TME_LEAVE = 0x00000002;
        public const uint TME_NONCLIENT = 0x00000010;
        public const uint TME_QUERY = 0x40000000;

        public const uint GMMP_USE_DISPLAY_POINTS = 1;
        public const uint GMMP_USE_HIGH_RESOLUTION_POINTS = 2;

        public const int POINTER_DEVICE_PRODUCT_STRING_MAX = 520;

        public const uint POINTER_MOD_SHIFT = 4;
        public const uint POINTER_MOD_CTRL = 8;
                
        public const uint PDC_ARRIVAL = 0x001;
        public const uint PDC_REMOVAL = 0x002;
        public const uint PDC_ORIENTATION_0 = 0x004;
        public const uint PDC_ORIENTATION_90 = 0x008;
        public const uint PDC_ORIENTATION_180 = 0x010;
        public const uint PDC_ORIENTATION_270 = 0x020;
        public const uint PDC_MODE_DEFAULT = 0x040;
        public const uint PDC_MODE_CENTERED = 0x080;
        public const uint PDC_MAPPING_CHANGE = 0x100;
        public const uint PDC_RESOLUTION = 0x200;
        public const uint PDC_ORIGIN = 0x400;
        public const uint PDC_MODE_ASPECTRATIOPRESERVED = 0x800;

        public const int PA_ACTIVATE = MA_ACTIVATE;
        public const int PA_NOACTIVATE = MA_NOACTIVATE;

        public const int WM_NCPOINTERUPDATE = 0x0241;
        public const int WM_NCPOINTERDOWN = 0x0242;
        public const int WM_NCPOINTERUP  = 0x0243;
        public const int WM_POINTERUPDATE = 0x0245;
        public const int WM_POINTERDOWN  = 0x0246;
        public const int WM_POINTERUP  = 0x0247;
        public const int WM_POINTERENTER  = 0x0249;
        public const int WM_POINTERLEAVE  = 0x024A;
        public const int WM_POINTERACTIVATE = 0x024B;
        public const int WM_POINTERCAPTURECHANGED = 0x024C;
        public const int WM_TOUCHHITTESTING = 0x024D;
        public const int WM_POINTERWHEEL  = 0x024E;
        public const int WM_POINTERHWHEEL = 0x024F;

        public const int WM_POINTERDEVICECHANGE = 0x238;
        public const int WM_POINTERDEVICEINRANGE = 0x239;
        public const int WM_POINTERDEVICEOUTOFRANGE = 0x23A;

        public const int WM_TOUCH = 0x240;

        public const uint TOUCH_HIT_TESTING_DEFAULT = 0;
        public const uint TOUCH_HIT_TESTING_CLIENT = 1;
        public const uint TOUCH_HIT_TESTING_NONE = 2;

        public const string MICROSOFT_TABLETPENSERVICE_PROPERTY = "MicrosoftTabletPenServiceProperty";

        public const uint TABLET_DISABLE_PRESSANDHOLD = 0x00000001;
        public const uint TABLET_DISABLE_PENTAPFEEDBACK = 0x00000008;
        public const uint TABLET_DISABLE_PENBARRELFEEDBACK = 0x00000010;
        public const uint TABLET_DISABLE_TOUCHUIFORCEON = 0x00000100;
        public const uint TABLET_DISABLE_TOUCHUIFORCEOFF = 0x00000200;
        public const uint TABLET_DISABLE_TOUCHSWITCH = 0x00008000;
        public const uint TABLET_DISABLE_FLICKS = 0x00010000;

        public const uint TABLET_ENABLE_FLICKSONCONTEXT = 0x00020000;
        public const uint TABLET_ENABLE_FLICKLEARNINGMODE = 0x00040000;

        public const uint TABLET_DISABLE_SMOOTHSCROLLING = 0x00080000;
        public const uint TABLET_DISABLE_FLICKFALLBACKKEYS = 0x00100000;

        public const uint TABLET_ENABLE_MULTITOUCHDATA = 0x01000000;

        public const int WM_GESTURE = 0x0119;
        public const int WM_GESTURENOTIFY = 0x011A;

        public const uint GF_BEGIN = 0x00000001;
        public const uint GF_INERTIA = 0x00000002;
        public const uint GF_END = 0x00000004;

        public const uint GID_BEGIN = 1;
        public const uint GID_END = 2;
        public const uint GID_ZOOM = 3;
        public const uint GID_PAN = 4;
        public const uint GID_ROTATE = 5;
        public const uint GID_TWOFINGERTAP = 6;
        public const uint GID_PRESSANDTAP = 7;
        public const uint GID_ROLLOVER = GID_PRESSANDTAP;

        public const uint GC_ALLGESTURES = 0x00000001;

        public const uint GC_ZOOM = 0x00000001;

        public const uint GC_PAN = 0x00000001;
        public const uint GC_PAN_WITH_SINGLE_FINGER_VERTICALLY = 0x00000002;
        public const uint GC_PAN_WITH_SINGLE_FINGER_HORIZONTALLY = 0x00000004;
        public const uint GC_PAN_WITH_GUTTER = 0x00000008;
        public const uint GC_PAN_WITH_INERTIA = 0x00000010;

        public const uint GC_ROTATE = 0x00000001;

        public const uint GC_TWOFINGERTAP = 0x00000001;

        public const uint GC_PRESSANDTAP = 0x00000001;
        public const uint GC_ROLLOVER = GC_PRESSANDTAP;

        public const uint GESTURECONFIGMAXCOUNT = 256;

        public const uint RDW_INVALIDATE = 0x0001;
        public const uint RDW_INTERNALPAINT = 0x0002;
        public const uint RDW_ERASE = 0x0004;
        public const uint RDW_VALIDATE = 0x0008;
        public const uint RDW_NOINTERNALPAINT = 0x0010;
        public const uint RDW_NOERASE = 0x0020;
        public const uint RDW_NOCHILDREN = 0x0040;
        public const uint RDW_ALLCHILDREN = 0x0080;
        public const uint RDW_UPDATENOW = 0x0100;
        public const uint RDW_ERASENOW = 0x0200;
        public const uint RDW_FRAME = 0x0400;
        public const uint RDW_NOFRAME = 0x0800;

        public const uint GR_GDIOBJECTS = 0;
        public const uint GR_GDIOBJECTS_PEAK = 2;
        public const uint GR_USEROBJECTS = 1;
        public const uint GR_USEROBJECTS_PEAK = 4;

        public const int APPMODEL_ERROR_NO_PACKAGE = 15700;

        public const uint PRODUCT_UNDEFINED = 0x00000000;

        public const uint PRODUCT_ULTIMATE = 0x00000001;
        public const uint PRODUCT_HOME_BASIC = 0x00000002;
        public const uint PRODUCT_HOME_PREMIUM = 0x00000003;
        public const uint PRODUCT_ENTERPRISE = 0x00000004;
        public const uint PRODUCT_HOME_BASIC_N = 0x00000005;
        public const uint PRODUCT_BUSINESS = 0x00000006;
        public const uint PRODUCT_STANDARD_SERVER = 0x00000007;
        public const uint PRODUCT_DATACENTER_SERVER = 0x00000008;
        public const uint PRODUCT_SMALLBUSINESS_SERVER = 0x00000009;
        public const uint PRODUCT_ENTERPRISE_SERVER = 0x0000000A;
        public const uint PRODUCT_STARTER = 0x0000000B;
        public const uint PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C;
        public const uint PRODUCT_STANDARD_SERVER_CORE = 0x0000000D;
        public const uint PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E;
        public const uint PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F;
        public const uint PRODUCT_BUSINESS_N = 0x00000010;
        public const uint PRODUCT_WEB_SERVER = 0x00000011;
        public const uint PRODUCT_CLUSTER_SERVER = 0x00000012;
        public const uint PRODUCT_HOME_SERVER = 0x00000013;
        public const uint PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014;
        public const uint PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015;
        public const uint PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016;
        public const uint PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017;
        public const uint PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018;
        public const uint PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019;
        public const uint PRODUCT_HOME_PREMIUM_N = 0x0000001A;
        public const uint PRODUCT_ENTERPRISE_N = 0x0000001B;
        public const uint PRODUCT_ULTIMATE_N = 0x0000001C;
        public const uint PRODUCT_WEB_SERVER_CORE = 0x0000001D;
        public const uint PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E;
        public const uint PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F;
        public const uint PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020;
        public const uint PRODUCT_SERVER_FOUNDATION = 0x00000021;
        public const uint PRODUCT_HOME_PREMIUM_SERVER = 0x00000022;
        public const uint PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023;
        public const uint PRODUCT_STANDARD_SERVER_V = 0x00000024;
        public const uint PRODUCT_DATACENTER_SERVER_V = 0x00000025;
        public const uint PRODUCT_ENTERPRISE_SERVER_V = 0x00000026;
        public const uint PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027;
        public const uint PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028;
        public const uint PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029;
        public const uint PRODUCT_HYPERV = 0x0000002A;
        public const uint PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B;
        public const uint PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C;
        public const uint PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D;
        public const uint PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E;
        public const uint PRODUCT_STARTER_N = 0x0000002F;
        public const uint PRODUCT_PROFESSIONAL = 0x00000030;
        public const uint PRODUCT_PROFESSIONAL_N = 0x00000031;
        public const uint PRODUCT_SB_SOLUTION_SERVER = 0x00000032;
        public const uint PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033;
        public const uint PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034;
        public const uint PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035;
        public const uint PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036;
        public const uint PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037;
        public const uint PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038;
        public const uint PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 0x00000039;
        public const uint PRODUCT_PROFESSIONAL_EMBEDDED = 0x0000003A;
        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B;
        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C;
        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D;
        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E;
        public const uint PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F;
        public const uint PRODUCT_CLUSTER_SERVER_V = 0x00000040;
        public const uint PRODUCT_EMBEDDED = 0x00000041;
        public const uint PRODUCT_STARTER_E = 0x00000042;
        public const uint PRODUCT_HOME_BASIC_E = 0x00000043;
        public const uint PRODUCT_HOME_PREMIUM_E = 0x00000044;
        public const uint PRODUCT_PROFESSIONAL_E = 0x00000045;
        public const uint PRODUCT_ENTERPRISE_E = 0x00000046;
        public const uint PRODUCT_ULTIMATE_E = 0x00000047;
        public const uint PRODUCT_ENTERPRISE_EVALUATION = 0x00000048;
        public const uint PRODUCT_MULTIPOINT_STANDARD_SERVER = 0x0000004C;
        public const uint PRODUCT_MULTIPOINT_PREMIUM_SERVER = 0x0000004D;
        public const uint PRODUCT_STANDARD_EVALUATION_SERVER = 0x0000004F;
        public const uint PRODUCT_DATACENTER_EVALUATION_SERVER = 0x00000050;
        public const uint PRODUCT_ENTERPRISE_N_EVALUATION = 0x00000054;
        public const uint PRODUCT_EMBEDDED_AUTOMOTIVE = 0x00000055;
        public const uint PRODUCT_EMBEDDED_INDUSTRY_A = 0x00000056;
        public const uint PRODUCT_THINPC = 0x00000057;
        public const uint PRODUCT_EMBEDDED_A = 0x00000058;
        public const uint PRODUCT_EMBEDDED_INDUSTRY = 0x00000059;
        public const uint PRODUCT_EMBEDDED_E = 0x0000005A;
        public const uint PRODUCT_EMBEDDED_INDUSTRY_E = 0x0000005B;
        public const uint PRODUCT_EMBEDDED_INDUSTRY_A_E = 0x0000005C;
        public const uint PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 0x0000005F;
        public const uint PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 0x00000060;
        public const uint PRODUCT_CORE_ARM = 0x00000061;
        public const uint PRODUCT_CORE_N = 0x00000062;
        public const uint PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063;
        public const uint PRODUCT_CORE_SINGLELANGUAGE = 0x00000064;
        public const uint PRODUCT_CORE = 0x00000065;
        public const uint PRODUCT_PROFESSIONAL_WMC = 0x00000067;
        public const uint PRODUCT_MOBILE_CORE = 0x00000068;
        public const uint PRODUCT_EMBEDDED_INDUSTRY_EVAL = 0x00000069;
        public const uint PRODUCT_EMBEDDED_INDUSTRY_E_EVAL = 0x0000006A;
        public const uint PRODUCT_EMBEDDED_EVAL = 0x0000006B;
        public const uint PRODUCT_EMBEDDED_E_EVAL = 0x0000006C;
        public const uint PRODUCT_NANO_SERVER = 0x0000006D;
        public const uint PRODUCT_CLOUD_STORAGE_SERVER = 0x0000006E;
        public const uint PRODUCT_CORE_CONNECTED = 0x0000006F;
        public const uint PRODUCT_PROFESSIONAL_STUDENT = 0x00000070;
        public const uint PRODUCT_CORE_CONNECTED_N = 0x00000071;
        public const uint PRODUCT_PROFESSIONAL_STUDENT_N = 0x00000072;
        public const uint PRODUCT_CORE_CONNECTED_SINGLELANGUAGE = 0x00000073;
        public const uint PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC = 0x00000074;
        public const uint PRODUCT_CONNECTED_CAR = 0x00000075;
        public const uint PRODUCT_INDUSTRY_HANDHELD = 0x00000076;
        public const uint PRODUCT_PPI_PRO = 0x00000077;
        public const uint PRODUCT_ARM64_SERVER = 0x00000078;
        public const uint PRODUCT_EDUCATION = 0x00000079;
        public const uint PRODUCT_EDUCATION_N = 0x0000007A;
        public const uint PRODUCT_IOTUAP = 0x0000007B;
        public const uint PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER = 0x0000007C;
        public const uint PRODUCT_ENTERPRISE_S = 0x0000007D;
        public const uint PRODUCT_ENTERPRISE_S_N = 0x0000007E;
        public const uint PRODUCT_PROFESSIONAL_S = 0x0000007F;
        public const uint PRODUCT_PROFESSIONAL_S_N = 0x00000080;
        public const uint PRODUCT_ENTERPRISE_S_EVALUATION = 0x00000081;
        public const uint PRODUCT_ENTERPRISE_S_N_EVALUATION = 0x00000082;
        public const uint PRODUCT_HOLOGRAPHIC = 0x00000087;
        public const uint PRODUCT_PRO_SINGLE_LANGUAGE = 0x0000008A;
        public const uint PRODUCT_PRO_CHINA = 0x0000008B;
        public const uint PRODUCT_ENTERPRISE_SUBSCRIPTION = 0x0000008C;
        public const uint PRODUCT_ENTERPRISE_SUBSCRIPTION_N = 0x0000008D;
        public const uint PRODUCT_DATACENTER_NANO_SERVER = 0x0000008F;
        public const uint PRODUCT_STANDARD_NANO_SERVER = 0x00000090;
        public const uint PRODUCT_DATACENTER_A_SERVER_CORE = 0x00000091;
        public const uint PRODUCT_STANDARD_A_SERVER_CORE = 0x00000092;
        public const uint PRODUCT_DATACENTER_WS_SERVER_CORE = 0x00000093;
        public const uint PRODUCT_STANDARD_WS_SERVER_CORE = 0x00000094;
        public const uint PRODUCT_UTILITY_VM = 0x00000095;
        public const uint PRODUCT_DATACENTER_EVALUATION_SERVER_CORE = 0x0000009F;
        public const uint PRODUCT_STANDARD_EVALUATION_SERVER_CORE = 0x000000A0;
        public const uint PRODUCT_PRO_WORKSTATION = 0x000000A1;
        public const uint PRODUCT_PRO_WORKSTATION_N = 0x000000A2;
        public const uint PRODUCT_PRO_FOR_EDUCATION = 0x000000A4;
        public const uint PRODUCT_PRO_FOR_EDUCATION_N = 0x000000A5;
        public const uint PRODUCT_AZURE_SERVER_CORE = 0x000000A8;
        public const uint PRODUCT_AZURE_NANO_SERVER = 0x000000A9;
        public const uint PRODUCT_ENTERPRISEG = 0x000000AB;
        public const uint PRODUCT_ENTERPRISEGN = 0x000000AC;
        public const uint PRODUCT_SERVERRDSH = 0x000000AF;
        public const uint PRODUCT_CLOUD = 0x000000B2;
        public const uint PRODUCT_CLOUDN = 0x000000B3;

        public const uint PRODUCT_UNLICENSED = 0xABCDABCD;

        public const int ABM_NEW = 0x00000000;
        public const int ABM_REMOVE = 0x00000001;
        public const int ABM_QUERYPOS = 0x00000002;
        public const int ABM_SETPOS = 0x00000003;
        public const int ABM_GETSTATE = 0x00000004;
        public const int ABM_GETTASKBARPOS = 0x00000005;
        public const int ABM_ACTIVATE = 0x00000006;
        public const int ABM_GETAUTOHIDEBAR = 0x00000007;
        public const int ABM_SETAUTOHIDEBAR = 0x00000008;

        public const int ABS_AUTOHIDE = 1;
        public const int ABS_ALWAYSONTOP = 2;

        public const int WM_POWERBROADCAST = 0x218;

        public const int PBT_APMPOWERSTATUSCHANGE = 0xa;
        public const int PBT_APMRESUMEAUTOMATIC = 0x12;
        public const int PBT_APMRESUMESUSPEND = 7;
        public const int PBT_APMSUSPEND = 4;
        public const int PBT_POWERSETTINGCHANGE = 0x8013;

        public const uint DEVICE_NOTIFY_WINDOW_HANDLE = 0;
        public const uint DEVICE_NOTIFY_SERVICE_HANDLE = 1;

        public static readonly Guid GUID_POWER_SAVING_STATUS = new Guid(0xE00958C0, 0xC213, 0x4ACE, 0xAC, 0x77, 0xFE, 0xCC, 0xED, 0x2E, 0xEE, 0xA5);
    }
}
