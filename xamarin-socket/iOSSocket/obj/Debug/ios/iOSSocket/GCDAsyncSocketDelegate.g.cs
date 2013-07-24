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
	[Register("GCDAsyncSocketDelegate", true)]
	[Model]
	public unsafe partial class GCDAsyncSocketDelegate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GCDAsyncSocketDelegate () : base (NSObjectFlag.Empty)
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
		public GCDAsyncSocketDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GCDAsyncSocketDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GCDAsyncSocketDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("socket:didAcceptNewSocket:")]
		[CompilerGenerated]
		public virtual void didAcceptNewSocket (GCDAsyncSocket socket, GCDAsyncSocket newSocket)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("socket:didConnectToHost:port:")]
		[CompilerGenerated]
		public virtual void didConnectToHost (GCDAsyncSocket socket, NSString host, global::System.UInt16 port)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("socket:didReadData:withTag:")]
		[CompilerGenerated]
		public virtual void didReadData (GCDAsyncSocket socket, NSData data, global::System.Int64 tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("socket:didReadPartialDataOfLength:tag:")]
		[CompilerGenerated]
		public virtual void didReadPartialData (GCDAsyncSocket socket, global::System.UInt32 partialDataLength, global::System.Int64 tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("socket:didWriteDataWithTag:")]
		[CompilerGenerated]
		public virtual void didWriteData (GCDAsyncSocket socket, global::System.Int64 tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("socket:didWritePartialDataOfLength:tag:")]
		[CompilerGenerated]
		public virtual void didWritePartialData (GCDAsyncSocket socket, global::System.UInt32 partialDataLength, global::System.Int64 tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("socketDidCloseReadStream")]
		[CompilerGenerated]
		public virtual void didCloseReadStream (GCDAsyncSocket socket)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("socketDidDisconnect:withError:")]
		[CompilerGenerated]
		public virtual void didDisconnect (GCDAsyncSocket socket, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GCDAsyncSocketDelegate */
}
