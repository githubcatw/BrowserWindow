using UnityEngine;
using NT.Android;

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
            BWAndroidOpener.Open(url);
        }
#else
        // Default to opening the URL in a standard browser
        public static void Open(string url) {
            Application.OpenURL(url);
        }
#endif
    }
}