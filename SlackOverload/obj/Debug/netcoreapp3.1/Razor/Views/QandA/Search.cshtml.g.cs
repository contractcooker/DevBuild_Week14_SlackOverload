#pragma checksum "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa736fd3a7eafb89769b4b3fd9163cdcdc5f969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Search), @"mvc.1.0.view", @"/Views/QandA/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa736fd3a7eafb89769b4b3fd9163cdcdc5f969", @"/Views/QandA/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
  
    ViewData["Title"] = "Search";
    List<Question> Results = (List<Question>)ViewData["Results"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Search</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
 foreach (Question q in Results)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3><a");
            BeginWriteAttribute("href", " href=\"", 181, "\"", 207, 2);
            WriteAttributeValue("", 188, "/QandA/Detail/", 188, 14, true);
#nullable restore
#line 12 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
WriteAttributeValue("", 202, q.Id, 202, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
                                 Write(q.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n");
#nullable restore
#line 13 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
     if (q.Detail.Length > 100)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 15 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
        Write(q.Detail.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</div><a");
            BeginWriteAttribute("href", " href=\"", 320, "\"", 352, 2);
            WriteAttributeValue("", 327, "/QandA/EditQuestion/", 327, 20, true);
#nullable restore
#line 15 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
WriteAttributeValue("", 347, q.Id, 347, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 16 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 19 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
        Write(q.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><a");
            BeginWriteAttribute("href", " href=\"", 418, "\"", 450, 2);
            WriteAttributeValue("", 425, "/QandA/EditQuestion/", 425, 20, true);
#nullable restore
#line 19 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
WriteAttributeValue("", 445, q.Id, 445, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 20 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
Write(q.Username);

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\tbarron\OneDrive - KNEX\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Search.cshtml"
               
}

#line default
#line hidden
#nullable disable
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
