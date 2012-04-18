#region Namespace Directives

using System;
using System.Runtime.InteropServices;

#endregion

namespace Crystalbyte.Chocolate.Bindings {
    [StructLayout(LayoutKind.Sequential)]
    public struct CefResourceBundleHandler {
        public CefBase Base;
        public IntPtr GetLocalizedString;
        public IntPtr GetDataResource;
    }

    public delegate int GetLocalizedStringCallback(IntPtr self, int messageId, IntPtr @string);

    public delegate int GetDataResourceCallback(IntPtr self, int resourceId, IntPtr data, IntPtr dataSize);
}