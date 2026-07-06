// WARNING
// This file has been generated automatically by Rider IDE to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface SheetViewController : NSViewController {
	NSTextField *_PasswordLabel;
	NSTextField *_PasswordTxtField;
	NSImageView *_ProfileImageView;
	NSTextField *_UsernameLabel;
	NSTextField *_UsernameTxtField;
}

@property (nonatomic, retain) IBOutlet NSTextField *PasswordLabel;

@property (nonatomic, retain) IBOutlet NSTextField *PasswordTxtField;

@property (nonatomic, retain) IBOutlet NSImageView *ProfileImageView;

@property (nonatomic, retain) IBOutlet NSTextField *UsernameLabel;

@property (nonatomic, retain) IBOutlet NSTextField *UsernameTxtField;

- (IBAction)CancelBtn:(id)sender;

- (IBAction)OKBtn:(id)sender;

@end
