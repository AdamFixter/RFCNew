#pragma checksum "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fea62fa6bbd76011e90bb2c18b6ad6a4f1e22915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateNew_Details), @"mvc.1.0.view", @"/Views/CreateNew/Details.cshtml")]
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
#line 1 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\_ViewImports.cshtml"
using RFC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\_ViewImports.cshtml"
using RFC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea62fa6bbd76011e90bb2c18b6ad6a4f1e22915", @"/Views/CreateNew/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4ddab8934f76edf50d0bb6435f89b8c3095685", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateNew_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFC.Models.CreateNew>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default button btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""right"">
    <div class=""header"" style=""display:flex; justify-content: space-between;"">
        <h1 style=""display:inline-block; width:auto; vertical-align: top;"">Details</h1>
        <div class=""buttons"" style=""margin-top: 0px; display:inline-block;width:auto;vertical-align: top;"">
            <div class=""otherButtons"">
                <button style=""width: 100%"" class=""button submit btn btn-primary"" onclick=""goBack()"">Go Back</button>
            </div>
        </div>
    </div>
    <div class=""rightContent"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ID
                    </th>
                    <th>
                        Priority
                    </th>
                    <th>
                        Product
                    </th>
                    <th>
                        Customer Name
                    </th>
                    <th>
                        Requested Due Dat");
            WriteLiteral("e\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.CustomersAffected);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                </tr>
            </tbody>
        </table>
        <h3>Questions:</h3>
        <table class=""table"" style=""table-layout: fixed"">
            <tbody>
                <tr>
                    <td>
                        <button type=""button"" id=""Question"" class=""collapsible"">");
#nullable restore
#line 63 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.ReasonForChange));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 65 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.ReasonForChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 71 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.ChangeDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 73 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.ChangeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 79 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.SystemAffected));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 81 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.SystemAffected);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 87 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.customers));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 89 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.customers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 95 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.WhoPerforming));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 97 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.WhoPerforming);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 103 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.RiskOfChange));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 105 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.RiskOfChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 111 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.RiskNoChange));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 113 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.RiskNoChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 119 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.VerifyAfter));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 121 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.VerifyAfter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 127 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.RollBackPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 129 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.RollBackPlan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 135 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 137 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 143 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.WhyDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 145 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.WhyDueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 151 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.ServiceImpact));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 153 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.ServiceImpact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n        <div class=\"buttons\" style=\"display: flex; justify-content: space-around\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fea62fa6bbd76011e90bb2c18b6ad6a4f1e2291519044", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 161 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                               WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fea62fa6bbd76011e90bb2c18b6ad6a4f1e2291521333", async() => {
#nullable restore
#line 162 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                                                                                          Write(Model.Approved ? "Unapprove" : "Approve");

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7082, "btn", 7082, 3, true);
            AddHtmlAttributeValue(" ", 7085, "btn-default", 7086, 12, true);
            AddHtmlAttributeValue(" ", 7097, "button", 7098, 7, true);
#nullable restore
#line 162 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
AddHtmlAttributeValue(" ", 7104, Model.Approved ? "btn-warning" : "btn-success", 7105, 49, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                                                                       WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>


<style>

    .p-wrapped {
        word-break: break-all;
        white-space: normal
    }

    #Question:focus {
        outline: none;
    }
</style>


<script>

    let coll = document.getElementsByClassName(""collapsible"");
    for (let i = 0; i < coll.length; i++) {
        let question = coll[i];
        let content = question.nextElementSibling;

        question.addEventListener(""click"", function () {
            if (content.style.display == """" || content.style.display == ""block"") {
                content.style.display = ""none"";
                if (localStorage.getItem('IsDarkMode') == '1') {
                    question.style.background = ""#000000"";
                }
                else if (localStorage.getItem('IsDarkMode') == '0') {
                    question.style.background = ""#f3f3f3"";
                }

            } else {

                content.style.display = ""block"";
                if (localStorage.getItem('IsD");
            WriteLiteral(@"arkMode') == '1') {
                    question.style.background = ""#303030"";
                }
                else if (localStorage.getItem('IsDarkMode') == '0') {
                    question.style.background = ""#d2d2d2"";
                }
            }
        });
    }

</script>
<script>
    function goBack() {
        window.history.back();
    }
</script>
<script>
    if ( window.history.replaceState ) {
    window.history.replaceState( null, null, window.location.href );
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFC.Models.CreateNew> Html { get; private set; }
    }
}
#pragma warning restore 1591
