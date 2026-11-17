//1) Cadastro de carros

//Escreva um programa que crie quatro objetos da classe Carro, contendo os seguintes atributos:
//-Fabricante;
//-Modelo;
//-Ano de fabricação;
//-Ano do modelo;
//-Valor.
//Armazene os quatro objetos em um vetor e faça a exibição dos dados de todos os carros cadastrados.

Carro[] carros = new Carro[4];

Carro CadastrarCarro()
{
    Console.WriteLine("Digite o fabricante do carro:");

    string fabricante = Console.ReadLine();

    Console.WriteLine("Digite o modelo do carro:");
    string modelo = Console.ReadLine();

    Console.WriteLine("Digite o ano de fabricação do carro:");
    int anofabricacao = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o ano do modelo do carro:");
    int anomodelo = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do carro:");
    double valor = Double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o tipo de combustivo do carro:");
    string combustivel = Console.ReadLine();

    Console.WriteLine("Digite quantas cilindradas o carro possui (somente o número):");
    int cilindrada = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a potencia do carro (somente o número):");
    int potencia = int.Parse(Console.ReadLine());

    Motor motor = new Motor();

    motor.Combustivel = combustivel;
    motor.Cilindrada = cilindrada;
    motor.Potencia = potencia;

    Carro c = new Carro(fabricante, modelo, anofabricacao, anomodelo,valor,motor);

    return c;
}
void ImprimirCarro()
{
    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine(carros[i].GetNome());
    }
}

for (int i = 0; i < 1; i++)
{
    carros[i] = CadastrarCarro();
}
ImprimirCarro();



