using UnityEngine;
using NT.Android;
using NT.iOS;

namespace NT {
    /// <summary>
    /// Opens web browser windows.
    /// </summary>
    public class BrowserWindow {
        #region Open with default settings
        /// <summary>
        /// Open the system browser with the passed URL and default settings.
        /// </summary>
        /// <param name="url">The URL to open.</param>
#if UNITY_EDITOR
        // Editor - open the URL in a standard browser
        public static void Open(string url) {
            Application.OpenURL(url);
        }
#elif UNITY_IPHONE
        // iOS - use SKSafariViewController
        public static void Open(string url) {
            BWiOSOpener.Open(url);
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
        #endregion

        #region Close
        /// <summary>
        /// If a browser window is open, close it.
        /// </summary>
#if UNITY_EDITOR
        // Editor is unsupported
        public static void Close() {
            Debug.LogWarning("BrowserWindow.Close() is unsupported in the Editor.");
        }
#elif UNITY_IPHONE
        // iOS - use SKSafariViewController
        public static void Close() {
            BWiOSOpener.Close();
        }
#else
        // Any other platform is unsupported
        public static void Close() {
            Debug.LogError("BrowserWindow.Close() is unsupported on this platform.");
        }
#endif
        #endregion

        #region Setting a custom configuration
        /// <summary>
        /// The configuration for Android custom tabs.
        /// </summary>
        private BWAndroidConfig AndroidConfig;
        /// <summary>
        /// Sets the configuration for Android windows.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public void SetAndroidConfig(BWAndroidConfig config) {
            AndroidConfig = config;
        }
        #endregion

        #region Open with a custom configuration
        /// <summary>
        /// Open the system browser with the passed URL and settings.
        /// </summary>
        /// <param name="url">The URL to open.</param>
#if UNITY_EDITOR
        // Editor - open the URL in a standard browser
        public void CustomOpen(string url) {
            Application.OpenURL(url);
        }
#elif UNITY_ANDROID
        // Android - open Chrome custom tab with Android config
        public void CustomOpen(string url) {
            BWAndroidOpener.Open(url, AndroidConfig);
        }
#else
        // Default to Open() with no parameters
        public void CustomOpen(string url) {
            Open(url);
        }
#endif
        #endregion
    }
}