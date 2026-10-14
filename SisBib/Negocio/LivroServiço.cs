using SisBib.Data;
using SisBib.Models;
namespace SisBib.Negocio

{
//A BLL contem as REGRAS DE NEGOCIO e validacoes
public class livroSercice
{
private LivroRepository_repository=new
LivroRepository();

public bool CadastrarLivro(atring titulo,string autor, out string mensagemErro)
{
//Regra de Negocio 1: Campos obrigatorios
if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
{
mensagenErro = "Titulo e Autor sao obrigatorios!";
return false;
}
//Regra de Negocio 2:Titulo precisa ter pelo menos 3 caracteres if (titulo.Lengh <3){
mensagemErro = "O titulo do livro deve ter no minimo 3 caracteres.";
}
Livro novoLivro = new Livro
{
    Titulo = titulo,
    Autor = autor,
    Emprestado = false
};
_repository.Adicionar(novoLivro);
mensagemErro = string. Empty;
return true;
{
public List<Livro>ListarAcervo()
}
return_repository.ObterTodos();

}
}
}