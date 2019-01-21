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
    [Register ("RegistrationViewController")]
    partial class RegistrationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton finishRegisterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView registerScreen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmailDomain { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmailHandle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtLName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPswd { get; set; }

        [Action ("FinishRegisterButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FinishRegisterButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (finishRegisterButton != null) {
                finishRegisterButton.Dispose ();
                finishRegisterButton = null;
            }

            if (registerScreen != null) {
                registerScreen.Dispose ();
                registerScreen = null;
            }

            if (txtBDate != null) {
                txtBDate.Dispose ();
                txtBDate = null;
            }

            if (txtEmailDomain != null) {
                txtEmailDomain.Dispose ();
                txtEmailDomain = null;
            }

            if (txtEmailHandle != null) {
                txtEmailHandle.Dispose ();
                txtEmailHandle = null;
            }

            if (txtFName != null) {
                txtFName.Dispose ();
                txtFName = null;
            }

            if (txtLName != null) {
                txtLName.Dispose ();
                txtLName = null;
            }

            if (txtPswd != null) {
                txtPswd.Dispose ();
                txtPswd = null;
            }
        }
    }
}