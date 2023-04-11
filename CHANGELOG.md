# 1.2
This is a minor feature release for Browser Window.

## Closing browser windows
On some platforms, like iOS, apps have to manually tell the OS to close a browser window. This update adds a way to do this in Unity with the `BrowserWindow.Close()` method.

This currently works on iOS only.

## Android specific changes
### Disabling the Share button
Chrome custom tabs open with a share button by default. To prevent this, use `BWAndroidConfig.DisableSharing()`. Pretty simple.

### Animations
The transitions between a browser window and the game can now be changed using new methods in `BWAndroidConfig`: `SetAnimations`, `SetStartAnimation` and `SetExitAnimation`.

For this feature a `BWAndroidAnimation` class has been added. The library also comes with 2 preset animations:
| <img alt="A GIF showing a Chrome window with example.com fading in" src="https://raw.githubusercontent.com/githubcatw/BrowserWindow/dev/DocumentationAssets/animation_fade.gif" width="300px"/> | <img alt="A GIF showing a Chrome window with example.com sliding in" src="https://raw.githubusercontent.com/githubcatw/BrowserWindow/dev/DocumentationAssets/animation_slide.gif" width="300px"/> |
| --- | --- |
| `BWAndroidAnimations.Fade` | `BWAndroidAnimations.SlideLeft` |

For more information see the [documentation](https://github.com/githubcatw/BrowserWindow/wiki/Android-platform-specific-customization#bwandroidconfigsetanimationsbwandroidanimations-bwandroidanimations).

# 1.1
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

# 1.0
- Initial release. 
