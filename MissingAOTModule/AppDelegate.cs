using System.Runtime.InteropServices;
using iOSLibrary;
using Microsoft.VisualBasic;
using ObjCRuntime;
using Constants = ObjCRuntime.Constants;

namespace MissingAOTModule;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

		new Class1().Something();

		// create a UIViewController with a single UILabel
		var vc = new UIViewController ();
		vc.View!.AddSubview (new UILabel (Window!.Frame) {
			BackgroundColor = UIColor.SystemBackground,
			TextAlignment = UITextAlignment.Center,
			Text = "test",
			AutoresizingMask = UIViewAutoresizing.All,
		});
		Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible ();
		return true;
	}
}