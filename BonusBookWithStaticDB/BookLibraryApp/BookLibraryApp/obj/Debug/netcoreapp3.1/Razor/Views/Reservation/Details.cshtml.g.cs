#pragma checksum "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3478234f0eb96d14bbf588f5d3db49ec990219b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Details), @"mvc.1.0.view", @"/Views/Reservation/Details.cshtml")]
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
#nullable restore
#line 1 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.ReservationViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.AuthorViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.BookViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.MemberViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.HomeViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3478234f0eb96d14bbf588f5d3db49ec990219b", @"/Views/Reservation/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80915d9b3061c82dcf6ac8148304f783530b57f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservationDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\" style=\"color:white\">\r\n    <h2 class=\"display-4\">Reservation Details:</h2>\r\n</div>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3478234f0eb96d14bbf588f5d3db49ec990219b5840", async() => {
                WriteLiteral("Add Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3478234f0eb96d14bbf588f5d3db49ec990219b8229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 11 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MemberFullName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(":");
#nullable restore
#line 11 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
                                                                   Write(Model.MemberFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3478234f0eb96d14bbf588f5d3db49ec990219b10155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 12 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PaymentMethod);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 12 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
                                                                                    Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Reading ");
#nullable restore
#line 13 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
                                                     Write(Model.ReservationMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p class=\"card-subtitle mb-2 text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3478234f0eb96d14bbf588f5d3db49ec990219b12479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateTimeBegin);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(";");
#nullable restore
#line 14 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
                                                                                    Write(Model.DateTimeBegin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-subtitle mb-2 text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3478234f0eb96d14bbf588f5d3db49ec990219b14419", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 15 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateTimeEnd);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(":");
#nullable restore
#line 15 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
                                                                                  Write(Model.DateTimeEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 20 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
     foreach (var book in Model.Books)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 18rem; margin-left:15px;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1021, "\"", 1042, 1);
#nullable restore
#line 23 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
WriteAttributeValue("", 1027, book.ImageLink, 1027, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"text-center\">");
#nullable restore
#line 25 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
                                   Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>");
#nullable restore
#line 27 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Reservation\Details.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
