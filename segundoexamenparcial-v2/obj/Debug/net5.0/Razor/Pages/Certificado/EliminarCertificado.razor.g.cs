#pragma checksum "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "632fa30e34dc111418a513a80c37ddb5f0afb576"
// <auto-generated/>
#pragma warning disable 1591
namespace segundoexamenparcial_v2.Pages.Certificado
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using segundoexamenparcial_v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using segundoexamenparcial_v2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor"
using segundoexamenparcial_v2.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor"
using segundoexamenparcial_v2.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarCertificado/{Id}")]
    public partial class EliminarCertificado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar certificado</h3>\n<hr>\n");
            __builder.AddMarkupContent(1, "<h3>¿Estas seguro que lo quieres eliminar?</h3>\n ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "fieldset");
                __builder2.AddAttribute(10, "disabled", "true");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"Descripcion\" class=\"control-label\">Descripción</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "Descripcion");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor"
                                                                              obj.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Descripcion = __value, obj.Descripcion))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.OpenElement(21, "button");
                __builder2.AddAttribute(22, "type", "submit");
                __builder2.AddAttribute(23, "class", "btn btn-primary");
                __builder2.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor"
                                                                      eliminarCertificado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(25, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "type", "button");
                __builder2.AddAttribute(29, "class", "btn btn-primary");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(31, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Certificado/EliminarCertificado.razor"
       
    
    [Parameter]
    public string Id {get; set;}
    Certificado obj = new Certificado();

    protected override void OnInitialized() {
        obj = serv.Obtener(int.Parse(Id));
    }
    protected void eliminarCertificado() {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("Certificados");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("Certificados");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCertificados serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591