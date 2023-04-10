using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NT.Android {
    public class BWAndroidConfig : BWPlatformConfig {

        public string ColorCode { get; private set; }
        public bool NoSharing { get; private set; }

        /// <summary>
        /// Sets the color of the browser window's title.
        /// </summary>
        /// <param name="color">The color to use.</param>
        public void SetColor(Color color) {
            ColorCode = "#" + ColorUtility.ToHtmlStringRGB(color);
        }

        /// <summary>
        /// Disables the Share function of the browser window.
        /// </summary>
        public void DisableSharing() {
            NoSharing = true;
        }
    }
}