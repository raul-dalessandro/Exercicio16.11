using System;
using System.Collections.Generic;
using System.Text;


public class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoFabricacao;
    public int AnoModelo;
    public double Valor;
    public Motor Motor;

    public Carro(string fabricante, string modelo, int anoFabricacao, int anoModelo, double valor, Motor motor)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        AnoFabricacao = anoFabricacao;
        AnoModelo = anoModelo;
        Valor = valor;
        Motor = motor;
    }

    public string GetNome()
    {
        return $"Fabricante: {Fabricante}, Modelo: {Modelo}, Ano Fabricação: {AnoFabricacao}, Ano Modelo: {AnoModelo}, Valor: {Valor}, Ipva:{CalcularIPVA():F2}\n" +
            $"Motor: {Motor.Combustivel}, {Motor.Cilindrada} cilindradas, {Motor.Potencia} cv\n";
    }

    public double CalcularIPVA()
    {
        if(DateTime.Now.Year - AnoFabricacao <= 20)
        {
            double ipva = Valor * 0.04;
            return ipva;
        }
        else
        {
            return 0;
        }
    }
}



