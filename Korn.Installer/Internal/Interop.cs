using System.Runtime.InteropServices;

static class Interop
{
    const string gdi = "gdi32";

    [DllImport(gdi)] public static extern 
        nint CreateRoundRectRgn(int left, int top, int right, int bottom, int cornerWidth, int cornerHeight);
}