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
    [Register ("ProfileViewController")]
    partial class ProfileViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel profileBDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField profileCountry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel profileEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel profileFName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel profileLName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField profilePassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField profileZipCode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton updateProfileButton { get; set; }

        [Action ("UpdateProfileButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UpdateProfileButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (profileBDate != null) {
                profileBDate.Dispose ();
                profileBDate = null;
            }

            if (profileCountry != null) {
                profileCountry.Dispose ();
                profileCountry = null;
            }

            if (profileEmail != null) {
                profileEmail.Dispose ();
                profileEmail = null;
            }

            if (profileFName != null) {
                profileFName.Dispose ();
                profileFName = null;
            }

            if (profileLName != null) {
                profileLName.Dispose ();
                profileLName = null;
            }

            if (profilePassword != null) {
                profilePassword.Dispose ();
                profilePassword = null;
            }

            if (profileZipCode != null) {
                profileZipCode.Dispose ();
                profileZipCode = null;
            }

            if (updateProfileButton != null) {
                updateProfileButton.Dispose ();
                updateProfileButton = null;
            }
        }
    }
}