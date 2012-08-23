using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security;
using Crystalbyte.Chocolate.Bindings.Internal;

namespace Crystalbyte.Chocolate.Bindings
{
	[StructLayout(LayoutKind.Sequential)]
	public struct CefGeolocationCallback {
		public CefBase Base;
		public IntPtr Cont;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct CefGeolocationHandler {
		public CefBase Base;
		public IntPtr OnRequestGeolocationPermission;
		public IntPtr OnCancelGeolocationPermission;
	}
	
	public delegate void OnRequestGeolocationPermissionCallback(IntPtr self, IntPtr browser, IntPtr requestingUrl, int requestId, IntPtr callback);
	public delegate void OnCancelGeolocationPermissionCallback(IntPtr self, IntPtr browser, IntPtr requestingUrl, int requestId);
	
}
