#pragma checksum "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99bcf4825fecd063779bf6ff5a8b3534229fbbed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MyBookings), @"mvc.1.0.view", @"/Views/Movie/MyBookings.cshtml")]
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
#line 1 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\_ViewImports.cshtml"
using CinemaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\_ViewImports.cshtml"
using CinemaWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bcf4825fecd063779bf6ff5a8b3534229fbbed", @"/Views/Movie/MyBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3823143c08cfa8d228e4d64d23521f797cb23703", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MyBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CinemaLogic.DB.Bookings>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
  
    ViewData["Title"] = "My bookings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>My bookings</h2>\r\n<br />\r\n");
#nullable restore
#line 8 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Title</th>\r\n            <th>Screening</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 17 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
                Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
               Write(Model[i].Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
               Write(Model[i].BookedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99bcf4825fecd063779bf6ff5a8b3534229fbbed5415", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookedtime", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
                                                                            WriteLiteral(Model[i].BookedTime);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookedtime"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookedtime", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookedtime"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 27 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>You don\'t have any bookings yet.</div>\r\n");
#nullable restore
#line 31 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\MyBookings.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CinemaLogic.DB.Bookings>> Html { get; private set; }
    }
}
#pragma warning restore 1591
