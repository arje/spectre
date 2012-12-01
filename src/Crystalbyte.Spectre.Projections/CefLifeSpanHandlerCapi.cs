#region Licensing notice

// Copyright (C) 2012, Alexander Wieser-Kuciel <alexander.wieser@crystalbyte.de>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

#region Using directives

using System;
using System.Runtime.InteropServices;
using System.Security;

#endregion

namespace Crystalbyte.Spectre.Projections {
    [StructLayout(LayoutKind.Sequential)]
    public struct CefLifeSpanHandler {
        public CefBase Base;
        public IntPtr OnBeforePopup;
        public IntPtr OnAfterCreated;
        public IntPtr RunModal;
        public IntPtr DoClose;
        public IntPtr OnBeforeClose;
    }

    [SuppressUnmanagedCodeSecurity]
    public static class CefLifeSpanHandlerCapiDelegates {
        public delegate int OnBeforePopupCallback(
            IntPtr self, IntPtr parentbrowser, IntPtr popupfeatures, IntPtr windowinfo, IntPtr url, IntPtr client,
            IntPtr settings);

        public delegate void OnAfterCreatedCallback(IntPtr self, IntPtr browser);

        public delegate int RunModalCallback(IntPtr self, IntPtr browser);

        public delegate int DoCloseCallback(IntPtr self, IntPtr browser);

        public delegate void OnBeforeCloseCallback(IntPtr self, IntPtr browser);
    }
}
