namespace Est_Desafio.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TO DO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string placa = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            veiculos.Add(placa);
#pragma warning restore CS8604 // Possible null reference argument.
            Console.WriteLine($"Veículo com placa {placa} adicionado.");
        }

public void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para remover:");
    // Ensure that `placa` is not null
    string? placa = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(placa))
    {
        Console.WriteLine("Placa inválida. Por favor, tente novamente.");
        return;
    }

    // Verifica se o veículo existe
    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

        // Ensure that `horasInput` is not null
        string? horasInput = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(horasInput) || !int.TryParse(horasInput, out int horas))
        {
            Console.WriteLine("Valor inválido, por favor digite um número válido de horas.");
            return;
        }

        // Calcular o valor total
        decimal valorTotal = precoInicial + (precoPorHora * horas);

        // Remover a placa digitada da lista de veículos, ensuring `placa` is not null
        veiculos.Remove(placa);

        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
    }
    else
    {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
    }
}


        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TO DO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
