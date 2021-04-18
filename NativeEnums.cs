/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using System;

namespace PaintDotNet.SystemLayer
{
    internal static class NativeEnums
    {
        [Flags]
        public enum TBPFLAG
            : int
        {
            TBPF_NOPROGRESS = 0,
            TBPF_INDETERMINATE = 0x1,
            TBPF_NORMAL = 0x2,
            TBPF_ERROR = 0x4,
            TBPF_PAUSED = 0x8
        }

        [Flags]
        public enum STPFLAG
            : int
        {
            STPF_NONE = 0x0,
            STPF_USEAPPTHUMBNAILALWAYS = 0x1,
            STPF_USEAPPTHUMBNAILWHENACTIVE = 0x2,
            STPF_USEAPPPEEKALWAYS = 0x4,
            STPF_USEAPPPEEKWHENACTIVE = 0x8
        }

        [Flags]
        public enum THBMASK
            : int
        {
            THB_BITMAP = 0x1,
            THB_ICON = 0x2,
            THB_TOOLTIP = 0x4,
            THB_FLAGS = 0x8
        }

        [Flags]
        public enum THBFLAGS
            : int
        {
            THBF_ENABLED = 0x00000000,
            THBF_DISABLED = 0x00000001,
            THBF_DISMISSONCLICK = 0x00000002,
            THBF_NOBACKGROUND = 0x00000004,
            THBF_HIDDEN = 0x00000008,
            THBF_NONINTERACTIVE = 0x00000010
        }

        public enum BP_BUFFERFORMAT
        {
            BPBF_COMPATIBLEBITMAP,
            BPBF_DIB,
            BPBF_TOPDOWNDIB,
            BPBF_TOPDOWNMONODIB
        }

        public enum BP_ANIMATIONSTYLE
        {
            [Obsolete("As per SDK documentation, this is not implemented.", true)]
            BPAS_NONE,

            BPAS_LINEAR,

            [Obsolete("As per SDK documentation, this is not implemented.", true)]
            BPAS_CUBIC,

            [Obsolete("As per SDK documentation, this is not implemented.", true)]
            BPAS_SINE,
        }

        public enum SHSTOCKICONID
        {
            SIID_DOCNOASSOC = 0,          // document (blank page), no associated program
            SIID_DOCASSOC = 1,            // document with an associated program
            SIID_APPLICATION = 2,         // generic application with no custom icon
            SIID_FOLDER = 3,              // folder (closed)
            SIID_FOLDEROPEN = 4,          // folder (open)
            SIID_DRIVE525 = 5,            // 5.25" floppy disk drive
            SIID_DRIVE35 = 6,             // 3.5" floppy disk drive
            SIID_DRIVEREMOVE = 7,         // removable drive
            SIID_DRIVEFIXED = 8,          // fixed (hard disk) drive
            SIID_DRIVENET = 9,            // network drive
            SIID_DRIVENETDISABLED = 10,   // disconnected network drive
            SIID_DRIVECD = 11,            // CD drive
            SIID_DRIVERAM = 12,           // RAM disk drive
            SIID_WORLD = 13,              // entire network
            SIID_SERVER = 15,             // a computer on the network
            SIID_PRINTER = 16,            // printer
            SIID_MYNETWORK = 17,          // My network places
            SIID_FIND = 22,               // Find
            SIID_HELP = 23,               // Help
            SIID_SHARE = 28,              // overlay for shared items
            SIID_LINK = 29,               // overlay for shortcuts to items
            SIID_SLOWFILE = 30,           // overlay for slow items
            SIID_RECYCLER = 31,           // empty recycle bin
            SIID_RECYCLERFULL = 32,       // full recycle bin
            SIID_MEDIACDAUDIO = 40,       // Audio CD Media
            SIID_LOCK = 47,               // Security lock
            SIID_AUTOLIST = 49,           // AutoList
            SIID_PRINTERNET = 50,         // Network printer
            SIID_SERVERSHARE = 51,        // Server share
            SIID_PRINTERFAX = 52,         // Fax printer
            SIID_PRINTERFAXNET = 53,      // Networked Fax Printer
            SIID_PRINTERFILE = 54,        // Print to File
            SIID_STACK = 55,              // Stack
            SIID_MEDIASVCD = 56,          // SVCD Media
            SIID_STUFFEDFOLDER = 57,      // Folder containing other items
            SIID_DRIVEUNKNOWN = 58,       // Unknown drive
            SIID_DRIVEDVD = 59,           // DVD Drive
            SIID_MEDIADVD = 60,           // DVD Media
            SIID_MEDIADVDRAM = 61,        // DVD-RAM Media
            SIID_MEDIADVDRW = 62,         // DVD-RW Media
            SIID_MEDIADVDR = 63,          // DVD-R Media
            SIID_MEDIADVDROM = 64,        // DVD-ROM Media
            SIID_MEDIACDAUDIOPLUS = 65,   // CD+ (Enhanced CD) Media
            SIID_MEDIACDRW = 66,          // CD-RW Media
            SIID_MEDIACDR = 67,           // CD-R Media
            SIID_MEDIACDBURN = 68,        // Burning CD
            SIID_MEDIABLANKCD = 69,       // Blank CD Media
            SIID_MEDIACDROM = 70,         // CD-ROM Media
            SIID_AUDIOFILES = 71,         // Audio files
            SIID_IMAGEFILES = 72,         // Image files
            SIID_VIDEOFILES = 73,         // Video files
            SIID_MIXEDFILES = 74,         // Mixed files
            SIID_FOLDERBACK = 75,         // Folder back
            SIID_FOLDERFRONT = 76,        // Folder front
            SIID_SHIELD = 77,             // Security shield. Use for UAC prompts only.
            SIID_WARNING = 78,            // Warning
            SIID_INFO = 79,               // Informational
            SIID_ERROR = 80,              // Error
            SIID_KEY = 81,                // Key / Secure
            SIID_SOFTWARE = 82,           // Software
            SIID_RENAME = 83,             // Rename
            SIID_DELETE = 84,             // Delete
            SIID_MEDIAAUDIODVD = 85,      // Audio DVD Media
            SIID_MEDIAMOVIEDVD = 86,      // Movie DVD Media
            SIID_MEDIAENHANCEDCD = 87,    // Enhanced CD Media
            SIID_MEDIAENHANCEDDVD = 88,   // Enhanced DVD Media
            SIID_MEDIAHDDVD = 89,         // HD-DVD Media
            SIID_MEDIABLURAY = 90,        // BluRay Media
            SIID_MEDIAVCD = 91,           // VCD Media
            SIID_MEDIADVDPLUSR = 92,      // DVD+R Media
            SIID_MEDIADVDPLUSRW = 93,     // DVD+RW Media
            SIID_DESKTOPPC = 94,          // desktop computer
            SIID_MOBILEPC = 95,           // mobile computer (laptop/notebook)
            SIID_USERS = 96,              // users
            SIID_MEDIASMARTMEDIA = 97,    // Smart Media
            SIID_MEDIACOMPACTFLASH = 98,  // Compact Flash
            SIID_DEVICECELLPHONE = 99,    // Cell phone
            SIID_DEVICECAMERA = 100,      // Camera
            SIID_DEVICEVIDEOCAMERA = 101, // Video camera
            SIID_DEVICEAUDIOPLAYER = 102, // Audio player
            SIID_NETWORKCONNECT = 103,    // Connect to network
            SIID_INTERNET = 104,          // Internet
            SIID_ZIPFILE = 105,           // ZIP file
            SIID_SETTINGS = 106,          // Settings
            // 107-131 are internal Vista RTM icons
            // 132-159 for SP1 icons
            SIID_DRIVEHDDVD = 132,        // HDDVD Drive (all types)
            SIID_DRIVEBD = 133,           // BluRay Drive (all types)
            SIID_MEDIAHDDVDROM = 134,     // HDDVD-ROM Media
            SIID_MEDIAHDDVDR = 135,       // HDDVD-R Media
            SIID_MEDIAHDDVDRAM = 136,     // HDDVD-RAM Media
            SIID_MEDIABDROM = 137,        // BluRay ROM Media
            SIID_MEDIABDR = 138,          // BluRay R Media
            SIID_MEDIABDRE = 139,         // BluRay RE Media (Rewriable and RAM)
            SIID_CLUSTEREDDRIVE = 140,    // Clustered disk
            // 160+ are for Windows 7 icons
            SIID_MAX_ICONS = 174,
        }

        public enum WINDOWTHEMEATTRIBUTETYPE
            : uint
        {
            WTA_NONCLIENT = 1
        }

        [Flags]
        public enum WTNCA
            : int
        {
            WTNCA_NODRAWCAPTION = 1,
            WTNCA_NODRAWICON = 2,
            WTNCA_NOSYSMENU = 4,
            WTNCA_NOMIRRORHELP = 8,
            WTNCA_VALIDBITS = 1 | 2 | 4 | 8
        }

        public enum TEXTSHADOWTYPE
        {
            TST_NONE = 0,
            TST_SINGLE = 1,
            TST_CONTINUOUS = 2
        }

        [Flags]
        public enum POINTER_MESSAGE_FLAGS
            : uint
        {
            POINTER_MESSAGE_FLAG_NEW = 0x00000001, // New pointer
            POINTER_MESSAGE_FLAG_INRANGE = 0x00000002, // Pointer has not departed
            POINTER_MESSAGE_FLAG_INCONTACT = 0x00000004, // Pointer is in contact
            POINTER_MESSAGE_FLAG_FIRSTBUTTON = 0x00000010, // Primary action
            POINTER_MESSAGE_FLAG_SECONDBUTTON = 0x00000020, // Secondary action
            POINTER_MESSAGE_FLAG_THIRDBUTTON = 0x00000040, // Third button
            POINTER_MESSAGE_FLAG_FOURTHBUTTON = 0x00000080, // Fourth button
            POINTER_MESSAGE_FLAG_FIFTHBUTTON = 0x00000100, // Fifth button
            POINTER_MESSAGE_FLAG_PRIMARY = 0x00002000, // Pointer is primary
            POINTER_MESSAGE_FLAG_CONFIDENCE = 0x00004000, // Pointer is considered unlikely to be accidental
            POINTER_MESSAGE_FLAG_CANCELED = 0x00008000, // Pointer is departing in an abnormal manner
        }

        [Flags]
        public enum TOUCH_FLAGS
            : uint
        {
            TOUCH_FLAG_NONE
        }

        [Flags]
        public enum TOUCH_MASK
        {
            TOUCH_MASK_NONE = 0,
            TOUCH_MASK_CONTACTAREA = 1,
            TOUCH_MASK_ORIENTATION = 2,
            TOUCH_MASK_PRESSURE = 4
        }

        public enum FEEDBACK_TYPE
            : uint
        {
            FEEDBACK_TOUCH_CONTACTVISUALIZATION = 1,
            FEEDBACK_PEN_BARRELVISUALIZATION = 2,
            FEEDBACK_PEN_TAP = 3,
            FEEDBACK_PEN_DOUBLETAP = 4,
            FEEDBACK_PEN_PRESSANDHOLD = 5,
            FEEDBACK_PEN_RIGHTTAP = 6,
            FEEDBACK_TOUCH_TAP = 7,
            FEEDBACK_TOUCH_DOUBLETAP = 8,
            FEEDBACK_TOUCH_PRESSANDHOLD = 9,
            FEEDBACK_TOUCH_RIGHTTAP = 10,
            FEEDBACK_GESTURE_PRESSANDTAP = 11,
            FEEDBACK_MAX = 0xFFFFFFFF
        }

        public enum LOGICAL_PROCESSOR_RELATIONSHIP
        {
            RelationProcessorCore,
            RelationNumaNode,
            RelationCache,
            RelationProcessorPackage,
            RelationGroup,
            RelationAll = 0xffff
        }

        public enum PROCESSOR_CACHE_TYPE
        {
            CacheUnified,
            CacheInstruction,
            CacheData,
            CacheTrace
        }

        [Flags]
        public enum TASKDIALOG_FLAGS
        {
            TDF_ENABLE_HYPERLINKS = 0x0001,
            TDF_USE_HICON_MAIN = 0x0002,
            TDF_USE_HICON_FOOTER = 0x0004,
            TDF_ALLOW_DIALOG_CANCELLATION = 0x0008,
            TDF_USE_COMMAND_LINKS = 0x0010,
            TDF_USE_COMMAND_LINKS_NO_ICON = 0x0020,
            TDF_EXPAND_FOOTER_AREA = 0x0040,
            TDF_EXPANDED_BY_DEFAULT = 0x0080,
            TDF_VERIFICATION_FLAG_CHECKED = 0x0100,
            TDF_SHOW_PROGRESS_BAR = 0x0200,
            TDF_SHOW_MARQUEE_PROGRESS_BAR = 0x0400,
            TDF_CALLBACK_TIMER = 0x0800,
            TDF_POSITION_RELATIVE_TO_WINDOW = 0x1000,
            TDF_RTL_LAYOUT = 0x2000,
            TDF_NO_DEFAULT_RADIO_BUTTON = 0x4000,
            TDF_CAN_BE_MINIMIZED = 0x8000,
            TDF_NO_SET_FOREGROUND = 0x00010000, // Don't call SetForegroundWindow() when activating the dialog
            TDF_SIZE_TO_CONTENT = 0x01000000  // used by ShellMessageBox to emulate MessageBox sizing behavior
        }

        [Flags]
        public enum TASKDIALOG_COMMON_BUTTON_FLAGS
        {
            TDCBF_OK_BUTTON = 0x0001, // selected control return value IDOK
            TDCBF_YES_BUTTON = 0x0002, // selected control return value IDYES
            TDCBF_NO_BUTTON = 0x0004, // selected control return value IDNO
            TDCBF_CANCEL_BUTTON = 0x0008, // selected control return value IDCANCEL
            TDCBF_RETRY_BUTTON = 0x0010, // selected control return value IDRETRY
            TDCBF_CLOSE_BUTTON = 0x0020  // selected control return value IDCLOSE
        }
    }
}
