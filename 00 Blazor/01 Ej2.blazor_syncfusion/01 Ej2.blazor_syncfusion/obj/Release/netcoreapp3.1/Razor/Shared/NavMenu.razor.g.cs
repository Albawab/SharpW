#pragma checksum "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b44093b34c478dbdb5703a594ccca602c068786"
// <auto-generated/>
#pragma warning disable 1591
namespace _01_Ej2.blazor_syncfusion.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using _01_Ej2.blazor_syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using _01_Ej2.blazor_syncfusion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"top-row pl-4 navbar navbar-dark\">\r\n    <a class=\"navbar-brand\" href>01 Ej2.blazor_syncfusion</a>\r\n    <button class=\"navbar-toggler\" @onclick=\"ToggleNavMenu\">\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    </button>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "@onclick", "ToggleNavMenu");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "nav flex-column");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "nav-item px-3");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "NavLink");
            __builder.AddAttribute(12, "class", "nav-link");
            __builder.AddAttribute(13, "href", true);
            __builder.AddAttribute(14, "Match", "NavLinkMatch.All");
            __builder.AddMarkupContent(15, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "NavLink");
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "Data");
            __builder.AddMarkupContent(24, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Data\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "NavLink");
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "fetchdata");
            __builder.AddMarkupContent(33, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "NavLink");
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "time");
            __builder.AddMarkupContent(42, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Time\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item px-3");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "NavLink");
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "getData");
            __builder.AddMarkupContent(51, "\r\n                <span class=\"oi oi-play-circle\" aria-hidden=\"true\"></span>Get Data\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "li");
            __builder.AddAttribute(54, "class", "nav-item px-3");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "NavLink");
            __builder.AddAttribute(57, "class", "nav-link");
            __builder.AddAttribute(58, "href", "temperature");
            __builder.AddMarkupContent(59, "\r\n                <span class=\"oi oi-play-circle\" aria-hidden=\"true\"></span>Cpu Temprature\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Abdul\Desktop\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
