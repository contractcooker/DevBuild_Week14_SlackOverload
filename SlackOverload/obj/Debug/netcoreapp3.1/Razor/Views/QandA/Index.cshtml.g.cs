#pragma checksum "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fce9cdaf02de0131a9a14700ba6d07ac2016a6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Index), @"mvc.1.0.view", @"/Views/QandA/Index.cshtml")]
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
#line 1 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fce9cdaf02de0131a9a14700ba6d07ac2016a6e", @"/Views/QandA/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QAndA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
  
    ViewData["Title"] = "Index";
    List<Question> Questions = (List<Question>)ViewData["Questions"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Recent Questions</h1>\r\n");
#nullable restore
#line 10 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
 foreach (Question q in Questions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3><a");
            BeginWriteAttribute("href", " href=\"", 228, "\"", 254, 2);
            WriteAttributeValue("", 235, "/QandA/Detail/", 235, 14, true);
#nullable restore
#line 12 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
WriteAttributeValue("", 249, q.Id, 249, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
                                 Write(q.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n");
#nullable restore
#line 13 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"

    string username = Context.Session.GetString("Username");

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
     if (q.Detail.Length > 100 && q.Username.Equals(username))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 18 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
        Write(q.Detail.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</div><a");
            BeginWriteAttribute("href", " href=\"", 464, "\"", 496, 2);
            WriteAttributeValue("", 471, "/QandA/EditQuestion/", 471, 20, true);
#nullable restore
#line 18 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
WriteAttributeValue("", 491, q.Id, 491, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 19 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
    }
    else if (q.Username.Equals(username))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 22 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
        Write(q.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><a");
            BeginWriteAttribute("href", " href=\"", 595, "\"", 627, 2);
            WriteAttributeValue("", 602, "/QandA/EditQuestion/", 602, 20, true);
#nullable restore
#line 22 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
WriteAttributeValue("", 622, q.Id, 622, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 23 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
Write(q.Username);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Index.cshtml"
               
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fce9cdaf02de0131a9a14700ba6d07ac2016a6e8692", async() => {
                WriteLiteral("\r\n\r\n    <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />\r\n    <input type=\"search\" id=\"Search\" name=\"Search\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
