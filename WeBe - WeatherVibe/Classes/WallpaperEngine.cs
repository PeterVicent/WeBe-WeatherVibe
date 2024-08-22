using System.Diagnostics;

namespace WeBe___WeatherVibe.Classes
{
    public static class WallpaperEngine
    {
        public static string ExecutablePath {  get; set; }

        internal static bool StartAndSetProfile(string profile)
        {
            try
            {
                var proc = Process.Start(ExecutablePath, $"-control openProfile -profile \"{profile}\"");

                return true;
            }
            catch { return false; }
        }
    }
}
