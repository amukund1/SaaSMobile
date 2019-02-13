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
    [Register ("StudyDetailViewController")]
    partial class StudyDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel studyDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel studyName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel studyOwner { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton studyRegisterButton { get; set; }

        [Action ("StudyRegisterButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StudyRegisterButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (studyDescription != null) {
                studyDescription.Dispose ();
                studyDescription = null;
            }

            if (studyName != null) {
                studyName.Dispose ();
                studyName = null;
            }

            if (studyOwner != null) {
                studyOwner.Dispose ();
                studyOwner = null;
            }

            if (studyRegisterButton != null) {
                studyRegisterButton.Dispose ();
                studyRegisterButton = null;
            }
        }
    }
}