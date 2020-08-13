// <copyright file="NavMenuCode.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Shared
{
    using System.Collections.Generic;
    using System.Linq;
    using HenE_BlazorComponent.Controllers;
    using HenE_BlazorComponent.Data;
    using Microsoft.AspNetCore.Components;
    using Syncfusion.Blazor.Navigations;

    public class NavMenuCode : ComponentBase
    {
        /// <summary>
        /// collapseNavMenu.
        /// </summary>
        protected bool collapseNavMenu = true;

        /// <summary>
        /// controller.
        /// </summary>
        FormulierController controller = new FormulierController();

        /// <summary>
        /// formulier.
        /// </summary>
        protected Formulier formulier;

        /// <summary>
        /// oldFormulier.
        /// </summary>
        protected Formulier oldFormulier;

        /// <summary>
        /// formulieren.
        /// </summary>
        protected List<Formulier> formulieren;

        /// <summary>
        /// Gets or sets formulier element als group.
        /// </summary>
        protected dynamic formulierElementenGroup { get; set; }

        /// <summary>
        /// formulierSectionsKindGroup.
        /// </summary>
        protected dynamic formulierSectionsKindGroup;

        /// <summary>
        /// Expand.
        /// </summary>
        protected ExpandOnSettings Expand = ExpandOnSettings.Click;

        /// <summary>
        /// HashTagName.
        /// </summary>
        protected string HashTagName = "#0";

        /// <summary>
        /// oldSection.
        /// </summary>
        protected FormulierSectie oldSection;

        /// <summary>
        /// Section.
        /// </summary>
        protected FormulierSectie Section;

        /// <summary>
        /// Gets Nav menue.
        /// </summary>
        protected string NavMenuCssClass => this.collapseNavMenu ? "collapse" : null;

        /// <summary>
        /// Roept waaneer de page start.
        /// </summary>
        protected override void OnInitialized()
        {
            // Get de controller.
            FormulierController formulierController = new FormulierController();

            this.formulieren = formulierController.GetFormuliers();
        }

        /// <summary>
        /// verandert de situatie van de slidebar.
        /// </summary>
        protected void ToggleNavMenu()
        {
            this.collapseNavMenu = !this.collapseNavMenu;
            this.StateHasChanged();
        }

        /// <summary>
        /// Toon of verstoppen de data van een formulier.
        /// </summary>
        /// <param name="huidigeFormulier">Huidige formulier.</param>
        protected void ToggleDataList(Formulier huidigeFormulier)
        {
            if (huidigeFormulier != this.formulier)
            {
                this.oldFormulier = this.formulier;
            }

            this.formulier = huidigeFormulier;
            if (this.formulierElementenGroup == null)
            {
                // bringt de element van de huidige formulier.
                // Sorteert de element bij groepen.
                this.formulierElementenGroup = this.formulier.Kinderen.GroupBy(g => g.Row).OrderBy(o => o.Key);
            }
            else
            {
                this.formulierElementenGroup = null;
            }

            this.StateHasChanged();
        }

        /// <summary>
        /// Voeg de data van een secties in.
        /// </summary>
        /// <param name="sectie">De sectie die zijn data wordt ingevoegd.</param>
        protected void ToggleDataSection(FormulierSectie sectie)
        {
            if (sectie.SectionKinderen != null)
            {
                if (sectie != this.Section)
                {
                    this.oldSection = this.Section;
                }

                this.Section = sectie;
                if (this.formulierSectionsKindGroup == null)
                {
                    // bringt de element van de huidige formulier.
                    // Sorteert de element bij groepen.
                    this.formulierSectionsKindGroup = this.Section.SectionKinderen.GroupBy(g => g.Row).OrderBy(o => o.Key);
                }
                else
                {
                    this.formulierSectionsKindGroup = null;
                }

                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Verzamelt de URL delen in een URL.
        /// </summary>
        /// <param name="sectie">Huidige sectie.</param>
        /// <param name="huidigeFormulierVanUitNav">Een formulier.</param>
        /// <returns>De URL van deze adress.</returns>
        protected string GetUrl(FormulierSectie sectie, Formulier huidigeFormulierVanUitNav)
        {
            int formulierNummer = -1;
            foreach (Formulier huidigeFormulier in this.formulieren)
            {
                formulierNummer++;
                if (huidigeFormulierVanUitNav == huidigeFormulier)
                {
                    foreach (FormulierSectie huidigeSectie in huidigeFormulier.Kinderen)
                    {
                        if (sectie == huidigeSectie)
                        {
                            return this.HashTagName = "/" + formulierNummer.ToString() + "#" + sectie.SectionNumber.ToString();
                        }
                    }
                }
            }

            return this.HashTagName;
        }

        /// <summary>
        /// Verzamelt de URL delen in een URL.
        /// </summary>
        /// <param name="huidigeFormulier">huidigeFormulier.</param>
        /// <returns>De URL.</returns>
        protected string GetUrl(Formulier huidigeFormulier)
        {
            int formulierNummer = -1;

            foreach (Formulier eenformulier in this.formulieren)
            {
                formulierNummer++;
                if (huidigeFormulier != this.oldFormulier && huidigeFormulier == eenformulier)
                {
                    this.oldFormulier = huidigeFormulier;
                    return this.HashTagName = "/" + formulierNummer.ToString();
                }
            }

            return string.Empty;
        }
    }
}
