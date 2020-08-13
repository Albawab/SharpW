// <copyright file="BaseControllerFormulierBlazor.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Pages.Formulier
{
    using System.Linq;
    using System.Threading.Tasks;
    using HenE_BlazorComponent.Controllers;
    using HenE_BlazorComponent.Data;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;

    /// <summary>
    /// Deze klas doet de data voor de blazor klaar.
    /// </summary>
    public class BaseControllerFormulierBlazor : ComponentBase
    {
        /// <summary>
        /// Gets or sets De id from de slidebar.
        /// </summary>
        [Parameter]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets formulier elementen.
        /// </summary>
        public dynamic FormulierElementenGroup { get; set; }

        /// <summary>
        /// Gets controle.
        /// </summary>
        public FormulierController Controller { get; } = new FormulierController();

        /// <summary>
        /// Gets or sets een formulier.
        /// </summary>
        public Formulier EenFormulier { get; set; }

        /// <summary>
        /// Gets or sets navigation manager.
        /// </summary>
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        /// <summary>
        /// Gets or sets JsRunTime.
        /// </summary>
        [Inject]
        private IJSRuntime JsRuntime { get; set; }

        /// <summary>
        /// start wanneer de project start.
        /// </summary>
        protected override void OnInitialized()
        {
            this.EenFormulier = this.Controller.GetData(0);
            this.NavigationManager.LocationChanged += this.TryFragmentNavigation;
        }

        /// <summary>
        /// als de webpage is klaar dan loopt deze functie.
        /// </summary>
        /// <param name="firstRender">Is het eerst renderen.</param>
        /// <returns>Een Task waar de webpage wordt verandert.</returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await this.NavigationManager.NavigateToFragmentAsync(this.JsRuntime);
        }

        /// <summary>
        /// On de parameter heeft een nieuwe value gekeren dan werkt deze method.
        /// </summary>
        protected override void OnParametersSet()
        {
            switch (this.Id)
            {
                case 0:
                    this.EenFormulier = this.Controller.GetData(0);
                    break;
                case 1:
                    this.EenFormulier = this.Controller.GetData(1);
                    break;
                case 2:
                    this.EenFormulier = this.Controller.GetData(2);
                    break;
            }

            this.FormulierElementenGroup = this.EenFormulier.Kinderen.GroupBy(g => g.Row).OrderBy(o => o.Key).ToArray();
            this.StateHasChanged();
        }

        /// <summary>
        /// Probeer om naar een deel van de webpagina te gaan.
        /// </summary>
        /// <param name="sender">De sender.</param>
        /// <param name="args">De details op webpagen wordt verandert.</param>
        private async void TryFragmentNavigation(object sender, LocationChangedEventArgs args)
        {
            await this.NavigationManager.NavigateToFragmentAsync(this.JsRuntime);
            this.StateHasChanged();
        }
    }
}
