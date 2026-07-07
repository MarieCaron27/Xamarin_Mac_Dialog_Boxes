namespace boites_dialogue
{
    [Register ("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public bool ShowPrintAsSheet { get; set;} = true;
        public bool ShowSaveAsSheet { get; set;} = true;
        
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
            dlg.AllowedFileTypes = new string[] { "txt", "html", "md", "css", "cs" };

            if (dlg.RunModal() == 1)
            {
                var url = dlg.Urls[0];

                if (url != null)
                {
                    var path = url.Path;

                    var storyboard = NSStoryboard.FromName("Main", null);
                    var controller = storyboard.InstantiateInitialController() as NSWindowController;

                    controller.ShowWindow(this);

                    var viewController = controller.Window.ContentViewController as ViewController;

                    viewController.Text = File.ReadAllText(path);
                    viewController.View.Window.SetTitleWithRepresentedFilename(Path.GetFileName(path));
                    viewController.View.Window.RepresentedUrl = url;
                }
            }
        }
        
        [Export ("showPrinter:")]
        void ShowDocument (NSObject sender) {
            var dlg = new NSPrintPanel();
            var storyboard = NSStoryboard.FromName("Main", null);
            var controller = storyboard.InstantiateInitialController() as NSWindowController;

            // Display the print dialog as dialog box
            if (ShowPrintAsSheet) {
                dlg.BeginSheet(new NSPrintInfo(),controller.Window,this,null,new IntPtr());
            } else {
                if (dlg.RunModalWithPrintInfo(new NSPrintInfo()) == 1) {
                    var alert = new NSAlert () {
                        AlertStyle = NSAlertStyle.Critical,
                        InformativeText = "We need to print the document here...",
                        MessageText = "Print Document",
                    };
                    alert.RunModal ();
                }
            }
        }
        
        [Export ("showLayout:")]
        void ShowLayout (NSObject sender) {
            var dlg = new NSPageLayout();
            var storyboard = NSStoryboard.FromName("Main", null);
            var controller = storyboard.InstantiateInitialController() as NSWindowController;

            // Display the print dialog as dialog box
            if (ShowPrintAsSheet) {
                dlg.BeginSheet (new NSPrintInfo (), controller.Window);
            } else {
                if (dlg.RunModal () == 1) {
                    var alert = new NSAlert () {
                        AlertStyle = NSAlertStyle.Critical,
                        InformativeText = "We need to print the document here...",
                        MessageText = "Print Document",
                    };
                    alert.RunModal ();
                }
            }
        }
        
        [Export("saveDocumentAs:")]
        void ShowSaveAs (NSObject sender)
        {
            var dlg = new NSSavePanel ();
            dlg.Title = "Save Text File";
            dlg.AllowedFileTypes = new string[] { "txt", "html", "md", "css" };
            var storyboard = NSStoryboard.FromName("Main", null);
            var controller = storyboard.InstantiateInitialController() as NSWindowController;

            if (ShowSaveAsSheet) {
                dlg.BeginSheet(controller.Window,(result) => {
                    var alert = new NSAlert () {
                        AlertStyle = NSAlertStyle.Critical,
                        InformativeText = "We need to save the document here...",
                        MessageText = "Save Document",
                    };
                    alert.RunModal ();
                });
            } else {
                if (dlg.RunModal () == 1) {
                    var alert = new NSAlert () {
                        AlertStyle = NSAlertStyle.Critical,
                        InformativeText = "We need to save the document here...",
                        MessageText = "Save Document",
                    };
                    alert.RunModal ();
                }
            }

        }
    }
}