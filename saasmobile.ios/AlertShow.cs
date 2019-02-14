using System;
using UIKit;

namespace saasmobile.ios
{
    public static class AlertShow
    {
        public static void Show(UIViewController inpView, string title, string message)
        {
            UIAlertController alert = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            inpView.PresentViewController(alert, true, null);
        }


    }
}
