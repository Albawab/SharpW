#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\NotitieRazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ebbcb372cc0f7b374a1937d6eb0b951e2248836"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HenE_Ej2.blazor_syncfusion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using HenE_Ej2.blazor_syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using HenE_Ej2.blazor_syncfusion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\_Imports.razor"
using Syncfusion.EJ2.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\NotitieRazor.razor"
using HenE_Application.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\NotitieRazor.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/notitieRazor")]
    public partial class NotitieRazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\NotitieRazor.razor"
       
    private List<Notitie> notities;

    protected override async Task OnInitializedAsync()
    {
        notities = await Http.GetJsonAsync<List<Notitie>>("https://localhost:45001/Notitie");
    }

    private async Task Update(Notitie notitie)
    {
        await Http.PutJsonAsync("https://localhost:45001/Notitie", notitie);
    }

    private async Task Save(Notitie notitie)
    {
        await Http.PostJsonAsync("https://localhost:45001/Notitie", notitie);
    }
    private async Task Delete(int id)
    {
        await Http.DeleteAsync($"https://localhost:45001/Notitie/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
