package dev.torosyan

import android.content.Context
import android.graphics.Color
import android.net.Uri
import androidx.browser.customtabs.CustomTabColorSchemeParams
import androidx.browser.customtabs.CustomTabsIntent
import androidx.browser.customtabs.CustomTabsIntent.COLOR_SCHEME_SYSTEM

class BrowserWindow {

    fun OpenWindow(url: String, context: Context) {
        // TODO open webview when no chrome
        OpenCct(url, context, null)
    }
    fun OpenWindow(url: String, context: Context, config: BWCustomConfiguration?) {
        // TODO open webview when no chrome
        OpenCct(url, context, config)
    }
    fun OpenCct(url: String, context: Context, config: BWCustomConfiguration? = null) {
        // Chrome custom tab
        val builder = CustomTabsIntent.Builder()
        // show website title
        builder.setShowTitle(true)
        // apply config
        if (config != null) {
            if (config.colorCode.isNotEmpty()) {
                val colorScheme: CustomTabColorSchemeParams = CustomTabColorSchemeParams.Builder()
                    .setToolbarColor(Color.parseColor(config.colorCode))
                    .build()
                builder.setDefaultColorSchemeParams(colorScheme)
            }
            if (config.noShare) {
                builder.setShareState(CustomTabsIntent.SHARE_STATE_OFF)
            }
            builder.setStartAnimations(context, config.enterS, config.exitS)
            builder.setExitAnimations(context, config.enterE, config.exitE)
        } else {
            // animation for enter and exit of tab
            builder.setStartAnimations(context, android.R.anim.fade_in, android.R.anim.fade_out)
            builder.setExitAnimations(context, android.R.anim.fade_in, android.R.anim.fade_out)
        }
        builder.build().launchUrl(context, Uri.parse(url))
    }
}

class BWCustomConfiguration {
    var colorCode: String = ""
    var noShare: Boolean = false

    var enterS: Int = android.R.anim.fade_in
    var enterE: Int = android.R.anim.fade_in
    var exitS: Int = android.R.anim.fade_out
    var exitE: Int = android.R.anim.fade_out

    fun SetColorCode(color: String) {
        colorCode = color
    }
    fun DisableSharing() {
        noShare = true
    }

    fun SetStartAnimations(enter: Int, exit: Int) {
        enterS = enter
        exitS = exit
    }
    fun SetExitAnimations(enter: Int, exit: Int) {
        enterE = enter
        exitE = exit
    }
}