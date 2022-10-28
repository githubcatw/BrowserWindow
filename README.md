# Browser Window
Library for opening Chrome custom tabs from Unity.

## Installation
This repository is a Unity package. Add this repository as a git package to your project from the Package Manager, install [Google's External Dependency Manager](https://github.com/googlesamples/unity-jar-resolver) and resolve Android packages to install the native dependencies.

After that it's as simple as calling `BrowserWindow.Open` to open a URL:
```c#
string repo = "https://github.com/githubcatw/BrowserWindow";
BrowserWindow.Open(repo);
```

## FAQ

### Q: What platforms are supported?
A. Currently the library only supports custom windows on Android, and calls Unity's `Application.OpenURL` method on other platforms. iOS `SFSafariViewController` support is planned.

### Q: When using ProGuard there is a missing plugin error!
A. Enable the custom proguard-user file if it's off, and add this to `Plugins/Android/proguard-user.txt`:
```
-keep public class dev.torosyan.** { *; }
```
