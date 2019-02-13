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
    [Register ("SelectedStudyDetailViewController")]
    partial class SelectedStudyDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selectedStudyContactInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selectedStudyDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selectedStudyName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (selectedStudyContactInfo != null) {
                selectedStudyContactInfo.Dispose ();
                selectedStudyContactInfo = null;
            }

            if (selectedStudyDescription != null) {
                selectedStudyDescription.Dispose ();
                selectedStudyDescription = null;
            }

            if (selectedStudyName != null) {
                selectedStudyName.Dispose ();
                selectedStudyName = null;
            }
        }
    }
}