#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff680df0dd80bc89e9f06bf89bab7e6526dfe61"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE.Aeolus.Overzichten.Blazor.Models.Body.Component.Grid
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.t4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Navigation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Navigation.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body.Component.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Body.Component.Toolbar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Models.Header;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using HenE.Aeolus.Overzichten.Blazor.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    public partial class ODataGrid<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control-section");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content-wrapper");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<TItem>>(6);
            __builder.AddAttribute(7, "Locale", "nl");
            __builder.AddAttribute(8, "Height", "100%");
            __builder.AddAttribute(9, "Width", "100%");
            __builder.AddAttribute(10, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowPdfExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "AllowExcelExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                                                                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                                                                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(16);
                __builder2.AddAttribute(17, "Adaptor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                    Adaptors.ODataV4Adaptor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                   Url

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(20);
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\r\n");
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                 foreach (dynamic prop in tp.GetProperties())
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(23, "                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(24);
                    __builder3.AddAttribute(25, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                        prop.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "HeaderText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                 GetDescription(prop)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Format", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                                                  GetFormat(prop)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                                                                               TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "CustomAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                                                                                                                                                                     new { @class = "e-attr" }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n");
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(31, "            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
            }
            ));
            __builder.AddComponentReferenceCapture(33, (__value) => {
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
                       DefaultGrid = (Syncfusion.Blazor.Grids.SfGrid<TItem>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(37, @"<style>
    .e-grid .e-gridheader {
        border: none;
    }
    .e-grid {
        border: none;
    }
    div .control-section .content-wrapper{
        border: none;
    }
    .e-columnheader .e-attr {
        background-color: rgb(87, 87, 86);
        color: white;
        height: 30px;
    }

    #gridshtrawg0kjn3 {
        width: 100%;
    }

    .e-pagercontainer .e-currentitem {
        background-color: rgb(118, 183, 41);
    }

        .e-pagercontainer .e-currentitem:hover {
            background-color: rgb(51, 156, 209);
        }
    .e-filtered {
        color: black;
        padding-top: 0px;
    }


    .e-filterbarcell .e-fltrinputdiv span .e-input {
        height: 15px;
        padding-top: 0px;

    }

    .e-filterbarcell .e-fltrinputdiv span {
        height: 20px;
        padding-top: 0px;
        border: none;
        border-bottom: 2px solid;
    }


</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\06 Grid\HenE_Grid\Models\Body\Component\Grid\ODataGrid.razor"
      
    [Parameter]
    public string Route { get; set; }
    private Type tp;

    [Parameter]
    public SfGrid<TItem> DefaultGrid { get; set; }
    [Parameter]
    public EventCallback<SfGrid<TItem>> Callback { get; set; }

    [CascadingParameter]
    public EventCallback<SfGrid<TItem>> DefaultGridChanged { get; set; }

    protected override void OnInitialized()
    {
        tp = typeof(TItem);
    }

    protected string Url
    {
        get { return Settings.GetInstellingen().OdatabaseUrl + this.Route; }
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            Callback.InvokeAsync(this.DefaultGrid);
        }
    }

    private string GetDescription(dynamic propertie)
    {
        AttributeCollection attributes = TypeDescriptor.GetProperties(typeof(TItem))[$"{propertie.Name}"].Attributes;
        DescriptionAttribute myAttribute = (DescriptionAttribute)attributes[typeof(DescriptionAttribute)];
        return myAttribute.Description != "" ? myAttribute.Description : propertie.Name;
    }

    private string GetFormat(dynamic item)
    {
        if (item.PropertyType == typeof(string))
        {
            return "";
        }
        else if (item.PropertyType == typeof(DateTime))
        {
            return "dd-MM-yyy";
        }
        else if (item.PropertyType == typeof(decimal))
        {
            return "d";
        }
        return "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHaveSettings Settings { get; set; }
    }
}
#pragma warning restore 1591