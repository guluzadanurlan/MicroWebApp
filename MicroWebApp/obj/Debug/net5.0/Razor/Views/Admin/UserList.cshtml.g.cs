#pragma checksum "E:\MicroWebPrj\MicroWebApp\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc0ba3986d539508e61c83fd4132cef5a9bcf4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc0ba3986d539508e61c83fd4132cef5a9bcf4b", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209c94c65f88b4645ccf308cb2d901ff2ea3163d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MicroWebPrj\MicroWebApp\Views\Admin\UserList.cshtml"
  Layout="_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\MicroWebPrj\MicroWebApp\Views\Admin\UserList.cshtml"
      
        foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 7 "E:\MicroWebPrj\MicroWebApp\Views\Admin\UserList.cshtml"
          Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n             <p>");
#nullable restore
#line 8 "E:\MicroWebPrj\MicroWebApp\Views\Admin\UserList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 9 "E:\MicroWebPrj\MicroWebApp\Views\Admin\UserList.cshtml"
              Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>----------------------</p>\r\n");
#nullable restore
#line 11 "E:\MicroWebPrj\MicroWebApp\Views\Admin\UserList.cshtml"

        }
    

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591