#pragma checksum "D:\Users\Elian\Desktop\EliExpress\ElisExpressUI\ElisExpress\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19a9cb8a7606b008db59493b5524126039e29550"
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
#line 1 "D:\Users\Elian\Desktop\EliExpress\ElisExpressUI\ElisExpress\Views\_ViewImports.cshtml"
using ElisExpress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Elian\Desktop\EliExpress\ElisExpressUI\ElisExpress\Views\_ViewImports.cshtml"
using ElisExpress.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Elian\Desktop\EliExpress\ElisExpressUI\ElisExpress\Views\_ViewImports.cshtml"
using ElisExpress.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19a9cb8a7606b008db59493b5524126039e29550", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abbd11aaec0336de8b9ea94f1101caf1e92536f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formInputBuscar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Users\Elian\Desktop\EliExpress\ElisExpressUI\ElisExpress\Views\Home\Index.cshtml"
  
    //ViewBag.Title = this.Session.SessionID;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""jumbotron1"" class=""min-vh-100"">
    <div id=""jumbotron1-caption"">
        <div class=""row text-white"">
            <div class=""col-xl-5 col-lg-6 col-md-8 col-sm-10 mx-auto text-center p-4"">
                <h1 class=""display-4 text-truncate"">Hoy quiero...</h1>
                <div");
            BeginWriteAttribute("class", " class=\"", 359, "\"", 367, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19a9cb8a7606b008db59493b5524126039e295505210", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Hamburguesa, pizza, pollo"" id=""inputBuscar"">
                        </div>
                        <button type=""submit"" class=""btn btn-primary btn-lg"">ToGo</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            WriteLiteral(@"<section class=""jumboCenter bg-primary text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 mx-auto"">
                <h2 class=""section-heading text-white"">¡Descubre lo que todos hablan con 3 simples pasos!</h2>
            </div>
        </div>
    </div>
</section>

<section class=""clearfix bg-white pasos text-dark"">
    <div class=""emptyRight"">
        <source media=""(min-width: 768px)"" srcset=""Content/imgs/UberEats.jpg"">
        <img class=""none"" src=""Content/imgs/UberEats.jpg"" alt=""Paso1"" style=""width:100%;height:100%;object-fit:cover;"">
    </div>
    <div class=""introRight"">
        <h1 class=""numberCircle"" style=""padding-top:0px;"">1</h1>

        <h2>Buscá tu restaurante favorito y agregá los productos más deliciosos al carrito.</h1>

    </div>
</section>

<section class=""clearfix bg-dark pasos"">
    <div class=""emptyLeft"">
        <source media=""(min-width: 768px)"" srcset=""Content/imgs/delivery.jpg"">
        <img class=""none""");
            WriteLiteral(@" src=""Content/imgs/payment.jpg"" alt=""Paso2"" style=""width:100%;height:100%;object-fit:cover;"">
    </div>
    <div class=""introLeft"">
        <h1 class=""numberCircle"" style=""padding-top:0px;"">2 </h1>
        <h1>Confirmá el pago con tu cuenta PayPal. </h1>
    </div>
</section>

<section class=""clearfix text-dark pasos "">
    <div class=""emptyRight"">
        <source media=""(min-width: 768px)"" srcset=""Content/imgs/payment.jpg"">
        <img class=""none"" src=""Content/imgs/delivery.jpg"" alt=""Paso3"" style=""width:100%;height:100%;object-fit:cover;"">
    </div>
    <div class=""introRight"">
        <h1 class=""numberCircle"" style=""padding-top:0px;"">3</h1>

        <h1>Tu orden será entregada por uno de nuestros colaboradores.</h1>

    </div>
</section>

<section class=""jumboCenter bg-light text-center"" id=""registrarmeDiv"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 mx-auto"">
                <h2 class=""section-heading text-primary"">Pedí ToGo!</h2>
 ");
            WriteLiteral("               <p class=\"lead\">\r\n                    ");
#nullable restore
#line 80 "D:\Users\Elian\Desktop\EliExpress\ElisExpressUI\ElisExpress\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Registrarme", "vRegistrarUsuarioFinal", "Home", new { @class = "btn btn-primary btn-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
