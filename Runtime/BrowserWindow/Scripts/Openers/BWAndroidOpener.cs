using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NT.Android {
    public class BWAndroidOpener {
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
    }
}