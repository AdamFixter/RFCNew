#pragma checksum "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfa21f930440d4b291f81b3fb1db8899782592ad"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa21f930440d4b291f81b3fb1db8899782592ad", @"/Views/CreateNew/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var priorityList = Html.GetEnumSelectList<Priority>();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>    // Some javascript is positioned here so the script executes before loading the HTML\r\n    console.log(\"message is start|\" + \"");
#nullable restore
#line 11 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                  Write(TempData["lastRowID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \"|end\");\r\n    if (\"");
#nullable restore
#line 12 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
    Write(TempData["lastRowID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" != \"\") {\r\n        console.log(\"it is not empty\");\r\n        var state = \"\"\r\n        if (\"");
#nullable restore
#line 15 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
        Write(TempData["stateMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"True\" && \"");
#nullable restore
#line 15 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                 Write(TempData["stateStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"True\")\r\n            endString = \" is now approved\";\r\n        else if (\"");
#nullable restore
#line 17 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
             Write(TempData["stateMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"False\" && \"");
#nullable restore
#line 17 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                       Write(TempData["stateStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"True\")\r\n            endString = \" is now unapproved\";\r\n        else if (\"");
#nullable restore
#line 19 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
             Write(TempData["stateMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"True\" && \"");
#nullable restore
#line 19 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                      Write(TempData["stateStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"False\")\r\n            endString = \" failed to be approved\";\r\n        else if (\"");
#nullable restore
#line 21 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
             Write(TempData["stateMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"False\" && \"");
#nullable restore
#line 21 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                       Write(TempData["stateStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" == \"False\")\r\n            endString = \" failed to be unapproved\";\r\n\r\n        alert(\"Submission ID: \" + \"");
#nullable restore
#line 24 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                              Write(TempData["lastRowID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + endString + \"\\n\\nPress OK to go back to the Details\");\r\n        window.location.href = \'/CreateNew/Details/\' + \"");
#nullable restore
#line 25 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                   Write(TempData["lastRowID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    }
</script>

<div id=""right"">
    <div class=""header"" style=""display:flex; justify-content: space-between;"">
        <h1 style=""display:inline-block; width:auto; vertical-align: top;"">Requests</h1>
        <div class=""buttons"" style=""margin-top: 0px; display:inline-block;width:auto;vertical-align: top;"">
            <div class=""otherButtons"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa21f930440d4b291f81b3fb1db8899782592ad10356", async() => {
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
#line 39 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p id=\"filter\">\r\n                <div class=\"searchBoxFormat\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
               Write(Html.TextBox("searchID", null, new { @class = "searchBox", placeholder = "Search by ID", list = "datalist", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <input list=""searchPriority"" placeholder=""Search by Priority"" class=""searchBox"" />
                    <datalist id=""searchPriority""></datalist>
                    <input list=""searchProduct"" placeholder=""Search by Product"" class=""searchBox"" />
                    <datalist id=""searchProduct""></datalist>
                    ");
#nullable restore
#line 48 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
               Write(Html.TextBox("searchCustomer", null, new { @class = "searchBox", placeholder = "Search by Customer", list = "datalist", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 49 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
               Write(Html.TextBox("searchApproved", null, new { @class = "searchBox", placeholder = "Search by Status", list = "datalist", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"searchBoxFormat\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
               Write(Html.TextBox("searchDateStart", null, new { @class = "searchBox", list = "datalist", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 53 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
               Write(Html.TextBox("searchDateEnd", null, new { @class = "searchBox", list = "datalist", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <input type=\"submit\" value=\"Search\" />\r\n                <datalist id=\"datalist\"></datalist>\r\n            </p>\r\n");
#nullable restore
#line 59 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-bordered table-condensed table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("ID" + (string.IsNullOrEmpty(ViewBag.sortOrder) ? " ▼" : "") + (ViewBag.sortOrder == "IDDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.IDSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 67 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Priority" + (ViewBag.sortOrder == "RFCTypeAsc" ? " ▼" : "") + (ViewBag.sortOrder == "RFCTypeDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.RFCTypeSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 70 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Product Name" + (ViewBag.sortOrder == "ProductNameAsc" ? " ▼" : "") + (ViewBag.sortOrder == "ProductNameDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.ProductNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Customer Name" + (ViewBag.sortOrder == "CustomerNameAsc" ? " ▼" : "") + (ViewBag.sortOrder == "CustomerNameDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.CustomerNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 76 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Requested Due Date" + (ViewBag.sortOrder == "RequestedDueDateAsc" ? " ▼" : "") + (ViewBag.sortOrder == "RequestedDueDateDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.RequestedDueDateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Approved" + (ViewBag.sortOrder == "ApprovedAsc" ? " ▼" : "") + (ViewBag.sortOrder == "ApprovedDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.Approved }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody id=\"row-hover\">\r\n");
#nullable restore
#line 84 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"d-table-row\" id=\"table-row\" data-href=");
#nullable restore
#line 86 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                                 Write("/CreateNew/Details/" + item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 91 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 94 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 97 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CustomersAffected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 100 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 6014, "\"", 6091, 1);
#nullable restore
#line 103 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
WriteAttributeValue("", 6020, item.Approved ? "images/tick-symbol.png" : "images/cross-symbol.png", 6020, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: auto; height: 5%;\" />\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 106 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <div class=\"buttons\">\r\n            <div class=\"formButtons\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa21f930440d4b291f81b3fb1db8899782592ad21839", async() => {
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
#line 113 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6590, "button", 6590, 6, true);
            AddHtmlAttributeValue(" ", 6596, "submit", 6597, 7, true);
            AddHtmlAttributeValue(" ", 6603, "btn", 6604, 4, true);
            AddHtmlAttributeValue(" ", 6607, "btn-default", 6608, 12, true);
#nullable restore
#line 116 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 6619, !Model.HasPreviousPage ? "disabled" : "", 6620, 43, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa21f930440d4b291f81b3fb1db8899782592ad26354", async() => {
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
#line 120 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6990, "button", 6990, 6, true);
            AddHtmlAttributeValue(" ", 6996, "submit", 6997, 7, true);
            AddHtmlAttributeValue(" ", 7003, "btn", 7004, 4, true);
            AddHtmlAttributeValue(" ", 7007, "btn-default", 7008, 12, true);
#nullable restore
#line 123 "C:\Users\Christian.Cybaniak\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 7019, !Model.HasNextPage ? "disabled" : "", 7020, 39, false);

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
            WriteLiteral(@"
                <div>
                    <button id=""weeklyAgenda"" onclick=""weeklyAgenda()"" class=""button btn btn-success"">Weekly Agenda</button>
                </div>
            </div>
        </div>
    </div>
</div>

<style>
    #weeklyAgenda {
        display: none;
        white-space: nowrap;
    }

    .searchBox {
        width: 17.5%;
        margin: 0.3%;
        background-color: #e7e7e7;
    }

    .searchBoxFormat {
        align-content: center;
        width: 100%;
    }
</style>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa21f930440d4b291f81b3fb1db8899782592ad31382", async() => {
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
    var dateRangeFrom = document.getElementById(""searchDateStart"");
    var dateRangeTo = document.getElementById(""searchDateEnd"");
    var priority = document.getElementById(""searchPriority"")
    var product = document.getElementById(""searchProduct"")

    dateRangeFrom.type = ""date"";
    dateRangeFrom.format = ""{0:yyyy-MM-dd}"";

    dateRangeTo.type = ""date"";
    dateRangeTo.format = ""{0:yyyy-MM-dd}"";


    priority.innerHTML = `<option value=""Retrospective""></option>
                            <option value=""Normal""></option>
                            <option value=""Emergency""></option>`;

    product.innerHTML = `<option value=""RIO""></option>
                            <option value=""Flow""></option>
                            <option value=""Oceano""></option>
                            <option value=""Conexes""></option>
                            <option value=""Mosaic""></option>`;


</script>

<script type=""text/javascript"">
    $(document).ready(function ($) {
 ");
            WriteLiteral("       $(\".d-table-row\").click(function () {\r\n            window.document.location = $(this).data(\"href\");\r\n        });\r\n    });\r\n</script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa21f930440d4b291f81b3fb1db8899782592ad33667", async() => {
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

    function weeklyAgenda() {
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
