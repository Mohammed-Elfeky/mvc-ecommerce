#pragma checksum "F:\iti courses\mvc\Day2\lab\mvc-ecommerce\e-commerce-project\Views\Shared\_Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "290b0f96d71f15f09c8a03b3885a819f94e079c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Admin), @"mvc.1.0.view", @"/Views/Shared/_Admin.cshtml")]
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
#line 1 "F:\iti courses\mvc\Day2\lab\mvc-ecommerce\e-commerce-project\Views\_ViewImports.cshtml"
using e_commerce_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\iti courses\mvc\Day2\lab\mvc-ecommerce\e-commerce-project\Views\_ViewImports.cshtml"
using e_commerce_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"290b0f96d71f15f09c8a03b3885a819f94e079c6", @"/Views/Shared/_Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d2b6c0324bc10d943d4faa178708e7e5b2a33a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-search form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-search-main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290b0f96d71f15f09c8a03b3885a819f94e079c64338", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <!-- Sweet Alert -->
    <link type=""text/css"" href=""/AdminLayoutTemplate/sweetalert2.min.css"" rel=""stylesheet"">

    <!-- Notyf -->
    <link type=""text/css"" href=""/AdminLayoutTemplate/notyf.min.css"" rel=""stylesheet"">

    <!-- Volt CSS -->
    <link type=""text/css"" href=""/AdminLayoutTemplate/volt.css"" rel=""stylesheet"">
    ");
#nullable restore
#line 14 "F:\iti courses\mvc\Day2\lab\mvc-ecommerce\e-commerce-project\Views\Shared\_Admin.cshtml"
Write(RenderSection("MyStyles",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290b0f96d71f15f09c8a03b3885a819f94e079c66192", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 18 "F:\iti courses\mvc\Day2\lab\mvc-ecommerce\e-commerce-project\Views\Shared\_Admin.cshtml"
Write(Html.Partial("_aside"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
       
<main class=""content"">

                 <nav class=""navbar navbar-top navbar-expand navbar-dashboard navbar-dark ps-0 pe-2 pb-0"">
  <div class=""container-fluid px-0"">
    <div class=""d-flex justify-content-between w-100"" id=""navbarSupportedContent"">
      <div class=""d-flex align-items-center"">
        <!-- Search form -->
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290b0f96d71f15f09c8a03b3885a819f94e079c67064", async() => {
                    WriteLiteral(@"
          <div class=""input-group input-group-merge search-bar"">
              <span class=""input-group-text"" id=""topbar-addon"">
                <svg class=""icon icon-xs"" x-description=""Heroicon name: solid/search"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20"" fill=""currentColor"" aria-hidden=""true"">
                  <path fill-rule=""evenodd"" d=""M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z"" clip-rule=""evenodd""></path>
                </svg>
              </span>
              <input type=""text"" class=""form-control"" id=""topbarInputIconLeft"" placeholder=""Search"" aria-label=""Search"" aria-describedby=""topbar-addon"">
          </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <!-- / Search form -->
      </div>
      <!-- Navbar links -->
      <ul class=""navbar-nav align-items-center"">
        <li class=""nav-item dropdown"">
          <a class=""nav-link text-dark notification-bell unread dropdown-toggle"" data-unread-notifications=""true"" href=""#"" role=""button"" data-bs-toggle=""dropdown"" data-bs-display=""static"" aria-expanded=""false"">
            <svg class=""icon icon-sm text-gray-900"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path d=""M10 2a6 6 0 00-6 6v3.586l-.707.707A1 1 0 004 14h12a1 1 0 00.707-1.707L16 11.586V8a6 6 0 00-6-6zM10 18a3 3 0 01-3-3h6a3 3 0 01-3 3z""></path></svg>
          </a>
          <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-center mt-2 py-0"">
            <div class=""list-group list-group-flush"">
              <a href=""#"" class=""text-center text-primary fw-bold border-bottom border-light py-3"">Notifications</a>
              <a href=""#"" class=""list-group-item list-group-item-action border-bottom""");
                WriteLiteral(@">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                      <!-- Avatar -->
                      <img alt=""Image placeholder"" src=""../../assets/img/team/profile-picture-1.jpg"" class=""avatar-md rounded"">
                    </div>
                    <div class=""col ps-0 ms-2"">
                      <div class=""d-flex justify-content-between align-items-center"">
                          <div>
                            <h4 class=""h6 mb-0 text-small"">Jose Leos</h4>
                          </div>
                          <div class=""text-end"">
                            <small class=""text-danger"">a few moments ago</small>
                          </div>
                      </div>
                      <p class=""font-small mt-1 mb-0"">Added you to an event ""Project stand-up"" tomorrow at 12:30 AM.</p>
                    </div>
                </div>
              </a>
              <a href=""#"" class=""list-group-item list-group");
                WriteLiteral(@"-item-action border-bottom"">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                      <!-- Avatar -->
                      <img alt=""Image placeholder"" src=""../../assets/img/team/profile-picture-2.jpg"" class=""avatar-md rounded"">
                    </div>
                    <div class=""col ps-0 ms-2"">
                      <div class=""d-flex justify-content-between align-items-center"">
                          <div>
                            <h4 class=""h6 mb-0 text-small"">Neil Sims</h4>
                          </div>
                          <div class=""text-end"">
                            <small class=""text-danger"">2 hrs ago</small>
                          </div>
                      </div>
                      <p class=""font-small mt-1 mb-0"">You've been assigned a task for ""Awesome new project"".</p>
                    </div>
                </div>
              </a>
              <a href=""#"" class=""list-group-item");
                WriteLiteral(@" list-group-item-action border-bottom"">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                      <!-- Avatar -->
                      <img alt=""Image placeholder"" src=""../../assets/img/team/profile-picture-3.jpg"" class=""avatar-md rounded"">
                    </div>
                    <div class=""col ps-0 m-2"">
                      <div class=""d-flex justify-content-between align-items-center"">
                          <div>
                            <h4 class=""h6 mb-0 text-small"">Roberta Casas</h4>
                          </div>
                          <div class=""text-end"">
                            <small>5 hrs ago</small>
                          </div>
                      </div>
                      <p class=""font-small mt-1 mb-0"">Tagged you in a document called ""Financial plans"",</p>
                    </div>
                </div>
              </a>
              <a href=""#"" class=""list-group-item list-grou");
                WriteLiteral(@"p-item-action border-bottom"">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                      <!-- Avatar -->
                      <img alt=""Image placeholder"" src=""../../assets/img/team/profile-picture-4.jpg"" class=""avatar-md rounded"">
                    </div>
                    <div class=""col ps-0 ms-2"">
                      <div class=""d-flex justify-content-between align-items-center"">
                          <div>
                            <h4 class=""h6 mb-0 text-small"">Joseph Garth</h4>
                          </div>
                          <div class=""text-end"">
                            <small>1 d ago</small>
                          </div>
                      </div>
                      <p class=""font-small mt-1 mb-0"">New message: ""Hey, what's up? All set for the presentation?""</p>
                    </div>
                </div>
              </a>
              <a href=""#"" class=""list-group-item list-group-");
                WriteLiteral(@"item-action border-bottom"">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                      <!-- Avatar -->
                      <img alt=""Image placeholder"" src=""../../assets/img/team/profile-picture-5.jpg"" class=""avatar-md rounded"">
                    </div>
                    <div class=""col ps-0 ms-2"">
                      <div class=""d-flex justify-content-between align-items-center"">
                          <div>
                            <h4 class=""h6 mb-0 text-small"">Bonnie Green</h4>
                          </div>
                          <div class=""text-end"">
                            <small>2 hrs ago</small>
                          </div>
                      </div>
                      <p class=""font-small mt-1 mb-0"">New message: ""We need to improve the UI/UX for the landing page.""</p>
                    </div>
                </div>
              </a>
              <a href=""#"" class=""dropdown-item text-cen");
                WriteLiteral(@"ter fw-bold rounded-bottom py-3"">
                <svg class=""icon icon-xxs text-gray-400 me-1"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path d=""M10 12a2 2 0 100-4 2 2 0 000 4z""></path><path fill-rule=""evenodd"" d=""M.458 10C1.732 5.943 5.522 3 10 3s8.268 2.943 9.542 7c-1.274 4.057-5.064 7-9.542 7S1.732 14.057.458 10zM14 10a4 4 0 11-8 0 4 4 0 018 0z"" clip-rule=""evenodd""></path></svg>
                View all
              </a>
            </div>
          </div>
        </li>
        <li class=""nav-item dropdown ms-lg-3"">
          <a class=""nav-link dropdown-toggle pt-1 px-0"" href=""#"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
            <div class=""media d-flex align-items-center"">
              <img class=""avatar rounded-circle"" alt=""Image placeholder"" src=""../../assets/img/team/profile-picture-3.jpg"">
              <div class=""media-body ms-2 text-dark align-items-center d-none d-lg-block"">
                <span class=""mb-0 font-small fw-bo");
                WriteLiteral(@"ld text-gray-900"">Bonnie Green</span>
              </div>
            </div>
          </a>
          <div class=""dropdown-menu dashboard-dropdown dropdown-menu-end mt-2 py-1"">
            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
              <svg class=""dropdown-icon text-gray-400 me-2"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-6-3a2 2 0 11-4 0 2 2 0 014 0zm-2 4a5 5 0 00-4.546 2.916A5.986 5.986 0 0010 16a5.986 5.986 0 004.546-2.084A5 5 0 0010 11z"" clip-rule=""evenodd""></path></svg>
              My Profile
            </a>
            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
              <svg class=""dropdown-icon text-gray-400 me-2"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M11.49 3.17c-.38-1.56-2.6-1.56-2.98 0a1.532 1.532 0 01-2.286.948c-1.372-.836-2.942.734-2.106 2.106.54.886.061 2.042-.947 2.287-1");
                WriteLiteral(@".561.379-1.561 2.6 0 2.978a1.532 1.532 0 01.947 2.287c-.836 1.372.734 2.942 2.106 2.106a1.532 1.532 0 012.287.947c.379 1.561 2.6 1.561 2.978 0a1.533 1.533 0 012.287-.947c1.372.836 2.942-.734 2.106-2.106a1.533 1.533 0 01.947-2.287c1.561-.379 1.561-2.6 0-2.978a1.532 1.532 0 01-.947-2.287c.836-1.372-.734-2.942-2.106-2.106a1.532 1.532 0 01-2.287-.947zM10 13a3 3 0 100-6 3 3 0 000 6z"" clip-rule=""evenodd""></path></svg>
              Settings
            </a>
            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
              <svg class=""dropdown-icon text-gray-400 me-2"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M5 3a2 2 0 00-2 2v10a2 2 0 002 2h10a2 2 0 002-2V5a2 2 0 00-2-2H5zm0 2h10v7h-2l-1 2H8l-1-2H5V5z"" clip-rule=""evenodd""></path></svg>
              Messages
            </a>
            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
              <svg class=""dropdown-icon text-gray-400 me-2"" fill=""currentColor"" ");
                WriteLiteral(@"viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-2 0c0 .993-.241 1.929-.668 2.754l-1.524-1.525a3.997 3.997 0 00.078-2.183l1.562-1.562C15.802 8.249 16 9.1 16 10zm-5.165 3.913l1.58 1.58A5.98 5.98 0 0110 16a5.976 5.976 0 01-2.516-.552l1.562-1.562a4.006 4.006 0 001.789.027zm-4.677-2.796a4.002 4.002 0 01-.041-2.08l-.08.08-1.53-1.533A5.98 5.98 0 004 10c0 .954.223 1.856.619 2.657l1.54-1.54zm1.088-6.45A5.974 5.974 0 0110 4c.954 0 1.856.223 2.657.619l-1.54 1.54a4.002 4.002 0 00-2.346.033L7.246 4.668zM12 10a2 2 0 11-4 0 2 2 0 014 0z"" clip-rule=""evenodd""></path></svg>
              Support
            </a>
            <div role=""separator"" class=""dropdown-divider my-1""></div>
            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
              <svg class=""dropdown-icon text-danger me-2"" fill=""none"" stroke=""currentColor"" viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg""><path stroke-linecap=""round"" stroke-linejoin=""round"" s");
                WriteLiteral(@"troke-width=""2"" d=""M17 16l4-4m0 0l-4-4m4 4H7m6 4v1a3 3 0 01-3 3H6a3 3 0 01-3-3V7a3 3 0 013-3h4a3 3 0 013 3v1""></path></svg>                
              Logout
            </a>
          </div>
        </li>
      </ul>
    </div>
</div>
</nav>
        ");
#nullable restore
#line 187 "F:\iti courses\mvc\Day2\lab\mvc-ecommerce\e-commerce-project\Views\Shared\_Admin.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n </main>\r\n\r\n\r\n\r\n\r\n    </div>\r\n        <script src=\"/lib/jquery/dist/jquery.js\"></script>\r\n        ");
#nullable restore
#line 195 "F:\iti courses\mvc\Day2\lab\mvc-ecommerce\e-commerce-project\Views\Shared\_Admin.cshtml"
   Write(RenderSection("MyScripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
