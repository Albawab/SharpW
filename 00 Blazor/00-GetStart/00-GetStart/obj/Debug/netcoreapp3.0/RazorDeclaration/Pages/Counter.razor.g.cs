#pragma checksum "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa854bdec3524d3bc1b70b917e754cf6463e1ec1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace _00_GetStart.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using _00_GetStart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\_Imports.razor"
using _00_GetStart.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\Pages\Counter.razor"
using _00_GetStart.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\Pages\Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Source\Sharp\00 Blazor\00-GetStart\00-GetStart\Pages\Counter.razor"
       
    int nummer = 0;
    int currentCount = 0;

    void CallSignalR()
    {
        // wat gaan we nu doen?

/*
 * var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

var message = document.getElementById("message");
var bt = document.getElementById("bt");

connection.on("ReceiveMessage", function a(second) {
    var li = document.createElement("li");
    var textnode = document.createTextNode(second);
    li.appendChild(textnode);
    message.appendChild(li);

});

connection.start();


bt.addEventListener("click", Send);
function Send() {

    connection.invoke("SendMessage");
}
 * */

    }


    void IncrementCount()
    {
        currentCount++;
    }

    protected override async Task OnInitializedAsync()
    {
        nummer = await Seconds.GetSec();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591