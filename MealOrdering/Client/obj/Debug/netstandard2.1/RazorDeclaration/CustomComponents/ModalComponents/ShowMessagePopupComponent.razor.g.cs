#pragma checksum "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62d0a76154766df2dbc65f7c6c758e2e0fae203c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MealOrdering.Client.CustomComponents.ModalComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents.ModalComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.Utils;

#line default
#line hidden
#nullable disable
    public partial class ShowMessagePopupComponent : BaseModalComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor"
       

    //bu metot dışarıdan gelen parametreleri bu componentin içine setliyor

    //bu componentin yaratılmasından IModalInstance Sorumlu

    public async override Task SetParametersAsync(ParameterView parameters)
    {
        Message = parameters.GetValueOrDefault<string>("Message") ?? "Mesaj yok";
        OkText = "Ok";

        await base.SetParametersAsync(parameters);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
