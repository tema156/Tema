#pragma checksum "E:\Calismalarim\Github\Tema\Tema\Views\UyapOlaylari\ihbarGirisIslemleri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2697bb9701437e0d6feaf08162b05e21bfa8346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UyapOlaylari_ihbarGirisIslemleri), @"mvc.1.0.view", @"/Views/UyapOlaylari/ihbarGirisIslemleri.cshtml")]
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
#line 1 "E:\Calismalarim\Github\Tema\Tema\Views\_ViewImports.cshtml"
using Tema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Calismalarim\Github\Tema\Tema\Views\_ViewImports.cshtml"
using Tema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2697bb9701437e0d6feaf08162b05e21bfa8346", @"/Views/UyapOlaylari/ihbarGirisIslemleri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39359d2d1e2bc32db81741592126793fd96ff379", @"/Views/_ViewImports.cshtml")]
    public class Views_UyapOlaylari_ihbarGirisIslemleri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "E:\Calismalarim\Github\Tema\Tema\Views\UyapOlaylari\ihbarGirisIslemleri.cshtml"
  
    ViewData["Title"] = "ihbarGirisIslemleri";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    <div class=\"container\">\n\n        <div >\n          <h1  style=\"color:red\" >İHBAR İŞLEMLERİ</h1>\n        </div>\n\n\n\n        <div class=\"row\">\n            \n            <br />\n\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa83463876", async() => {
                WriteLiteral("\n\n                <div class=\"form-group col-md-4\">\n                    <label for=\"exampleFormControlSelect1\">İhbar Bildirim tipi</label>\n                    <select class=\"form-control\" id=\"exampleFormControlSelect1\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa83464387", async() => {
                    WriteLiteral("156 İhbar Hattı");
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa83465432", async() => {
                    WriteLiteral("Doğrudan");
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa83466470", async() => {
                    WriteLiteral("Karakola Müracaat");
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

                <div class=""form-group col-md-4"">
                    <label for=""exampleFormControlInput1"">Tarih ve saati</label>
                    <input type=""datetime"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""İhbara ati tarih saat giriniz."">
                </div>
                <div class=""form-group col-md-4"">
                    <label for=""exampleFormControlSelect1"">Yapılan işlemler</label>
                    <select class=""form-control"" id=""exampleFormControlSelect1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa83468100", async() => {
                    WriteLiteral("Devriye cıkıldı");
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa83469145", async() => {
                    WriteLiteral("Teyit edildi");
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa834610187", async() => {
                    WriteLiteral("İşlem yapılmadı");
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

                <div class=""form-group col-md-6"">
                    <label for=""exampleFormControlTextarea1"">İhbar özeti</label>
                    <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                </div>
                <div class=""form-group col-md-6"">
                    <label for=""asd"">İhbar Sonucu</label>
                    <select class=""form-control"" id=""asd"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa834611731", async() => {
                    WriteLiteral("Asılsız");
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2697bb9701437e0d6feaf08162b05e21bfa834612769", async() => {
                    WriteLiteral("Gerçek");
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
                <div class=""form-group col-md-6"">
                   <p></p>
                </div> <div class=""form-group col-md-6"">
                   <p></p>
                </div> <div class=""form-group col-md-6"">
                </div> <div class=""form-group col-md-6"">
                   <p></p>
                </div>
                <br />
               
                   <button type=""submit"" class=""btn btn-primary d-inline"">Kaydet</button>  


              





            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <br /><br />


        <div class=""row"">
            <table id=""example1"" class=""display"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>İhbar Bildirim Tipi</th>
                        <th>İhbar Özeti</th>
                        <th>Tarih ve Saati</th>
                        <th>Yapılan İşlem</th>
                        <th>İhbar Sonucu</th> 
                        <th>Durumu</th>
                        <th>Sil</th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>


                            ");
#nullable restore
#line 101 "E:\Calismalarim\Github\Tema\Tema\Views\UyapOlaylari\ihbarGirisIslemleri.cshtml"
                       Write(Html.ActionLink("Hırsızlık", "OlayGirisIslemleri", "UyapOlaylari", null, new { @class = "fa fa-arrow-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                        </td>
                        <td>01.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:red"">Gerçek</span></td>
                        <td>AÇIK</td>
                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:black"">Asılsız</span></td>
                        <td>KAPANDI</td>
                        <td> <button type=""button"" class=""btn btn-danger"" disabled   >Sil</button></td>
                    </tr>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>  ");
#nullable restore
#line 123 "E:\Calismalarim\Github\Tema\Tema\Views\UyapOlaylari\ihbarGirisIslemleri.cshtml"
                         Write(Html.ActionLink("Kasten Yaralama", "OlayGirisIslemleri", "UyapOlaylari", null, new { @class = "fa fa-arrow-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>28.03.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:red"">Gerçek</span></td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>Çakırova mahallesinde gerçekleşen yangın...</td>
                        <td>01.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:black"">Asılsız</span></td>
                        <td>KAPANDI</td>

                        <td> <button type=""button"" class=""btn btn-danger""  disabled >Sil</button></td>
                    </tr>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>  ");
#nullable restore
#line 143 "E:\Calismalarim\Github\Tema\Tema\Views\UyapOlaylari\ihbarGirisIslemleri.cshtml"
                         Write(Html.ActionLink("Orman Yangını", "OlayGirisIslemleri", "UyapOlaylari", null, new { @class = "fa fa-arrow-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>28.03.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:red"">Gerçek</span></td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>Çakırova mahallesinde gerçekleşen yangın...</td>
                        <td>01.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:darkolivegreen"">Asılsız</span></td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                    ");
            WriteLiteral(@"    <td>Devriye Çıkıldı</td>
                        <td><span style=""color:red"">Gerçek</span></td>
                        <td>KAPANDI</td>


                        <td> <button type=""button"" class=""btn btn-danger""  disabled>Sil</button></td>
                    </tr>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>Ayvacık mahallesinde gerçekleşen evden hırsızlık...</td>
                        <td>28.03.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:darkolivegreen"">Asılsız</span></td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>Çakırova mahallesinde gerçekleşen yangın...</td>
                        <td>01.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                 ");
            WriteLiteral(@"       <td><span style=""color:red"">Gerçek</span></td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>156 İhbar Hattı</td>
                        <td>Ayvacık mahallesinde gerçekleşen evden hırsızlık...</td>
                        <td>28.03.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:darkolivegreen"">Asılsız</span></td>
                        <td>KAPANDI</td>


                        <td> <button type=""button"" class=""btn btn-danger""  disabled>Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:red"">Gerçek</span>");
            WriteLiteral(@"</td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:darkolivegreen"">Asılsız</span></td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:red"">Gerçek</span></td>
                        <td>AÇIK</td>

                        <td");
            WriteLiteral(@"> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:darkolivegreen"">Asılsız</span></td>
                        <td>KAPANDI</td>

                        <td> <button type=""button"" class=""btn btn-danger""  disabled>Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:darkolivegreen"">Asılsız</span></td>
                        <td>KAPANDI</td>

                        <td> <button type=""button"" class=""btn btn-dange");
            WriteLiteral(@"r""  disabled>Sil</button></td>
                    </tr>
                    <tr>
                        <td>Karakola Müracaat</td>
                        <td>Süleymaniye mahallesinde oto hırsızlığı</td>
                        <td>04.04.2020</td>
                        <td>Devriye Çıkıldı</td>
                        <td><span style=""color:red"">Gerçek</span></td>
                        <td>AÇIK</td>

                        <td> <button type=""button"" class=""btn btn-danger"">Sil</button></td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <th>İhbar Bildirim Tipi</th>
                        <th>İhbar Özeti</th>
                        <th>Tarih ve Saati</th>
                        <th>Yapılan İşlem</th>
                        <th>İhbar Sonucu</th> 
                        <th>Durumu</th>
                        <th>Sil</th>
                    </tr>
                </tfoot>
            </table>
        </div>
    </div>

<br /><");
            WriteLiteral("br />\n\n\n\n\n");
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
