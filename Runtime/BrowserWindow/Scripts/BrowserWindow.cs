using UnityEngine;

namespace NT {
    /// <summary>
    /// Opens web browser windows.
    /// </summary>
    public static class BrowserWindow {
        /// <summary>
        /// Open the system browser with the passed URL.
        /// </summary>
        /// <param name="url">The URL to open.</param>
#if UNITY_EDITOR
        // Editor - open the URL in a standard browser
        public static void Open(string url) {
            Application.OpenURL(url);
        }
#elif UNITY_ANDROID
        // Android - open Chrome custom tab
        public static void Open(string url) {
            // Retrieve the UnityPlayer class
            AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            // Retrieve the UnityPlayerActivity object (the current context)
            AndroidJavaObject unityActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
            // Retrieve the class from our native plugin
            AndroidJavaObject native = new AndroidJavaObject("dev.torosyan.BrowserWindow");
            // Call the plugin with the URL
            var args = new object[] {
                url,
                unityActivity
            };
            native.Call("OpenWindow", args);
        }
#else
        // Default to opening the URL in a standard browser
        public static void Open(string url) {
            Application.OpenURL(url);
        }
#endif
    }
}