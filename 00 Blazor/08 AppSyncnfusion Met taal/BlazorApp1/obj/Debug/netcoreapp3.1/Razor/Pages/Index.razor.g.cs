#pragma checksum "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d437ac868efa6e0ac06f5f55a748614d46f2a252"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(0);
            __builder.AddAttribute(1, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                   ExcelExport

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Content", "Excel Export");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<Order>>(4);
            __builder.AddAttribute(5, "AllowExcelExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ShowColumnMenu", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Toolbar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                                                                                                  new List<string> { "Add","Edit","Delete","Update","Cancel" }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Locale", "es");
            __builder.AddAttribute(12, "Query", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Data.Query>(
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                                                                                                                                                                                     Query

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Order>>(15);
                __builder2.AddAttribute(16, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<Order>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<Order>>(this, 
#nullable restore
#line 14 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                               Begin

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(18);
                __builder2.AddAttribute(19, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(23);
                __builder2.AddAttribute(24, "Url", "http://localhost:64956/odata/books");
                __builder2.AddAttribute(25, "Adaptor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 16 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                     Adaptors.ODataV4Adaptor

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(27);
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(30);
                    __builder3.AddAttribute(31, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                           nameof(Order.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "HeaderText", "ID");
                    __builder3.AddAttribute(33, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 18 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                           TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(37);
                    __builder3.AddAttribute(38, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                           nameof(Order.Title)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "HeaderText", "Title Name");
                    __builder3.AddAttribute(40, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(42);
                    __builder3.AddAttribute(43, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                           nameof(Order.Price)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "HeaderText", "Freight");
                    __builder3.AddAttribute(45, "Format", "C2");
                    __builder3.AddAttribute(46, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 20 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
                                                                                           TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(50, (__value) => {
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
              DefaultGrid = (Syncfusion.Blazor.Grids.SfGrid<Order>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Abdul\Desktop\Werk\00 Blazor\08 AppSyncnfusion Met taal\BlazorApp1\Pages\Index.razor"
      
    private SfGrid<Order> DefaultGrid;
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        //this.JsRuntime.Sf().LoadLocaleData("wwwroot/ej2-locale/src/es.json").SetCulture("es");
    }
    public void ExcelExport()
    {
        this.DefaultGrid.ExcelExport();
    }

    public int BranchSelected, RegionSelected;
    protected string SelectedOrder;
    List<Dropdown> Dropdown1 = EnumHelper.ConvertEnumToBindingSource<BranchType>();
    List<Dropdown> Dropdown2 = EnumHelper.ConvertEnumToBindingSource<Region>();
    protected Query Query = new Query().Expand(new List<string> { "RelatedOrder" });

    private Query GetDefaultQuery() => new Query().Expand(new List<string> { "RelatedOrder" });

    public class EnumHelper
    {
        public static List<Dropdown> ConvertEnumToBindingSource<T>()
        {
            var ret = new List<Dropdown>();
            var values = Enum.GetValues(typeof(T)).Cast<T>().ToList();

            for (var i = 0; i < Enum.GetNames(typeof(T)).Length; i++)
            {
                ret.Add(new Dropdown()
                {
                    Name = Enum.GetNames(typeof(T))[i],
                    Value = i,
                });
            }

            return ret;
        }
    }
    public class Dropdown
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
    public class Order
    {
        public Guid guid { get; set; }
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double? Price { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BranchType Branch { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Region Regime { get; set; }
        [Required(ErrorMessage = "Select a related order")]
        public Guid? RelatedOrderId { get; set; }
        public Order RelatedOrder { get; set; }
    }
    public void Change(ChangeEventArgs<int> Args, string ID)
    {
        if (ID == "Branch")
        {
            BranchSelected = Args.Value;
        }
        else if (ID == "Regime")
        {
            RegionSelected = Args.Value;
        }
    }
    public void Begin(ActionEventArgs<Order> Args)
    {
        if (Args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            var text = (BranchType)Enum.Parse(typeof(BranchType), "Modulo");
            Args.Data.Branch = (BranchType)Enum.Parse(typeof(BranchType), Dropdown1.Find(x => x.Value == BranchSelected).Name);
            Args.Data.Regime = (Region)Enum.Parse(typeof(Region), Dropdown2.Find(x => x.Value == RegionSelected).Name);
        }
    }
    public enum BranchType
    {
        //[EnumMember(Value ="Dirección")]
        [Display(Name = "Dirección")]
        Direccion,
        //[EnumMember(Value = "Representación")]
        [Display(Name = "Representación")]
        Representacion,
        //[EnumMember(Value = "Modulo")]
        [Display(Name = "Modulo")]
        Modulo
    }
    public enum Region
    {
        //[EnumMember(Value = "Centro")]
        [Display(Name = "Centro")]
        Centro,
        //[EnumMember(Value ="Sur")]
        [Display(Name = "Sur")]
        Sur,
        //[EnumMember(Value = "Norte")]
        [Display(Name = "Norte")]
        Norte,
        //[EnumMember(Value = "Occidente")]
        [Display(Name = "Occidente")]
        Occidente,
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
