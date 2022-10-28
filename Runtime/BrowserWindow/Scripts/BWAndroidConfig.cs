using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NT.BrowserWindow.Android {
    public class BWAndroidConfig : BWPlatformConfig {
        
        public string ColorCode { get; private set; }

        /// <summary>
        /// Sets the color of the browser window's title.
        /// </summary>
        /// <param name="color">The color to use.</param>
        public void SetColor(Color color) {
            ColorCode = "#" + ColorUtility.ToHtmlStringRGB(color);
        }
    }
}