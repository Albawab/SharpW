// <copyright file="AppLocalizer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Overzichten.Blazor
{
    using Syncfusion.Blazor;

    /// <summary>
    /// Geef de applicatie lokalisator.
    /// </summary>
    public class AppLocalizer : ISyncfusionStringLocalizer
    {
        /// <inheritdoc/>
        public System.Resources.ResourceManager Manager => HenE.Aeolus.Overzichten.Blazor.Resources.SyncfusionBlazorLocale.ResourceManager;

        /// <inheritdoc/>
        public string Get(string key)
        {
            return this.Manager.GetString(key);
        }
    }
}
