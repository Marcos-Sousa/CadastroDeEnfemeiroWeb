#pragma checksum "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab8f68d9c2eb4fb2c9ed147a0cf52009bf1a5ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospital_Index), @"mvc.1.0.view", @"/Views/Hospital/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hospital/Index.cshtml", typeof(AspNetCore.Views_Hospital_Index))]
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
#line 1 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\_ViewImports.cshtml"
using NurseManagement;

#line default
#line hidden
#line 2 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\_ViewImports.cshtml"
using NurseManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab8f68d9c2eb4fb2c9ed147a0cf52009bf1a5ec", @"/Views/Hospital/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8aa126ffe3580f29b2b0c076cb398ae215a3962", @"/Views/_ViewImports.cshtml")]
    public class Views_Hospital_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NurseManagement.Models.Hospital>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary glyphicon glyphicon-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 89, true);
            WriteLiteral("\r\n<h2 class=\"text-center well text-info\">Lista de Hospitais Cadastrados</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(185, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25cf2937a60d4f559f53c7c49e2ef8b4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(261, 248, true);
            WriteLiteral("\r\n</p>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-body\">\r\n        <table class=\"table  table-bordered table-condensed\" id=\"serverTable\">\r\n            <thead>\r\n                <tr>\r\n\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(510, 40, false);
#line 19 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(550, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(630, 40, false);
#line 22 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(670, 52, true);
            WriteLiteral("\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(723, 42, false);
#line 24 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(765, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(845, 46, false);
#line 27 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Complement));

#line default
#line hidden
            EndContext();
            BeginContext(891, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(971, 40, false);
#line 30 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1202, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1287, 39, false);
#line 40 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1418, 39, false);
#line 43 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1549, 41, false);
#line 46 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1682, 45, false);
#line 49 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Complement));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1819, 39, false);
#line 52 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 112, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-right\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1970, "\"", 2018, 1);
#line 55 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
WriteAttributeValue("", 1977, Url.Action("Edit", new { id = item.Id }), 1977, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2019, 88, true);
            WriteLiteral(" class=\"btn btn-success glyphicon glyphicon-pencil\"></a>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2107, "\"", 2157, 1);
#line 56 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
WriteAttributeValue("", 2114, Url.Action("Detail", new { id = item.Id }), 2114, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 133, true);
            WriteLiteral(" class=\"btn btn-info glyphicon glyphicon-file\"></a>\r\n                            <a class=\"btn btn-danger glyphicon glyphicon-remove\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2291, "\"", 2392, 11);
            WriteAttributeValue("", 2301, "Remove(\'", 2301, 8, true);
#line 57 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
WriteAttributeValue("", 2309, item.Id, 2309, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2317, "\',", 2317, 2, true);
            WriteAttributeValue(" ", 2319, "\'Hospital\',", 2320, 12, true);
            WriteAttributeValue(" ", 2331, "\'Esse", 2332, 6, true);
            WriteAttributeValue(" ", 2337, "Hospital?", 2338, 10, true);
            WriteAttributeValue(" ", 2347, "Os", 2348, 3, true);
            WriteAttributeValue(" ", 2350, "enfermeiros", 2351, 12, true);
            WriteAttributeValue(" ", 2362, "vinculados,", 2363, 12, true);
            WriteAttributeValue(" ", 2374, "serão", 2375, 6, true);
            WriteAttributeValue(" ", 2380, "excluidos\')", 2381, 12, true);
            EndWriteAttribute();
            BeginContext(2393, 65, true);
            WriteLiteral("></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2477, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2557, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 67 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Hospital\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2627, 880, true);
                WriteLiteral(@"
    <script>
        // jquery datatable
        $(""#serverTable"").dataTable({
            ""bJQueryUI"": true,
            ""oLanguage"": {
                ""sProcessing"": ""Processando..."",
                ""sLengthMenu"": ""Mostrar _MENU_ registros"",
                ""sZeroRecords"": ""Não foram encontrados resultados"",
                ""sInfo"": ""Mostrando de _START_ até _END_ de _TOTAL_ registros"",
                ""sInfoEmpty"": ""Mostrando de 0 até 0 de 0 registros"",
                ""sInfoFiltered"": """",
                ""sInfoPostFix"": """",
                ""sSearch"": ""Buscar:"",
                ""sUrl"": """",
                ""oPaginate"": {
                    ""sFirst"": ""Primeiro"",
                    ""sPrevious"": ""Anterior"",
                    ""sNext"": ""Seguinte"",
                    ""sLast"": ""Último""
                }
            }
        })
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NurseManagement.Models.Hospital>> Html { get; private set; }
    }
}
#pragma warning restore 1591
