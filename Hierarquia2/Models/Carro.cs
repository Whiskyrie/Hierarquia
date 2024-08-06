
namespace LocadoraDeVeiculos.Models;

public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }

    public Carro(string marca, string modelo, int ano, decimal valorDiaria, int numeroDePortas)
        : base(marca, modelo, ano, valorDiaria)
    {
        NumeroDePortas = numeroDePortas;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}, Diária: {ValorDiaria:C}, Portas: {NumeroDePortas}");
    }
}
