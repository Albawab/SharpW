#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15e442d186222af61d8601f172ed72189edf464"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_StudentPage), @"mvc.1.0.razor-page", @"/Pages/StudentPage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/studentPage")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15e442d186222af61d8601f172ed72189edf464", @"/Pages/StudentPage.cshtml")]
    public class Pages_StudentPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml"
  
    ViewData["Title"] = "StudentPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml"
 foreach (Page_Component_Views.Model.Student student in Model.Students)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>");
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml"
       Write(student.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml"
       Write(student.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml"
       Write(student.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    <br /><hr />\r\n");
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>StudentPage</h1>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Pages\StudentPage.cshtml"
Write(Html.ActionLink("Lijst van studenten", "GetList", "Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page_Component_Views.Pages.StudentPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Page_Component_Views.Pages.StudentPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Page_Component_Views.Pages.StudentPageModel>)PageContext?.ViewData;
        public Page_Component_Views.Pages.StudentPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
