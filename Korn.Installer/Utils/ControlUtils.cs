static class ControlUtils
{
    public static void SetRoundCorners(Form control, int cornerSize)
        => control.Region = GraphicsUtils.GetRoundRectangle(Point.Empty, control.ClientSize, cornerSize);
}