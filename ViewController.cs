using ObjCRuntime;

namespace boites_dialogue;

public partial class ViewController : NSViewController
{
    public static AppDelegate App {
        get { return (AppDelegate)NSApplication.SharedApplication.Delegate; }
    }
    
    protected ViewController(NativeHandle handle) : base(handle)
    {
        // This constructor is required if the view controller is loaded from a xib or a storyboard.
        // Do not put any initialization here, use ViewDidLoad instead.
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        // Do any additional setup after loading the view.
    }

    public override NSObject RepresentedObject
    {
        get => base.RepresentedObject;
        set
        {
            base.RepresentedObject = value;

            // Update the view, if already loaded.
            ConfigureEditor();
        }
    }
    
    public void ConfigureEditor() {

        // General Preferences
        TextEditor.Enabled = App.Preferences.SmartLinks;
        TextEditor.Enabled = App.Preferences.SmartQuotes;
    }
    
    public override void PrepareForSegue (NSStoryboardSegue segue, NSObject sender)
    {
        base.PrepareForSegue (segue, sender);

        // Take action based on the segue name
        switch (segue.Identifier) {
            case "ModalSegue":
                var dialog = segue.DestinationController as CustomDialogController;
                dialog.DialogTitle = "MacDialog";
                dialog.DialogDescription = "This is a sample dialog.";
                dialog.DialogAccepted += (s, e) => {
                    Console.WriteLine ("Dialog accepted");
                    DismissViewController (dialog);
                };
                dialog.Presentor = this;
                break;
            case "SheetSegue":
                var sheet = segue.DestinationController as SheetViewController;
                sheet.SheetAccepted += (s, e) => {
                    Console.WriteLine ("User Name: {0} Password: {1}", sheet.UserName, sheet.Password);
                };
                sheet.Presentor = this;
                break;
        }
    }
}