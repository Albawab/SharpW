#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3c85aeeca68da932e57da39e972b5c3d3668e9f"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
using HenE_Application.Container;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"h3\">Employees:</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                 employees

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                                       OntvangGegevens

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                                                                          SendFoutMessage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table ");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<tr>\r\n        <th>Id</th>\r\n        <th>Achter naam</th>\r\n        <th>Voor naam</th>\r\n        <th>E-mail</th>\r\n        <th>Huisnr</th>\r\n    </tr>\r\n    ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
         foreach (var employee in employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                 employee.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                 employee.VoorNaam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                 employee.AchterNaam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                 employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
                 employee.HuisNummer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 Ej2.blazor_syncfusion-Form-EditForm\HenE_Ej2.blazor_syncfusion\Pages\Employees.razor"
       
    Medewerker[] employees;


    private async void OntvangGegevens()
    {

        //await HttpClient.PostAsync<Medewerker>("https://localhost:45001/Employees", );
    }



    private void SendFoutMessage()
    {

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
