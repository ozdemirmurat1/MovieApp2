#pragma checksum "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058454ed88c5a9108c4eb5b8d115e818ff0f289b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Film_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Film/Index.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
using Enoca2.Presentation.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058454ed88c5a9108c4eb5b8d115e818ff0f289b", @"/Areas/Admin/Views/Film/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e84ad44b96496e238d10392f94958ed5ba668e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Film_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
  
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
                    <h1>Film List</h1>
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
                            <h3 cla");
            WriteLiteral(@"ss=""card-title"">Film List</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""example1"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>Id</th>
                                        <th>Film Name</th>
                                        <th>Film Production Year</th>                                       
                                        <th>Transactions</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 47 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
                                     foreach (var item in Model.List1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 50 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 51 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
                                           Write(item.FilmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 52 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
                                           Write(item.FilmProductionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                           \r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2340, "\"", 2372, 2);
            WriteAttributeValue("", 2347, "/admin/film/edit/", 2347, 17, true);
#nullable restore
#line 53 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
WriteAttributeValue("", 2364, item.Id, 2364, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> | <a");
            BeginWriteAttribute("href", " href=\"", 2387, "\"", 2421, 2);
            WriteAttributeValue("", 2394, "/admin/film/delete/", 2394, 19, true);
#nullable restore
#line 53 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
WriteAttributeValue("", 2413, item.Id, 2413, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Film\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>Id</th>
                                        <th>Film Name</th>
                                        <th>Film Production Year</th>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
