// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BaitNews.iOS
{
    [Register ("SettingsViewController")]
    partial class SettingsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblBuildVersion { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblBuildVersion != null) {
                lblBuildVersion.Dispose ();
                lblBuildVersion = null;
            }
        }
    }
}