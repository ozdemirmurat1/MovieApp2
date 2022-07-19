#pragma checksum "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b763bdbf5f0754a008de3d4223e21a4fbca33d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\_ViewImports.cshtml"
using Enoca2.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\_ViewImports.cshtml"
using Enoca2.Presentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
using Enoca2.Presentation.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b763bdbf5f0754a008de3d4223e21a4fbca33d6", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e84ad44b96496e238d10392f94958ed5ba668e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>DataTables</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">DataTables</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">

                    <!-- /.card -->

                    <div class=""card"">
                        <div class=""card-header"">
                            <h3 class=""card-titl");
            WriteLiteral(@"e"">Kullanıcı Listesi</h3>
                        </div>

                       
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""example1"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>Id</th>
                                        <th>Email</th>
                                        <th>UserName</th>
                                        <th>Status</th>
                                        <th>IsAdmin</th>
                                        <th>Transactions</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 52 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                     foreach (var item in Model.UserList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 55 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 56 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 57 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 58 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 59 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                           Write(item.IsAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 60 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                           Write(Html.Raw(item.IsAdmin == true ? "Admin" : "Normal User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2616, "\"", 2648, 2);
            WriteAttributeValue("", 2623, "/admin/user/edit/", 2623, 17, true);
#nullable restore
#line 61 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2640, item.Id, 2640, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> | <a");
            BeginWriteAttribute("href", " href=\"", 2663, "\"", 2697, 2);
            WriteAttributeValue("", 2670, "/admin/user/delete/", 2670, 19, true);
#nullable restore
#line 61 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2689, item.Id, 2689, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\User\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>Id</th>
                                        <th>Email</th>
                                        <th>UserName</th>
                                        <th>Status</th>
                                        <th>IsAdmin</th>
                                        <th>Transactions</th>
                                    </tr>
                                </tfoot>
                            </table>                          

                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
