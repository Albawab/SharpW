#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\GetData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d5b7129c2863464fe8303377f0a7783c15640a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace _01_Ej2.blazor_syncfusion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using _01_Ej2.blazor_syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using _01_Ej2.blazor_syncfusion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.LinearGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\GetData.razor"
using _01_Ej2.blazor_syncfusion.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/getData")]
    public partial class GetData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\01 Ej2.blazor_syncfusion\01 Ej2.blazor_syncfusion\Pages\GetData.razor"
       

    static string getD { get; set; }
    EjsToast ToastObj;

    /// <summary>
    /// Toont een box waarin de greoten staat.
    /// </summary>
    private void ShowMessage() {
            ToastModel Toast = new ToastModel { Title = $"Hallo {getD}", Content = "Leuk dat je komt hier.", CssClass = "e-toast-success", Icon = "e-success toast-icons" };
        this.ToastObj.Show(Toast);
    }
    /// <summary>
    /// Gets de naam van de persoon.
    /// </summary>
    private void Get()
    {
        getD = Getdata.Get();
        ShowMessage();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataBase Getdata { get; set; }
    }
}
#pragma warning restore 1591
