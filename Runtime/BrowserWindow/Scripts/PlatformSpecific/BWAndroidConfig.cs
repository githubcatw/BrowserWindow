using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NT.Android {
    public class BWAndroidConfig : BWPlatformConfig {

        public string ColorCode { get; private set; }
        public bool NoSharing { get; private set; }
        public BWAndroidAnimations StartAnim { get; private set; }
        public BWAndroidAnimations ExitAnim { get; private set; }

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

        /// <summary>
        /// Sets the browser window's entrance animation.
        /// </summary>
        public void SetStartAnimations(BWAndroidAnimations animations) {
            StartAnim = animations;
        }

        /// <summary>
        /// Sets the browser window's exit animation.
        /// </summary>
        public void SetExitAnimations(BWAndroidAnimations animations) {
            ExitAnim = animations;
        }

        /// <summary>
        /// Sets the start and exit animations of this browser window.
        /// </summary>
        /// <param name="start">the start animations</param>
        /// <param name="exit">the exit animations</param>
        public void SetAnimations(BWAndroidAnimations start, BWAndroidAnimations exit) { 
            SetStartAnimations(start);
            SetExitAnimations(exit);
        }
    }
}