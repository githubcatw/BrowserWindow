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
        public static void Open(string url) {
#if UNITY_EDITOR
            // Editor - open the URL in a standard browser
            Application.OpenURL(url);
#elif UNITY_IPHONE
            // iOS - use SKSafariViewController
            BWiOSOpener.Open(url);
#elif UNITY_ANDROID
            // Android - open Chrome custom tab
            BWAndroidOpener.Open(url);
#else
            // Default to opening the URL in a standard browser
            Application.OpenURL(url);
#endif
        }
        #endregion

        #region Close
        /// <summary>
        /// If a browser window is open, close it.
        /// </summary>
        public static void Close() {
#if UNITY_EDITOR
            // Editor is unsupported
            Debug.LogWarning("BrowserWindow.Close() is unsupported in the Editor.");
#elif UNITY_IPHONE
            // iOS - use SKSafariViewController
            BWiOSOpener.Close();
#else
            // Any other platform is unsupported
            Debug.LogError("BrowserWindow.Close() is unsupported on this platform.");
#endif
        }
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

        public void CustomOpen(string url) {
#if UNITY_EDITOR
            // Editor - open the URL in a standard browser
            Application.OpenURL(url);
#elif UNITY_ANDROID
            // Android - open Chrome custom tab with Android config
            BWAndroidOpener.Open(url, AndroidConfig);
#else
            // Default to Open() with no parameters
            Open(url);
#endif
        }
        #endregion
    }
}