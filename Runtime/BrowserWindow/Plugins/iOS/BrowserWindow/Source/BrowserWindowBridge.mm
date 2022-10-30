// BrowserWindow iOS plugin Obj-C bridge
// (c) 2022 Narek

#import <Foundation/Foundation.h>
#include "UnityFramework/UnityFramework-Swift.h"

extern UIViewController * UnityGetGLViewController();

extern "C" {
    
#pragma mark - Functions
    
    // cstring to NSString converter
    NSString* CreateNSString (const char* string) {
      if (string)
        return [NSString stringWithUTF8String: string];
      else
            return [NSString stringWithUTF8String: ""];
    }

    void _openBW(char* url) {
        // Get the Unity view controller
        UIViewController * uvc = UnityGetGLViewController();
        // Call Swift side
        [[BrowserWindow shared] OpenWindowWithUrl:CreateNSString(url) vc:uvc];
    }
}
