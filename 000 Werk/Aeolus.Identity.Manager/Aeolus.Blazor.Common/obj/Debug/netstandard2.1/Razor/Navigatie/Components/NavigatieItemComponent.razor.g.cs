#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79e11c9d6856824a4d6f13157fcd402175aaced"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE.Aeolus.Blazor.Common.Navigatie.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Navigatie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
    public partial class NavigatieItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", "elementList");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
                     ToggleLists

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "i");
            __builder.AddAttribute(7, "class", "fas" + " fa-angle-double-" + (
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
                                       symbolList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", 
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
                  Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "label");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.OpenElement(14, "span");
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
                        subItem.Titel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
     if (subItem.SubItems != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenElement(23, "ul");
            __builder.AddAttribute(24, "class", "list-unstyled elementsList");
            __builder.AddAttribute(25, "style", "display:" + (
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
                                                               hideElements

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
             foreach (var item in subItem.SubItems)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.OpenComponent<HenE.Aeolus.Blazor.Common.Navigatie.Components.NavigatieItemComponent>(28);
            __builder.AddAttribute(29, "subItem", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE.Aeolus.Blazor.Common.Navigatie.Models.NavigatieItemModel>(
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
                                                 item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\Navigatie\Components\NavigatieItemComponent.razor"
       
    [Parameter]
    public NavigatieItemModel subItem { get; set; }
    string symbolList = "";
    private string hideElements = "none";

    protected override void OnInitialized()
    {
        if (subItem.SubItems != null)
        {
            if (subItem.SubItems.Count != 0)
            {
                symbolList = "right";
            }

        }
    }

    private string Url
    {
        get
        {
            if (subItem is PageNavigatieItemModel)
            {
                PageNavigatieItemModel page = (PageNavigatieItemModel)subItem;
                return page.Page;
            }
            return string.Empty;
        }
    }


    private void ToggleLists()
    {
        if (symbolList == "right")
        {
            symbolList = "down";
            hideElements = "";

        }
        else if (subItem.SubItems == null)
        {
            symbolList = "";
        }
        else
        {
            symbolList = "right";
            hideElements = "none";
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591