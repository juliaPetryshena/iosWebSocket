using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libCocoaAsyncSocket.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "Security Foundation")]
