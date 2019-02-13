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
        UIKit.UIButton joinStudyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView RegisteredStudiesTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView studiesScreen { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (joinStudyButton != null) {
                joinStudyButton.Dispose ();
                joinStudyButton = null;
            }

            if (RegisteredStudiesTableView != null) {
                RegisteredStudiesTableView.Dispose ();
                RegisteredStudiesTableView = null;
            }

            if (studiesScreen != null) {
                studiesScreen.Dispose ();
                studiesScreen = null;
            }
        }
    }
}