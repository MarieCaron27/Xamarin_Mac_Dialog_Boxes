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
	[Register ("SheetViewController")]
	partial class SheetViewController
	{
		[Outlet]
		AppKit.NSTextField PasswordLabel { get; set; }

		[Outlet]
		AppKit.NSTextField PasswordTxtField { get; set; }

		[Outlet]
		AppKit.NSImageView ProfileImageView { get; set; }

		[Outlet]
		AppKit.NSTextField UsernameLabel { get; set; }

		[Outlet]
		AppKit.NSTextField UsernameTxtField { get; set; }

		[Action ("CancelBtn:")]
		partial void CancelBtn (Foundation.NSObject sender);

		[Action ("OKBtn:")]
		partial void OKBtn (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (PasswordLabel != null) {
				PasswordLabel.Dispose ();
				PasswordLabel = null;
			}

			if (PasswordTxtField != null) {
				PasswordTxtField.Dispose ();
				PasswordTxtField = null;
			}

			if (ProfileImageView != null) {
				ProfileImageView.Dispose ();
				ProfileImageView = null;
			}

			if (UsernameLabel != null) {
				UsernameLabel.Dispose ();
				UsernameLabel = null;
			}

			if (UsernameTxtField != null) {
				UsernameTxtField.Dispose ();
				UsernameTxtField = null;
			}

		}
	}
}
