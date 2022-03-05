
function Cadastrar() {
   $("#divdoformulario").after("<h3>Cadastrar</h3>");
   $("#divdoformulario").hide();
}

$(document).ready(
    function () {
        //nesse bloco que controlamos o submite que sera realizado no formulario
        $("#formulariocadastro").submit(
            function (e) {
                e.preventDefault();
                Cadastrar();
            }
        );
    }
);