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
            // If we have a config, apply it and call the native function
            if (config != null) {
                AndroidJavaObject nativeConfig = CreateNativeConfig(config);
                native.Call("OpenWindow", url, unityActivity, nativeConfig);
            }
            // Call the plugin with the URL
            else native.Call("OpenWindow", url, unityActivity);
        }

        private static AndroidJavaObject CreateNativeConfig(BWAndroidConfig config) {
            // Retrieve the class from our native plugin
            AndroidJavaObject nativeConfig = new AndroidJavaObject("dev.torosyan.BWCustomConfiguration");
            // Set color code
            if (config.ColorCode != null)
                nativeConfig.Call("SetColorCode", config.ColorCode);
            // Set no sharing flag
            if (config.NoSharing)
                nativeConfig.Call("DisableSharing");
            // Set anims
            if (config.StartAnim != null)
                nativeConfig.Call("SetStartAnimations", config.StartAnim.EntranceID, config.StartAnim.ExitID);
            if (config.ExitAnim != null)
                nativeConfig.Call("SetExitAnimations", config.ExitAnim.EntranceID, config.ExitAnim.ExitID);
            // Return the resulting config
            return nativeConfig;
        }
    }
}