// <copyright file="Extensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using Microsoft.JSInterop;
    using Syncfusion.Blazor.Popups;

    /// <summary>
    /// Klas waar de Extensions functies staan.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// zorg dat de scroller gaat naar een nieuwe deel van de pagina.
        /// </summary>
        /// <param name="navigationManager">De navigationManager.</param>
        /// <param name="jSRuntime">De runtime van javascript.</param>
        /// <returns>Een nieuwe runtime.</returns>
        public static ValueTask NavigateToFragmentAsync(this NavigationManager navigationManager, IJSRuntime jSRuntime)
        {
            var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

            if (uri.Fragment.Length == 0)
            {
                return default;
            }

            return jSRuntime.InvokeVoidAsync("blazorHelpers.scrollToFragment", uri.Fragment.Substring(1));
        }

        /// <summary>
        /// Convert string to enumation.
        /// </summary>
        /// <param name="position">the enum as string.</param>
        /// <returns>the enum.</returns>
        public static Position ToPositionTooltip(this string position)
        {
            return (Position)Enum.Parse(typeof(Position), position);
        }
    }
}
