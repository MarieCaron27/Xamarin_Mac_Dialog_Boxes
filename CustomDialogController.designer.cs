// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace boites_dialogue
{
	[Register ("CustomDialogController")]
	partial class CustomDialogController
	{
		[Outlet]
		AppKit.NSTextField DescriptionTxtField { get; set; }

		[Outlet]
		AppKit.NSImageView GlobalImagView { get; set; }

		[Outlet]
		AppKit.NSTextField TitleTxtField { get; set; }

		[Action ("CancelBtn:")]
		partial void CancelBtn (Foundation.NSObject sender);

		[Action ("OKBtn:")]
		partial void OKBtn (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (DescriptionTxtField != null) {
				DescriptionTxtField.Dispose ();
				DescriptionTxtField = null;
			}

			if (GlobalImagView != null) {
				GlobalImagView.Dispose ();
				GlobalImagView = null;
			}

			if (TitleTxtField != null) {
				TitleTxtField.Dispose ();
				TitleTxtField = null;
			}

		}
	}
}
