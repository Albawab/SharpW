#pragma checksum "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64202746e90e9bf6b02829e8688018894fb95361"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BlazorApp</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "index");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddMarkupContent(29, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "counter");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "fetchdata");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n        ");
            __builder.OpenElement(47, "li");
            __builder.AddAttribute(48, "class", "nav-item px-3");
            __builder.AddMarkupContent(49, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "class", "nav-link");
            __builder.AddAttribute(52, "href", "");
            __builder.AddAttribute(53, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\n                <span class=\"oi oi-people\" aria-hidden=\"true\"></span> Authors\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n        ");
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "nav-item px-3");
            __builder.AddMarkupContent(60, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "nav-link");
            __builder.AddAttribute(63, "href", "publishers");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "\n                <span class=\"oi oi-book\" aria-hidden=\"true\"></span> Publishers\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
