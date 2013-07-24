using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;

namespace iOSSocket
{
	[BaseType (typeof (NSObject))]
	interface GCDAsyncSocket {

		// Initializer (constructor)
		[Export ("initWithDelegate:delegateQueue:")]
		IntPtr Constructor (NSObject socketDelegate, DispatchQueue dispatchQueue);

		// Delegate && DelegateQueue properties
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject socketDelegate { get; set; }

		[Export ("delegateQueue", ArgumentSemantic.Retain)][NullAllowed]
		DispatchQueue delegateQueue { get; set; }

		// Connect && Disconnect
		[Export ("connectToHost:onPort:error:")]
		bool connect (string host, UInt16 port, out NSError error);

		[Export ("connectToHost:onPort:withTimeout:error:")]
		bool connect (string host, UInt16 port, double timeout, out NSError error);

		[Export ("connectToHost:onPort:viaInterface:withTimeout:error:")]
		bool connect (string host, UInt16 port, string networkInterface, double timeout, out NSError error);

		[Export ("disconnect")]
		void disconnect ();

		// State checking
		[Export ("isDisconnected")]
		bool isDisconnected ();

		[Export ("isConnected")]
		bool isConnected ();

		// Read && write

		/**
		 * Reads the first available bytes that become available on the socket.
		 * 
		 * If the timeout value is negative, the read operation will not use a timeout.
		**/
		[Export ("readDataWithTimeout:tag:")]
		void readData (double timeInterval, long tag);

		[Export ("readDataToLength:withTimeout:tag")]
		void readData (uint length, double timeInterval, long tag);

		[Export  ("writeData:withTimeout:tag:")]
		void writeData (NSData data, double timeInterval, long tag);

		// Listening && Accepting connections
		[Export ("acceptOnInterface:port:error:")]
		bool accept (string networkInterface, UInt16 port, out NSError error);

		[Export ("acceptOnPort:error:")]
		bool accept (UInt16 port, out NSError error);
	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface GCDAsyncSocketDelegate {
		[Export ("socket:didAcceptNewSocket:")]
		void didAcceptNewSocket (GCDAsyncSocket socket, GCDAsyncSocket newSocket);

		[Export ("socket:didConnectToHost:port:")]
		void didConnectToHost (GCDAsyncSocket socket, NSString host, UInt16 port);

		[Export ("socket:didReadData:withTag:")]
		void didReadData (GCDAsyncSocket socket, NSData data, long tag);

		[Export ("socket:didReadPartialDataOfLength:tag:")]
		void didReadPartialData (GCDAsyncSocket socket, uint partialDataLength, long tag);

		[Export ("socket:didWriteDataWithTag:")]
		void didWriteData (GCDAsyncSocket socket, long tag);

		[Export ("socket:didWritePartialDataOfLength:tag:")]
		void didWritePartialData (GCDAsyncSocket socket, uint partialDataLength, long tag);

		[Export ("socketDidCloseReadStream")]
		void didCloseReadStream (GCDAsyncSocket socket);

		[Export ("socketDidDisconnect:withError:")]
		void didDisconnect (GCDAsyncSocket socket, NSError error);
	}
	
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//
}

