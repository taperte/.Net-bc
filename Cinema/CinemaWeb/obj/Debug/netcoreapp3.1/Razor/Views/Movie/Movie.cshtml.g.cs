#pragma checksum "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4841b66cd855f9fdcc77442b9d3781ac7555ffdf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4841b66cd855f9fdcc77442b9d3781ac7555ffdf", @"/Views/Movie/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3823143c08cfa8d228e4d64d23521f797cb23703", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Genres", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-sm small-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
  
    ViewData["Title"] = Model.Movie.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <ul class=\"nav nav-pills mb-3\">\r\n");
#nullable restore
#line 7 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
         foreach (var g in Model.Genres)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
             if (g.Movies.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4841b66cd855f9fdcc77442b9d3781ac7555ffdf7836", async() => {
#nullable restore
#line 12 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                                                                                        Write(g.Genre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 312, "nav-link", 312, 8, true);
#nullable restore
#line 12 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
AddHtmlAttributeValue(" ", 320, g.Id == Model.Movie.Genre.Id ? "active" : "", 321, 47, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-genreid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
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
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 14 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <div>\r\n        <br />\r\n        <h3>");
#nullable restore
#line 19 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
       Write(Model.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 20 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
         if (Model.Movie.OriginalTitle != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"card-subtitle\">");
#nullable restore
#line 22 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                 Write(Model.Movie.OriginalTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 23 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-md-5 col-sm-12\">\r\n                <div><b>Genre:</b> ");
#nullable restore
#line 27 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                              Write(Model.Movie.Genre.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div><b>Year:</b> ");
#nullable restore
#line 28 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                             Write(Model.Movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div><b>Duration:</b> ");
#nullable restore
#line 29 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                 Write(Model.Movie.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\'</div>\r\n                <div><b>Director:</b> ");
#nullable restore
#line 30 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                 Write(Model.Movie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div><b>Country:</b> ");
#nullable restore
#line 31 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                Write(Model.Movie.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <br />\r\n                <div>");
#nullable restore
#line 33 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                Write(Model.Movie.Abstract);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <br />\r\n                <div><b>Auditorium:</b> ");
#nullable restore
#line 35 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                   Write(Model.Movie.Auditorium.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <br />\r\n                <div><b>Prices:</b></div>\r\n");
#nullable restore
#line 38 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                 for (int i = 0; i < Model.Prices.Count; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                     if (Model.AuditoriumSeatCount[i] > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b>");
#nullable restore
#line 42 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                      Write(Model.Seats[i].Type.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><span> — ");
#nullable restore
#line 42 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                 Write(Model.Prices[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" EUR</span>\r\n                        <br />\r\n");
#nullable restore
#line 44 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-7 col-sm-12\">\r\n                <iframe width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=\"", 1828, "\"", 1854, 1);
#nullable restore
#line 48 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
WriteAttributeValue("", 1834, Model.Movie.Trailer, 1834, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" align=\"right\"></iframe>\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <p><b>Screenings:</></b><br /></p>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 55 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                 for (int i = 0; i < Model.Screenings.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 col-sm-12\">\r\n                        <b class=\"orange\">");
#nullable restore
#line 58 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                     Write(Model.Screenings[i].Time.ToString().Substring(0, Model.Screenings[i].Time.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 59 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                         for (int j = 0; j < Model.ScreeningsSeatCount[i].Count; j++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                             if (Model.ScreeningsSeatCount[i][j] > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row\">\r\n                                    <div class=\"col-md-2 col-sm-12\">");
#nullable restore
#line 64 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                               Write(Model.Seats[j].Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 64 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                     Write(Model.ScreeningsSeatCount[i][j]);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</div>\r\n                                    \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4841b66cd855f9fdcc77442b9d3781ac7555ffdf19185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 66 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4841b66cd855f9fdcc77442b9d3781ac7555ffdf20734", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-xs-1"" maxlength=""3"">
                                                <label class=""col-form-label-sm""></label>
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4841b66cd855f9fdcc77442b9d3781ac7555ffdf21280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 71 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TicketCount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4841b66cd855f9fdcc77442b9d3781ac7555ffdf23125", async() => {
                    WriteLiteral("Book");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-screeningid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                                                                                   WriteLiteral(Model.Screenings[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["screeningid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-screeningid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["screeningid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                                                                                                                              WriteLiteral(Model.Seats[j].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["seatid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-seatid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["seatid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                                                                                                                                                                                                                                         WriteLiteral(Model.TicketCount);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ticketcount"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ticketcount", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ticketcount"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 77 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n                    </div>\r\n");
#nullable restore
#line 81 "C:\Users\sl41040\source\.Net-bc\Cinema\CinemaWeb\Views\Movie\Movie.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
