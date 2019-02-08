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
        UIKit.UIDatePicker bDatePicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton finishRegisterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView registerScreen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtConfPswd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCountry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtLName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPswd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtZipCode { get; set; }

        [Action ("FinishRegisterButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FinishRegisterButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (bDatePicker != null) {
                bDatePicker.Dispose ();
                bDatePicker = null;
            }

            if (finishRegisterButton != null) {
                finishRegisterButton.Dispose ();
                finishRegisterButton = null;
            }

            if (registerScreen != null) {
                registerScreen.Dispose ();
                registerScreen = null;
            }

            if (txtConfPswd != null) {
                txtConfPswd.Dispose ();
                txtConfPswd = null;
            }

            if (txtCountry != null) {
                txtCountry.Dispose ();
                txtCountry = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
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

            if (txtZipCode != null) {
                txtZipCode.Dispose ();
                txtZipCode = null;
            }
        }
    }
}