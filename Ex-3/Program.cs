//3) Cadastro de livros

//Crie uma classe Livro com os seguintes atributos:
//-Título, do tipo string;
//-Autor, do tipo string;
//-Número de páginas, do tipo inteiro positivo.
//Crie um construtor que receba os três valores e um método get para cada propriedade.
//Sobrescreva o método ToString() para retornar as informações do livro.

Livro l1;
void CadastrarLivro()
{
    Console.WriteLine("Informe o Titulo: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Informe o Autor: ");
    string autor = Console.ReadLine();
    Console.WriteLine("Informe o Numero de páginas: ");
    int numeroPag = int.Parse(Console.ReadLine());

    Livro l = new(titulo, autor, numeroPag);
    l1 = l;

}

CadastrarLivro();

    Console.WriteLine(l1.getTitulo());
    Console.WriteLine(l1.getAutor());
    Console.WriteLine(l1.getNumeroPaginas());
    Console.WriteLine(l1.ToString());

    Console.WriteLine(l1);//se mandar assim ja chama automaticamente o ToString que sobrescrevi
