using System.Runtime.CompilerServices;
using Projeto.Models;

Console.Clear();

decimal valorEntrada;
decimal valorHora;
int horas;
Estacionamento est = new Estacionamento();
bool continua = true;


 Console.WriteLine("Sistema de Estacionamento - Seja Bem Vindo");

 Console.WriteLine("Informe o valor de entrada:");
 valorEntrada = Convert.ToDecimal(Console.ReadLine());

 Console.WriteLine("Informe o valor por hora:");
 valorHora = Convert.ToDecimal(Console.ReadLine());


 while (continua)
 {
     Console.Clear();

     Console.WriteLine("Informe sua ação desejada!");
     Console.WriteLine("1 - Cadastrar veículo");
     Console.WriteLine("2 - Liberar veículo");
     Console.WriteLine("3 - Exibir veículos estacionados");
     Console.WriteLine("4 - Sair");
     string opcao = Console.ReadLine();

     switch(opcao)
     {
         case "1":
            Veiculo veiculo = new Veiculo();

             Console.WriteLine("Informe a placa do carro");
             veiculo.Placa = Console.ReadLine();

             Console.WriteLine("Informe o modelo do carro");
             veiculo.Modelo = Console.ReadLine();

             Console.WriteLine("Informe o ano do carro");
             veiculo.Ano = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Quantas horas o veículo permanecerá estacionado:");
             horas = Convert.ToInt32(Console.ReadLine());

             veiculo.ValorEstacionamento(valorEntrada, valorHora, horas);
             
             est.AdicionarVeiculo(veiculo);
             est.Mensagem("Veículo cadastrado com sucesso!");
             break;

         case "2":
            if (!est.veiculos.Any())
            {
                Console.WriteLine("Não há carros no estacionamneto");
                Console.WriteLine("Precione entre para sair");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("Informe a placa do carro");
            string placa = Console.ReadLine();
            est.RemoverVeiculo(placa);
            est.Mensagem();
             break;
        
         case "3":
            est.ListarVeiculos();
            est.Mensagem();
             break;
        
         case "4":
             Console.WriteLine("Encerrando operação");
             continua = false;
             break;
         }
 }

