#pragma checksum "C:\Users\nessu\Downloads\projetohotsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970a08111ab80302dcc9bc92f3902c59131562e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\nessu\Downloads\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nessu\Downloads\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970a08111ab80302dcc9bc92f3902c59131562e4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interesse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nessu\Downloads\projetohotsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Hotsite";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row mt-5"">
    <div class=""col-md-4"">

        <div>
            <h1>Iniciativa Saúde da Cidade</h1>
            <p>
                Texto sobre vida saudável: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae
                legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae
                hendrerit.
            </p>
            <p>
                Texto sobre vida iniciativa: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae
                legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae
                hendrerit.
            </p>
        </div>
    </div>
    <div class=""col-md-8"">

        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
                    <div class=""card-body"">
                     ");
            WriteLiteral(@"   <a href=""#"" data-toggle=""modal"" data-target=""#Agenda"" class=""text-center"""">Agenda de eventos</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
                    <div class=""card-body"">
                        <a href=""#"" data-toggle=""modal"" data-target=""#Dicas"" class=""text-center"""">Dicas de vida saudável</a>
                    </div>
                </div>

            </div>
            <div class=""col-md-4"">
                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
                    <div class=""card-body"">
                        <a href=""#"" data-toggle=""modal"" data-target=""#Apoiadores"" class=""text-center"""">Apoiadores</a>
                    </div>
                </div>

            </div>
        </div>

    ");
            WriteLiteral(@"</div>

    <div class=""col-md-8"">
        colocar uma div com img
    </div>

    <div class=""row mt-3"">

        <div class=""col-md-6"">

            <div id=""divdoformulario"">
                <h2>Entre em contato!:</h2>
                <p>Nos mande uma mensagem e fique por dentro de nossos eventos</p>

                <form method=""POST"" id=""formulariocadastro"">
                
                <div>
                        <label asp-for=""Nome"">Nome:</label>
                        <input asp-for=""Nome"" />
                    </div>
                    <div>
                        <label asp-for=""Email"">Email:</label>
                        <input asp-for=""Email"" />
                    </div>
                    <div>
                        <label asp-for=""Mensagem"">Mensagem (opcional):</label>
                        <textarea asp-for=""Mensagem""></textarea>
                    </div>

                     <div>
                        <input type=""submit"" value=""Enviar"" />");
            WriteLiteral(@"
                    </div> 
                              
            </div>
        </div>

    </div>


<div class=""modal fade"" id=""Agenda"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        ...
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
  </div>
</div>

<div class=""modal fade"" id=""Dicas"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
 ");
            WriteLiteral(@" <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        ...
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
  </div>
</div>
<div class=""modal fade"" id=""Apoiadores"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""close"" data-di");
            WriteLiteral(@"smiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        ...
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
  </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interesse> Html { get; private set; }
    }
}
#pragma warning restore 1591
