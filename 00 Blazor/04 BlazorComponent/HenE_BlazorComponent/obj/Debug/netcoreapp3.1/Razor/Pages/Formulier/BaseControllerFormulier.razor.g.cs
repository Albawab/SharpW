#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05187ffd41fe4a3a04bc4726299e5471facb1da0"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages.Formulier
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Enumeration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Id:int}")]
    public partial class BaseControllerFormulier : BaseControllerFormulierBlazor
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
 if (FormulierElementenGroup != null)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "text-align:center");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "h1");
            __builder.AddContent(5, 
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
             EenFormulier.Titel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container-fluid");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
         foreach (var formulierElenent in FormulierElementenGroup)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\n");
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
                 foreach (var element in formulierElenent)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.Formulier.FormulierSectionMain>(15);
            __builder.AddAttribute(16, "Section", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.FormulierSectie>(
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
                                                  element

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.AddMarkupContent(23, "<h2>Loading...</h2>\n");
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\BaseControllerFormulier.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591