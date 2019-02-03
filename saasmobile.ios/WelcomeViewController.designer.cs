// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace saasmobile.ios
{
    [Register ("WelcomeViewController")]
    partial class WelcomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField welcomeEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton welcomeLoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton welcomeRegisterButton { get; set; }

        [Action ("WelcomeLoginButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void WelcomeLoginButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("WelcomeRegisterButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void WelcomeRegisterButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (welcomeEmail != null) {
                welcomeEmail.Dispose ();
                welcomeEmail = null;
            }

            if (welcomeLoginButton != null) {
                welcomeLoginButton.Dispose ();
                welcomeLoginButton = null;
            }

            if (welcomeRegisterButton != null) {
                welcomeRegisterButton.Dispose ();
                welcomeRegisterButton = null;
            }
        }
    }
}