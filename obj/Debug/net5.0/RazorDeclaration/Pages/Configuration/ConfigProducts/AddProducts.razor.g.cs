// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Config/AddProducts")]
    public partial class AddProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\Suriel Rodríguez\Desktop\SupermercadoWeb-JoseRosario\SupermercadoWeb\Pages\Configuration\ConfigProducts\AddProducts.razor"
       
    private Producto producto = new Producto();
    List<Categoria> categorias = new List<Categoria>();
    FileStream stream;
    string imageUrl = null;
    async Task HandleFileSelected(InputFileChangeEventArgs e)
    {
        var imagenFile = e.GetMultipleFiles().FirstOrDefault();
        string format = "image/jpg";
        if (imagenFile != null)
        {
            var resized = await imagenFile.RequestImageFileAsync(format, 100, 100);
            var buffer = new Byte[resized.Size];
            await resized.OpenReadStream().ReadAsync(buffer);
            producto.Imagen = buffer;
            imageUrl = $"data:image / jpg; base64,{Convert.ToBase64String(buffer)}";
        }
    }
    protected override void OnInitialized()
    {
        categorias = dbContext.Categorias.ToList();
    }
    protected async Task Save()
    {
        /*await ProductsService.InsertProduct(producto);
        NavigationManager.NavigateTo("/Config/ListProduct");
        stream = new FileStream(image, FileMode.Open, FileAccess.Read); */
        await dbContext.Productos.AddAsync(producto);
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
