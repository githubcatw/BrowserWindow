// BrowserWindow native plugin for iOS
// (c) 2022 Narek

import Foundation
import SafariServices

@objc public class BrowserWindow : NSObject {
    
    @objc public static let shared = BrowserWindow()
    @objc public func OpenWindow(url: String, vc: UIViewController) {
        let sf = SFSafariViewController(url: URL(string: url)!)
        vc.present(sf, animated: true)
    }
}
