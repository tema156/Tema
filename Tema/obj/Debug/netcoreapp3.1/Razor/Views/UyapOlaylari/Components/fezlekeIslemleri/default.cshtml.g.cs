#pragma checksum "C:\Users\2549186\Source\Repos\Tema2\Tema\Views\UyapOlaylari\Components\fezlekeIslemleri\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a7064a09087ce500e607bb18733ecefca4c0ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UyapOlaylari_Components_fezlekeIslemleri_default), @"mvc.1.0.view", @"/Views/UyapOlaylari/Components/fezlekeIslemleri/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a7064a09087ce500e607bb18733ecefca4c0ba8", @"/Views/UyapOlaylari/Components/fezlekeIslemleri/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d193bd4c7e7d4de6350815cc45c078d4250dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_UyapOlaylari_Components_fezlekeIslemleri_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""panel panel-default"">
  <div class=""panel-heading""  style=""color:red"" >İhbar Bilgileri</div>
  <div class=""panel-body"">
<div class=""form-group col-lg-12"">
                                        <label for=""exampleFormControlTextarea1"">İhbar ve Bildirim Özeti</label>
                                        <textarea class=""form-control"" id=""exampleFormControlTextarea1"" placeholder="" İhbar özeti burada olacaktır""></textarea>
                                    </div>


                                    <div class=""form-group col-lg-12"">
                                        <label for=""exampleFormControlSelect1"">Sorumlu Birlik</label>
                                        <select class=""form-control"" id=""exampleFormControlSelect1"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a7064a09087ce500e607bb18733ecefca4c0ba84038", async() => {
                WriteLiteral("Ankara");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a7064a09087ce500e607bb18733ecefca4c0ba85040", async() => {
                WriteLiteral("İstanbul");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a7064a09087ce500e607bb18733ecefca4c0ba86044", async() => {
                WriteLiteral("İzmir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                    </div>
  </div>
</div>


<div class=""panel panel-default"">
  <div class=""panel-heading"">
    <h3 class=""panel-title"" style=""color:red""  >Olay Özet Bilgileri</h3>
  </div>
  <div class=""panel-body"">
 <div class=""form-group col-lg-12"">
   <label for=""exampleFormControlSelect1"">Olay Özeti</label>
   <textarea  class=""form-control""></textarea>
   </div>
  </div>
</div>


<div class=""panel panel-default"">
  <div class=""panel-heading"">
    <h3 class=""panel-title"" style=""color:red""   >Taraf Bilgileri</h3>
  </div>
  <div class=""panel-body"">
    Panel content
  </div>
</div>



<div class=""panel panel-default"">
  <div class=""panel-heading"">
    <h3 class=""panel-title""   style=""color:red"" >Tahkikat Bilgileri</h3>
  </div>
  <div class=""panel-body"">
    Panel content
  </div>
</div>
            
            
<button type=""button"" class=""btn btn-success"">Polise Aktar</button>
<button type=""but");
            WriteLiteral("ton\" class=\"btn btn-success\">Olaya Ait Fezleke Oluştur</button>\r\n<button type=\"button\" class=\"btn btn-warning\">Çıktı Al</button>\r\n<button type=\"button\" class=\"btn btn-warning\">Onaya Gönder </button>\r\n\r\n\r\n\r\n    ");
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
