// <copyright file="ConvertAlignToBootstrapString.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Enumeration
{
    /// <summary>
    /// Helpt de enumeratie om string te worden.
    /// </summary>
    public static class ConvertAlignToBootstrapString
    {
        /// <summary>
        /// Zet de vertical align tot string om.
        /// </summary>
        /// <param name="verticlaAlign">Waar een element wordt geplaatst.// Vertical.</param>
        /// <returns>De vertival aligan enum als string.</returns>
        public static string ToBootstrap(this VerticalAlign verticlaAlign)
        {
            switch (verticlaAlign)
            {
                case VerticalAlign.Top:
                    return "start";
                case VerticalAlign.Center:
                    return "center";
                case VerticalAlign.Bottom:
                    return "end";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Zet de horizontal align tot string om.
        /// </summary>
        /// <param name="horizontal">Waar een element wordt geplaatst.// horizontal.</param>
        /// <returns>De horizontal aligan enum als string.</returns>
        public static string ToBootstrap(this HorizontalAlign horizontal)
        {
            switch (horizontal)
            {
                case HorizontalAlign.Left:
                    return "start";
                case HorizontalAlign.Center:
                    return "center";
                case HorizontalAlign.Right:
                    return "end";
                default:
                    return string.Empty;
            }
        }
    }
}
