using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security;
using Crystalbyte.Chocolate.Bindings.Internal;

namespace Crystalbyte.Chocolate.Bindings
{
	[SuppressUnmanagedCodeSecurity]
	public static class CefCommandLineCapi {
		[DllImport(CefAssembly.Name, EntryPoint = "cef_command_line_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public static extern IntPtr CefCommandLineCreate();
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct CefCommandLine {
		public CefBase Base;
		public IntPtr InitFromString;
		public IntPtr Reset;
		public IntPtr GetCommandLineString;
		public IntPtr GetProgram;
		public IntPtr SetProgram;
		public IntPtr HasSwitches;
		public IntPtr HasSwitch;
		public IntPtr GetSwitchValue;
		public IntPtr GetSwitches;
		public IntPtr AppendSwitch;
		public IntPtr AppendSwitchWithValue;
		public IntPtr HasArguments;
		public IntPtr GetArguments;
		public IntPtr AppendArgument;
	}
	
	public delegate void InitFromStringCallback(IntPtr self, IntPtr commandLine);
	public delegate void ResetCallback(IntPtr self);
	public delegate IntPtr GetCommandLineStringCallback(IntPtr self);
	public delegate IntPtr GetProgramCallback(IntPtr self);
	public delegate void SetProgramCallback(IntPtr self, IntPtr program);
	public delegate int HasSwitchesCallback(IntPtr self);
	public delegate int HasSwitchCallback(IntPtr self, IntPtr name);
	public delegate IntPtr GetSwitchValueCallback(IntPtr self, IntPtr name);
	public delegate void GetSwitchesCallback(IntPtr self, IntPtr switches);
	public delegate void AppendSwitchCallback(IntPtr self, IntPtr name);
	public delegate void AppendSwitchWithValueCallback(IntPtr self, IntPtr name, IntPtr value);
	public delegate int HasArgumentsCallback(IntPtr self);
	public delegate void GetArgumentsCallback(IntPtr self, IntPtr arguments);
	public delegate void AppendArgumentCallback(IntPtr self, IntPtr argument);
	
}