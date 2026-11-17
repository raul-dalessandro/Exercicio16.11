//2) Conta bancária

//Crie uma classe ContaBancaria com os seguintes atributos:
//-Titular, do tipo string;
//-Saldo, do tipo double.
//Adicione os seguintes métodos à classe:
//-Depositar: recebe um parâmetro do tipo double e adiciona o valor ao saldo.
//- Sacar: recebe um parâmetro do tipo double e subtrai o valor do saldo.
//- ExibirSaldo: mostra o saldo da conta formatado.
//- ToString: retorna as informações da conta, mostrando o titular e o saldo.

using Ex_2;
ContaBancaria c = new();
void CadastrarConta()
{
    Console.WriteLine("Informe o Titular: ");
    string titular = Console.ReadLine();
    Console.WriteLine("Informe o Saldo: ");
    double saldo = double.Parse(Console.ReadLine());
   
    c.Titular =titular; 
    c.Saldo = saldo;

}

CadastrarConta();

Console.WriteLine("Quanto voce quer Depositar?");
double deposito = double.Parse(Console.ReadLine());

c.Depositar(deposito);
c.ExibirSaldo();

Console.WriteLine("Quanto voce quer Sacar?");
double sacar = double.Parse(Console.ReadLine());

c.Sacar(sacar);
c.ExibirSaldo();

Console.WriteLine(c.ToString());


