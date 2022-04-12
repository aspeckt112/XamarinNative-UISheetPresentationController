using Foundation;
using ObjCRuntime;
using System;
using UIKit;

namespace XamarinUISheetPresentationController
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            // https://matrejek.eu/posts/implementing-form-with-uisheetpresentationcontroller/
            
            NavigationItem.Title = "Sheet Demo";

            var button = new UIBarButtonItem("Show Sheet", UIBarButtonItemStyle.Bordered, null);

            button.Clicked += (s, e) =>
            {
                var popupViewController = new PopupViewController();
                var navigationController = new UINavigationController(rootViewController: popupViewController);
                navigationController.ModalPresentationStyle = UIModalPresentationStyle.PageSheet;
                var sheetPresentationController = navigationController.PresentationController as UISheetPresentationController;
                sheetPresentationController.PrefersGrabberVisible = true;
                sheetPresentationController.Detents = new UISheetPresentationControllerDetent[]
                {
                    UISheetPresentationControllerDetent.CreateMediumDetent(),
                    UISheetPresentationControllerDetent.CreateLargeDetent()
                };

                this.PresentViewController(navigationController, true, () =>
                {

                });
            };

            NavigationItem.RightBarButtonItem = button;
        }


        void ShowSheet()
        {

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
