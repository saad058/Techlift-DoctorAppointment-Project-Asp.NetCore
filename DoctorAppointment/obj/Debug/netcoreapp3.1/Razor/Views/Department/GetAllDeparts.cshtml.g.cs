#pragma checksum "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac797115342333e4f7672bda2a1455d175d1424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_GetAllDeparts), @"mvc.1.0.view", @"/Views/Department/GetAllDeparts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac797115342333e4f7672bda2a1455d175d1424", @"/Views/Department/GetAllDeparts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181036f4c93c3b782b3c2f251e99d644f7799d95", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_GetAllDeparts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoctorAppointment.Models.Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
  
    ViewData["Title"] = "GetAllDeparts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetAllDeparts</h1>\r\n\r\n<p>\r\n    \r\n    <a");
            BeginWriteAttribute("href", " href=\"", 155, "\"", 183, 1);
#nullable restore
#line 12 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
WriteAttributeValue("", 162, Url.Action("AddNew"), 162, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Add Department</a>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
           Write(Html.DisplayFor(modelItem => item.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("\r\n                  <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1579, "\"", 1663, 3);
            WriteAttributeValue("", 1589, "window.location.href=\'", 1589, 22, true);
#nullable restore
#line 41 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
WriteAttributeValue("", 1611, Url.Action("Edit", new { id = item.DepartmentId }), 1611, 51, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1662, "\'", 1662, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n\r\n                  <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1745, "\"", 1832, 3);
            WriteAttributeValue("", 1755, "window.location.href=\'", 1755, 22, true);
#nullable restore
#line 43 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
WriteAttributeValue("", 1777, Url.Action("Details", new { id = item.DepartmentId }), 1777, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1831, "\'", 1831, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Details</button>\r\n                    <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1916, "\"", 2006, 3);
            WriteAttributeValue("", 1926, "window.location.href=\'", 1926, 22, true);
#nullable restore
#line 44 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
WriteAttributeValue("", 1948, Url.Action("DeleteByID", new { id = item.DepartmentId }), 1948, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2005, "\'", 2005, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "D:\Bootcamp\DoctorAppointment\DoctorAppointment\DoctorAppointment\Views\Department\GetAllDeparts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoctorAppointment.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
