#pragma checksum "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33325b6ab5282da460906c0e97624f7b6adf019d"
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
#line 1 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using MicroWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using MicroWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using MicroWebApp.Models.ControllersModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using MicroWebApp.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using MicroWebApp.HelperClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Bootstrap4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\MicroWebPrj\MicroWebApp\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Bootstrap4.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33325b6ab5282da460906c0e97624f7b6adf019d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd958b107aba867e683305adabf299827fc0f1f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<BlogsModelsWithPhoto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Responsive image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\r\n  <div class=\"rightSection\">\r\n        <div class=\" col-0 col-md-3 d-none d-md-block d-sm-none \">\r\n        <h1 class=\"ensevilen\">En Sevilen Yazılar</h1>\r\n\r\n         </div>\r\n  </div>\r\n</section>\r\n\r\n\r\n");
#nullable restore
#line 21 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
  
    foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section class=""blogSection"">
            <div class=""container-fluid flexxx"">
                <div class=""row"">
                    <div class=""col-11 col-md-9 col-sm-11"">
                        <div class=""card w-100 shadow"">
                            <div class=""card-body"">
                                <a href=""/karpuz.html""> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "33325b6ab5282da460906c0e97624f7b6adf019d6378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
                                                      WriteLiteral(item.PhotoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 30 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                <br>\r\n                                <br>\r\n                                <h5 class=\"card-title paragraf sec-h5\"><span class=\"sec--h5\">");
#nullable restore
#line 34 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
                                                                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                                <p class=\"card-text paragraf card-ppp\">");
#nullable restore
#line 35 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
                                                                  Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"blogInfo\">\r\n                                <span class=\"createDate\">Paylasim tarixi: ");
#nullable restore
#line 42 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
                                                                     Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h6 class=\"author\">Yazar: ");
#nullable restore
#line 43 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
                                                     Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </section>\r\n");
            WriteLiteral("        <!-----------------SECTION-1 BITIR-------------------------->\r\n");
#nullable restore
#line 58 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"paging col-10\">\r\n    ");
#nullable restore
#line 63 "E:\MicroWebPrj\MicroWebApp\Views\Home\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new {page}),
    Bootstrap4PagedListRenderOptions.ClassicPlusFirstAndLast));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<br>
<br>

<section style=""max-width: 100%; overflow: hidden;"">
    <div>

        <div class=""about"">
            <h1 class=""eniyi"">En İyi Yazarlarımız</h1>
            <br>
            <h3 id=""h3"" class=""vibrate-1""> Ben Nurlan Gulu, 2017 senesinden buyana blog yazarlığı yapıyorum, ve işimi
                çok seviyorum.</h3>
            <br />
            <br />


        </div>

    </div>

    <div class=""about"">
        <div class=""padd"">
            <p> <span id=""id1"">AKLIMA</span> <span className=""paragraf""> - COO, AMERIMAR ENTERPRISES, INC.</span></p>
        </div>
    </div>
    <br>
    <div class=""imgcontainer img22 container"">
        <div class=""imgclick row"">

            <div><a onclick=""aklima()"" href=""#sec5""><img id=""aklima"" style="" border-radius: 5px;"" class=""imageclick""
                        src=""http://vue.rainbowit.net/img/testimonial-2.b2f946b1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2977, "\"", 2983, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a></div>\r\n            <div><a onclick=\"fatima()\" href=\"#sec5\"><img id=\"fatima\" class=\"imageclick\"\r\n                        src=\"http://vue.rainbowit.net/img/testimonial-2.b2f946b1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3173, "\"", 3179, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a></div>\r\n            <div><a onclick=\"jannat()\" href=\"#sec5\"><img id=\"jannat\" class=\"imageclick\"\r\n                        src=\"http://vue.rainbowit.net/img/testimonial-3.3926a604.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3369, "\"", 3375, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a></div>\r\n            <div><a onclick=\"johns()\" href=\"#sec5\"><img id=\"johns\" class=\"imageclick\"\r\n                        src=\"http://vue.rainbowit.net/img/testimonial-4.5d3ec0a7.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3563, "\"", 3569, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a></div>\r\n            <div><a onclick=\"john()\" href=\"#sec5\"><img id=\"john\" class=\"imageclick\"\r\n                        src=\"http://vue.rainbowit.net/img/testimonial-5.70ba829d.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3755, "\"", 3761, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a></div>\r\n            <div><a onclick=\"amar()\" href=\"#sec5\"><img id=\"amar\" class=\"imageclick\"\r\n                        src=\"http://vue.rainbowit.net/img/testimonial-6.32f5aaee.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3947, "\"", 3953, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a></div>\r\n            <div><a onclick=\"fatimama()\" href=\"#sec5\"><img id=\"fatimama\" class=\"imageclick\"\r\n                        src=\"http://vue.rainbowit.net/img/testimonial-7.8ec70d2b.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4147, "\"", 4153, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a></div>

        </div>
    </div>
    <br />



</section>
<br>
<br>

<section>

    <div class=""text-center"">
        <h1>Tərəfdaşlarımız</h1>
    </div>
    <hr style=""width: 50%;"">

    <div class=""responsive container"">
        <div>
            <img src=""http://vue.rainbowit.net/img/brand-02.0f998484.png""");
            BeginWriteAttribute("alt", " alt=\"", 4493, "\"", 4499, 0);
            EndWriteAttribute();
            WriteLiteral("> <br>\r\n        </div>\r\n        <div>\r\n            <img src=\"http://vue.rainbowit.net/img/brand-01.881d99d3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4612, "\"", 4618, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <br>\r\n        </div>\r\n        <div>\r\n            <img src=\"http://vue.rainbowit.net/img/brand-04.f60ed605.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4744, "\"", 4750, 0);
            EndWriteAttribute();
            WriteLiteral("> <br>\r\n        </div>\r\n        <div>\r\n            <img src=\"http://vue.rainbowit.net/img/brand-05.9afbe393.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4863, "\"", 4869, 0);
            EndWriteAttribute();
            WriteLiteral("> <br>\r\n        </div>\r\n        <div>\r\n            <img src=\"http://vue.rainbowit.net/img/brand-06.8e38619b.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4982, "\"", 4988, 0);
            EndWriteAttribute();
            WriteLiteral("> <br>\r\n        </div>\r\n        <div>\r\n            <img src=\"http://vue.rainbowit.net/img/brand-03.3384d0c1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5101, "\"", 5107, 0);
            EndWriteAttribute();
            WriteLiteral("> <br>\r\n        </div>\r\n        <div>\r\n            <img src=\"http://vue.rainbowit.net/img/brand-02.0f998484.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5220, "\"", 5226, 0);
            EndWriteAttribute();
            WriteLiteral("> <br>\r\n        </div>\r\n        <div>\r\n            <img src=\"http://vue.rainbowit.net/img/brand-04.f60ed605.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5339, "\"", 5345, 0);
            EndWriteAttribute();
            WriteLiteral("> <br>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<BlogsModelsWithPhoto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
