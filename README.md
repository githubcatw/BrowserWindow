# Browser Window
Library for opening web browser windows from Unity.

## Installation
This repository is a Unity package. Add this repository as a git package to your project from the Package Manager, install [Google's External Dependency Manager](https://github.com/googlesamples/unity-jar-resolver) and resolve Android packages to install the native dependencies.

After that it's as simple as calling `BrowserWindow.Open` to open a URL:
```c#
string repo = "https://github.com/githubcatw/BrowserWindow";
BrowserWindow.Open(repo);
```

## Customization
Browser windows can be customized, with different settings depending on the platform. For this an object with the class `BrowserWindow` needs to be created, as well as a platform-specific configuration.

Here's an example for changing colors of Chrome custom tabs on Android
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

## FAQ

### Q: What platforms are supported?
A. Currently the library only supports custom windows on Android, and calls Unity's `Application.OpenURL` method on other platforms. iOS `SFSafariViewController` support is planned.

### Q: When using ProGuard there is a missing plugin error!
A. Enable the custom proguard-user file if it's off, and add this to `Plugins/Android/proguard-user.txt`:
```
-keep public class dev.torosyan.** { *; }
```
