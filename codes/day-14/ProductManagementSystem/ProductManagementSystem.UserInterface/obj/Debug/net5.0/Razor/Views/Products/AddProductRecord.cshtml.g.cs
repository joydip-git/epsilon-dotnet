#pragma checksum "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c00adfbb9186ad623a5153eacc44b6300cf588e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_AddProductRecord), @"mvc.1.0.view", @"/Views/Products/AddProductRecord.cshtml")]
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
#line 1 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
using ProductManagementSystem.UserInterface.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c00adfbb9186ad623a5153eacc44b6300cf588e", @"/Views/Products/AddProductRecord.cshtml")]
    public class Views_Products_AddProductRecord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductAddViewModel>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c00adfbb9186ad623a5153eacc44b6300cf588e3096", async() => {
                WriteLiteral("\r\n    <title>Add Product</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c00adfbb9186ad623a5153eacc44b6300cf588e4096", async() => {
                WriteLiteral("\r\n    <h2>Add a Record</h2>\r\n\r\n");
#nullable restore
#line 12 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
     using (this.Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 17 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
               Write(this.Html.LabelFor(pv => pv.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
               Write(this.Html.TextBoxFor(pv => pv.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
               Write(this.Html.LabelFor(pv => pv.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
               Write(this.Html.TextBoxFor(pv => pv.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
               Write(this.Html.LabelFor(pv => pv.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
               Write(this.Html.TextBoxFor(pv => pv.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <input type=\"submit\" value=\"Add Record\" />\r\n");
#nullable restore
#line 41 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 51 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
       if (this.ViewBag.Status != null)
        {
            var message = this.ViewBag.Status ? "Added" : "Failed";

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>");
#nullable restore
#line 54 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
             Write(message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "E:\epsilon-dotnet\codes\day-14\ProductManagementSystem\ProductManagementSystem.UserInterface\Views\Products\AddProductRecord.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
