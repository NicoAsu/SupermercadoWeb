#pragma checksum "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97968a4a002124d260abe6faa9659bbb28c7825c"
// <auto-generated/>
#pragma warning disable 1591
namespace SupermercadoWeb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using SupermercadoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using SupermercadoWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-hene7q79g3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-hene7q79g3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "b-hene7q79g3");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private tyrone09876543_ProyectoFinalDBContext dbContext { get; set; }
    }
}
#pragma warning restore 1591