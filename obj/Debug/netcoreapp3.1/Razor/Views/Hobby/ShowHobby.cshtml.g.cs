#pragma checksum "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34008539982f7ec02ded2231fabab78525b2ab2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hobby_ShowHobby), @"mvc.1.0.view", @"/Views/Hobby/ShowHobby.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34008539982f7ec02ded2231fabab78525b2ab2c", @"/Views/Hobby/ShowHobby.cshtml")]
    public class Views_Hobby_ShowHobby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Storege.Entity.Hobby>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34008539982f7ec02ded2231fabab78525b2ab2c2921", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>показать описание книги</title>\r\n    <style>\r\n        body {\r\n            background: #ee8ce9 /* Цвет фона */\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34008539982f7ec02ded2231fabab78525b2ab2c4111", async() => {
                WriteLiteral("\r\n    <h1>Описание кинги</h1>\r\n    <div>\r\n");
#nullable restore
#line 21 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>описание</label>\r\n");
#nullable restore
#line 25 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
       Write(item.hobby);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 512, "\"", 546, 2);
                WriteAttributeValue("", 519, "/Hobby/UpdateHobby/", 519, 19, true);
#nullable restore
#line 26 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
WriteAttributeValue("", 538, item.Id, 538, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 574, "\"", 605, 2);
                WriteAttributeValue("", 581, "/Hobby/DelHobby/", 581, 16, true);
#nullable restore
#line 27 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
WriteAttributeValue("", 597, item.Id, 597, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Del</a>\r\n            <br />\r\n");
#nullable restore
#line 29 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
         using (Html.BeginForm("AddHobby", "Hobby"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <input type=\"submit\" value=\"add\" />\r\n            </div>\r\n");
#nullable restore
#line 35 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
#nullable restore
#line 36 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Hobby\ShowHobby.cshtml"
   Write(Html.ActionLink("Student", "ShowStudent", "Student"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Storege.Entity.Hobby>> Html { get; private set; }
    }
}
#pragma warning restore 1591
