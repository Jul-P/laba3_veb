#pragma checksum "D:\5-4 лаба Попкова Юлия\5лаба\Views\Rating\UpdateRating.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74491d2a0f9a663b77cea5ce80449d5c6969b144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rating_UpdateRating), @"mvc.1.0.view", @"/Views/Rating/UpdateRating.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74491d2a0f9a663b77cea5ce80449d5c6969b144", @"/Views/Rating/UpdateRating.cshtml")]
    public class Views_Rating_UpdateRating : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Storege.Entity.Rating>
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
#line 2 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Rating\UpdateRating.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74491d2a0f9a663b77cea5ce80449d5c6969b1442933", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Изменить автора</title>\r\n    <style>\r\n        body {\r\n            background: #ee8ce9 /* Цвет фона */\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74491d2a0f9a663b77cea5ce80449d5c6969b1444115", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 20 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Rating\UpdateRating.cshtml"
         using (Html.BeginForm("Update", "Rating", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input id=\"StudentId\" name=\"StudentId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 481, "\"", 498, 1);
#nullable restore
#line 22 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Rating\UpdateRating.cshtml"
WriteAttributeValue("", 489, Model.Id, 489, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <lable> Автор: </lable>\r\n            <input id=\"Result\" type=\"text\" name=\"Result\"");
                BeginWriteAttribute("value", " value=\"", 597, "\"", 618, 1);
#nullable restore
#line 24 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Rating\UpdateRating.cshtml"
WriteAttributeValue("", 605, Model.Result, 605, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br /><br />\r\n            <input type=\"submit\" value=\"Up\" />\r\n");
#nullable restore
#line 26 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Rating\UpdateRating.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
#nullable restore
#line 27 "D:\5-4 лаба Попкова Юлия\5лаба\Views\Rating\UpdateRating.cshtml"
   Write(Html.ActionLink("Nazad", "ShowRating", "Rating"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Storege.Entity.Rating> Html { get; private set; }
    }
}
#pragma warning restore 1591
