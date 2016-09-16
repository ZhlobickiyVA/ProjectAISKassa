using System.Runtime.InteropServices;
using System.Text;

namespace Dosadi.EZTwain
{

    public abstract class EZTwain
{
        //  XDefs translation of \EZTwain\VC\eztwain.h
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_AcquireNative")] public static extern
        System.IntPtr AcquireNative(System.IntPtr hwndApp, int wPixTypes);
        public const int TWAIN_BW = 0x1;
        public const int TWAIN_GRAY = 0x2;
        public const int TWAIN_RGB = 0x4;
        public const int TWAIN_PALETTE = 0x8;
        public const int TWAIN_ANYTYPE = 0x0;
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_FreeNative")] public static extern
        void FreeNative(System.IntPtr hdib);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_AcquireToClipboard")] public static extern
        int AcquireToClipboard(System.IntPtr hwndApp, int wPixTypes);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_AcquireToFilename")] public static extern
        int AcquireToFilename(System.IntPtr hwndApp, string sFile);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SelectImageSource")] public static extern
        int SelectImageSource(System.IntPtr hwnd);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_IsAvailable")] public static extern
        int IsAvailable();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_EasyVersion")] public static extern
        int EasyVersion();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_State")] public static extern
        int State();
        public const int TWAIN_PRESESSION = 1;
        public const int TWAIN_SM_LOADED = 2;
        public const int TWAIN_SM_OPEN = 3;
        public const int TWAIN_SOURCE_OPEN = 4;
        public const int TWAIN_SOURCE_ENABLED = 5;
        public const int TWAIN_TRANSFER_READY = 6;
        public const int TWAIN_TRANSFERRING = 7;
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_DibDepth")] public static extern
        int DibDepth(System.IntPtr hdib);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_DibWidth")] public static extern
        int DibWidth(System.IntPtr hdib);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_DibHeight")] public static extern
        int DibHeight(System.IntPtr hdib);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_DibNumColors")] public static extern
        int DibNumColors(System.IntPtr hdib);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_RowSize")] public static extern
        int RowSize(System.IntPtr hdib);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_ReadRow")] public static extern
        void ReadRow(System.IntPtr hdib, int nRow, System.IntPtr prow);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_CreateDibPalette")] public static extern
        System.IntPtr CreateDibPalette(System.IntPtr hdib);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_DrawDibToDC")] public static extern
        void DrawDibToDC(System.IntPtr hDC, int dx, int dy, int w, int h, System.IntPtr hdib, int sx, int sy);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_WriteNativeToFilename")] public static extern
        int WriteNativeToFilename(System.IntPtr hdib, string sFile);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_WriteNativeToFile")] public static extern
        int WriteNativeToFile(System.IntPtr hdib, System.IntPtr fh);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_LoadNativeFromFilename")] public static extern
        System.IntPtr LoadNativeFromFilename(string sFile);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_LoadNativeFromFile")] public static extern
        System.IntPtr LoadNativeFromFile(System.IntPtr fh);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetHideUI")] public static extern
        void SetHideUI(int fHide);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetHideUI")] public static extern
        int GetHideUI();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_RegisterApp")] public static extern
        void RegisterApp(int nMajorNum, int nMinorNum, int nLanguage, int nCountry, StringBuilder lpszVersion, StringBuilder lpszMfg, StringBuilder lpszFamily, StringBuilder lpszProduct);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetResultCode")] public static extern
        int GetResultCode();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetConditionCode")] public static extern
        int GetConditionCode();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_ErrorBox")] public static extern
        void ErrorBox(string sMsg);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_ReportLastError")] public static extern
        void ReportLastError(string sMsg);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_LoadSourceManager")] public static extern
        int LoadSourceManager();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_OpenSourceManager")] public static extern
        int OpenSourceManager(System.IntPtr hwnd);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_OpenDefaultSource")] public static extern
        int OpenDefaultSource();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_EnableSource")] public static extern
        int EnableSource(System.IntPtr hwnd);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_DisableSource")] public static extern
        int DisableSource();
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_CloseSource")] public static extern
        int CloseSource();

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_CloseSourceManager")] public static extern
        int CloseSourceManager(System.IntPtr hwnd);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_UnloadSourceManager")] public static extern
        int UnloadSourceManager();



        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_WaitForNativeXfer")] public static extern
        System.IntPtr WaitForNativeXfer(System.IntPtr hwnd);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_ModalEventLoop")] public static extern
        void ModalEventLoop();


        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_EndXfer")] public static extern
        int EndXfer();

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_AbortAllPendingXfers")] public static extern
        int AbortAllPendingXfers();



        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_NegotiateXferCount")] public static extern
        int NegotiateXferCount(int nXfers);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_NegotiatePixelTypes")] public static extern
        int NegotiatePixelTypes(int wPixTypes);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetCurrentUnits")] public static extern
        int GetCurrentUnits();

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetCurrentUnits")] public static extern
        int SetCurrentUnits(int nUnits);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetBitDepth")] public static extern
        int GetBitDepth();

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetBitDepth")] public static extern
        int SetBitDepth(int nBits);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetPixelType")] public static extern
        int GetPixelType();

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetCurrentPixelType")] public static extern
        int SetCurrentPixelType(int nPixType);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetCurrentResolution")] public static extern
        double GetCurrentResolution();

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetYResolution")] public static extern
        double GetYResolution();

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetCurrentResolution")] public static extern
        int SetCurrentResolution(double dRes);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetContrast")] public static extern
        int SetContrast(double dCon);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetBrightness")] public static extern
        int SetBrightness(double dBri);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetXferMech")] public static extern
        int SetXferMech(int mech);
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_XferMech")] public static extern
        int XferMech();
        public const int XFERMECH_NATIVE = 0;
        public const int XFERMECH_FILE = 1;
        public const int XFERMECH_MEMORY = 2;


 
        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_SetCapOneValue")] public static extern
        int SetCapOneValue(int Cap, int ItemType, int ItemVal);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_GetCapCurrent")] public static extern
        int GetCapCurrent(int Cap, int ItemType, System.IntPtr pVal);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_ToFix32")] public static extern
        int ToFix32(double d);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_Fix32ToFloat")] public static extern
        double Fix32ToFloat(int nfix);



        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_DS")] public static extern
        int DS(int DG, int DAT, int MSG, System.IntPtr pData);

        [DllImport("eztw32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, EntryPoint="TWAIN_Mgr")] public static extern
        int Mgr(int DG, int DAT, int MSG, System.IntPtr pData);




    }
} // namespace
