using NT.Android;
using UnityEngine;
using UnityEngine.UI;

namespace NT.Samples {
    public class BrowserWindowSample : MonoBehaviour {

        public InputField URLField;
        public Button OpenButton;
        public Button AdvancedSettingsOpener;
        public Button OpenColoredButton;
        public Button OpenSlideButton;

        void Start() {
            // Add some listeners
            URLField.onValueChanged.AddListener(InputValueChanged);
            OpenButton.onClick.AddListener(Open);
            OpenColoredButton.onClick.AddListener(OpenColored);
            OpenSlideButton.onClick.AddListener(OpenSlide);
        }

        // This is the main function that calls BrowserWindow.
        void Open() {
            // Get the text
            string url = URLField.text;
            // If there is no "http" in the start, add it
            if (!url.StartsWith("http")) url = "http://" + url;
            // Open browser window
            BrowserWindow.Open(url);
        }

        // This is a simple function that disables the input field
        // if there is no URL.
        void InputValueChanged(string text) {
            OpenButton.interactable = text.Length > 0;
        }

        #region Advanced settings
        // This is a function that calls BrowserWindow with a config.
        void OpenColored() {
            // Get the text
            string url = URLField.text;
            // If there is no "http" in the start, add it
            if (!url.StartsWith("http")) url = "http://" + url;
            // Create a config
            BWAndroidConfig androidConfig = new BWAndroidConfig();
            androidConfig.SetColor(Color.blue);
            // Create a BrowserWindow instance
            BrowserWindow window = new BrowserWindow();
            window.SetAndroidConfig(androidConfig);
            // Open browser window
            window.CustomOpen(url);
        }

        // This is a function that calls BrowserWindow with a config
        // telling it that the window has to slide in from the left.
        void OpenSlide() {
            // Get the text
            string url = URLField.text;
            // If there is no "http" in the start, add it
            if (!url.StartsWith("http")) url = "http://" + url;
            // Create a config
            BWAndroidConfig androidConfig = new BWAndroidConfig();
            // Set the animations
            androidConfig.SetStartAnimations(BWAndroidAnimations.SlideLeft);
            androidConfig.SetExitAnimations(BWAndroidAnimations.SlideLeft);
            // Create a BrowserWindow instance
            BrowserWindow window = new BrowserWindow();
            window.SetAndroidConfig(androidConfig);
            // Open browser window
            window.CustomOpen(url);
        }
        #endregion
    }
}