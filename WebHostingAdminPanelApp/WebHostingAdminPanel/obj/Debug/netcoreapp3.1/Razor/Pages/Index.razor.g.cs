#pragma checksum "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2baf42fc2911763d48e575e32e826720849af270"
// <auto-generated/>
#pragma warning disable 1591
namespace WebHostingAdminPanel.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using WebHostingAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\_Imports.razor"
using WebHostingAdminPanel.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Dobro do??li!</h1>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h3>Admin Control Panel v1.0</h3>\r\n<br>\r\n");
            __builder.AddMarkupContent(2, "<h4 style=\"font-style:oblique\">Obavijesti</h4>\r\n");
            __builder.AddMarkupContent(3, "<p>Trenutno nema novih obavijesti.</p>\r\n");
            __builder.OpenComponent<WebHostingAdminPanel.Shared.SurveyPrompt>(4);
            __builder.AddAttribute(5, "Title", "Imate neki prijedlog za pobolj??anje sistema?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
