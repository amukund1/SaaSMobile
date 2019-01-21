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
    [Register ("StudiesViewController")]
    partial class StudiesViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView studiesScreen { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (studiesScreen != null) {
                studiesScreen.Dispose ();
                studiesScreen = null;
            }
        }
    }
}