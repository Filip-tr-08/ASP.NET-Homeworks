#pragma checksum "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\Homework2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d006bd11d8638d2410dbf174a5b2d2ac3011c671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
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
#line 1 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\Homework2\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\Homework2\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\Homework2\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d006bd11d8638d2410dbf174a5b2d2ac3011c671", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ea9ab00a32b7f2cf7f231de5ada8c6192dfdcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<title>Pizza - ");
#nullable restore
#line 6 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\Homework2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title> ");
            WriteLiteral("\n\n<h2>Details:</h2>\n<p>Name:");
#nullable restore
#line 9 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\Homework2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
   Write(ViewBag.PizzaViewModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Price:");
#nullable restore
#line 10 "E:\web development\seavus prezentacii i materijali\domasni\asp.net domasni\Homework2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
    Write(ViewBag.PizzaViewModel.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
