using System.Collections.Generic;
using LocadoraDeVeiculos.Models;

namespace LocadoraDeVeiculos.Services;

public class Locadora
{
    private readonly List<Veiculo> veiculos;

    public Locadora()
    {
        veiculos = [];
    }

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
    }

    public void ListarVeiculos()
    {
        foreach (var veiculo in veiculos)
        {
            veiculo.ExibirDetalhes();
        }
    }
}
