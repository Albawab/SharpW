#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\Pages\ApiPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e1b3070c03abd6783455b40b5abf47b862ce812"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HenE.Aeolus.Identity.Manager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Identity.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Identity.Manager.Mockups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.docs.ListAndItemsBody.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.docs.GridBody.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.docs.Header.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.Header.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.Header.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.docs.Menubar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.docs.Navigatie.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.Navigatie.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\_Imports.razor"
using HenE.Aeolus.Shared.Ui.Blazor.Navigatie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\Pages\ApiPage.razor"
using HenE.Aeolus.Identity.Manager.Api.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Identity.Manager\Pages\ApiPage.razor"
using HenE.Aeolus.Identity.Manager.Api.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/api")]
    public partial class ApiPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
