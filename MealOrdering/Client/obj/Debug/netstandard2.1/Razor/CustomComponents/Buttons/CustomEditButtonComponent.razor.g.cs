#pragma checksum "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d50473d2a0d2b0559ba18d6ff98574d8e64e3d"
// <auto-generated/>
#pragma warning disable 1591
namespace MealOrdering.Client.CustomComponents.Buttons
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
#line 10 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents.Buttons;

#line default
#line hidden
#nullable disable
    public partial class CustomEditButtonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn" + " btn-" + (
#nullable restore
#line 3 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                        Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "  \r\n    ");
            __builder.OpenElement(3, "span");
            __builder.AddAttribute(4, "class", "fas" + " fa-" + (
#nullable restore
#line 4 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                         Icon

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
     ButtonTest

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
      
    [Parameter]
    public string ButtonTest { get; set; }

    [Parameter]
    public string Color { get; set; }

    [Parameter]
    public string Icon { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
