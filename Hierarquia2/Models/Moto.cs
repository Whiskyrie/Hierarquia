namespace LocadoraDeVeiculos.Models;

public class Moto : Veiculo
{
    public int Cilindradas { get; set; }

    public Moto(string marca, string modelo, int ano, decimal valorDiaria, int cilindradas)
        : base(marca, modelo, ano, valorDiaria)
    {
        Cilindradas = cilindradas;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Moto: {Marca} {Modelo}, Ano: {Ano}, Diária: {ValorDiaria:C}, Cilindradas: {Cilindradas}");
    }
}
