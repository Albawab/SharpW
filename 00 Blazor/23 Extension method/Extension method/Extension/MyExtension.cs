namespace Extension_method.Extension
{
    public static class MyExtension
    {
        public static string ToBootstrap(this HorizontalAlign horizontal)
        {
            return horizontal switch
            {
                HorizontalAlign.Left => "start",
                HorizontalAlign.Center => "center",
                HorizontalAlign.Right => "end",
                _ => string.Empty,
            };
        }
    }
}
