#pragma checksum "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\UyapOlaylari\Components\tahkikatIslemleriTasarim2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae525c1253a802f561e3e791875f8672ccd5246c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UyapOlaylari_Components_tahkikatIslemleriTasarim2_Default), @"mvc.1.0.view", @"/Views/UyapOlaylari/Components/tahkikatIslemleriTasarim2/Default.cshtml")]
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
#line 1 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\_ViewImports.cshtml"
using Tema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\_ViewImports.cshtml"
using Tema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae525c1253a802f561e3e791875f8672ccd5246c", @"/Views/UyapOlaylari/Components/tahkikatIslemleriTasarim2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d193bd4c7e7d4de6350815cc45c078d4250dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_UyapOlaylari_Components_tahkikatIslemleriTasarim2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <div class=""panel panel-info"">
  <div class=""panel-heading"">Tahkikat İşlemleri</div>
  <div class=""panel-body"">
                <button type=""button"" id=""B_olayYeriTesbitTutatagi"" class=""btn btn-primary"">Olay Yeri Tespit Tutanağı <span class=""glyphicon glyphicon-list-alt"" aria-hidden=""true""></span>  </button>
                <button type=""button"" id=""B_ifadeAlmaIslemleri"" class=""btn btn-primary"">İfade Alma İşlemleri <span class=""glyphicon glyphicon-pencil"" aria-hidden=""true""></span> </button>
                <button type=""button"" id=""B_aileIciSiddetOlaylari"" class=""btn btn-primary"">Aile İçi Şiddet Olayları  <span class=""glyphicon glyphicon-plus-sign"" aria-hidden=""true""></span></button>
                <button type=""button"" id=""B_savciGorusmeTutanagi"" class=""btn btn-primary"">Savcı Görüşme Tutanağı <span class=""glyphicon glyphicon-edit"" aria-hidden=""true""></span> </button>
                <button type=""button"" id=""B_degerTesbitTutatagi"" class=""btn btn-primary"">İlgili Kurum Değer Tespit Tutanağı <span c");
            WriteLiteral("lass=\"glyphicon glyphicon-file\" aria-hidden=\"true\"></span></button>\r\n\r\n  </div>\r\n</div>\r\n\r\n\r\n<div  class=\"col-lg-12\" style=\"margin:5px;\">\r\n                    <div id=\"olayYeriTesbitTutatagi_view\" style=\"display: none;\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\UyapOlaylari\Components\tahkikatIslemleriTasarim2\Default.cshtml"
                   Write(await Component.InvokeAsync("olayYeriTesbitTutanagi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"ifadeAlmaIslemleri_view\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\UyapOlaylari\Components\tahkikatIslemleriTasarim2\Default.cshtml"
                   Write(await Component.InvokeAsync("ifadeAlmaIslemleri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"aileIciSiddetOlaylari_view\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\UyapOlaylari\Components\tahkikatIslemleriTasarim2\Default.cshtml"
                   Write(await Component.InvokeAsync("aileIciSiddetOlaylari"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                     <div id=\"savciGorusmeTutanagi_view\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\UyapOlaylari\Components\tahkikatIslemleriTasarim2\Default.cshtml"
                   Write(await Component.InvokeAsync("savciGorusmeTutanagi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"degerTesbitTutatagi_view\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\UyapOlaylari\Components\tahkikatIslemleriTasarim2\Default.cshtml"
                   Write(await Component.InvokeAsync("degerTesbitTutatagi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n</div>   \r\n\r\n  ");
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
