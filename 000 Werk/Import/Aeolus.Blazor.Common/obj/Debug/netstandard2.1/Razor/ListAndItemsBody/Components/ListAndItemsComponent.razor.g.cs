#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5703b1a7a87c03f4681d6bc17e7608a38bad79a"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Navigatie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Components.LijstItems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Components.FullPageComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class ListAndItemsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "body-of-page");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "toolsHeader");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
         ToolbarrenderFragmenta

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", " list-body-element");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", " list-items-block");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenComponent<HenE.Aeolus.Blazor.Common.ListAndItemsBody.Components.LijstItems.LijstItemsComponent>(15);
            __builder.AddAttribute(16, "Service", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces.ILijstItemsService>(
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
                                          lijstItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Callback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models.LijstItemModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models.LijstItemModel>(this, 
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
                                                                CallBack

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "body-of-component");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenComponent<HenE.Aeolus.Blazor.Common.ListAndItemsBody.Components.FullPageComponents.SubBodyComponent>(23);
            __builder.AddAttribute(24, "Service", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces.IAppService>(
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
                                         (IAppService)Service

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Key", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
                                                                     Key

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Import\Aeolus.Blazor.Common\ListAndItemsBody\Components\ListAndItemsComponent.razor"
       
    [Parameter]
    public object TypeObject { get; set; }
    [Parameter]
    public IAppService Service { get; set; }
    [Parameter]
    public IMenubarSevice ToolsMenuSevice { get; set; }
    List<MenubarItemModel> menubarItems;
    RenderFragment ToolbarrenderFragmenta;
    private ILijstItemsService lijstItems;
    int Key = 0;
    object huidigeObject = null;

    protected override void OnInitialized()
    {
        lijstItems = (ILijstItemsService)Service;
        ToolbarrenderFragmenta = builder =>
        {
            builder.OpenComponent<MenubarBodyComponent>(0);
            builder.AddAttribute(1, "MenubarItems", GetMenubarItems());
            builder.CloseComponent();
        };
    }

    private List<MenubarItemModel> GetMenubarItems()
    {

        menubarItems = new List<MenubarItemModel>();
        foreach (MenubarItemModel menubarItem in MenubarService.GetMenubarItems())
        {
            if (Service.GetItemAppModel(Key).Id == menubarItem.Id)
            {
                menubarItems.Add(menubarItem);
            }
        }
        return menubarItems;

    }

    private void CallBack(LijstItemModel listItem)
    {
        huidigeObject = listItem;
        Key = listItem.Id;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMenubarSevice MenubarService { get; set; }
    }
}
#pragma warning restore 1591