#pragma checksum "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d7bc9f40084b10c662e19984bd67bd891ee45d"
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
#line 1 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\_ViewImports.cshtml"
using RFC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\_ViewImports.cshtml"
using RFC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d7bc9f40084b10c662e19984bd67bd891ee45d", @"/Views/CreateNew/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4ddab8934f76edf50d0bb6435f89b8c3095685", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateNew_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFC.Models.CreateNew>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button submit btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CreateNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default button btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default button btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
  
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
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05d7bc9f40084b10c662e19984bd67bd891ee45d6726", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                        Requested Due Date
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        ");
#nullable restore
#line 41 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                   Write(Model.CustomersAffected);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
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
#line 63 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.ReasonForChange));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 65 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.ReasonForChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 71 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.ChangeDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 73 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.ChangeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 79 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.SystemAffected));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 81 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.SystemAffected);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 87 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.customers));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 89 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.customers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 95 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.WhoPerforming));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 97 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.WhoPerforming);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 103 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.RiskOfChange));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 105 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.RiskOfChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 111 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.RiskNoChange));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 113 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.RiskNoChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 119 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.VerifyAfter));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 121 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.VerifyAfter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 127 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.RollBackPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 129 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.RollBackPlan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 135 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 137 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 143 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.WhyDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 145 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.WhyDueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <button type=\"button\" id=\"Question\" class=\"collapsible\">");
#nullable restore
#line 151 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.ServiceImpact));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <div class=\"content\" style=\"width: 100%\">\r\n                            <p class=\"p-wrapped\">");
#nullable restore
#line 153 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                            Write(Model.ServiceImpact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n        <div class=\"buttons\" style=\"display: flex; justify-content: space-around\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05d7bc9f40084b10c662e19984bd67bd891ee45d22777", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 161 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05d7bc9f40084b10c662e19984bd67bd891ee45d25071", async() => {
#nullable restore
#line 162 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
                                                                                                    Write(Model.Approved ? "Unapprove" : "Approve");

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Details.cshtml"
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
    .collapsible {
        background-color: #f3f3f3;
        cursor: pointer;
        padding: 18px;
        width: 100%;
        border: none;
        text-align: left;
        outline: none;
        font-size: 15px;
        font-weight: bold;
        border-color: #f3f3f3;
        outline: none;
    }

        .active, .collapsible:hover {
            background-color: #d2d2d2;
        }

    .content {
        padding: 0 18px;
        display: none;
        overflow: hidden;
        background-color: #d2d2d2;
    }

    .p-wrapped {
        word-break: break-all;
        white-space: normal
    }

    #Question:focus {
        outline: none;
    }
</style>


<script>
    var coll = document.getElementsByClassName(""collapsible"");
    var i;

    for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener(""click"", function () {
            this.classList.toggle(""active"");
            var content = this.nex");
            WriteLiteral("tElementSibling;\r\n            if (content.style.display === \"block\") {\r\n                content.style.display = \"none\";\r\n            } else {\r\n                content.style.display = \"block\";\r\n            }\r\n        });\r\n    }\r\n</script>");
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
