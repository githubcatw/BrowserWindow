using System.Runtime.InteropServices;

namespace NT.iOS {
    public class BWiOSOpener {
        [DllImport("__Internal")]
        private static extern void _openBW(string url);

        public static void Open(string url) {
            _openBW(url);
        }
    }
}