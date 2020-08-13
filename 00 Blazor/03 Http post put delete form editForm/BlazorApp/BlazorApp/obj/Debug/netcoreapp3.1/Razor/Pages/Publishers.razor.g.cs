#pragma checksum "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0abd837cf8fc3ac7383e39619dea9d0a5dd6b4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publishers")]
    public partial class Publishers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<h3><b>Enter Publisher Information</b></h3>\n    <hr>\n    ");
            __builder.OpenComponent<CuriousDriveRazorLibrary.ServerValidations>(4);
            __builder.AddAttribute(5, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                  IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                                     Result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.AddMarkupContent(9, "<span>Publisher : </span>");
                __builder2.AddContent(10, 
#nullable restore
#line 11 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                  RecordName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(11, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                      publisher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                                 SavePublisher

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\n\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-12 row");
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.AddMarkupContent(21, "<label class=\"col-2 font-weight-bold\">first name :</label>\n            ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "class", "form-control col-3");
                __builder2.AddAttribute(24, "placeholder", "publisher\'s name");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                                                                 publisher.Publisher_Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => publisher.Publisher_Name = __value, publisher.Publisher_Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddElementReferenceCapture(27, (__value) => {
#nullable restore
#line 19 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                         publisherNameTextBox = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n            &nbsp;");
                __Blazor.BlazorApp.Pages.Publishers.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 20 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                            () => publisher.Publisher_Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n        <br>\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-12 row");
                __builder2.AddMarkupContent(35, "\n            ");
                __builder2.AddMarkupContent(36, "<label class=\"col-2 font-weight-bold\">city :</label>\n            ");
                __builder2.OpenComponent<CuriousDriveRazorLibrary.SelectCity>(37);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n        <br>\n        ");
                __builder2.AddMarkupContent(40, @"<div class=""col-12 row"">
            <span class=""col-2""></span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Save"">
            <span>&nbsp;</span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Clear"">
        </div>

    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n<br>\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-6");
            __builder.AddMarkupContent(45, "\n\n    ");
            __builder.AddMarkupContent(46, "<h3><b>Publishers</b></h3>\n\n    ");
            __Blazor.BlazorApp.Pages.Publishers.TypeInference.CreateMatTable_1(__builder, 47, 48, 
#nullable restore
#line 45 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                      publisherList

#line default
#line hidden
#nullable disable
            , 49, 
#nullable restore
#line 45 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                              true

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 45 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                                                    true

#line default
#line hidden
#nullable disable
            , 51, "tester", 52, "mat-elevation-z5", 53, (__builder2) => {
                __builder2.AddMarkupContent(54, "\n            ");
                __builder2.AddMarkupContent(55, "<th class=\"col-2\">PublisherId</th>\n            ");
                __builder2.AddMarkupContent(56, "<th class=\"col-6\">Publisher Name</th>\n            ");
                __builder2.AddMarkupContent(57, "<th class=\"col-4\">City</th>\n        ");
            }
            , 58, (context) => (__builder2) => {
                __builder2.AddMarkupContent(59, "\n            ");
                __builder2.OpenElement(60, "td");
                __builder2.AddContent(61, 
#nullable restore
#line 52 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                 context.Pub_Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n            ");
                __builder2.OpenElement(63, "td");
                __builder2.AddContent(64, 
#nullable restore
#line 53 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                 context.Publisher_Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n            ");
                __builder2.OpenElement(66, "td");
                __builder2.AddContent(67, 
#nullable restore
#line 54 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
                 context.City

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\n        ");
            }
            );
            __builder.AddMarkupContent(69, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Abdul\Desktop\BlazorApp-master\BlazorApp\BlazorApp\Pages\Publishers.razor"
       

    public Publisher publisher { get; set; }
    public List<Publisher> publisherList { get; set; }
    public string[] Cities { get; set; }
    ElementReference publisherNameTextBox;

    public bool IsVisible { get; set; }
    public string RecordName { get; set; }
    public bool Result { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Cities == null)
        {
            Cities = await JSRuntime.InvokeAsync<string[]>("getCities");

            StateHasChanged();
        }
    }

    protected override void OnInitialized()
    {
        publisher = new Publisher();
        publisherList = publisherService.GetPublishers();
    }

    private async Task SavePublisher()
    {
        Result = false;//publisherService.SavePublisher(publisher);
        IsVisible = true;
        RecordName = publisher.Publisher_Name;

        publisher = new Publisher();

        //await JSRuntime.InvokeVoidAsync("saveMessage",publisherName, "");
        await JSRuntime.InvokeVoidAsync("setFocusOnElement", publisherNameTextBox);
    }

    public async Task DeletePublisher(string publisherId)
    {
        var confirm = await JSRuntime.InvokeAsync<bool>("confirmDelete");

        if (confirm)
            publisherService.DeletePublisher(publisherId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Publishers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatTable_1<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg6)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Striped", __arg1);
        __builder.AddAttribute(__seq2, "AllowSelection", __arg2);
        __builder.AddAttribute(__seq3, "RowClass", __arg3);
        __builder.AddAttribute(__seq4, "class", __arg4);
        __builder.AddAttribute(__seq5, "MatTableHeader", __arg5);
        __builder.AddAttribute(__seq6, "MatTableRow", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
