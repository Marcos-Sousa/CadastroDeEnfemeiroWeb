#pragma checksum "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a2a824f773209c03958c0fc016d351f963a9d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nurse_Index), @"mvc.1.0.view", @"/Views/Nurse/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nurse/Index.cshtml", typeof(AspNetCore.Views_Nurse_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a2a824f773209c03958c0fc016d351f963a9d2", @"/Views/Nurse/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8aa126ffe3580f29b2b0c076cb398ae215a3962", @"/Views/_ViewImports.cshtml")]
    public class Views_Nurse_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NurseManagement.Models.Nurse>>
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 94, true);
            WriteLiteral("\r\n<h2 class=\"text-center well alert-info\">Lista de Enfermeiros Cadastrados</h2>\r\n\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(187, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f69a383eaa46568da70d7f34b78891", async() => {
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
            BeginContext(263, 246, true);
            WriteLiteral("\r\n</p>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-body\">\r\n        <table class=\"table  table-bordered table-condensed\" id=\"serverTable\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(510, 40, false);
#line 19 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(550, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(630, 41, false);
#line 22 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Coren));

#line default
#line hidden
            EndContext();
            BeginContext(671, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(751, 45, false);
#line 25 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(796, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(876, 48, false);
#line 28 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.NameHospital));

#line default
#line hidden
            EndContext();
            BeginContext(924, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1115, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1200, 39, false);
#line 38 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1331, 40, false);
#line 41 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Coren));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1463, 44, false);
#line 44 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1599, 47, false);
#line 47 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NameHospital));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 112, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-right\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1758, "\"", 1806, 1);
#line 50 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
WriteAttributeValue("", 1765, Url.Action("Edit", new { id = item.Id }), 1765, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1807, 88, true);
            WriteLiteral(" class=\"btn btn-success glyphicon glyphicon-pencil\"></a>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1895, "\"", 1945, 1);
#line 51 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
WriteAttributeValue("", 1902, Url.Action("Detail", new { id = item.Id }), 1902, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1946, 134, true);
            WriteLiteral(" class=\"btn btn-info glyphicon glyphicon-file\"></a>\r\n                            <a  class=\"btn btn-danger glyphicon glyphicon-remove\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2080, "\"", 2138, 7);
            WriteAttributeValue("", 2090, "Remove(\'", 2090, 8, true);
#line 52 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
WriteAttributeValue("", 2098, item.Id, 2098, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2106, "\',", 2106, 2, true);
            WriteAttributeValue(" ", 2108, "\'Nurse\',", 2109, 9, true);
            WriteAttributeValue(" ", 2117, "\'Esse", 2118, 6, true);
            WriteAttributeValue(" ", 2123, "Enfermeiro", 2124, 11, true);
            WriteAttributeValue(" ", 2134, "?\')", 2135, 4, true);
            EndWriteAttribute();
            BeginContext(2139, 65, true);
            WriteLiteral("></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2223, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2303, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 62 "C:\Users\Marcos S L\Desktop\nurse-Management\NurseManagementWeb\NurseManagement\Views\Nurse\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2373, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2750, 878, true);
                WriteLiteral(@"    <script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NurseManagement.Models.Nurse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
