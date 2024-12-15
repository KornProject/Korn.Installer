static class ControlUtils
{
    public static void SetRoundCorners(Control control, int cornerSize)
        => control.Region = GraphicsUtils.GetRoundRectangle(Point.Empty, control.ClientSize, cornerSize);

    public static void SetRoundCorners(Control[] controls, int cornerSize)
    {
        foreach (var control in controls)
            SetRoundCorners(control, cornerSize);
    }
}