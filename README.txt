Classes e Objetos
1) Cadastro de carros

Escreva um programa que crie quatro objetos da classe Carro, contendo os seguintes atributos:
- Fabricante;
- Modelo;
- Ano de fabricação;
- Ano do modelo;
- Valor.
Armazene os quatro objetos em um vetor e faça a exibição dos dados de todos os carros cadastrados.

2) Conta bancária

Crie uma classe ContaBancaria com os seguintes atributos:
- Titular, do tipo string;
- Saldo, do tipo double.
Adicione os seguintes métodos à classe:
- Depositar: recebe um parâmetro do tipo double e adiciona o valor ao saldo.
- Sacar: recebe um parâmetro do tipo double e subtrai o valor do saldo.
- ExibirSaldo: mostra o saldo da conta formatado.
- ToString: retorna as informações da conta, mostrando o titular e o saldo.

3) Cadastro de livros

Crie uma classe Livro com os seguintes atributos:
- Título, do tipo string;
- Autor, do tipo string;
- Número de páginas, do tipo inteiro positivo.
Crie um construtor que receba os três valores e um método get para cada propriedade.
Sobrescreva o método ToString() para retornar as informações do livro.

4) Carros, motores e cálculo de IPVA

Utilizando o exercício 1 como base, faça as seguintes alterações:
- Crie uma função que calcule o IPVA do carro. Carros com 20 anos ou mais de fabricação são isentos do pagamento.
- Crie uma classe Motor com três atributos: combustível, cilindrada e potência.
- A classe Motor deve ser um atributo da classe Carro, ou seja, cada carro deve possuir um objeto Motor.