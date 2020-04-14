#pragma checksum "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c30ab6ff8974b878cf00776d903fd7ccc578ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Detail), @"mvc.1.0.view", @"/Views/QandA/Detail.cshtml")]
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
#line 1 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c30ab6ff8974b878cf00776d903fd7ccc578ac", @"/Views/QandA/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
  
    ViewData["Title"] = Model.Title;
    List<Answer> Answers = (List<Answer>)ViewData["Answers"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>");
#nullable restore
#line 10 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
Write(Model.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Asked on ");
#nullable restore
#line 11 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
         Write(Model.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 11 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
                          Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<h2>Answers</h2>\r\n");
#nullable restore
#line 13 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
 if (Answers.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>There are no answers yet.</p>\r\n    <p><a");
            BeginWriteAttribute("href", " href=\"", 360, "\"", 393, 2);
            WriteAttributeValue("", 367, "/QandA/AddAnswer/", 367, 17, true);
#nullable restore
#line 16 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 384, Model.Id, 384, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Submit your own!</a></p>\r\n");
#nullable restore
#line 17 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
 foreach (Answer a in Answers)
{
    string username = Context.Session.GetString("Username");

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>");
#nullable restore
#line 25 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
           Write(a.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>:\r\n        ");
#nullable restore
#line 26 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
   Write(a.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <em>");
#nullable restore
#line 27 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
       Write(a.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> Votes: ");
#nullable restore
#line 27 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
                             Write(a.Upvotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 28 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
         if (a.Username.Equals(username))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 720, "\"", 750, 2);
            WriteAttributeValue("", 727, "/QandA/EditAnswer/", 727, 18, true);
#nullable restore
#line 30 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 745, a.Id, 745, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 776, "\"", 808, 2);
            WriteAttributeValue("", 783, "/QandA/DeleteAnswer/", 783, 20, true);
#nullable restore
#line 31 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 803, a.Id, 803, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">DELETE!</a>\r\n");
#nullable restore
#line 32 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 35 "C:\Users\tbarron\OneDrive - Knex\Documents\GitHub\SlackOverload\SlackOverload\Views\QandA\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Question> Html { get; private set; }
    }
}
#pragma warning restore 1591