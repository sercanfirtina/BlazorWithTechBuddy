#pragma checksum "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09088a66f7c6c5e824cc7ca69352bcaaf0750dc9"
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
    public partial class CustomEditButtonComponent : BaseButtonComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MealOrdering.Client.CustomComponents.Buttons.ButtonComponent>(0);
            __builder.AddAttribute(1, "Caption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                            Caption??"Edit"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                          Color??"secondary"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                         Icon??"secondary"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                          OnClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ToolTipStr", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                               ToolTipStr ?? "Edit"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "IsOutline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                             IsOutline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "IsSmall", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\SERCAN\source\repos\Blazor\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                           IsSmall

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
