//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace ApiDefinition {
	public partial class Messaging {
		static internal System.Reflection.Assembly this_assembly = typeof (Messaging).Assembly;

		const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";

		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static bool bool_objc_msgSend_IntPtr_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static bool bool_objc_msgSendSuper_IntPtr_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, IntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static bool bool_objc_msgSend_IntPtr_UInt16_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, global::System.Double arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static bool bool_objc_msgSendSuper_IntPtr_UInt16_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, global::System.Double arg3, IntPtr arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static bool bool_objc_msgSend_IntPtr_UInt16_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, IntPtr arg3, global::System.Double arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static bool bool_objc_msgSendSuper_IntPtr_UInt16_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt16 arg2, IntPtr arg3, global::System.Double arg4, IntPtr arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_Double_Int64 (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Int64 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_Double_Int64 (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Int64 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_UInt32_Double_Int64 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Double arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_UInt32_Double_Int64 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Double arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr_Double_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr_Double_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static bool bool_objc_msgSend_UInt16_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static bool bool_objc_msgSendSuper_UInt16_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr_IntPtr_UInt16 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt16 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt16 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt16 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr_UInt32_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr_UInt32_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.Int64 arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2);
	}
}
