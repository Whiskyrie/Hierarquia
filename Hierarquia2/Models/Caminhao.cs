namespace LocadoraDeVeiculos.Models;

public class Caminhao : Veiculo
{
    public int CapacidadeDeCarga { get; set; }

    public Caminhao(string marca, string modelo, int ano, decimal valorDiaria, int capacidadeDeCarga)
        : base(marca, modelo, ano, valorDiaria)
    {
        CapacidadeDeCarga = capacidadeDeCarga;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Caminhão: {Marca} {Modelo}, Ano: {Ano}, Diária: {ValorDiaria:C}, Capacidade de Carga: {CapacidadeDeCarga} kg");
    }
}
