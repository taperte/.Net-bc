#pragma checksum "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399890fbdde9f3da4413eac71a2871c8ddb0b76b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Movie), @"mvc.1.0.view", @"/Views/Movie/Movie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399890fbdde9f3da4413eac71a2871c8ddb0b76b", @"/Views/Movie/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3823143c08cfa8d228e4d64d23521f797cb23703", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieSeatsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Genres", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
  
    ViewData["Title"] = Model.Movie.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"nav nav-pills mb-3\">\r\n");
#nullable restore
#line 6 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
     foreach (var g in Model.Genres)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399890fbdde9f3da4413eac71a2871c8ddb0b76b4828", async() => {
#nullable restore
#line 9 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
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
#line 9 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
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
#line 11 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<div>\r\n    <br />\r\n    <h3>");
#nullable restore
#line 15 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
   Write(Model.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 16 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
     if (Model.Movie.OriginalTitle != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5 class=\"card-subtitle\">");
#nullable restore
#line 18 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                             Write(Model.Movie.OriginalTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 19 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-5 col-sm-12\">\r\n            <div><b>Genre:</b> ");
#nullable restore
#line 23 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                          Write(Model.Movie.Genre.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><b>Year:</b> ");
#nullable restore
#line 24 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                         Write(Model.Movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><b>Duration:</b> ");
#nullable restore
#line 25 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                             Write(Model.Movie.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\'</div>\r\n            <div><b>Director:</b> ");
#nullable restore
#line 26 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                             Write(Model.Movie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><b>Country:</b> ");
#nullable restore
#line 27 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                            Write(Model.Movie.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <br />\r\n            <div>");
#nullable restore
#line 29 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
            Write(Model.Movie.Abstract);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <br />\r\n            <div><b>Prices:</b></div>\r\n");
#nullable restore
#line 32 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
             for (int i = 0; i < Model.Prices.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <b>");
#nullable restore
#line 34 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
              Write(Model.Seats[i].Type.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span> — ");
#nullable restore
#line 34 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                         Write(Model.Prices[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" EUR</span>\r\n                <br />\r\n");
#nullable restore
#line 36 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-7 col-sm-12\">\r\n            <iframe width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=\"", 1326, "\"", 1352, 1);
#nullable restore
#line 39 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
WriteAttributeValue("", 1332, Model.Movie.Trailer, 1332, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" align=\"right\"></iframe>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div><b>Screenings:</b></div>\r\n    <table class=\"table table-hover light\">\r\n        <tr>\r\n");
#nullable restore
#line 46 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
             foreach (var screening in Model.Screenings)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n                    ");
#nullable restore
#line 49 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
               Write(screening.ToString().Substring(0, screening.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
#nullable restore
#line 51 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n");
#nullable restore
#line 54 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
             foreach (var screening in Model.Screenings)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n");
#nullable restore
#line 57 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                     foreach (var seat in Model.Seats)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399890fbdde9f3da4413eac71a2871c8ddb0b76b13713", async() => {
                WriteLiteral("Book ");
#nullable restore
#line 59 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                                                                                                   Write(seat.Type.ToLower());

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-time", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                           WriteLiteral(screening);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["time"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-time", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["time"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                                          WriteLiteral(Model.Movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                                                                             WriteLiteral(seat.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["seatid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-seatid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["seatid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <br />\r\n");
#nullable restore
#line 61 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n");
#nullable restore
#line 63 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieSeatsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
