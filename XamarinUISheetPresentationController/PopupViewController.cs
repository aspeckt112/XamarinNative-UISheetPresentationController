using System;

using UIKit;

namespace XamarinUISheetPresentationController
{
    public partial class PopupViewController : UIViewController
    {
        public PopupViewController() : base("PopupViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Red;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

