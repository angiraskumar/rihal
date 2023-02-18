#pragma checksum "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7df5804d56214510850f0c12fe5e9dde793a0e3b"
// <auto-generated/>
#pragma warning disable 1591
namespace CurdOperation.Web.Pages.student
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
#line 3 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
using CurdOperation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
using CurdOperation.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/student/list")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\r\n    <h3>Student List</h3>\r\n    <div class=\"form-group\">\r\n        <a class=\"btn btn-success\" href=\"student/create\"><i class=\"oi oi-plus\"></i> Create New</a>\r\n    </div>\r\n    <br>\r\n</div>\r\n");
#nullable restore
#line 14 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
 if (models == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 17 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
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
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Student Name</th>\r\n                <th>Class</th>\r\n                <th>Country</th>\r\n                <th>Last Update</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 31 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
             foreach (var cls in models)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
                     cls.StudentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 35 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
                     cls.StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 36 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
                     cls.ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 37 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
                     cls.CountryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 38 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
                     cls.LastDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 40 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 43 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\List.razor"
       
    private StudentModel[] models;

    protected override async Task OnInitializedAsync()
    {
        models = await service.GetStudents();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService service { get; set; }
    }
}
#pragma warning restore 1591
