#pragma checksum "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4eb79b65c28093f15cd49f32467c6aa7334d8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4eb79b65c28093f15cd49f32467c6aa7334d8e", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RSVP>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(98, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(111, 219, true);
            WriteLiteral("<h1>Welcome to the Wedding Planner <a href=\"logout\">Log Out</a></h1>\n\n<table class=\"table table-striped\">\n    <tr>\n        <th>Wedding</th>\n        <th>Date</th>\n        <th>Guest</th>\n        <th>Action</th>\n    </tr>\n");
            EndContext();
#line 12 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
      foreach (Wedding wedding in @ViewBag.AllWeddings){

#line default
#line hidden
            BeginContext(387, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(417, 15, false);
#line 14 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
           Write(wedding.Wedder1);

#line default
#line hidden
            EndContext();
            BeginContext(432, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(436, 15, false);
#line 14 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
                              Write(wedding.Wedder2);

#line default
#line hidden
            EndContext();
            BeginContext(451, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(474, 12, false);
#line 15 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
           Write(wedding.Date);

#line default
#line hidden
            EndContext();
            BeginContext(486, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(509, 23, false);
#line 16 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
           Write(wedding.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(532, 39, true);
            WriteLiteral("</td>\n            <td>\n                ");
            EndContext();
            BeginContext(571, 336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b4eb79b65c28093f15cd49f32467c6aa7334d8e6888", async() => {
                BeginContext(637, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(658, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b4eb79b65c28093f15cd49f32467c6aa7334d8e7283", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 19 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.WeddingId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 19 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                        WriteLiteral(wedding.WeddingId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(726, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(747, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b4eb79b65c28093f15cd49f32467c6aa7334d8e9822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 20 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Wedding);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 20 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                      WriteLiteral(wedding);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(803, 97, true);
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-success\">RSVP</button>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(907, 19, true);
            WriteLiteral("\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 926, "\"", 965, 3);
            WriteAttributeValue("", 933, "/DeleteRSVP/{", 933, 13, true);
#line 23 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 946, wedding.WeddingId, 946, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 964, "}", 964, 1, true);
            EndWriteAttribute();
            BeginContext(966, 55, true);
            WriteLiteral(" class=\"btn btn-warning\">un-RSVP</a>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1063, 3);
            WriteAttributeValue("", 1028, "/DeleteWedding/{", 1028, 16, true);
#line 24 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1044, wedding.WeddingId, 1044, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1062, "}", 1062, 1, true);
            EndWriteAttribute();
            BeginContext(1064, 67, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n            </td>\n        </tr>\n");
            EndContext();
#line 27 "/Users/alex/Desktop/01_coding_dojo/04_C#/03_ORMs/03_entity_framework/WeddingPlanner/Views/Home/Dashboard.cshtml"
    }

#line default
#line hidden
            BeginContext(1138, 66, true);
            WriteLiteral("</table>\n\n<a href=\"/new\" class=\"btn btn-secondary\">New Wedding</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RSVP> Html { get; private set; }
    }
}
#pragma warning restore 1591
