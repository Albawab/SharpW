#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\Pages\TextBoxComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cd8c9e29307230a43858494a376bc772f2c3c9b"
// <auto-generated/>
#pragma warning disable 1591
namespace CustomComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using CustomComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\_Imports.razor"
using CustomComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\Pages\TextBoxComponent.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\Pages\TextBoxComponent.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
    public partial class TextBoxComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TextBoxComponent</h3>\r\n\r\n");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.Inputs.EjsTextBox>(1);
            __builder.AddAttribute(2, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\Pages\TextBoxComponent.razor"
                    Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\Pages\TextBoxComponent.razor"
                                          ValueChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\Pages\TextBoxComponent.razor"
                                                                          ValueExpression

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\02 form-Suncfusion\CustomComponent\Pages\TextBoxComponent.razor"
       

    [Parameter] public string Value { get; set; }

    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public Expression<Func<string>> ValueExpression { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
