#pragma checksum "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab6ea359002717f999fd52dafd9a63a94f0af801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\_ViewImports.cshtml"
using VetChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\_ViewImports.cshtml"
using VetChat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab6ea359002717f999fd52dafd9a63a94f0af801", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c97886edbd2b53b7e2d228cebf4d09813fab65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\Home\Index.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""text-center"">
    <h1 class=""display-4 text-white"">Welcome to VetChat</h1>
    <p class=""text-white"">Let's connect with other veterans or service members around the world!</p>
</div>
<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner fixed-top"">
        <div class=""carousel-item active"">
            <img src=""https://cloudfront-us-east-1.images.arcpublishing.com/gray/DP7WUXDA4ZJUJNKF3WRV76TYVA.jpg"" class=""d-block w-100 rounded border border-dark"" alt=""Thanke you for your service"">
        </div>
        <div class=""carousel-item"">
            <img src=""https://27pebh3agxku3bgo3k10r6k0-wpengine.netdna-ssl.com/wp-content/uploads/2016");
            WriteLiteral(@"/11/iStock_14772884_XLARGE.jpg"" class=""d-block w-100 rounded border border-dark"" alt=""Thanks"">
        </div>
        <div class=""carousel-item"">
            <img src=""https://i0.wp.com/www.natchitochestimes.com/wp-content/uploads/2017/09/veterans-day1.jpg?fit=1400%2C900&ssl=1"" class=""d-block w-100 rounded border border-dark"" alt=""Branch"">
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
");
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