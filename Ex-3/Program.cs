//3) Cadastro de livros

//Crie uma classe Livro com os seguintes atributos:
//-Título, do tipo string;
//-Autor, do tipo string;
//-Número de páginas, do tipo inteiro positivo.
//Crie um construtor que receba os três valores e um método get para cada propriedade.
//Sobrescreva o método ToString() para retornar as informações do livro.

Livro CadastrarLivro()
{
    Console.WriteLine("Informe o Titulo: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Informe o Autor: ");
    string autor = Console.ReadLine();
    Console.WriteLine("Informe o Numero de páginas: ");
    int numeroPaginas = int.Parse(Console.ReadLine());

    while (numeroPaginas <= 0)
    {
        Console.WriteLine("O número de páginas deve ser positivo.");
        Console.WriteLine("Informe novamente o número de páginas: ");
        numeroPaginas = int.Parse(Console.ReadLine());
    }

    return new Livro (titulo, autor, numeroPaginas);
}

Livro[] PopularVetor()
{
    int x = 0;
    while (x <= 0)
    {
        Console.WriteLine("Informe quantos livros voce quer cadastrar:");
        x = int.Parse(Console.ReadLine());
    }

    Livro[] livros = new Livro[x];

    for (int i = 0; i < livros.Length; i++ )
    {
        livros[i] = CadastrarLivro();
    }
    return livros;
}

void MostrarVetor(Livro[] livros)
{
    for (int i = 0; i < livros.Length; i++)
    {
        Console.WriteLine(livros[i]); //se mandar assim ja chama automaticamente o ToString que sobrescrevi
    }
}

MostrarVetor(PopularVetor());

