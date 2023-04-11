## 1.1
This is a feature release for Browser Window, featuring some improvements:
### Full iOS support
iOS `SKSafariViewController` is now supported. This means that, instead of just opening Safari, Browser Window will now show a custom window on iOS:

<img src="https://devimages-cdn.apple.com/wwdc-services/articles/images/5988B8A3-851E-41E2-9754-AAA6DD38A1B4/2048.jpeg" alt="A custom Safari window showing the Apple Developer site on an iPhone X" width="500px"/>

_(credit: Apple Developer)_

And you don't need to update your code - simply call `BrowserWindow.Open()` as usual.

### Platform configuration
Sometimes, a Browser Window implementation on one platform might support more features than one on another platform. To give developers the ability to control these options, 1.1 introduces platform-specific configuration.

<img src="https://user-images.githubusercontent.com/17374742/219452879-0765effc-d749-469c-b325-37f9f0cf3a6e.png" alt="2 Chrome custom tabs side by side: one with a default gray toolbar and one with a blue toolbar" width="500px"/>

As the name suggests, this is a way to configure platform-specific settings. This requires a slightly different way to call Browser Window functions - instead of just calling `BrowserWindow.Open()` you have to create an object and pass it the configuration:

```c#
// Create a BrowserWindow object and set the Android config
BrowserWindow window = new BrowserWindow();
// Create an Android configuration
BWAndroidConfig androidConfig = new BWAndroidConfig();

// Customize the Android configuration here.

// Set the Android configuration
window.SetAndroidConfig(androidConfig);

// Then, in your code, use:
window.CustomOpen("https://example.com");
```

Currently this is only supported on Android. To learn more and see more detailed examples and what settings are supported please read the [wiki page](https://github.com/githubcatw/BrowserWindow/wiki/Platform-specific-customization) on this feature.

## 1.0
- Initial release. 
