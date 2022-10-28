using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NT.Android {
    public class BWAndroidOpener {
        public static void Open(string url, BWAndroidConfig config = null) {
            // Retrieve the UnityPlayer class
            AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            // Retrieve the UnityPlayerActivity object (the current context)
            AndroidJavaObject unityActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
            // Retrieve the class from our native plugin
            AndroidJavaObject native = new AndroidJavaObject("dev.torosyan.BrowserWindow");
            // If we have a config, apply it
            if (config != null) {
                ApplyConfig(config, native);
            }
            // Call the plugin with the URL
            var args = new object[] {
                url,
                unityActivity
            };
            native.Call("OpenWindow", args);
        }

        private static void ApplyConfig(BWAndroidConfig config, AndroidJavaObject native) {
            if (config.ColorCode != "") {
                native.Call("SetColorCode", config.ColorCode);
            }
        }
    }
}