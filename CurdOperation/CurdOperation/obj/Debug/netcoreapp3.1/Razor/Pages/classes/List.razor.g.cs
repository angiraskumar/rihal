#pragma checksum "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86dd9c586ac37ea5f9e9952031ff3405b2e19b40"
// <auto-generated/>
#pragma warning disable 1591
namespace CurdOperation.Web.Pages.classes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using CurdOperation.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using CurdOperation.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
using CurdOperation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
using CurdOperation.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/classes/list")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\r\n    <h3>Class List</h3>\r\n    <div class=\"form-group\">\r\n        <a class=\"btn btn-success\" href=\"classes/create\"><i class=\"oi oi-plus\"></i> Create New</a>\r\n    </div>\r\n    <br>\r\n</div>\r\n");
#nullable restore
#line 14 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
 if (models == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 17 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Class Name</th>\r\n               \r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 29 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
             foreach (var cls in models)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
                         cls.ClassId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
                         cls.ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                   \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 36 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 39 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\classes\List.razor"
       
    private ClassesModel[] models;

    protected override async Task OnInitializedAsync()
    {
        models = await service.GetClasses();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassesService service { get; set; }
    }
}
#pragma warning restore 1591
