#pragma checksum "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\Body\Component\BaseBodyComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa95b602b96ed03fc350716c2bbae3cc599d876"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Aeolus.Blazor.Common.Body.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Navigatie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Aeolus.Blazor.Common.Body.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Aeolus.Blazor.Common.Body.Component.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Aeolus.Blazor.Common.Body.Component.Toolbar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    public partial class BaseBodyComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\source\repos\HenE.Aeolus.Overzichten.Blazor\Aeolus.Blazor.Common\Body\Component\BaseBodyComponent.razor"
       
    [Parameter]
    public string Url { get; set; }
    [Parameter]
    public string link { get; set; }

    public SfGrid<TItem> DefaultGrid { get; set; }

    private void GetData(SfGrid<TItem> data)
    {
        DefaultGrid = data;
    }
    public void ExcelExport()
    {
        ExcelExportProperties ExcelProperties = new ExcelExportProperties();
        ExcelTheme Theme = new ExcelTheme();

        ExcelStyle ThemeStyle = new ExcelStyle()
        {
            FontName = "Segoe UI",
            FontColor = "#666666",
            FontSize = 12
        };

        Theme.Header = ThemeStyle;
        Theme.Record = ThemeStyle;
        Theme.Caption = ThemeStyle;
        ExcelProperties.Theme = Theme;
        ExcelProperties.FileName = $"Excel file_{DateTime.Now}.xlsx";
        // ExcelProperties.ExportType = Syncfusion.Blazor.Grids.ExportType.CurrentPage;
        this.DefaultGrid.ExcelExport(ExcelProperties);
    }
    public void PdfExport()
    {
        PdfExportProperties ExportProperties = new PdfExportProperties();
        ExportProperties.FileName = $"Pdf file_{DateTime.Now}.pdf";
        this.DefaultGrid.PdfExport(ExportProperties);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
