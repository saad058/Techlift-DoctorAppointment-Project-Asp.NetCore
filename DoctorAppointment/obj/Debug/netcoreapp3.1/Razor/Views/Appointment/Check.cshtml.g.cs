#pragma checksum "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2236370b890f2443b53b6e90fce9930917602a88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_Check), @"mvc.1.0.view", @"/Views/Appointment/Check.cshtml")]
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
#line 1 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\_ViewImports.cshtml"
using DoctorAppointment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\_ViewImports.cshtml"
using DoctorAppointment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2236370b890f2443b53b6e90fce9930917602a88", @"/Views/Appointment/Check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181036f4c93c3b782b3c2f251e99d644f7799d95", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_Check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoctorAppointment.Models.DoctorInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-style-one rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PatientInfoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterPatient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2236370b890f2443b53b6e90fce9930917602a885067", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Check</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2236370b890f2443b53b6e90fce9930917602a886126", async() => {
                WriteLiteral(@"
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-form"">
        <div class=""modal-dialog s"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Modal title</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
                WriteLiteral(@"                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>
");
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 39 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>   No doctors are available on that Department. </p>\r\n");
#nullable restore
#line 42 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
    }

            else
            {

           

#line default
#line hidden
#nullable disable
                WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
               Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
               Write(Html.DisplayNameFor(model => model.DoctorFee));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n\r\n\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 62 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
               Write(Html.DisplayNameFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 65 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
               Write(Html.DisplayNameFor(model => model.Last_Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 72 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsAvailable));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoctorFee));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n");
                WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 85 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
                   Write(Html.DisplayFor(modelItem => item.First_Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Last_Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2236370b890f2443b53b6e90fce9930917602a8811427", async() => {
                    WriteLiteral(" Book_My_Appointment");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 97 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 100 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Appointment\Check.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoctorAppointment.Models.DoctorInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
