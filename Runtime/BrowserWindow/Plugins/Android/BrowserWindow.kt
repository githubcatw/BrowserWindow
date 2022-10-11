package dev.torosyan

import android.content.Context
import android.net.Uri
import androidx.browser.customtabs.CustomTabsIntent

class BrowserWindow {
    fun OpenWindow(url: String, context: Context) {
        // TODO open webview when no chrome
        OpenCct(url, context)
    }
    fun OpenCct(url: String, context: Context) {
        // Chrome custom tab
        val builder = CustomTabsIntent.Builder()
        // show website title
        builder.setShowTitle(true)
        // animation for enter and exit of tab
        builder.setStartAnimations(context, android.R.anim.fade_in, android.R.anim.fade_out)
        builder.setExitAnimations(context, android.R.anim.fade_in, android.R.anim.fade_out)
        builder.build().launchUrl(context, Uri.parse(url))
    }
}