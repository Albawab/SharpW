#pragma checksum "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\Pages\Bootstrap_Form.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1afd04f57a1c31772517c418cd4d5607ffdb24f4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace _00_Bootstrap.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using _00_Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using _00_Bootstrap.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\Pages\Bootstrap_Form.razor"
using _00_Bootstrap.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bootsrrapForm")]
    public partial class Bootstrap_Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\Pages\Bootstrap_Form.razor"
       
    public Persoon persoon { get; set; }
    string class_name;
    string class_achternaam;

    protected override async Task OnInitializedAsync()
    {
        persoon = new Persoon();
    }

    public void SaveData()
    {
        if (persoon.Naam == "Arno")
        {
            class_name = "is-valid";
        }
        else
        {
            class_name = "is-invalid";
        }
        if (persoon.AchterNaam == "Horlings")
        {
            class_achternaam = "is-valid";
        }
        else
        {
            class_achternaam = "is-invalid";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Handler handler { get; set; }
    }
}
#pragma warning restore 1591
