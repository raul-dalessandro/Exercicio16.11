public class Livro
{
    public string Titulo;
    public string Autor;
    public int NumeroPaginas;

    public Livro(string titulo,string autor,int numeroPaginas)
    {
       
        while (numeroPaginas <= 0)
        {
            Console.WriteLine("O número de páginas deve ser positivo.");
            Console.WriteLine("Informe novamente o número de páginas: ");
            numeroPaginas = int.Parse(Console.ReadLine());
        }
        NumeroPaginas = numeroPaginas;
        Titulo = titulo;
        Autor = autor;
    }

    public string getTitulo()
    {
        return Titulo;
    }

    public string getAutor()
    {
        return Autor;
    }

    public int getNumeroPaginas()
    {
        return NumeroPaginas;
    }

    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, Número de páginas: {NumeroPaginas}";
    }
}