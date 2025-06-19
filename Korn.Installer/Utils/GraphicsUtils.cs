using Korn.Modules.WinApi;

static class GraphicsUtils
{
    public static nint GetNativeRoundRectangle(int left, int top, int right, int bottom, int size) 
        => Gdi32.CreateRoundRectRgn(left, top, right, bottom, size, size);

    public static Region GetRoundRectangle(Point location, Size size, int cornerSize) 
        => GetRoundRectangle(new Rectangle(location, size), cornerSize);

    public static Region GetRoundRectangle(Rectangle rectangle, int cornerSize) 
        => Region.FromHrgn(GetNativeRoundRectangle(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom, cornerSize));
}