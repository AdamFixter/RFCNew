#pragma checksum "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee21df782dc850da0e920f6d39a526f5628dbc46"
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
#line 1 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\_ViewImports.cshtml"
using RFC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\_ViewImports.cshtml"
using RFC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee21df782dc850da0e920f6d39a526f5628dbc46", @"/Views/CreateNew/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4ddab8934f76edf50d0bb6435f89b8c3095685", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateNew_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFC.ViewModel.CreateNewViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button submit btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var prevDisabled = !Model.Requests.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.Requests.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div id=\"right\">\n    <div class=\"header\">\n        <h1>View Requests</h1>\n");
#nullable restore
#line 13 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\n                Find in\n                ");
#nullable restore
#line 17 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
           Write(Html.DropDownList("ColumnSelect", "Select a Column"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                by:\n                ");
#nullable restore
#line 19 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
           Write(Html.TextBox("searchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 20 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
           Write(Html.TextBox("DateTo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <ej-date-range-picker id=\"DateRange\" date-format=\"dd/MM/yyyy\" width=\"200px\"></ej-date-range-picker>\n                <input type=\"submit\" value=\"Search\" />\n            </p>\n");
#nullable restore
#line 24 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"rightContent\">\n        <table class=\"table\">\n            <thead>\n                <tr>\n                    <th>\n                        ");
#nullable restore
#line 31 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("ID", "Index", new { sortOrder = ViewBag.IDSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 34 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("RFC Type", "Index", new { sortOrder = ViewBag.RFCTypeSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 37 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Product Name", "Index", new { sortOrder = ViewBag.ProductNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 40 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Customer Name", "Index", new { sortOrder = ViewBag.CustomerNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 43 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Requested Due Date", "Index", new { sortOrder = ViewBag.RequestedDueDateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 50 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                 foreach (var item in Model.Requests)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
#nullable restore
#line 54 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 57 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 60 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 63 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CustomersAffected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 66 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee21df782dc850da0e920f6d39a526f5628dbc4611909", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                      WriteLiteral(item.ID);

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
            WriteLiteral(" |\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee21df782dc850da0e920f6d39a526f5628dbc4614109", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                     WriteLiteral(item.ID);

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
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 73 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        <div class=\"buttons\">\n            <div class=\"otherButtons\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee21df782dc850da0e920f6d39a526f5628dbc4616682", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"formButtons\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee21df782dc850da0e920f6d39a526f5628dbc4618403", async() => {
                WriteLiteral("\n                   Previous\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                              WriteLiteral(Model.Requests.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3443, "button", 3443, 6, true);
            AddHtmlAttributeValue(" ", 3449, "submit", 3450, 7, true);
            AddHtmlAttributeValue(" ", 3456, "btn", 3457, 4, true);
            AddHtmlAttributeValue(" ", 3460, "btn-default", 3461, 12, true);
#nullable restore
#line 85 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 3472, prevDisabled, 3473, 13, false);

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
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee21df782dc850da0e920f6d39a526f5628dbc4622892", async() => {
                WriteLiteral("\n                    Next\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                             WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                               WriteLiteral(Model.Requests.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                 WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3818, "button", 3818, 6, true);
            AddHtmlAttributeValue(" ", 3824, "submit", 3825, 7, true);
            AddHtmlAttributeValue(" ", 3831, "btn", 3832, 4, true);
            AddHtmlAttributeValue(" ", 3835, "btn-default", 3836, 12, true);
#nullable restore
#line 92 "C:\Users\Adam.Sutton\Documents\GitHub\RFC MVC\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 3847, nextDisabled, 3848, 13, false);

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
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee21df782dc850da0e920f6d39a526f5628dbc4627423", async() => {
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
    var input = document.getElementById(""searchString"");
    var dateRangeTo = document.getElementById(""DateTo"");
    dateRangeTo.type = ""date"";
    dateRangeTo.format = ""{0:yyyy-MM-dd}"";
    dateRangeTo.style.visibility = ""hidden"";

    $('#ColumnSelect').on('change', function() {
        var index = $(this).find('option:selected').index();

        if (index == 5) {
            input.type = ""date"";
            input.format = ""{0:yyyy-MM-dd}"";
            dateRangeTo.style.visibility = ""visible"";
        } else {
            input.type = ""text"";
            input.format = null;
            dateRangeTo.style.visibility = ""hidden"";
        }
        input.value = """";
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFC.ViewModel.CreateNewViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
