#pragma checksum "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\t4\Controllers\VwuitstroomzorgComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f11dd0bacd480d62e2f80727a9398c010eb7c1c9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HenE_Grid.t4.Controllers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE_Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE_Grid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE_Grid.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE_Grid.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE_Grid.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE_Grid.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdul\Desktop\Werk\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vwuitstroomzorg")]
    public partial class VwuitstroomzorgComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHaveSettings Settings { get; set; }
    }
}
#pragma warning restore 1591
