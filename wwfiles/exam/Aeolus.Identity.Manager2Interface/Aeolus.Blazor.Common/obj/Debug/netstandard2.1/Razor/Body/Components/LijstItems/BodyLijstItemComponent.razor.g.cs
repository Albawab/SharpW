#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc50059bb8042cca719606aebcc71488e053141a"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE.Aeolus.Blazor.Common.Body.Components.LijstItems
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Navigatie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Body.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Body.Components.Toolbars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
    public partial class BodyLijstItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
 if (Kinderen != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
     foreach (LijstItemModel kind in Kinderen)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "list-item");
            __builder.AddAttribute(3, "style", "background-color:" + (
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
                                                    onActive(kind)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
                                                                               (() =>CallbackItems(kind))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "label");
            __builder.AddAttribute(7, "class", "list-item-title");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
                                        kind.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "list-item-body");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
                                     kind.Omschrijving

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\wwfiles\exam\Aeolus.Identity.Manager2Interface\Aeolus.Blazor.Common\Body\Components\LijstItems\BodyLijstItemComponent.razor"
       
    [Parameter]
    public List<LijstItemsModel> Kinderen { get; set; }
    [Parameter]
    public EventCallback<LijstItemModel> Callback{ get; set; }
    LijstItemModel activeItem;

    private void CallbackItems(LijstItemModel itemModel)
    {
        activeItem = itemModel;
        Callback.InvokeAsync(itemModel);
    }

    private string onActive(LijstItemModel item)
    {
        if (activeItem == item)
        {
            return "rgb(135,206,250)";
        }
        else
        {
            return "";
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
