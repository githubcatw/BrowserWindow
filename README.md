# Browser Window
Library for opening web browser windows on various platforms from Unity.

## Installation
This repository is a Unity package. [Add it as a Git package](https://docs.unity3d.com/Manual/upm-ui-giturl.html) to your project from the Package Manager.

If you plan to develop for Android, install [Google's External Dependency Manager](https://github.com/googlesamples/unity-jar-resolver) and resolve Android packages to install the native dependencies.

## Usage
Simply call `BrowserWindow.Open` to open a URL:
```c#
string repo = "https://github.com/githubcatw/BrowserWindow";
BrowserWindow.Open(repo);
```
You can also check out the [wiki](https://github.com/githubcatw/BrowserWindow/wiki) for full documentation. If you prefer learning by example or want to look at an example of usage check out the [Basic Sample](https://github.com/githubcatw/BrowserWindow/tree/main/Samples~/BWSample) provided with the package.

### Customization
Browser windows can be customized, with different settings depending on the platform. For this an object with the class `BrowserWindow` needs to be created, as well as a platform-specific configuration.

Here's an example for changing colors of Chrome custom tabs on Android:
```c#
// Create an Android configuration
BWAndroidConfig androidConfig = new BWAndroidConfig();
// Set the color of the window to blue
androidConfig.SetColor(Color.blue);
// Create a BrowserWindow object and set the Android config
BrowserWindow window = new BrowserWindow();
window.SetAndroidConfig(androidConfig);
```

After that it's as simple as calling `CustomOpen` on the object to open a URL with the preferred settings:
```c#
string repo = "https://github.com/githubcatw/BrowserWindow";
window.CustomOpen(repo);
```

In this example, the code above will launch a blue custom tab pointing to this repository on Android, and a regular browser window on other platforms.

For more information about customization check out the [wiki page on platform specific customization](https://github.com/githubcatw/BrowserWindow/wiki/Platform-specific-customization).

## FAQ

### Q. What platforms are supported?
A. Currently the library supports:
- Chrome custom tabs on Android,
- `SFSafariViewController` on iOS,
- Unity's `Application.OpenURL` method on other platforms.

### Q. When using ProGuard there is a missing plugin error!
A. Enable the custom proguard-user file if it's off, and add this to `Plugins/Android/proguard-user.txt`:
```
-keep public class dev.torosyan.** { *; }
```

## Q. Are there any licensing restrictions?
A. Browser Window is licensed under the MIT license, meaning that you can use it in a closed source project. If you make changes and think that other developers might like them too, feel free to contribute.
