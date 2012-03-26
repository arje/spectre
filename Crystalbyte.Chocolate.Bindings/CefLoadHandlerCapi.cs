using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security;
using Crystalbyte.Chocolate.Bindings.Internal;

namespace Crystalbyte.Chocolate.Bindings
{
	[StructLayout(LayoutKind.Sequential)]
	public struct CefLoadHandler {
		public CefBase Base;
		public IntPtr OnLoadStart;
		public IntPtr OnLoadEnd;
	}
	
	public delegate void OnLoadStartCallback(IntPtr self, IntPtr browser, IntPtr frame);
	public delegate void OnLoadEndCallback(IntPtr self, IntPtr browser, IntPtr frame, int httpstatuscode);
	
}