
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace CoursesIOS
{
	public partial class CoursesViewController : UIViewController
	{
		public CoursesViewController () : base ("CoursesViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

