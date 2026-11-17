public class Livro
{
    public string Titulo;
    public string Autor;
    public int NumeroPaginas;

    public Livro(string titulo,string autor,int numeroPaginas)
    {
       
        //while (numeroPaginas <= 0)
        //{
        //    Console.WriteLine("O número de páginas deve ser positivo.");
        //    Console.WriteLine("Informe novamente o número de páginas: ");
        //    numeroPaginas = int.Parse(Console.ReadLine());
        //}
       
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    public string GetTitulo()
    {
        return Titulo;
    }

    public string GetAutor()
    {
        return Autor;
    }

    public int GetNumeroPaginas()
    {
        return NumeroPaginas;
    }

    public override string ToString()
    {
        return $"Título: {GetTitulo()}, Autor: {GetAutor()}, Número de páginas: {GetNumeroPaginas()}\n";
    }
}