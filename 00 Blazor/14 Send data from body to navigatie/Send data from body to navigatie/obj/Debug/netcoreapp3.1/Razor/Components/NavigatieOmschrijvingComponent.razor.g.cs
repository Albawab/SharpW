#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Components\NavigatieOmschrijvingComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a79cdb2e0bd90c60939b84d0d1ea47e3ff9b21"
// <auto-generated/>
#pragma warning disable 1591
namespace Send_data_from_body_to_navigatie.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Send_data_from_body_to_navigatie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\_Imports.razor"
using Send_data_from_body_to_navigatie.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Components\NavigatieOmschrijvingComponent.razor"
using Send_data_from_body_to_navigatie.Models;

#line default
#line hidden
#nullable disable
    public partial class NavigatieOmschrijvingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"navigator-omschrijving-header\">\r\n        <h5><strong>Omschrijving:</strong></h5>\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "h6");
            __builder.AddMarkupContent(5, "<strong>Naam:</strong> ");
            __builder.AddContent(6, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Components\NavigatieOmschrijvingComponent.razor"
                                OmschrijvingNavigatorItem.Omschrijving

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "h6");
            __builder.AddMarkupContent(9, "<strong> Omschrijving:</strong>  ");
            __builder.AddContent(10, 
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Components\NavigatieOmschrijvingComponent.razor"
                                          OmschrijvingNavigatorItem.Omschrijving

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Components\NavigatieOmschrijvingComponent.razor"
       
    [Parameter]
    public OmschrijvingNavigatorModel OmschrijvingNavigatorItem { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
