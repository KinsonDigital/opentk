using OpenTK.Windowing.Desktop;
using System;

namespace Test_App
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var gameWinSettings = new GameWindowSettings();
            var nativeWinSettings = new NativeWindowSettings();

            var window = new GameWindow(gameWinSettings, nativeWinSettings);

            window.Run();
        }
    }
}
