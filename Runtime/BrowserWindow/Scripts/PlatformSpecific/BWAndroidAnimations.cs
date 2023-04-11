using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NT.Android {
    /// <summary>
    /// Entrance and exit animations.
    /// </summary>
    public class BWAndroidAnimations {
        /// <summary>
        /// The resource ID of the entrance animation.
        /// </summary>
        public int EntranceID;
        /// <summary>
        /// The resource ID of the exit animation.
        /// </summary>
        public int ExitID;

        /// <summary>
        /// Equal to android.R.anim.slide_in_left.
        /// </summary>
        public const int R_SLIDE_IN_LEFT = 0x010a0002;
        /// <summary>
        /// Equal to android.R.anim.slide_out_right.
        /// </summary>
        public const int R_SLIDE_OUT_RIGHT = 0x010a0003;
        /// <summary>
        /// Equal to android.R.anim.fade_in.
        /// </summary>
        public const int R_FADE_IN = 0x010a0000;
        /// <summary>
        /// Equal to android.R.anim.fade_out.
        /// </summary>
        public const int R_FADE_OUT = 0x010a0001;

        public BWAndroidAnimations(int entranceID, int exitID) { 
            this.EntranceID = entranceID;
            this.ExitID = exitID;
        }
        
        /// <summary>
        /// Simple fade animations.
        /// </summary>
        public static readonly BWAndroidAnimations Fade
            = new BWAndroidAnimations(R_FADE_IN, R_FADE_OUT);

        /// <summary>
        /// Sliding in from the left.
        /// </summary>
        public static readonly BWAndroidAnimations SlideLeft
            = new BWAndroidAnimations(R_SLIDE_IN_LEFT, R_SLIDE_OUT_RIGHT);
    }
}