#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7169476871506e99dd4d4c6c58d0c93b2ffb5464"
// <auto-generated/>
#pragma warning disable 1591
namespace Send_data_from_body_to_navigatie.Shared
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
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
using Send_data_from_body_to_navigatie.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
using Send_data_from_body_to_navigatie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
using Send_data_from_body_to_navigatie.Components;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"top-row pl-4 navbar navbar-dark\">\r\n    <a class=\"navbar-brand\" href>Send data from body to navigatie</a>\r\n    <button class=\"navbar-toggler\">\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    </button>\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
 if (OmschrijvingNavigatorItem != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "color:white;");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
     if (OmschrijvingNavigatorItem is OmschrijvingNavigatorModel navigatorModel)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenComponent<Send_data_from_body_to_navigatie.Components.NavigatieOmschrijvingComponent>(5);
            __builder.AddAttribute(6, "OmschrijvingNavigatorItem", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Send_data_from_body_to_navigatie.Models.OmschrijvingNavigatorModel>(
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
                                                                    navigatorModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Send data from body to navigatie\Send data from body to navigatie\Shared\NavMenu.razor"
       
    OmschrijvingNavigatorModel OmschrijvingNavigatorItem;
    protected override void OnInitialized()
    {
        // Geeft de functie aan de event die gaat werken als ites verandert in de service.
        handle.OnNavigationItemUpdate += (render) => this.OnChangeItem(render);
    }

    private async void OnChangeItem(IHandleNavigator handleNavigator)
    {
        OmschrijvingNavigatorItem = handleNavigator.OmschrijvingNavigatorModel;

        // InvokeAsync is inherited, it syncs the call back to the render thread
        await InvokeAsync(() => StateHasChanged());
    }
    public void Dispose()
    {
        handle.OnNavigationItemUpdate -= (render) => this.OnChangeItem(render);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHandleNavigator handle { get; set; }
    }
}
#pragma warning restore 1591
