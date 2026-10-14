using System;
using System.Collectins.Generic;
using sisBib.Business;
using SisBib.Models.
namespace SisBib.UI

{
public calss MenuConsole
{
private LivroService_livroService = new LivroService()
public void ExibirMenu()
{
    bool rodando = true;
    while (rodando){
        Console.Clear()
        Console.WriteLine(" SISTEMA DE BIBLIOTECA ESCOLAR ");
        Console.writeLine("1 - Cadastrar Novo Livro");
        Console.WriteLine("2 - Listar Colecao");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opcao:");
        string opcao = Console.ReadLine();
       switch (opcao){
        case "1":
         ExecutarCadastro();
         break;
         case"2":
          ExecutarListagem();
          break;
          case"0":
           rodando = false;
           Console.WriteLine("Encerrando o sistema...");
           break;
           default:
            Console.WriteLine("opcao invalida! Pressione qualquer tecla para continuar.");
              Console.ReadKey();
              break;
       }
    }
}
private void ExecutarCadastro()
 {
    Console.clear();
    Console.WriteLine("---CADASTRO DE LIVRO---");
    Console.write("Titulo do Livro:");
string titulo = Console.ReadLine();

  //Chama a camada de negocio bool sucesso=
  _livroService.CadastrarLivro(titulo,autor,out string mensagem);
  if(sucesso) {
    Console.writeLine("Livro cadastrado com sucesso!");
  }
 else{
    Console.writeLine($"Erro ao cadastrar:{mensagem}");
 }
  Console.writeLine("Pressione qualquer tecla para voltar ao menu.");
  Console.ReadKey();
 }
 private void ExecutarListagemm(){
    Console.clear();
    Console.writeLine("---ACERVO DA BIBLIOTECA---");
    List<Livro>acervo();
    if(acervo.Count == 0){
        Console.WriteLine("Nenhum livro cadastrado ate o momento.");
        else{
            foreach (var livro in acervo) {
    string status = livro.Emprestado ?
    "[Emprestado]" : "[Disponivel]";
    Console.writeLine($"ID:{livro.id}")|
    Titulo:{livro.Titulo} |Autor:{livro.Autor}|
    status: {status}");
            }
        }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    }
  }
}