#pragma checksum "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\Navigatie\Components\NavigatorComponenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e753a5910c3da3ef201317f0ac5b3d0163d47045"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Aeolus.Blazor.Common.Navigatie.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Navigatie.Models;

#line default
#line hidden
#line 1 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\Navigatie\Components\NavigatorComponenta.razor"
using Aeolus.Blazor.Common.Navigatie.Interfaces;

#line default
#line hidden
    public partial class NavigatorComponenta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\Navigatie\Components\NavigatorComponenta.razor"
       

    private dynamic navigatieItemsFavoriet { get; set; }
    private dynamic navigatieItemsNotFavoriet { get; set; }

    [Parameter]
    public INavigatieService navigatieService { get; set; }


    List<dynamic> items = null;

    protected override void OnInitialized()
    {
        this.navigatieItemsFavoriet = navigatieService.GetItems();
        //this.navigatieItemsNotFavoriet = navigatieService.GetAlleMappenNavigatieItems();

        items = new List<dynamic>() { navigatieItemsFavoriet, navigatieItemsNotFavoriet };
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
