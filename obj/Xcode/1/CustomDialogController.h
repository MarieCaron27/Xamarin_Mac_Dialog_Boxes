// WARNING
// This file has been generated automatically by Rider IDE to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface CustomDialogController : NSViewController {
	NSTextField *_DescriptionTxtField;
	NSImageView *_GlobalImagView;
	NSTextField *_TitleTxtField;
}

@property (nonatomic, retain) IBOutlet NSTextField *DescriptionTxtField;

@property (nonatomic, retain) IBOutlet NSImageView *GlobalImagView;

@property (nonatomic, retain) IBOutlet NSTextField *TitleTxtField;

- (IBAction)CancelBtn:(id)sender;

- (IBAction)OKBtn:(id)sender;

@end
