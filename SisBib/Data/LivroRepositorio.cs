using System.Collections.Generc;
usingSisBib.Data
{
//A DAL APENAS armazena e recupera dados. Nao faz validacoes nem imprime texto.
public class LivroRepository
{
  private static List<Livro>_tabelalivrosm= new List<Livro>(); private static intproximold = 1;
  public void Adicionar(livro livro)
{
    livro.Id = proximold++;
    _tabelaLivros.Add(livro);
}
Public List<livro>ObterTodos()
{
    return_tabelaLivros;
}
}
}