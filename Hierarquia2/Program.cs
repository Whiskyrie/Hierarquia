using LocadoraDeVeiculos.Models;
using LocadoraDeVeiculos.Services;

namespace LocadoraDeVeiculos;

class Program
{
    static void Main(string[] args)
    {
        Locadora locadora = new();

        Carro carro = new("Fiat", "Uno", 2020, 150.00m, 4);
        Moto moto = new("Yamaha", "MT-07", 2019, 100.00m, 700);
        Caminhao caminhao = new("Scania", "R450", 2021, 300.00m, 18000);

        locadora.AdicionarVeiculo(carro);
        locadora.AdicionarVeiculo(moto);
        locadora.AdicionarVeiculo(caminhao);

        locadora.ListarVeiculos();
    }
}
