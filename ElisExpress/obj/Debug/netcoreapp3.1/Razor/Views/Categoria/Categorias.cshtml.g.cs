#pragma checksum "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\Categoria\Categorias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eb75635cd8cb41b7d483434eb17c50a4a207bee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Categorias), @"mvc.1.0.view", @"/Views/Categoria/Categorias.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\_ViewImports.cshtml"
using ElisExpress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\_ViewImports.cshtml"
using ElisExpress.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\_ViewImports.cshtml"
using ElisExpress.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb75635cd8cb41b7d483434eb17c50a4a207bee", @"/Views/Categoria/Categorias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abbd11aaec0336de8b9ea94f1101caf1e92536f", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Categorias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoriaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\Categoria\Categorias.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eb75635cd8cb41b7d483434eb17c50a4a207bee4236", async() => {
                WriteLiteral("Crear categoría");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h1 class=""display-3 col-12"" style=""text-align-last: center;"">Categorias</h1>

<hr class=""my-4"">

<div class="" col-12"">
    <table class=""table table-hover col-11 table-bordered"" style=""text-align: center;"" id=""tbl_ordenesComercio"">
        <thead>
            <tr class=""table-dark"">
                <th scope=""col"">Id</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Descripción</th>
                <th scope=""col"">Opciones</th>
            </tr>
        </thead>
");
#nullable restore
#line 23 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\Categoria\Categorias.cshtml"
         foreach (var categoria in Model.Categorias)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\Categoria\Categorias.cshtml"
                   Write(categoria.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\Categoria\Categorias.cshtml"
                   Write(categoria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\Categoria\Categorias.cshtml"
                   Write(categoria.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <a href=""#""><i class=""fas fa-eye"" style=""color: #772953; margin-left: 5px;""></i></a>
                        <a href=""#""><i class=""fas fa-edit"" style=""color: #772953; margin-left: 5px;""></i></a>
                        <a href=""#""><i class=""fas fa-trash-alt"" style=""color: #772953; margin-left: 5px;""></i></a>
                    </td>

                </tr>
            </tbody>
");
#nullable restore
#line 44 "C:\Users\hp\Desktop\Nueva carpeta (2)\ElisExpressUI\ElisExpress\Views\Categoria\Categorias.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoriaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
