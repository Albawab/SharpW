#pragma checksum "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a2a2ff564c0272ef00d96a70d42eea41a77f2f"
// <auto-generated/>
#pragma warning disable 1591
namespace Impott.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Impott;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Impott.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Pages\Index.razor"
using Impott.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Pages\Index.razor"
using Impott.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IhandleNavigation
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\nWelcome to your new app.\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Pages\Index.razor"
                                Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Click");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Pages\Index.razor"
      
    public string Omschrijving { get; set; }

    protected override void OnInitialized()
    {

    }


    private void Update()
    {
        Omschrijving = "Hallo omschrijving";
        vav.UpdateNav(this);
        StateHasChanged();
    }


    public string GetData()
    {
        return "";
    }

    private OmschrijvingItem GetMenubarItems()
    {
        return new OmschrijvingItem()
        {
            Titel = "New",
            Omschrijving = "Hallo Impott.Data",
        };
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INavigation vav { get; set; }
    }
}
#pragma warning restore 1591
