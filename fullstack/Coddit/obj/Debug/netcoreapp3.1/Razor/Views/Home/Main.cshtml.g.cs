#pragma checksum "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c3f1bdda865a4d5ffbb160dcc027fd6c63dfca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
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
#line 1 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\_ViewImports.cshtml"
using Coddit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\_ViewImports.cshtml"
using Coddit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c3f1bdda865a4d5ffbb160dcc027fd6c63dfca", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016796766b5c48084a03a8fb2e3b536bb38caa9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"headerDiv\">\r\n    <h1><a href=\"/posts/new\">make post</a></h1>\r\n    <h1 id=\"userName\"><a href=\"#\">");
#nullable restore
#line 3 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"
                             Write(ViewBag.LoggedUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 7 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"
     foreach (Post post  in ViewBag.AllPosts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class = \"postBox\">\r\n            <div class=\"postLikes\">\r\n                <span>????</span>\r\n                <span>14</span>\r\n            </div>\r\n            <div class = \"postBoxInfo\">\r\n                <h3><a");
            BeginWriteAttribute("href", " href = \"", 434, "\"", 453, 1);
#nullable restore
#line 15 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"
WriteAttributeValue("", 443, post.Link, 443, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"
                                      Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>posted by ");
#nullable restore
#line 16 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"
                        Write(post.Creator.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>on ");
#nullable restore
#line 17 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"
                 Write(post.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><a href=\"#\">16 comments</a> Topic: ");
#nullable restore
#line 18 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"
                                                 Write(post.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Mutah\OneDrive\Desktop\C#\fullstack\Coddit\Views\Home\Main.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
