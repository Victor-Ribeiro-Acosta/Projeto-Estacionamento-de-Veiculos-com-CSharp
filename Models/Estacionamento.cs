

namespace Projeto.Models;

public class Estacionamento()
{
    public List<Veiculo> veiculos = new List<Veiculo>();

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
    }
    
    public void RemoverVeiculo(string placa)
    {
        foreach (Veiculo v in veiculos)
        {
            if (v.Placa == placa)
            {
                Console.WriteLine($"Veículo de placa {v.Placa} liberado - Valor do estacionamento R${v.valorEstacionamento}");
                veiculos.Remove(v);
                break;
            }
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            foreach(Veiculo veic in veiculos)
            {
                Console.WriteLine($"Modelo: {veic.Modelo}  -  Placa: {veic.Placa}  -  Ano: {veic.Ano}");
            }
        }

        else
        {
            Console.WriteLine("Não há veículos estacionados");
        }
    }

    public void Mensagem(string mensagem = "")
    {
        if (mensagem.Any())
        {
            Console.WriteLine(mensagem);
        }
        Console.WriteLine("Precione enter para continuar");
        Console.ReadLine();
    }
}


public class Veiculo
{
    public string Placa ;
    public string Modelo;
    public int Ano;
    public decimal valorEstacionamento;

    public void ValorEstacionamento(decimal valorEnt, decimal valorHora, int hora)
    {
        valorEstacionamento = Math.Round((valorHora * hora) + valorEnt, 2);
    }
}