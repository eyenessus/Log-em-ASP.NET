
function Cadastrar() {

   $("#divdoformulario").after("<h3>Mensagem enviada com sucesso!!!!</h3>");
   $("#divdoformulario").hide();

   let parameters = {
    //mesma propriedade da model do banco de dados
    Nome: $("#nome").val(), //obtendo os dados do formulario e armazenando em um objto chamado parameters
    Email: $("#email").val(),
    Mensagem: $("#mensagem").val(),
};

//como grava no banco de dados
//requisição de envio de dados

$.post("/Home/Cadastrar",parameters) //lugar onde vai enviar os dados
//post, informações/dados(parameteres)
//faz uma requisição por POST para o endereço /HOME/Cadastrar com os parametros
.done(
    function(data) {
        if(data.status == "success"){
            $("#formulario").after("<h3>Dado cadastrado com sucesso</h3>");
            $("#formulario").hide();
        }else{
            $("#formulario").after("<h3>"+data.message+"</h3>");
        }
    }
)
.fail(
function(){
    alert("Error Ocorreu algo errado!")
}
);//done quando a requisição deu certo fail e quando não deu
//retorno done houve comunicação e fail nada comunicou

}

$(document).ready(
    function () {
        //nesse bloco que controlamos o submite que sera realizado no formulario
        $("#formulario").submit(
            function (e) {
                e.preventDefault();

                //a acao de gravar no banco vai nessa funcao
                Cadastrar();
            }
        );
    }
);