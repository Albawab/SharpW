#pragma checksum "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d80fa7be2648ba06931a5125274fd6db666e857"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace _16_Configuration_render_modeOneTimeTwoTimes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using _16_Configuration_render_modeOneTimeTwoTimes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\_Imports.razor"
using _16_Configuration_render_modeOneTimeTwoTimes.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\Pages\FetchData.razor"
using _16_Configuration_render_modeOneTimeTwoTimes.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\AbdulAbdulbawab\Source\repos\16 Configuration render-modeOneTimeTwoTimes\16 Configuration render-modeOneTimeTwoTimes\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591