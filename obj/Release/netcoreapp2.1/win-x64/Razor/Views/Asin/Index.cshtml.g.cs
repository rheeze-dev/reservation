#pragma checksum "G:\dev\reservation\Views\Asin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f397f237d377168cfb5031807c14557fdabae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asin_Index), @"mvc.1.0.view", @"/Views/Asin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asin/Index.cshtml", typeof(AspNetCore.Views_Asin_Index))]
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
#line 1 "G:\dev\reservation\Views\_ViewImports.cshtml"
using AsinTransientAndApartment;

#line default
#line hidden
#line 2 "G:\dev\reservation\Views\_ViewImports.cshtml"
using AsinTransientAndApartment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f397f237d377168cfb5031807c14557fdabae2", @"/Views/Asin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944ac3da14e7a0af6a549436d58c02eb404c5639", @"/Views/_ViewImports.cshtml")]
    public class Views_Asin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1336, true);
            WriteLiteral(@"<!-- Navigation -->
<nav class=""navbar navbar-expand-lg navbar-light fixed-top py-3"" id=""mainNav"">
    <div class=""container"">
        <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">Home</a>
        <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
            <ul class=""navbar-nav ml-auto my-2 my-lg-0"">
                <li class=""nav-item"">
                    <a class=""nav-link js-scroll-trigger"" href=""#about"">About</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link js-scroll-trigger"" href=""#portfolio"">Portfolio</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link js-scroll-trigger"" hre");
            WriteLiteral(@"f=""#services"">Reservation</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link js-scroll-trigger"" href=""#contact"">Contact</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<!-- Home Section -->
<section id=""page-top"">
    ");
            EndContext();
            BeginContext(1337, 51, false);
#line 29 "G:\dev\reservation\Views\Asin\Index.cshtml"
Write(await Html.PartialAsync("~/views/Asin/Home.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 100, true);
            WriteLiteral("\r\n</section>\r\n\r\n<!-- AboutUs Section -->\r\n<section class=\"page-section bg-primary\" id=\"about\">\r\n    ");
            EndContext();
            BeginContext(1489, 54, false);
#line 34 "G:\dev\reservation\Views\Asin\Index.cshtml"
Write(await Html.PartialAsync("~/views/Asin/AboutUs.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 16, true);
            WriteLiteral("\r\n</section>\r\n\r\n");
            EndContext();
            BeginContext(1822, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
            BeginContext(10895, 75, true);
            WriteLiteral("\r\n   \r\n\r\n</div>\r\n<!-- Portfolio Section -->\r\n<section id=\"portfolio\">\r\n    ");
            EndContext();
            BeginContext(10971, 56, false);
#line 287 "G:\dev\reservation\Views\Asin\Index.cshtml"
Write(await Html.PartialAsync("~/views/Asin/Portfolio.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(11027, 132, true);
            WriteLiteral("\r\n</section>\r\n<!-- Rheeze Gyver B. Kalahi -->\r\n<div class=\"w3-container w3-black text-black\">\r\n    <h2 class=\"mb-4\"> </h2>\r\n</div>\r\n");
            EndContext();
            BeginContext(11337, 82, true);
            WriteLiteral("\r\n<!-- Reservation Section -->\r\n<section class=\"page-section\" id=\"services\">\r\n    ");
            EndContext();
            BeginContext(11420, 58, false);
#line 302 "G:\dev\reservation\Views\Asin\Index.cshtml"
Write(await Html.PartialAsync("~/views/Asin/Reservation.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(11478, 16, true);
            WriteLiteral("\r\n</section>\r\n\r\n");
            EndContext();
            BeginContext(11761, 88, true);
            WriteLiteral("\r\n<!-- Contact Section -->\r\n<section class=\"page-section bg-primary\" id=\"contact\">\r\n    ");
            EndContext();
            BeginContext(11850, 54, false);
#line 317 "G:\dev\reservation\Views\Asin\Index.cshtml"
Write(await Html.PartialAsync("~/views/Asin/Contact.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(11904, 56, true);
            WriteLiteral("\r\n</section>\r\n\r\n<section class=\"page-Testimonial\">\r\n    ");
            EndContext();
            BeginContext(11961, 58, false);
#line 321 "G:\dev\reservation\Views\Asin\Index.cshtml"
Write(await Html.PartialAsync("~/views/Asin/Testimonial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(12019, 16, true);
            WriteLiteral("\r\n</section>\r\n\r\n");
            EndContext();
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
