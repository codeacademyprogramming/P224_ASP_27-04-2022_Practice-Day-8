#pragma checksum "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6c780997930e679a85a20db06f9b12e05ed3a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6c780997930e679a85a20db06f9b12e05ed3a6", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e0429dacd3d1f56724a20b4541864981ed863e", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--====== Breadcrumb Part Start ======-->

<div class=""breadcrumb-area"">
    <div class=""container-fluid custom-container"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item active"">Cart</li>
            </ol>
        </nav>
    </div> <!-- container -->
</div>

<!--====== Breadcrumb Part Ends ======-->
<!--====== Cart Part Start ======-->

<section class=""cart-page pt-10"">
    <div class=""container-fluid custom-container"">
        <div class=""row basketContainer"">
            ");
#nullable restore
#line 25 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Basket\Index.cshtml"
       Write(await Html.PartialAsync("_BasketIndexPartial",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>

<!--====== Cart Part Ends ======-->
<!--====== Brand Part Start ======-->

<div class=""brand-area pt-80"">
    <div class=""container-fluid custom-container"">
        <div class=""row brand-active"">
            <div class=""col-lg-2"">
                <div class=""single-brand"">
                    <a href=""#"">
                        <img src=""assets/images/brand/brand-1.jpg"" alt=""brand"">
                    </a>
                </div> <!-- single brand -->
            </div>
            <div class=""col-lg-2"">
                <div class=""single-brand"">
                    <a href=""#"">
                        <img src=""assets/images/brand/brand-2.jpg"" alt=""brand"">
                    </a>
                </div> <!-- single brand -->
            </div>
            <div class=""col-lg-2"">
                <div class=""single-brand"">
                    <a href=""#"">
                        <img src=""assets/images/brand/brand-3.jpg"" alt=""brand"">
         ");
            WriteLiteral(@"           </a>
                </div> <!-- single brand -->
            </div>
            <div class=""col-lg-2"">
                <div class=""single-brand"">
                    <a href=""#"">
                        <img src=""assets/images/brand/brand-4.jpg"" alt=""brand"">
                    </a>
                </div> <!-- single brand -->
            </div>
            <div class=""col-lg-2"">
                <div class=""single-brand"">
                    <a href=""#"">
                        <img src=""assets/images/brand/brand-5.jpg"" alt=""brand"">
                    </a>
                </div> <!-- single brand -->
            </div>
            <div class=""col-lg-2"">
                <div class=""single-brand"">
                    <a href=""#"">
                        <img src=""assets/images/brand/brand-6.jpg"" alt=""brand"">
                    </a>
                </div> <!-- single brand -->
            </div>
            <div class=""col-lg-2"">
                <div class=""single-brand"">
");
            WriteLiteral(@"                    <a href=""#"">
                        <img src=""assets/images/brand/brand-4.jpg"" alt=""brand"">
                    </a>
                </div> <!-- single brand -->
            </div>
        </div> <!-- row -->
    </div> <!-- container -->
</div>

<!--====== Brand Part Ends ======-->
<!--====== Features Banner Part Start ======-->

<section class=""features-banner-area pt-80 pb-100"">
    <div class=""container-fluid custom-container"">
        <div class=""features-banner-wrapper d-flex flex-wrap"">
            <div class=""single-features-banner d-flex"">
                <div class=""banner-icon"">
                    <img src=""assets/images/banner-icon/icon1.png"" alt=""Icon"">
                </div>
                <div class=""banner-content media-body"">
                    <h3 class=""banner-title"">Free Shipping</h3>
                    <p>Free shipping on all US order</p>
                </div>
            </div> <!-- single features banner -->
            <div class=""singl");
            WriteLiteral(@"e-features-banner d-flex"">
                <div class=""banner-icon"">
                    <img src=""assets/images/banner-icon/icon2.png"" alt=""Icon"">
                </div>
                <div class=""banner-content media-body"">
                    <h3 class=""banner-title"">Support 24/7</h3>
                    <p>Contact us 24 hours a day</p>
                </div>
            </div> <!-- single features banner -->
            <div class=""single-features-banner d-flex"">
                <div class=""banner-icon"">
                    <img src=""assets/images/banner-icon/icon3.png"" alt=""Icon"">
                </div>
                <div class=""banner-content media-body"">
                    <h3 class=""banner-title"">100% Money Back</h3>
                    <p>You have 30 days to Return</p>
                </div>
            </div> <!-- single features banner -->
            <div class=""single-features-banner d-flex"">
                <div class=""banner-icon"">
                    <img src=""assets/im");
            WriteLiteral(@"ages/banner-icon/icon4.png"" alt=""Icon"">
                </div>
                <div class=""banner-content media-body"">
                    <h3 class=""banner-title"">90 Days Return</h3>
                    <p>If goods have problems</p>
                </div>
            </div> <!-- single features banner -->
            <div class=""single-features-banner d-flex"">
                <div class=""banner-icon"">
                    <img src=""assets/images/banner-icon/icon5.png"" alt=""Icon"">
                </div>
                <div class=""banner-content media-body"">
                    <h3 class=""banner-title"">Payment Secure</h3>
                    <p>We ensure secure payment</p>
                </div>
            </div> <!-- single features banner -->
        </div> <!-- features banner wrapper -->
    </div> <!-- container -->
</section>

<!--====== Features Banner Part Ends ======-->
<!--====== Newsletter Part Start ======-->

<section class=""newsletter-area pt-100 pb-100 bg_cover"" style=""ba");
            WriteLiteral(@"ckground-image: url(assets/images/bg-newletter.jpg)"">
    <div class=""container"">
        <div class=""row justify-content-end"">
            <div class=""col-lg-8"">
                <div class=""newsletter-content"">
                    <h2 class=""newsletter-title"">Subscribe our newsletter</h2>
                    <p>allup is a powerful eCommerce HTML Template</p>

                    <div class=""newsletter-forn"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6c780997930e679a85a20db06f9b12e05ed3a611256", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Your Email address\">\r\n                            <button class=\"main-btn\">Subscribe</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div> <!-- newsletter content -->\r\n            </div>\r\n        </div> <!-- row -->\r\n    </div> <!-- container -->\r\n</section>\r\n\r\n<!--====== Newsletter Part Ends ======-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
