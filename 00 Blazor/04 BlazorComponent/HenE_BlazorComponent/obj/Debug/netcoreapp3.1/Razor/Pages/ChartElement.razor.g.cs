#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c215e5df4fb1e17bc001871b54f0c8ee585685b"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Enumeration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
    public partial class ChartElement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "label");
            __builder.AddAttribute(1, "class", "mb-4" + " col-" + (
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                        CardChartElement.Columns

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "Syncfusion.Blazor.NavigationsChart");
            __builder.AddAttribute(4, "Title", "Chart Data");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.ChartArea>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartAreaBorder>(8);
                __builder2.AddAttribute(9, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                           0

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(11);
            __builder.AddAttribute(12, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                      Syncfusion.Blazor.Charts.ValueType.DateTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "LabelFormat", "y");
            __builder.AddAttribute(14, "IntervalType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.IntervalType>(
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                                                                                                 IntervalType.Years

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "EdgeLabelPlacement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.EdgeLabelPlacement>(
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                                                                                                                                         EdgeLabelPlacement.Shift

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMajorGridLines>(18);
                __builder2.AddAttribute(19, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                            0

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryYAxis>(22);
            __builder.AddAttribute(23, "Title", "Revenue in Millions");
            __builder.AddAttribute(24, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                                                 1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "LabelFormat", "{value}M");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisMajorTickLines>(28);
                __builder2.AddAttribute(29, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                            0

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartAxisLineStyle>(31);
                __builder2.AddAttribute(32, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                       0

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(35);
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(38);
                __builder2.AddAttribute(39, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                      CardChartElement.ChartData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "Name", "Product A");
                __builder2.AddAttribute(41, "XName", "XValueDate");
                __builder2.AddAttribute(42, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                                                                                             2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Opacity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                  0.5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "YName", "YValueData");
                __builder2.AddAttribute(45, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                                                ChartSeriesType.Area

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Fill", "blue");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(48);
                __builder2.AddAttribute(49, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                      CardChartElement.ChartData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Name", "Product B");
                __builder2.AddAttribute(51, "XName", "XValueDate");
                __builder2.AddAttribute(52, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                                                                                             2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "Opacity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                  0.5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "YName", "YValueData1");
                __builder2.AddAttribute(55, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
                                                                 ChartSeriesType.Area

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "Fill", "red");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ChartElement.razor"
       
    [Parameter]
    public CardChartElement CardChartElement { get; set; } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591