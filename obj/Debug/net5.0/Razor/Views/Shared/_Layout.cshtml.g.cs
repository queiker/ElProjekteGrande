#pragma checksum "C:\Users\queiker\Downloads\Grande\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea01627ce09c1c856335a0bd7d9e20a7e0ef034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\queiker\Downloads\Grande\Views\_ViewImports.cshtml"
using El_Projekte_Grande;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\queiker\Downloads\Grande\Views\_ViewImports.cshtml"
using El_Projekte_Grande.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\queiker\Downloads\Grande\Views\_ViewImports.cshtml"
using El_Projekte_Grande.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea01627ce09c1c856335a0bd7d9e20a7e0ef034", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da13874dc88548cd1bbb2a77ad7529447c1a2cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea01627ce09c1c856335a0bd7d9e20a7e0ef0345012", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Project</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ea01627ce09c1c856335a0bd7d9e20a7e0ef0345422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ea01627ce09c1c856335a0bd7d9e20a7e0ef0346600", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Yatra+One&display=swap\" rel=\"stylesheet\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ea01627ce09c1c856335a0bd7d9e20a7e0ef0347884", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    
    <style>
   body {
   font-family: ""Yatra One"";
   background:whitesmoke;
   color: silver;
   }
        .sidebar {
            position: fixed;
            top: 0;
            bottom: 0;
            left: 0;
            z-index: 100;
            padding: 90px 0 0;
            box-shadow: inset -1px 0 0 rgba(0, 0, 0, .1);
            z-index: 99;
        }

       
            
        .navbar {
            box-shadow: inset 0 -1px 0 rgba(0, 0, 0, .1);
            background: whitesmoke;
            
        }

     

        .sidebar .nav-link {
            color: #333;
        }

        .sidebar .nav-link.active {
            color:rgba(38,38,255,0.27);
        }
        .card{
       
        background: white;
        }
       #hotdeal{
       color: red;
       }
        #title{
        color: #6c757d;
        }
        
       
        
    </style>


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
            WriteLiteral("\r\n\r\n<!--NavBar-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea01627ce09c1c856335a0bd7d9e20a7e0ef03410721", async() => {
                WriteLiteral(@"
<nav class=""navbar navbar-light bg-light p-3"">
    <div class=""d-flex col-12 col-md-3 col-lg-2 mb-2 mb-lg-0 flex-wrap flex-md-nowrap justify-content-between"">
        <a class=""navbar-brand"" href=""#"">
            Zegarek
        </a>
        <button class=""navbar-toggler d-md-none collapsed mb-3"" type=""button"" data-toggle=""collapse"" data-target=""#sidebar"" aria-controls=""sidebar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
    </div>
    <div id=""title"" class=""col-12 col-md-4 col-lg-2 text-center"">
        <h1> Strefa Inwestora</h1>
    </div>
    <div class=""col-12 col-md-5 col-lg-8 d-flex align-items-center justify-content-md-end mt-3 mt-md-0"">

        <div class=""dropdown"">
            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-expanded=""false"">
                Witaj
            </button>
            <ul class=""dropdown-menu"" aria-lab");
                WriteLiteral(@"elledby=""dropdownMenuButton"">
                <li>
                    <a class=""dropdown-item"" href=""#"">Wiadomosci</a>
                </li>
                <li>
                    <a class=""dropdown-item"" href=""#"">Moje Inwestycje</a>
                </li>
                <li>
                    <a class=""dropdown-item"" href=""#"">Sign out</a>
                </li>
            </ul>
        </div>
    </div>
</nav>
<div class=""container-fluid"">
    <div class=""row"">
        <nav id=""sidebar"" class=""col-md-3 col-lg-2 d-md-block bg-light sidebar collapse"">
            <div class=""position-sticky"">
                <ul class=""nav flex-column"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">

                            <span class=""ml-2"">Zegar & Data </span>
                        </a>
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">
                            <svg xmlns=""http://w");
                WriteLiteral(@"ww.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-home"">
                                <path d=""M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z""></path><polyline points=""9 22 9 12 15 12 15 22""></polyline>
                            </svg>
                            <span class=""ml-2"">Home</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-file"">
                                <path d=""M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z""></path><polyline points=""13 2 13 9 20 9""></polyline>
                            </svg>
");
                WriteLiteral(@"                            <span class=""ml-2"">Info</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-shopping-cart"">
                                <circle cx=""9"" cy=""21"" r=""1""></circle><circle cx=""20"" cy=""21"" r=""1""></circle><path d=""M1 1h4l2.68 13.39a2 2 0 0 0 2 1.61h9.72a2 2 0 0 0 2-1.61L23 6H6""></path>
                            </svg>
                            <span class=""ml-2"">Inwestycje</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" ");
                WriteLiteral(@"fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-users"">
                                <path d=""M17 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2""></path><circle cx=""9"" cy=""7"" r=""4""></circle><path d=""M23 21v-2a4 4 0 0 0-3-3.87""></path><path d=""M16 3.13a4 4 0 0 1 0 7.75""></path>
                            </svg>
                            <span class=""ml-2"">Team</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-bar-chart-2"">
                                <line x1=""18"" y1=""20"" x2=""18"" y2=""10""></line><line x1=""12"" y1=""20"" x2=""12"" y2=""4""></line><line x1=""6"" y1=""20"" x2=""6"" y2=""14""></line>
             ");
                WriteLiteral(@"               </svg>
                            <span class=""ml-2"">Reporty</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-layers"">
                                <polygon points=""12 2 2 7 12 12 22 7 12 2""></polygon><polyline points=""2 17 12 22 22 17""></polyline><polyline points=""2 12 12 17 22 12""></polyline>
                            </svg>
                            <span class=""ml-2"">More</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""btn btn-sm btn-secondary ml-3 mt-2""");
                BeginWriteAttribute("href", " href=\"", 7492, "\"", 7499, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-book"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                <path fill-rule=""evenodd"" d=""M1 2.828v9.923c.918-.35 2.107-.692 3.287-.81 1.094-.111 2.278-.039 3.213.492V2.687c-.654-.689-1.782-.886-3.112-.752-1.234.124-2.503.523-3.388.893zm7.5-.141v9.746c.935-.53 2.12-.603 3.213-.493 1.18.12 2.37.461 3.287.811V2.828c-.885-.37-2.154-.769-3.388-.893-1.33-.134-2.458.063-3.112.752zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z""/>
                            </svg>
                            <span class=""ml-2"">Blog </span>
                        </a>
                    </li>


    ");
                WriteLiteral(@"            </ul>
            </div>
        </nav>

        <main class=""col-md-2 ml-sm-auto col-lg-10 px-md-4 py-4"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item"">
                        <a href=""#"">Kursy Walut</a>
                    </li>
                    <li class=""breadcrumb-item"">
                        <a href=""#"">Dolar</a>
                    </li>
                    <li class=""breadcrumb-item"">
                        <a href=""#"">Jen</a>
                    </li>
                    <li class=""breadcrumb-item"">
                        <a href=""#"">Euro</a>
                    </li>
                    <li class=""breadcrumb-item"">
                        <a href=""#"">inne</a>
                    </li>
                    <li class=""breadcrumb-item"">
                        <a href=""#"">inne</a>
                    </li>
                    <li class=""breadcrumb-item"">
                     ");
                WriteLiteral(@"                       <a href=""#"">inne</a>
                                        </li>

                </ol>
            </nav>
            <h1 class=""h2"">
                <span id=""hotdeal"">Hot Deal</span>
            </h1>
            <p>W co warto zainwestowac dzisiaj</p>
            <button class=""btn btn-info"">Sprawdz</button>
            ");
#nullable restore
#line 203 "C:\Users\queiker\Downloads\Grande\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


            <div class=""row"">
                <div class=""col-12 col-xl-8 mb-4 mb-lg-0"">
                    <div class=""card"">
                        <h5 class=""card-header"">Chat & Posts</h5>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <p>
                                    Lorem ipsum dolor sit amet, hendrerit scriptorem per at, usu id tation nonumes theophrastus. Wisi eius minim est ad, debitis maluisset repudiare vix id, simul signiferumque vel cu. Eu eum dolor sensibus. Vis no rationibus definiebas, nominavi principes ne est, no illum commune nam. Alienum sadipscing an has.

                                    Sed ei consul appellantur, erant dicunt persecuti nec ei. Purto fabellas nam id. Quem luptatum efficiendi nam cu, ei magna mazim viris sed. Eos animal civibus vivendum ut.
                                </p>
                            </div>
                            <a href=""#"" cl");
                WriteLiteral(@"ass=""btn btn-block btn-light"">View all</a>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-xl-4"">
                    <div class=""card"">
                        <h5 class=""card-header"">Wykresy</h5>
                        <div class=""card-body"">
                            <div id=""traffic-chart""></div>
                        </div>
                    </div>
                </div>
            </div>


            <footer class=""pt-5 d-flex justify-content-between"">
                <span>Copyright © 2021<a");
                BeginWriteAttribute("href", " href=\"", 11545, "\"", 11552, 0);
                EndWriteAttribute();
                WriteLiteral(@">GLD</a></span>
                <ul class=""nav m-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link text-secondary"" aria-current=""page"" href=""#"">Privacy Policy</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link text-secondary"" href=""#"">Terms and conditions</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link text-secondary"" href=""#"">Contact</a>
                    </li>
                </ul>
            </footer>
        </main>
    </div>
</div>
 <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/5.0.0-alpha1/js/bootstrap.min.js"" integrity=""sha384-oesi62hOLfzrys4LxRF63OJCXdXDipiYWBnvTl9Y9/TRlw5xlKIEHpNyvvDShgf/"" crossorigi");
                WriteLiteral("n=\"anonymous\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/chartist.js/latest/chartist.min.js\"></script>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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