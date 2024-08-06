namespace LocadoraDeVeiculos.Models;

public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public decimal ValorDiaria { get; set; }

    public Veiculo(string marca, string modelo, int ano, decimal valorDiaria)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        ValorDiaria = valorDiaria;
    }

    public abstract void ExibirDetalhes();
}
