#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\03 Http post put delete form editForm\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "723bae143b1936d0c669e289046bdd4b0c59911b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CuriousDriveRazorLibrary
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\03 Http post put delete form editForm\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\03 Http post put delete form editForm\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class SelectCity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 15 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\03 Http post put delete form editForm\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
       

    [Parameter]
    public string CurrentCity { get; set; }

    public string[] Cities { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Cities == null)
        {
            Cities = await JSRuntime.InvokeAsync<string[]>("getCities");

            StateHasChanged();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591