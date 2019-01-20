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
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton beginRegisterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton loginButton { get; set; }

        [Action ("BeginRegisterButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BeginRegisterButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton220_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton220_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (beginRegisterButton != null) {
                beginRegisterButton.Dispose ();
                beginRegisterButton = null;
            }

            if (loginButton != null) {
                loginButton.Dispose ();
                loginButton = null;
            }
        }
    }
}