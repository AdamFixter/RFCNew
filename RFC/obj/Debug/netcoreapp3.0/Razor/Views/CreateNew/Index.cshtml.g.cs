#pragma checksum "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c831715460399f288838ac8c00606c525ba20e2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c831715460399f288838ac8c00606c525ba20e2", @"/Views/CreateNew/Index.cshtml")]
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
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c831715460399f288838ac8c00606c525ba20e26262", async() => {
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
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n    <div class=\"rightContent\">\n");
#nullable restore
#line 19 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\n            Find in\n            ");
#nullable restore
#line 23 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
       Write(Html.DropDownList("ColumnSelect", "Select a Column"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            by:\n            ");
#nullable restore
#line 25 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
       Write(Html.TextBox("searchString", null, new { style="background-color: #e7e7e7;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\n            ");
#nullable restore
#line 26 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
       Write(Html.TextBox("DateTo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <ej-date-range-picker id=\"DateRange\" date-format=\"dd/MM/yyyy\" width=\"200px\"></ej-date-range-picker>\n            <input type=\"submit\" value=\"Search\" />\n        </p>\n");
#nullable restore
#line 30 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-bordered table-condensed table-striped table-hover\">\n            <thead>\n                <tr>\n                    <th>\n                        ");
#nullable restore
#line 35 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("ID" + (string.IsNullOrEmpty(ViewBag.sortOrder) ? " ▼" : "") + (ViewBag.sortOrder == "IDDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.IDSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 38 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("RFC Type" + (ViewBag.sortOrder == "RFCTypeAsc" ? " ▼" : "") + (ViewBag.sortOrder == "RFCTypeDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.RFCTypeSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 41 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Product Name" + (ViewBag.sortOrder == "ProductNameAsc" ? " ▼" : "") + (ViewBag.sortOrder == "ProductNameDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.ProductNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 44 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Customer Name" + (ViewBag.sortOrder == "CustomerNameAsc" ? " ▼" : "") + (ViewBag.sortOrder == "CustomerNameDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.CustomerNameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 47 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Requested Due Date" + (ViewBag.sortOrder == "RequestedDueDateAsc" ? " ▼" : "") + (ViewBag.sortOrder == "RequestedDueDateDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.RequestedDueDateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 50 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.ActionLink("Approved" + (ViewBag.sortOrder == "ApprovedAsc" ? " ▼" : "") + (ViewBag.sortOrder == "ApprovedDesc" ? " ▲" : ""), "Index", new { sortOrder = ViewBag.Approved }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 55 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"d-table-row\" id=\"table-row\" data-href=");
#nullable restore
#line 57 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                                             Write("/CreateNew/Details/" + item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n                    <td>\n                        ");
#nullable restore
#line 59 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 62 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 65 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 68 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CustomersAffected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 71 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 74 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                    Write(item.Approved ? "✓" : "✕");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 77 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        <div class=\"buttons\">\n            <div class=\"formButtons\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c831715460399f288838ac8c00606c525ba20e215776", async() => {
                WriteLiteral("\n                    Previous\n                ");
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
#line 83 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4258, "button", 4258, 6, true);
            AddHtmlAttributeValue(" ", 4264, "submit", 4265, 7, true);
            AddHtmlAttributeValue(" ", 4271, "btn", 4272, 4, true);
            AddHtmlAttributeValue(" ", 4275, "btn-default", 4276, 12, true);
#nullable restore
#line 86 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 4287, !Model.HasPreviousPage ? "disabled" : "", 4288, 43, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c831715460399f288838ac8c00606c525ba20e220261", async() => {
                WriteLiteral("\n                    Next\n                ");
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
                              WriteLiteral(Model.PageIndex + 1);

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
            AddHtmlAttributeValue("", 4651, "button", 4651, 6, true);
            AddHtmlAttributeValue(" ", 4657, "submit", 4658, 7, true);
            AddHtmlAttributeValue(" ", 4664, "btn", 4665, 4, true);
            AddHtmlAttributeValue(" ", 4668, "btn-default", 4669, 12, true);
#nullable restore
#line 93 "C:\Users\travis.melton\Documents\GitHub\RFCNew\RFC\Views\CreateNew\Index.cshtml"
AddHtmlAttributeValue(" ", 4680, !Model.HasNextPage ? "disabled" : "", 4681, 39, false);

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
            </div>
            <div>
                <button id=""weeklyAgenda"" onclick=""weeklyAgenda()"">Weekly Agenda</button>
            </div>
        </div>
    </div>
</div>


<style>

    #table-row td:hover {
        cursor: pointer;
    }
    #weeklyAgenda {
        display : none;
    }
</style>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c831715460399f288838ac8c00606c525ba20e225037", async() => {
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
    var dateRangeTo = document.getElementById(""DateTo"");
    dateRangeTo.type = ""date"";
    dateRangeTo.format = ""{0:yyyy-MM-dd}"";

    dateRangeTo.style.display = ""none"";
    window.onload = testfunction;

    $('#ColumnSelect').on('change', function () {
        var index = $(this).find('option:selected').index();

        if (index == 5) {
            dateRangeTo.value = """";
            input.type = ""date"";
            input.format = ""{0:yyyy-MM-dd}"";
            dateRangeTo.style.display = ""inline-block"";
            document.getElementById(""weeklyAgenda"").style.display=""inline-block"";
        } else {
            input.type = ""text"";
            input.format = null;
            dateRangeTo.innerHTML = """";
            dateRangeTo.style.display = ""none"";
            document.getElementById(""weeklyAgenda"").style.display=""none"";
        }
        input.value = """";
    })

    function testfunction() {

        var columnselect = document.getE");
            WriteLiteral(@"lementById(""ColumnSelect"");

        if (columnselect.options[columnselect.selectedIndex].text == ""Requested Due Date"") {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c831715460399f288838ac8c00606c525ba20e227672", async() => {
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
        var lastWeek = moment().subtract(7, ""day"").format(""YYYY-MM-DD"");

        console.log(todayDate);
        console.log(lastWeek);


        var dateFrom = document.getElementById(""searchString"");
        var dateTo = document.getElementById(""DateTo"");

        dateFrom.value = lastWeek;      //line252
        dateTo.value = todayDate;       //line253

        //const sevenDays = (60 * 60 * 24 * 7);
        //var today = new Date();
        //var lastWeek = ((today.getTime) - (60 * 60 * 24 * 7));

        
        //console.log(today);
        //console.log(sevenDays);
        //console.log(lastWeek);
        //var todayDate = new Date();
        //todayDate.setDate(todayDate.getDate());
        //console.log(todayDate.getDay());

        //var lastWeek = new Date();
        //lastWeek.setDate((lastWeek.getDate() - 7));
        //console.log(lastWeek);
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
