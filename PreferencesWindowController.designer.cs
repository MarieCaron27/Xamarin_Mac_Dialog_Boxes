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
	[Register ("PreferencesWindowController")]
	partial class PreferencesWindowController
	{
		[Outlet]
		AppKit.NSToolbar ToolBar { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ToolBar != null) {
				ToolBar.Dispose ();
				ToolBar = null;
			}

		}
	}
}
