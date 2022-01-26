#pragma checksum "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73dd466b34e7aaf427a730f6593d4bbed40c665"
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
#nullable restore
#line 3 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor"
using KorisniciLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statistika")]
    public partial class Statistika : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Statistika</h3>\r\n\r\n\r\n<br>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>\r\n                Paket\r\n            </th>\r\n            <th>\r\n                Količina\r\n            </th>\r\n        </tr>\r\n\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<td>\r\n                Broj Web Hosting paketa\r\n            </td>\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddMarkupContent(11, "\r\n                ");
#nullable restore
#line 32 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor"
__builder.AddContent(12, webHosting);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddMarkupContent(18, "<td>\r\n                Broj Mail Hosting paketa\r\n            </td>\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\r\n                ");
#nullable restore
#line 40 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor"
__builder.AddContent(21, mailHosting);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<td>\r\n                Broj Game Hosting paketa\r\n            </td>\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                ");
#nullable restore
#line 48 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor"
__builder.AddContent(30, gameHosting);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "h5");
            __builder.AddContent(37, "Ukupan broj korisnika: ");
#nullable restore
#line 54 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor"
__builder.AddContent(38, brojKorisnika);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "h5");
            __builder.AddContent(41, "Ukupan broj aktivnih paketa: ");
#nullable restore
#line 55 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor"
__builder.AddContent(42, brojAktivnihPaketa);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Pc\source\repos\WebHostingAdminPanelApp\WebHostingAdminPanel\Pages\Statistika.razor"
       
    public int brojKorisnika;

    public int brojAktivnihPaketa;

    public int webHosting, mailHosting, gameHosting;

    protected override void OnInitialized()
    {
        brojKorisnika = _db.GetNumberOfCustomers();
        brojAktivnihPaketa = _db.GetNumberOfAllActivePackets();
        webHosting = _db.GetCustomersPacketNumberByPacketId(1);
        mailHosting = _db.GetCustomersPacketNumberByPacketId(2);
        gameHosting = _db.GetCustomersPacketNumberByPacketId(3);
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private KorisniciLibrary.KonekcijaNaBazu _db { get; set; }
    }
}
#pragma warning restore 1591
