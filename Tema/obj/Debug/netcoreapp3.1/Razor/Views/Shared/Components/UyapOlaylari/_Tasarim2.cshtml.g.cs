#pragma checksum "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe59efe142a64229efca8c60ed0932d81fddf63c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UyapOlaylari__Tasarim2), @"mvc.1.0.view", @"/Views/Shared/Components/UyapOlaylari/_Tasarim2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe59efe142a64229efca8c60ed0932d81fddf63c", @"/Views/Shared/Components/UyapOlaylari/_Tasarim2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d193bd4c7e7d4de6350815cc45c078d4250dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UyapOlaylari__Tasarim2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-12"" style=""margin: 10px;"">
        <button type=""button"" id=""kimligibelirlimadur"" class=""btn btn-primary"">Kimliği Belirli Mağdur <span class=""glyphicon glyphicon-list-alt"" aria-hidden=""true""></span>  </button>
    <button type=""button"" id=""kimligibelirlisupheli"" class=""btn btn-primary"">Kimliği Belirli Şüpheli <span class=""glyphicon glyphicon-list-alt"" aria-hidden=""true""></span>  </button>
    <button type=""button"" id=""kimligibelirlitanik"" class=""btn btn-primary"">Kimliği Belirli Tanık <span class=""glyphicon glyphicon-list-alt"" aria-hidden=""true""></span>  </button>
    <button type=""button"" id=""kimligimechulmagdurtanik"" class=""btn btn-primary"">Kimliği Meçhul Mağdur/Tanık <span class=""glyphicon glyphicon-list-alt"" aria-hidden=""true""></span>  </button>
    <button type=""button"" id=""tuzelkisilik"" class=""btn btn-primary"">Tüzel Kişilik <span class=""glyphicon glyphicon-list-alt"" aria-hidden=""true""></span>  </button>
</div>


                   <div id=""divkimligibelirlisupheli"" style=""di");
            WriteLiteral("splay: none;\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("mernisBilgileri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 16 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("kimligibelirlisupheli"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"divkimligibelirlimadur\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("mernisBilgileri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("kimligibelirlimadur"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"divkimligibelirlitanik\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("mernisBilgileri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("kimligibelirlitanik"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"divkimligimechulmagdurtanik\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("mernisBilgileri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("kimligimechulmagdurtanik"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"divtuzelkisilik\"  style=\"display: none;\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("mernisBilgileri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\Shared\Components\UyapOlaylari\_Tasarim2.cshtml"
                   Write(await Component.InvokeAsync("tuzelkisilik"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n\r\n");
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
