// <copyright file="AppLocalizer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Import
{
    using Syncfusion.Blazor;

    /// <summary>
    /// Geef de applicatie lokalisator.
    /// </summary>
    public class AppLocalizer : ISyncfusionStringLocalizer
    {
        /// <inheritdoc/>
        public System.Resources.ResourceManager Manager => Resources.SyncfusionBlazorLocale.ResourceManager;

        /// <inheritdoc/>
        public string Get(string key)
        {
            return this.Manager.GetString(key);
        }
    }
}
