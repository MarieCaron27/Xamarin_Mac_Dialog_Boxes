namespace boites_dialogue
{
    [Register ("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        #region Computed Properties
        public int NewWindowNumber { get; set;} = -1;

        public AppPreferences Preferences { get; set; } = new AppPreferences();
        #endregion

        #region Constructors
        public AppDelegate ()
        {
        }
        #endregion

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
        
        #region Application Access
        public static AppDelegate App {
            get { return (AppDelegate)NSApplication.SharedApplication.Delegate; }
        }
        #endregion
        
        public void UpdateWindowPreferences()
        {
            foreach (var window in NSApplication.SharedApplication.AccessibilityWindows)
            {
                var content = window.Self as ViewController;

                if (content != null)
                {
                    content.ConfigureEditor();
                }
            }
        }
        
        [Export("openDocument:")]
        void OpenDialog(NSObject sender)
        {
            var dlg = NSOpenPanel.OpenPanel;
            dlg.CanChooseFiles = true;
            dlg.CanChooseDirectories = false;
            dlg.AllowedFileTypes = new string[] { "txt", "html", "md", "css" };

            if (dlg.RunModal() == 1)
            {
                var url = dlg.Urls[0];

                if (url != null)
                {
                    var path = url.Path;

                    var storyboard = NSStoryboard.FromName("Main", null);
                    var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;

                    controller.ShowWindow(this);

                    var viewController = controller.Window.ContentViewController as ViewController;

                    viewController.Text = File.ReadAllText(path);
                    viewController.View.Window.SetTitleWithRepresentedFilename(Path.GetFileName(path));
                    viewController.View.Window.RepresentedUrl = url;
                }
            }
        }
    }
}