#pragma checksum "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cdb054a365347dbca9c0fd783bc10ece73828ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Details), @"mvc.1.0.view", @"/Views/Author/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cdb054a365347dbca9c0fd783bc10ece73828ce", @"/Views/Author/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80915d9b3061c82dcf6ac8148304f783530b57f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorDetailsViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"" style=""color:white"">
    <h2 class=""display-4"">Author Details:</h2>
</div>
<br />
<br />
<div class=""card"" style=""display: flex; flex-direction: row; overflow-wrap: break-word"">
    <div class=""card-body"">
        <h5 class=""card-title"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cdb054a365347dbca9c0fd783bc10ece73828ce5180", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 10 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

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
#line 10 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
                                                             Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cdb054a365347dbca9c0fd783bc10ece73828ce7078", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 11 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nationality);

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
#line 11 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
                                                                                   Write(Model.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <div class=\"card\" style=\"width: 18rem; margin-left:15px;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=", 577, "", 598, 1);
#nullable restore
#line 13 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
WriteAttributeValue("", 582, Model.ImageLink, 582, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"card\" style=\"width: 40rem; margin-left:15px;\">\r\n        <h5 class=\"card-title mt-5 mb-5 ml-5\">Biography:</h5>\r\n        <p class=\"card-title mt-3 mb-5 ml-5 mr-5\">");
#nullable restore
#line 19 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
                                             Write(Model.Biography);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n\r\n</div>\r\n<br />\r\n<h3 style=\"color:white\">List Of Books:</h3>\r\n");
#nullable restore
#line 26 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
 if (Model.Books.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 style=\"color:white\">There are not any books inserted for this author...</h4>\r\n");
#nullable restore
#line 29 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 33 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
     foreach (var book in Model.Books)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 18rem; margin-left:15px;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1230, "\"", 1251, 1);
#nullable restore
#line 36 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
WriteAttributeValue("", 1236, book.ImageLink, 1236, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"text-center\">");
#nullable restore
#line 38 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
                                   Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>");
#nullable restore
#line 40 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 42 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\BonusBook\BookLibraryApp\BookLibraryApp\Views\Author\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
