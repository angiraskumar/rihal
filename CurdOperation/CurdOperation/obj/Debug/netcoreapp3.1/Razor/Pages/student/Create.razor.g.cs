#pragma checksum "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e80fd25d1cca5ec5a2a2c8cd4925397260c2357"
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
#line 3 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
using CurdOperation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
using CurdOperation.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/student/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Student</h2>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                  model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                    CreateCountry

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group ");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<label>Name:</label>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "name");
                __builder2.AddAttribute(17, "class", "form-control col-sm-5");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                                                                model.StudentName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.StudentName = __value, model.StudentName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.StudentName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group ");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.AddMarkupContent(30, "<label>Class</label>\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __Blazor.CurdOperation.Web.Pages.student.Create.TypeInference.CreateInputSelect_0(__builder2, 33, 34, "form-control col-sm-3", 35, 
#nullable restore
#line 26 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                           model.ClassId

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ClassId = __value, model.ClassId)), 37, () => model.ClassId, 38, (__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n                    ");
                    __builder3.AddMarkupContent(40, "<option value=\"0\">--Select--</option>\r\n");
#nullable restore
#line 28 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                     foreach (var cls in classes)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(41, "                        ");
                    __builder3.OpenElement(42, "option");
                    __builder3.AddAttribute(43, "value", 
#nullable restore
#line 30 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                       cls.ClassId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(44, 
#nullable restore
#line 30 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                                    cls.ClassName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\r\n");
#nullable restore
#line 31 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"

                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(46, "                ");
                }
                );
                __builder2.AddMarkupContent(47, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group ");
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.AddMarkupContent(56, "<label>Country</label>\r\n            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddMarkupContent(58, "\r\n                ");
                __Blazor.CurdOperation.Web.Pages.student.Create.TypeInference.CreateInputSelect_1(__builder2, 59, 60, "form-control col-sm-3", 61, 
#nullable restore
#line 42 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                           model.CountryId

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.CountryId = __value, model.CountryId)), 63, () => model.CountryId, 64, (__builder3) => {
                    __builder3.AddMarkupContent(65, "\r\n                    ");
                    __builder3.AddMarkupContent(66, "<option value=\"0\">--Select--</option>\r\n");
#nullable restore
#line 44 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                     foreach (var cls in countries)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(67, "                        ");
                    __builder3.OpenElement(68, "option");
                    __builder3.AddAttribute(69, "value", 
#nullable restore
#line 46 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                       cls.CountryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(70, 
#nullable restore
#line 46 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
                                                      cls.CountryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n");
#nullable restore
#line 47 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"

                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(72, "                ");
                }
                );
                __builder2.AddMarkupContent(73, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n    ");
                __builder2.AddMarkupContent(77, "<div class=\"row\">\r\n        <div class=\"col-md-12 text-right\">\r\n            <button type=\"submit\" class=\"btn btn-success\">Create</button>\r\n        </div>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "E:\ProjectSample\Rihal\CurdOperation\CurdOperation\Pages\student\Create.razor"
       
    StudentModel model = new StudentModel();
    private ClassesModel[] classes;
    private CountryModel[] countries;
    protected override async Task OnInitializedAsync()
    {
        classes = await clsservice.GetClasses();
        countries = await cntryservice.GetCountries();
    }

    async Task CreateCountry()
    {
        await service.AddStudent(model);
        navManger.NavigateTo("/student/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICountryService cntryservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassesService clsservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService service { get; set; }
    }
}
namespace __Blazor.CurdOperation.Web.Pages.student.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
