#pragma checksum "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\Pages\ButtonTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91074cadb5c1e81e367e46b252087b6c097fb4a6"
// <auto-generated/>
#pragma warning disable 1591
namespace MealOrdering.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/buttontest")]
    public partial class ButtonTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ButtonTest</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "btn-toolbar");
            __builder.AddMarkupContent(9, "\r\n          \r\n\r\n            ");
            __builder.OpenComponent<MealOrdering.Client.CustomComponents.Buttons.CustomEditButtonComponent>(10);
            __builder.AddAttribute(11, "ButtonTest", "Test Edit Button");
            __builder.AddAttribute(12, "Color", "primary");
            __builder.AddAttribute(13, "Icon", "edit");
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenComponent<MealOrdering.Client.CustomComponents.Buttons.CustomEditButtonComponent>(15);
            __builder.AddAttribute(16, "ButtonTest", "Edit Button");
            __builder.AddAttribute(17, "Color", "danger");
            __builder.AddAttribute(18, "Icon", "user-edit");
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.AddMarkupContent(20, "<button class=\"btn btn-danger\">Danger Button\r\n            </button>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
