#pragma checksum "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a084c85482e89c04b53503188fa4bcd919b892d"
// <auto-generated/>
#pragma warning disable 1591
namespace SupermercadoWeb.Pages.Configuration.ConfigProducts
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Config/ListProduct")]
    public partial class ListProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ListProducts</h3>");
#nullable restore
#line 3 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
 if (productos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Cargando...</em></p>");
#nullable restore
#line 6 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead class=""thead-dark""><tr><th scope=""col"">Nombre</th>
                <th scope=""col"">Precio</th>
                <th scope=""col"">Categoria</th>
                <th scope=""col"">Cantidad</th>
                <th scope=""col"">Foto</th>
                <th scope=""col""></th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 21 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
             foreach (var producto in productos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 24 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
                         producto.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 25 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
                         producto.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    \n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
                         producto.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 28 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
                                   producto.Imagen

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "alt", "Alternate Text");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "/Config/EditProducts/" + (
#nullable restore
#line 30 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
                                                       producto.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-primary btn-xs");
            __builder.AddAttribute(25, "title", "Editar");
            __builder.AddMarkupContent(26, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n                        ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "/Config/DeleteProducts/" + (
#nullable restore
#line 34 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
                                                         producto.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-danger btn-xs");
            __builder.AddAttribute(31, "title", "Eliminar");
            __builder.AddMarkupContent(32, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\ListProducts.razor"
       
    private IEnumerable<Producto> productos { get; set; }

    protected override async Task OnInitializedAsync()
    {
        productos = await ProductsService.GetAllProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private tyrone09876543_ProyectoFinalDBContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
