// BrowserWindow native plugin for iOS
// (c) 2022-2023 Narek

import Foundation
import SafariServices

@objc public class BrowserWindow : NSObject {
    
    @objc public static let shared = BrowserWindow()
    public var sfvc: SFSafariViewController? = nil
    
    @objc public func OpenWindow(url: String, vc: UIViewController) {
        sfvc = SFSafariViewController(url: URL(string: url)!)
        vc.present(sfvc!, animated: true)
    }
    
    @objc public func CloseWindow() {
        if (sfvc != nil) {
            sfvc!.dismiss(animated: true)
        } else {
            print("CloseWindow: Safari VC is nil, have you opened a BrowserWindow yet?")
        }
    }
}
