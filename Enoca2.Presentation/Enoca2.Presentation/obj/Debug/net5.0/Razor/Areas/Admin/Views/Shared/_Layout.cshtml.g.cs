#pragma checksum "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12de0fced0cdc1bd3af257d22b3a3da2825ef43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
using Enoca2.Presentation.Areas.Admin.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
using Enoca2.Presentation.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12de0fced0cdc1bd3af257d22b3a3da2825ef43", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e84ad44b96496e238d10392f94958ed5ba668e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_resultMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12de0fced0cdc1bd3af257d22b3a3da2825ef434834", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>AdminLTE 3 | Dashboard</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/admin/plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- Tempusdominus Bootstrap 4 -->
    <link rel=""stylesheet"" href=""/admin/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"">
    <!-- iCheck -->
    <link rel=""stylesheet"" href=""/admin/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
    <!-- JQVMap -->
    <link rel=""stylesheet"" href=""/admin/plugins/jqvmap/jqvmap.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/admin/dist/css/adminlte.min.css"">
    <!-- o");
                WriteLiteral(@"verlayScrollbars -->
    <link rel=""stylesheet"" href=""/admin/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
    <!-- Daterange picker -->
    <link rel=""stylesheet"" href=""/admin/plugins/daterangepicker/daterangepicker.css"">
    <!-- summernote -->
    <link rel=""stylesheet"" href=""/admin/plugins/summernote/summernote-bs4.min.css"">

");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12de0fced0cdc1bd3af257d22b3a3da2825ef437254", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n");
#nullable restore
#line 34 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
         if (TempData["message"] != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c12de0fced0cdc1bd3af257d22b3a3da2825ef437857", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 36 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (TempData.Get<ResultMessage>("message"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <!-- Preloader -->\r\n        ");
#nullable restore
#line 40 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("Preloader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Navbar -->\r\n        ");
#nullable restore
#line 43 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /.navbar -->\r\n        <!-- Main Sidebar Container -->\r\n        ");
#nullable restore
#line 46 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("MainSideBar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Content Wrapper. Contains page content -->\r\n        ");
#nullable restore
#line 49 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /.content-wrapper -->\r\n        ");
#nullable restore
#line 51 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("ContentWrapper"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Control Sidebar -->\r\n        ");
#nullable restore
#line 54 "C:\Users\90545\Desktop\Enoca_Challenge\Enoca_Görev2\Enoca2.Presentation\Enoca2.Presentation\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("ControlSideBar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script src=""/admin/plugins/jquery/jquery.min.js""></script>
    <!-- jQuery UI 1.11.4 -->
    <script src=""/admin/plugins/jquery-ui/jquery-ui.min.js""></script>
    <!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
    <script>
        $.widget.bridge('uibutton', $.ui.button)
    </script>
    <!-- Bootstrap 4 -->
    <script src=""/admin/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- ChartJS -->
    <script src=""/admin/plugins/chart.js/Chart.min.js""></script>
    <!-- Sparkline -->
    <script src=""/admin/plugins/sparklines/sparkline.js""></script>
    <!-- JQVMap -->
    <script src=""/admin/plugins/jqvmap/jquery.vmap.min.js""></script>
    <script src=""/admin/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
    <!-- jQuery Knob Chart -->
    <script src=""/admin/plugins/jquery-knob/jquery.knob.min.js""></script>
    <!-- daterangepicker -->
    <script src=""/");
                WriteLiteral(@"admin/plugins/moment/moment.min.js""></script>
    <script src=""/admin/plugins/daterangepicker/daterangepicker.js""></script>
    <!-- Tempusdominus Bootstrap 4 -->
    <script src=""/admin/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
    <!-- Summernote -->
    <script src=""/admin/plugins/summernote/summernote-bs4.min.js""></script>
    <!-- overlayScrollbars -->
    <script src=""/admin/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""/admin/dist/js/adminlte.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""/admin/dist/js/demo.js""></script>
    <!-- AdminLTE dashboard demo (This is only for demo purposes) -->
    <script src=""/admin/dist/js/pages/dashboard.js""></script>

    <script src=""/admin/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
    <script src=""/admin/plugins/datata");
                WriteLiteral(@"bles-responsive/js/dataTables.responsive.min.js""></script>
    <script src=""/admin/plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/dataTables.buttons.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.bootstrap4.min.js""></script>
    <script src=""/admin/plugins/jszip/jszip.min.js""></script>
    <script src=""/admin/plugins/pdfmake/pdfmake.min.js""></script>
    <script src=""/admin/plugins/pdfmake/vfs_fonts.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.html5.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.print.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.colVis.min.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

    <script >
        $(document).ready(function () {
            $(""#myInput"").on(""keyup"", function () {
                var ");
                WriteLiteral(@"value = $(this).val().toLowerCase();
                $(""#myTable tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
                });
            });
        });
            
    </script>
    <script>
        jQuery(document).ready(function ($) {
            $(""#filter"").submit(function () {
                $(this).find("":input"").filter(function () { return !this.value }).attr(""disabled"", ""disabled"");
                return true;
            });
            $(""form"").find("":input"").prop(""disabled"", false);
        });
    </script>
    

");
                WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"">
    </script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.13.1/jquery.validate.min.js"">
    </script>
    <script src=""https://ajax.aspnetcdn.com/ajax/mvc/5.2.3/jquery.validate.unobtrusive.min.js"">
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
