#pragma checksum "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c042a3eb6f569de22645e07cceda7a2f4d13e14d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Genres), @"mvc.1.0.view", @"/Views/Movie/Genres.cshtml")]
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
#line 1 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\_ViewImports.cshtml"
using CinemaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\_ViewImports.cshtml"
using CinemaWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c042a3eb6f569de22645e07cceda7a2f4d13e14d", @"/Views/Movie/Genres.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3823143c08cfa8d228e4d64d23521f797cb23703", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Genres : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenreMovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Genres", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
  
    ViewData["Title"] = "Genres";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"nav nav-pills mb-3\">\r\n");
#nullable restore
#line 6 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
     foreach (var g in Model.Genres)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c042a3eb6f569de22645e07cceda7a2f4d13e14d4579", async() => {
#nullable restore
#line 9 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                                                                                                Write(g.Genre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-genreid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                                                                                  WriteLiteral(g.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genreid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-genreid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genreid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 11 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
#nullable restore
#line 13 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
 if (Model.Movies.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover"">
        <tr>
            <th></th>
            <th>Title</th>
            <th>Director</th>
            <th>Year</th>
            <th>Duration</th>
            <th>Screenings</th>
            <th></th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
");
#nullable restore
#line 28 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
         for (int i = 0; i < Model.Movies.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
               Write(Model.Movies[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
               Write(Model.Movies[i].Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
               Write(Model.Movies[i].Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
               Write(Model.Movies[i].Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\'</td>\r\n");
#nullable restore
#line 36 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                 if (Model.Movies[i].ScreeningTime1 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 38 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                   Write(Model.Movies[i].ScreeningTime1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 43 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                 if (Model.Movies[i].ScreeningTime2 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 46 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                   Write(Model.Movies[i].ScreeningTime2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 47 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 51 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                 if (Model.Movies[i].ScreeningTime3 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 54 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                   Write(Model.Movies[i].ScreeningTime3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 59 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                 if (Model.Movies[i].ScreeningTime4 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 62 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                   Write(Model.Movies[i].ScreeningTime4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 63 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 67 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                 if (Model.Movies[i].ScreeningTime5 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 70 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                   Write(Model.Movies[i].ScreeningTime5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 71 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 75 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 77 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 79 "C:\Users\''Dell''\Documents\GitHub\.Net-bc\Cinema\CinemaWeb\Views\Movie\Genres.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenreMovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
