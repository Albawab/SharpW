#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\LijstItems\BodyLijstItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd5d03d07ef72f8e2d6ccd7abf4152f5dda6ada"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Components.LijstItems
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
    public partial class BodyLijstItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\000 Werk\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\LijstItems\BodyLijstItemComponent.razor"
       
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
