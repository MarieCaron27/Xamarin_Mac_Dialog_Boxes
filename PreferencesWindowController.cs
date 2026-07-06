namespace boites_dialogue
{
	public partial class PreferencesWindowController : NSWindowController
	{
		#region Constructors
		public PreferencesWindowController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Override Methods
		public override void WindowDidLoad ()
		{
			base.WindowDidLoad ();

			// Initialize
			Window.Delegate = new PreferenceWindowDelegate(Window);
			ToolBar.SelectedItemIdentifier = "General";
		}
		#endregion
	}
}
