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

namespace iOSSocket {
	[Register("GCDAsyncSocket", true)]
	public unsafe partial class GCDAsyncSocket : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selDelegateQueue = "delegateQueue";
		static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle ("delegateQueue");
		[CompilerGenerated]
		const string selSetDelegateQueue_ = "setDelegateQueue:";
		static readonly IntPtr selSetDelegateQueue_Handle = Selector.GetHandle ("setDelegateQueue:");
		[CompilerGenerated]
		const string selInitWithDelegateDelegateQueue_ = "initWithDelegate:delegateQueue:";
		static readonly IntPtr selInitWithDelegateDelegateQueue_Handle = Selector.GetHandle ("initWithDelegate:delegateQueue:");
		[CompilerGenerated]
		const string selConnectToHostOnPortError_ = "connectToHost:onPort:error:";
		static readonly IntPtr selConnectToHostOnPortError_Handle = Selector.GetHandle ("connectToHost:onPort:error:");
		[CompilerGenerated]
		const string selConnectToHostOnPortWithTimeoutError_ = "connectToHost:onPort:withTimeout:error:";
		static readonly IntPtr selConnectToHostOnPortWithTimeoutError_Handle = Selector.GetHandle ("connectToHost:onPort:withTimeout:error:");
		[CompilerGenerated]
		const string selConnectToHostOnPortViaInterfaceWithTimeoutError_ = "connectToHost:onPort:viaInterface:withTimeout:error:";
		static readonly IntPtr selConnectToHostOnPortViaInterfaceWithTimeoutError_Handle = Selector.GetHandle ("connectToHost:onPort:viaInterface:withTimeout:error:");
		[CompilerGenerated]
		const string selDisconnect = "disconnect";
		static readonly IntPtr selDisconnectHandle = Selector.GetHandle ("disconnect");
		[CompilerGenerated]
		const string selIsDisconnected = "isDisconnected";
		static readonly IntPtr selIsDisconnectedHandle = Selector.GetHandle ("isDisconnected");
		[CompilerGenerated]
		const string selIsConnected = "isConnected";
		static readonly IntPtr selIsConnectedHandle = Selector.GetHandle ("isConnected");
		[CompilerGenerated]
		const string selReadDataWithTimeoutTag_ = "readDataWithTimeout:tag:";
		static readonly IntPtr selReadDataWithTimeoutTag_Handle = Selector.GetHandle ("readDataWithTimeout:tag:");
		[CompilerGenerated]
		const string selReadDataToLengthWithTimeoutTag = "readDataToLength:withTimeout:tag";
		static readonly IntPtr selReadDataToLengthWithTimeoutTagHandle = Selector.GetHandle ("readDataToLength:withTimeout:tag");
		[CompilerGenerated]
		const string selWriteDataWithTimeoutTag_ = "writeData:withTimeout:tag:";
		static readonly IntPtr selWriteDataWithTimeoutTag_Handle = Selector.GetHandle ("writeData:withTimeout:tag:");
		[CompilerGenerated]
		const string selAcceptOnInterfacePortError_ = "acceptOnInterface:port:error:";
		static readonly IntPtr selAcceptOnInterfacePortError_Handle = Selector.GetHandle ("acceptOnInterface:port:error:");
		[CompilerGenerated]
		const string selAcceptOnPortError_ = "acceptOnPort:error:";
		static readonly IntPtr selAcceptOnPortError_Handle = Selector.GetHandle ("acceptOnPort:error:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GCDAsyncSocket");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GCDAsyncSocket () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public GCDAsyncSocket (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GCDAsyncSocket (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GCDAsyncSocket (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:delegateQueue:")]
		[CompilerGenerated]
		public GCDAsyncSocket (NSObject socketDelegate, global::MonoTouch.CoreFoundation.DispatchQueue dispatchQueue)
			: base (NSObjectFlag.Empty)
		{
			if (socketDelegate == null)
				throw new ArgumentNullException ("socketDelegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDelegateDelegateQueue_Handle, socketDelegate.Handle, dispatchQueue.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDelegateDelegateQueue_Handle, socketDelegate.Handle, dispatchQueue.Handle);
			}
		}
		
		[Export ("connectToHost:onPort:error:")]
		[CompilerGenerated]
		public virtual bool connect (string host, global::System.UInt16 port, out NSError error)
		{
			if (host == null)
				throw new ArgumentNullException ("host");
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			var nshost = NSString.CreateNative (host);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt16_IntPtr (this.Handle, selConnectToHostOnPortError_Handle, nshost, port, errorPtr);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt16_IntPtr (this.SuperHandle, selConnectToHostOnPortError_Handle, nshost, port, errorPtr);
			}
			NSString.ReleaseNative (nshost);
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("connectToHost:onPort:withTimeout:error:")]
		[CompilerGenerated]
		public virtual bool connect (string host, global::System.UInt16 port, global::System.Double timeout, out NSError error)
		{
			if (host == null)
				throw new ArgumentNullException ("host");
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			var nshost = NSString.CreateNative (host);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt16_Double_IntPtr (this.Handle, selConnectToHostOnPortWithTimeoutError_Handle, nshost, port, timeout, errorPtr);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt16_Double_IntPtr (this.SuperHandle, selConnectToHostOnPortWithTimeoutError_Handle, nshost, port, timeout, errorPtr);
			}
			NSString.ReleaseNative (nshost);
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("connectToHost:onPort:viaInterface:withTimeout:error:")]
		[CompilerGenerated]
		public virtual bool connect (string host, global::System.UInt16 port, string networkInterface, global::System.Double timeout, out NSError error)
		{
			if (host == null)
				throw new ArgumentNullException ("host");
			if (networkInterface == null)
				throw new ArgumentNullException ("networkInterface");
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			var nshost = NSString.CreateNative (host);
			var nsnetworkInterface = NSString.CreateNative (networkInterface);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt16_IntPtr_Double_IntPtr (this.Handle, selConnectToHostOnPortViaInterfaceWithTimeoutError_Handle, nshost, port, nsnetworkInterface, timeout, errorPtr);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt16_IntPtr_Double_IntPtr (this.SuperHandle, selConnectToHostOnPortViaInterfaceWithTimeoutError_Handle, nshost, port, nsnetworkInterface, timeout, errorPtr);
			}
			NSString.ReleaseNative (nshost);
			NSString.ReleaseNative (nsnetworkInterface);
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("disconnect")]
		[CompilerGenerated]
		public virtual void disconnect ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisconnectHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDisconnectHandle);
			}
		}
		
		[Export ("isDisconnected")]
		[CompilerGenerated]
		public virtual bool isDisconnected ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDisconnectedHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDisconnectedHandle);
			}
		}
		
		[Export ("isConnected")]
		[CompilerGenerated]
		public virtual bool isConnected ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConnectedHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsConnectedHandle);
			}
		}
		
		[Export ("readDataWithTimeout:tag:")]
		[CompilerGenerated]
		public virtual void readData (global::System.Double timeInterval, global::System.Int64 tag)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_Double_Int64 (this.Handle, selReadDataWithTimeoutTag_Handle, timeInterval, tag);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_Double_Int64 (this.SuperHandle, selReadDataWithTimeoutTag_Handle, timeInterval, tag);
			}
		}
		
		[Export ("readDataToLength:withTimeout:tag")]
		[CompilerGenerated]
		public virtual void readData (global::System.UInt32 length, global::System.Double timeInterval, global::System.Int64 tag)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_Double_Int64 (this.Handle, selReadDataToLengthWithTimeoutTagHandle, length, timeInterval, tag);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_Double_Int64 (this.SuperHandle, selReadDataToLengthWithTimeoutTagHandle, length, timeInterval, tag);
			}
		}
		
		[Export ("writeData:withTimeout:tag:")]
		[CompilerGenerated]
		public virtual void writeData (NSData data, global::System.Double timeInterval, global::System.Int64 tag)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_Int64 (this.Handle, selWriteDataWithTimeoutTag_Handle, data.Handle, timeInterval, tag);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_Double_Int64 (this.SuperHandle, selWriteDataWithTimeoutTag_Handle, data.Handle, timeInterval, tag);
			}
		}
		
		[Export ("acceptOnInterface:port:error:")]
		[CompilerGenerated]
		public virtual bool accept (string networkInterface, global::System.UInt16 port, out NSError error)
		{
			if (networkInterface == null)
				throw new ArgumentNullException ("networkInterface");
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			var nsnetworkInterface = NSString.CreateNative (networkInterface);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt16_IntPtr (this.Handle, selAcceptOnInterfacePortError_Handle, nsnetworkInterface, port, errorPtr);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt16_IntPtr (this.SuperHandle, selAcceptOnInterfacePortError_Handle, nsnetworkInterface, port, errorPtr);
			}
			NSString.ReleaseNative (nsnetworkInterface);
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("acceptOnPort:error:")]
		[CompilerGenerated]
		public virtual bool accept (global::System.UInt16 port, out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_UInt16_IntPtr (this.Handle, selAcceptOnPortError_Handle, port, errorPtr);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt16_IntPtr (this.SuperHandle, selAcceptOnPortError_Handle, port, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_socketDelegate_var;
		[CompilerGenerated]
		public virtual NSObject socketDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_socketDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_socketDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreFoundation.DispatchQueue delegateQueue {
			[Export ("delegateQueue", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return new DispatchQueue (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateQueueHandle));
				} else {
					return new DispatchQueue (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateQueueHandle));
				}
			}
			
			[Export ("setDelegateQueue:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegateQueue_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegateQueue_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_socketDelegate_var = null;
			}
		}
	} /* class GCDAsyncSocket */
}
