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
        UIKit.UITextField firstNameTextF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView registerScreen { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (firstNameTextF != null) {
                firstNameTextF.Dispose ();
                firstNameTextF = null;
            }

            if (registerScreen != null) {
                registerScreen.Dispose ();
                registerScreen = null;
            }
        }
    }
}