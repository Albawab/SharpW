// <copyright file="InstellingenJSON.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Setting
{
    using HenE_BlazorComponent.Interface;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Deze klas haalt de data van de appsetting.json op.
    /// </summary>
    public class InstellingenJSON : IHaveSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstellingenJSON"/> class.
        /// </summary>
        /// <param name="configuration">con.</param>
        public InstellingenJSON(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets de configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Geeft de data terug die uit de bestand appsetting.json gehaald.
        /// </summary>
        /// <returns>De data.</returns>
        public Instellingen GetInstellingen()
        {
            return new Instellingen
            {
                TimerTextAreaDataOpslaanMS = this.Configuration.GetSection("Instellingen").GetSection("TimerTextAreaDataOpslaanMS").Value,
                TimerToastTonen = this.Configuration.GetSection("Instellingen").GetSection("TimerToastTonen").Value,
            };
        }
    }
}
