#pragma checksum "D:\noni\git-repository\04_Project_NetCore\_04_Example\Views\RoleManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "169f2c81e14d81a1576a02c0b44923c0d942168f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleManagement_Index), @"mvc.1.0.view", @"/Views/RoleManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleManagement/Index.cshtml", typeof(AspNetCore.Views_RoleManagement_Index))]
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
#line 1 "D:\noni\git-repository\04_Project_NetCore\_04_Example\Views\_ViewImports.cshtml"
using _04_Example;

#line default
#line hidden
#line 2 "D:\noni\git-repository\04_Project_NetCore\_04_Example\Views\_ViewImports.cshtml"
using _04_Example.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f2c81e14d81a1576a02c0b44923c0d942168f", @"/Views/RoleManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5263ce06ecf9c08f93580cf3165f129006a762", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_04_Example_Entity.RoleModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\noni\git-repository\04_Project_NetCore\_04_Example\Views\RoleManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 30, true);
            WriteLiteral("\r\n<h1>Role Management</h1>\r\n\r\n");
            EndContext();
            BeginContext(193, 752, true);
            WriteLiteral(@"<div class=""card-header py-3"">
    <input id=""btnAddRole"" data-toggle=""modal"" data-target=""#myModalAdd"" type=""button"" class=""btn btn-primary"" value=""Add""/>

    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Role Name</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Role Name</th>
                        <th>Action</th>
                    </tr>
                </tfoot>
                <tbody>
                    <tr>
");
            EndContext();
            BeginContext(999, 496, true);
            WriteLiteral(@"                        <th>test</th>
                        <th>
                            <input id=""btnEditRole"" data-toggle=""modal"" data-target=""#myModalEdit"" type=""button"" class=""btn btn-primary"" value=""Edit"" />
                            <input id=""btnDelete"" type=""button"" class=""btn btn-danger"" onclick=""destroy();"" value=""Delete"" />
                        </th>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>


");
            EndContext();
            BeginContext(1507, 550, true);
            WriteLiteral(@"

<!--Modal-->
<div class=""modal fade"" id=""myModalAdd"" role=""form"">
    <div class=""modal-dialog"">

        <!--Modal Content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Create Role</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <div class=""form-inline"">
                    <label style=""width:100px;"">Role Name</label>
                    ");
            EndContext();
            BeginContext(2058, 103, false);
#line 61 "D:\noni\git-repository\04_Project_NetCore\_04_Example\Views\RoleManagement\Index.cshtml"
               Write(Html.TextBoxFor(model => model.RoleName, (object)new { autocomplete = "off", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 877, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <input id=""btnSave"" type=""submit"" class=""btn btn-primary"" value=""Save""/>
                <input id=""btnClose"" type=""button"" class=""btn btn-dark"" data-dismiss=""modal"" value=""Close""/>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""myModalEdit"" role=""form"">
    <div class=""modal-dialog"">

        <!--Modal Content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Update Role</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <div class=""form-inline"">
                    <label style=""width:100px;"">Role Name</label>
                    ");
            EndContext();
            BeginContext(3039, 103, false);
#line 84 "D:\noni\git-repository\04_Project_NetCore\_04_Example\Views\RoleManagement\Index.cshtml"
               Write(Html.TextBoxFor(model => model.RoleName, (object)new { autocomplete = "off", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3142, 346, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <input id=""btnUpdate"" type=""submit"" class=""btn btn-primary"" value=""Update"" />
                <input id=""btnClose"" type=""button"" class=""btn btn-dark"" data-dismiss=""modal"" value=""Close"" />
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_04_Example_Entity.RoleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
