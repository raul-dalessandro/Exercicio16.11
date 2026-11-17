
public class Motor
{
    public string Combustivel;
    public int Cilindrada;
    public int Potencia;

    public override string ToString()
    {
        return $"""
                Motor: {Combustivel}, {Cilindrada} cc, {Potencia} cv
                """;

    }
}

