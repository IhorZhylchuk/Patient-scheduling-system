#pragma checksum "C:\Users\Mr Z\Documents\GitHub\Patient-scheduling-system\P.S.S\P.S.S\Views\AdminMain\IndexAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bd1922ebf2f2b4a6a580a6f6a61de2a859b630c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMain_IndexAdmin), @"mvc.1.0.view", @"/Views/AdminMain/IndexAdmin.cshtml")]
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
#line 1 "C:\Users\Mr Z\Documents\GitHub\Patient-scheduling-system\P.S.S\P.S.S\Views\_ViewImports.cshtml"
using P.S.S;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr Z\Documents\GitHub\Patient-scheduling-system\P.S.S\P.S.S\Views\_ViewImports.cshtml"
using P.S.S.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd1922ebf2f2b4a6a580a6f6a61de2a859b630c", @"/Views/AdminMain/IndexAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ba28adfc748fcb173264ccdcf965d347d63bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMain_IndexAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mr Z\Documents\GitHub\Patient-scheduling-system\P.S.S\P.S.S\Views\AdminMain\IndexAdmin.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""md-form"">
    <input class=""timepicker"" data-provide=""timepicker"" type=""text"" />
    <label for=""input-limited-range"">Time...</label>
</div>

<link rel=""stylesheet"" href=""//cdnjs.cloudflare.com/ajax/libs/timepicker/1.3.5/jquery.timepicker.min.css"">
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"//cdnjs.cloudflare.com/ajax/libs/timepicker/1.3.5/jquery.timepicker.min.js\"></script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
