#pragma checksum "C:\Users\Laptop\Source\Repos\Grupa1-Ljepotice\Implementacija (2)\Views\Home\OdabirForme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2aa597ba8ecc718c6b7b7f643ee05394e267f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OdabirForme), @"mvc.1.0.view", @"/Views/Home/OdabirForme.cshtml")]
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
#line 1 "C:\Users\Laptop\Source\Repos\Grupa1-Ljepotice\Implementacija (2)\Views\_ViewImports.cshtml"
using Implementacija;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Laptop\Source\Repos\Grupa1-Ljepotice\Implementacija (2)\Views\_ViewImports.cshtml"
using Implementacija.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2aa597ba8ecc718c6b7b7f643ee05394e267f70", @"/Views/Home/OdabirForme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee90f075fdc38708f223e7ba174837f166cbcac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OdabirForme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>
    <button style=""margin-top:50px; display: inline-block;
  padding: 15px 25px;
  font-size: 20px;
  cursor: pointer;
  text-align: center;
  text-decoration: none;
  outline: none;
  color: #fff;
  background-color: blueviolet;
  border: none;
  border-radius: 15px;
  box-shadow: 0 9px #999;"" onclick=""redirectOnClick()"">
        Unos podataka o završenom testu
    </button>

</div>

<script>
    function redirectOnClick() {
        document.location = '/FormaZaTestDBs/Create';
    }
</script>


<div style=""padding-left:300px"">
    <button style=""margin-top:150px; display: inline-block;
  padding: 15px 25px;
  font-size: 20px;
  cursor: pointer;
  text-align: center;
  text-decoration: none;
  outline: none;
  color: #fff;
  background-color: blueviolet;
  border: none;
  border-radius: 15px;
  box-shadow: 0 9px #999;"" onclick=""redirectOnClick2()"">
        Unos podataka o završenom tretmanu
    </button>
</div>
<script>
    function redirectOnClick2() {
    ");
            WriteLiteral("    document.location = \'/FormaZaTretmanDBs/Create\';\r\n    }\r\n</script>\r\n\r\n\r\n");
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