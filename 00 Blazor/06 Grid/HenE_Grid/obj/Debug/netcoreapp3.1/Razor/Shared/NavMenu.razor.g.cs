#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "622dc00717a7304824f28217a8d2ec6f04b638db"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE.Aeolus.Overzichten.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.t4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Navigation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Navigation.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body.Component.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body.Component.Toolbar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Header;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Shared\NavMenu.razor"
                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenComponent<HenE.Aeolus.Overzichten.Blazor.Models.Navigation.Component.NavigatorComponent>(16);
            __builder.AddAttribute(17, "navigatieItemsFavoriet", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<dynamic>(
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Shared\NavMenu.razor"
                                                     navigatieItemsFavoriet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "navigatieItemsNotFavoriet", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<dynamic>(
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Shared\NavMenu.razor"
                                                                                                        navigatieItemsNotFavoriet

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, "<div class=\"navFooter\">\r\n        <a href=\"https://www.google.com/\"><span style=\"color:black\" target=\"_blank\">Ga naar Google</span></a>\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Shared\NavMenu.razor"
       
    NavigatieService navigatieService = null;
    dynamic navigatieItemsFavoriet;
    dynamic navigatieItemsNotFavoriet;
    private bool collapseNavMenu = true;

    protected override void OnInitialized()
    {
        navigatieService = new NavigatieService();
        navigatieItemsFavoriet = navigatieService.GetFavorietenNavigatieItems();
        navigatieItemsNotFavoriet = navigatieService.GetAlleMappenNavigatieItems();
    }

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
