#pragma checksum "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c63bdc7e827044aa8d80f933a0f0e9409ca637e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateNew_Index), @"mvc.1.0.view", @"/Views/CreateNew/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c63bdc7e827044aa8d80f933a0f0e9409ca637e", @"/Views/CreateNew/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4ddab8934f76edf50d0bb6435f89b8c3095685", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateNew_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<RFC.Models.CreateNew>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button submit btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/moment/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var priorityList = Html.GetEnumSelectList<Priority>();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""right"">
    <div class=""header"" style=""display:flex; justify-content: space-between;"">
        <h1 style=""display:inline-block; width:auto; vertical-align: top;"">Requests</h1>
        <div class=""buttons"" style=""margin-top: 0px; display:inline-block;width:auto;vertical-align: top;"">
            <div class=""otherButtons"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c63bdc7e827044aa8d80f933a0f0e9409ca637e6357", async() => {
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"rightContent\">\r\n");
#nullable restore
#line 21 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p id=\"filter\">\r\n                Find in\r\n                ");
#nullable restore
#line 25 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
           Write(Html.DropDownList("ColumnSelect", "Select a Column"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                by:\r\n                ");
#nullable restore
#line 27 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
           Write(Html.TextBox("searchString", null, new { style = "background-color: #e7e7e7;", list = "datalist", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
           Write(Html.TextBox("DateTo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <ej-date-range-picker id=\"DateRange\" date-format=\"dd/MM/yyyy\" width=\"200px\"></ej-date-range-picker>\r\n                <input type=\"submit\" value=\"Search\" />\r\n                <datalist id=\"datalist\"></datalist>\r\n            </p>\r\n");
#nullable restore
#line 33 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-bordered table-condensed table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("ID" + (string.IsNullOrEmpty(ViewBag.sortOrder) ? " ▼" : "") + (ViewBag.sortOrder == "IDDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.IDSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 41 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Priority" + (ViewBag.sortOrder == "RFCTypeAsc" ? " ▼" : "") + (ViewBag.sortOrder == "RFCTypeDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.RFCTypeSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 44 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Product Name" + (ViewBag.sortOrder == "ProductNameAsc" ? " ▼" : "") + (ViewBag.sortOrder == "ProductNameDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.ProductNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 47 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Customer Name" + (ViewBag.sortOrder == "CustomerNameAsc" ? " ▼" : "") + (ViewBag.sortOrder == "CustomerNameDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.CustomerNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 50 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Requested Due Date" + (ViewBag.sortOrder == "RequestedDueDateAsc" ? " ▼" : "") + (ViewBag.sortOrder == "RequestedDueDateDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.RequestedDueDateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 53 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Approved" + (ViewBag.sortOrder == "ApprovedAsc" ? " ▼" : "") + (ViewBag.sortOrder == "ApprovedDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.Approved }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody id=\"row-hover\">\r\n");
#nullable restore
#line 58 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"d-table-row\" id=\"table-row\" data-href=");
#nullable restore
#line 60 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                                 Write("/CreateNew/Details/" + item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 68 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CustomersAffected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                           <img");
            BeginWriteAttribute("src", " src=\"", 4147, "\"", 4224, 1);
#nullable restore
#line 77 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
WriteAttributeValue("", 4153, item.Approved ? "images/tick-symbol.png" : "images/cross-symbol.png", 4153, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: auto; height: 5%;\"/>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 80 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>

        <div class=""buttons"">
            <div >
                <button id=""weeklyAgenda"" onclick=""weeklyAgenda()"" class=""button btn btn-success"">Weekly Agenda</button>
            </div>
            <div class=""formButtons"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c63bdc7e827044aa8d80f933a0f0e9409ca637e16746", async() => {
                WriteLiteral("\r\n                    Previous\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4884, "button", 4884, 6, true);
            AddHtmlAttributeValue(" ", 4890, "submit", 4891, 7, true);
            AddHtmlAttributeValue(" ", 4897, "btn", 4898, 4, true);
            AddHtmlAttributeValue(" ", 4901, "btn-default", 4902, 12, true);
#nullable restore
#line 93 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 4913, !Model.HasPreviousPage ? "disabled" : "", 4914, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c63bdc7e827044aa8d80f933a0f0e9409ca637e21257", async() => {
                WriteLiteral("\r\n                    Next\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5284, "button", 5284, 6, true);
            AddHtmlAttributeValue(" ", 5290, "submit", 5291, 7, true);
            AddHtmlAttributeValue(" ", 5297, "btn", 5298, 4, true);
            AddHtmlAttributeValue(" ", 5301, "btn-default", 5302, 12, true);
#nullable restore
#line 100 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 5313, !Model.HasNextPage ? "disabled" : "", 5314, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<style>\r\n    #weeklyAgenda {\r\n        display : none;\r\n        white-space: nowrap;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c63bdc7e827044aa8d80f933a0f0e9409ca637e25939", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var input = document.getElementById(""searchString"");
    input.value = """";
    var dateRangeTo = document.getElementById(""DateTo"");
    var datalist = document.getElementById(""datalist"");
    dateRangeTo.type = ""date"";
    dateRangeTo.format = ""{0:yyyy-MM-dd}"";

    dateRangeTo.style.display = ""none"";
    window.onload = testfunction;

    $('#ColumnSelect').on('change', function () {
        var index = $(this).find('option:selected').index();
        switch (index) {
            case 2:
                datalist.innerHTML = `<option value=""Retrospective""></option>
                                      <option value=""Normal""></option>
                                      <option value=""Emergency""></option>`;
                break;
            case 3:
                datalist.innerHTML = `<option value=""RIO""></option>
                                      <option value=""Flow""></option>
                                      <option value=""Oceano""></option>
                ");
            WriteLiteral(@"                      <option value=""Conexes""></option>
                                      <option value=""Mosaic""></option>`;
                break;
            case 5:
                dateRangeTo.value = """";
                input.type = ""date"";
                input.format = ""{0:yyyy-MM-dd}"";
                dateRangeTo.style.display = ""inline-block"";
                document.getElementById(""weeklyAgenda"").style.display=""inline-block"";
                break;
            default:
                datalist.innerHTML = """";
                input.type = ""text"";
                input.format = null;
                dateRangeTo.innerHTML = """";
                dateRangeTo.style.display = ""none"";
                document.getElementById(""weeklyAgenda"").style.display=""none"";
                break;
        }
    })

    function testfunction() {

        var columnselect = document.getElementById(""ColumnSelect"");

        if (columnselect.options[columnselect.selectedIndex].text == ""Requested D");
            WriteLiteral(@"ue Date"") {
            input.type = ""date"";
            input.format = ""{0:yyyy-MM-dd}"";
            dateRangeTo.style.display = ""inline-block"";
        }
    }


</script>

<script type=""text/javascript"">
    $(document).ready(function ($) {
        $("".d-table-row"").click(function () {
            window.document.location = $(this).data(""href"");
        });
    });
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c63bdc7e827044aa8d80f933a0f0e9409ca637e29558", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>

    function weeklyAgenda()
    {
        var todayDate = moment().format(""YYYY-MM-DD"");
        var lastWeek = moment().subtract(8, ""day"").format(""YYYY-MM-DD"");
        var dateFrom = document.getElementById(""searchString"");
        var dateTo = document.getElementById(""DateTo"");

        dateFrom.value = lastWeek;
        dateTo.value = todayDate;
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<RFC.Models.CreateNew>> Html { get; private set; }
    }
}
#pragma warning restore 1591
