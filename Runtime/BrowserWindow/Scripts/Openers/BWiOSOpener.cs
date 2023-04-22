using System.Runtime.InteropServices;

namespace NT.iOS {
    public class BWiOSOpener {
#if UNITY_IPHONE
        [DllImport("__Internal")]
        private static extern void _openBW(string url);
        [DllImport("__Internal")]
        private static extern void _closeBW();

        public static void Open(string url) {
            _openBW(url);
        }
        public static void Close() {
            _closeBW();
        }
#endif
    }
}