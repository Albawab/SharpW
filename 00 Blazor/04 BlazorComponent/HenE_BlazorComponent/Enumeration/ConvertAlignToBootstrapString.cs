// <copyright file="ConvertAlignToBootstrapString.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Enumeration
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
            return verticlaAlign switch
            {
                VerticalAlign.Top => "start",
                VerticalAlign.Center => "center",
                VerticalAlign.Bottom => "end",
                _ => string.Empty,
            };
        }

        /// <summary>
        /// Zet de horizontal align tot string om.
        /// </summary>
        /// <param name="horizontal">Waar een element wordt geplaatst.// horizontal.</param>
        /// <returns>De horizontal aligan enum als string.</returns>
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
